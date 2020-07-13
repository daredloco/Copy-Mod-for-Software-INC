using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CopyMod
{
	internal static class Backend
	{
		internal static string SincPath { get; set; } = "";
		internal static string DataPath { get; set; } = "Mods";
		internal static string CodePath { get; set; } = "DLLMods";
		internal static string AppdataPath { get; set; } = Application.StartupPath + @"\Data\";
		internal static string ProjectsPath { get; set; } = AppdataPath + @"\Projects\";
		internal static string SettingsFile { get; private set; } = AppdataPath + "app.cfg";
		internal static List<Project> Projects = new List<Project>();

		internal static List<Project> GetCodeProjects()
		{
			return Projects.FindAll(x => x.Type == ProjectType.codemod);
		}

		internal static List<Project> GetDataProjects()
		{
			return Projects.FindAll(x => x.Type == ProjectType.datamod);
		}

		internal static bool Initialize()
		{
			CreateFolders();
			bool hasSettings = LoadSettings();
			LoadProjects();
			return hasSettings;
		}

		internal static void CreateFolders()
		{
			if (!Directory.Exists(AppdataPath))
				Directory.CreateDirectory(AppdataPath);
			if (!Directory.Exists(ProjectsPath))
				Directory.CreateDirectory(ProjectsPath);
		}

		internal static void LoadProjects()
		{
			string[] codeprojects = Directory.EnumerateFiles(ProjectsPath, "*." + ProjectType.codemod.ToString(), SearchOption.TopDirectoryOnly).ToArray();
			string[] dataprojects = Directory.EnumerateFiles(ProjectsPath, "*." + ProjectType.datamod.ToString(), SearchOption.TopDirectoryOnly).ToArray();

			foreach(string project in codeprojects)
			{
				FileInfo fi = new FileInfo(project);
				string[] flines = File.ReadAllLines(project);
				Project p = new Project(fi.Name.Replace(fi.Extension, ""), flines[0], flines[1], ProjectType.codemod);
				p.Overwrite = bool.Parse(flines[2]);
				p.SaveToFileTypes(flines[3]);
				Projects.Add(p);
			}

			foreach(string project in dataprojects)
			{
				FileInfo fi = new FileInfo(project);
				string[] flines = File.ReadAllLines(project);
				Project p = new Project(fi.Name.Replace(fi.Extension, ""), flines[0], flines[1], ProjectType.datamod);
				p.Overwrite = bool.Parse(flines[2]);
				p.SaveToFileTypes(flines[3]);
				Projects.Add(p);
			}
		}

		internal static void SaveProject(Project project)
		{
			string[] flines = new string[4] { project.Source, project.Destination, project.Overwrite.ToString(), project.FileTypesToSave() };
			string floc = Path.Combine(ProjectsPath, project.Name + "." + project.Type.ToString());
			if (File.Exists(floc))
				File.Delete(floc);
			File.WriteAllLines(floc, flines);
			Project p = Projects.Find(x => x.Name == project.Name);
			if (p != null)
				p = project;
			else
				Projects.Add(project);
		}

		internal static void DeleteProject(Project project)
		{
			if (project == null)
				return;
			string floc = Path.Combine(ProjectsPath, project.Name + "." + project.Type.ToString());
			if (File.Exists(floc))
				File.Delete(floc);
			Projects.Remove(project);
		}

		internal static bool LoadSettings()
		{
			if(File.Exists(SettingsFile))
			{
				string[] flines = File.ReadAllLines(SettingsFile);
				SincPath = flines[0];
			}
			if(SincPath == "")
			{
				GetSteamDirectory();
				if(SincPath == "")
					return false;
			}
			DataPath = Path.Combine(SincPath, DataPath);
			CodePath = Path.Combine(SincPath, CodePath);
			return true;
		}

		internal static void SaveSettings()
		{
			string[] flines = new string[1] { SincPath };
			if (File.Exists(SettingsFile))
				File.Delete(SettingsFile);
			File.WriteAllLines(SettingsFile, flines);
		}

		internal static void UpdatePaths(string newsincpath)
		{
			SincPath = newsincpath;
			DataPath = Path.Combine(SincPath, DataPath);
			CodePath = Path.Combine(SincPath, CodePath);
		}

		internal static void GetSteamDirectory()
		{
			if (SincPath == "")
			{
				if (MessageBox.Show("It seems like you didn't set the Software Inc folder,\nDo you want the Application to search the Software INC installation for you?", "Destination Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					object regreturn = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamPath", null);
					if (regreturn != null)
					{
						string steaminstall = regreturn as string;
						if (steaminstall != null)
						{
							UpdatePaths(Path.Combine(steaminstall, "steamapps/common/Software Inc/").Replace('/', '\\'));
							SaveSettings();
						}
					}
					else
					{
						MessageBox.Show("Couldn't find Software Inc installation directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
		}

		internal enum ProjectType
		{
			datamod,
			codemod
		}

		internal class Project
		{
			internal string Name { get; set; }
			internal string Source { get; set; }
			internal string Destination { get; set; }
			internal bool Overwrite { get; set; }
			internal List<string> FileTypes { get; set; }
			internal ProjectType Type { get; set; }

			internal Project(string name, string source, string destination, ProjectType type)
			{
				Name = name;
				Source = source;
				Destination = destination;
				Type = type;
				FileTypes = new List<string>();
				Overwrite = false;
			}

			internal void AddFileType(string filetype)
			{
				if(!FileTypes.Contains(filetype))
				{
					FileTypes.Add(filetype);
				}
			}

			internal void RemoveFileType(string filetype)
			{
				FileTypes.Remove(filetype);
			}

			internal string FileTypesToSave()
			{
				string fts = "";
				foreach(string ft in FileTypes)
				{
					if (fts == "")
						fts = ft;
					else
						fts += "," + ft;
				}
				return fts;
			}

			internal void SaveToFileTypes(string savestr)
			{
				foreach (string ft in savestr.Split(','))
					FileTypes.Add(ft);
			}

			internal bool CopyFiles()
			{
				if (Type == ProjectType.codemod)
					return CopyCodeFiles();
				else if (Type == ProjectType.datamod)
					return CopyDataFiles();

				return false;
			}

			bool CopyCodeFiles()
			{
				string finaldir = Path.Combine(CodePath, Destination);

				if (!Directory.Exists(finaldir))
					Directory.CreateDirectory(finaldir);
				var files = (from file in Directory.EnumerateFiles(Source, "*", SearchOption.TopDirectoryOnly)
							 where FileTypes.Contains(Path.GetExtension(file), StringComparer.InvariantCultureIgnoreCase)
							 select new
							 {
								 Source = file,
								 Destination = Path.Combine(finaldir, Path.GetFileName(file))
							 });
				foreach (var file in files)
				{
					try
					{
						File.Copy(file.Source, file.Destination, Overwrite);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return false;
					}
				}
				return true;
			}

			bool CopyDataFiles()
			{
				List<string> filestoignore = new List<string>() { };
				List<string> directoriestoignore = new List<string>() { };

				string finaldir = Path.Combine(DataPath, Destination);
				if (!Directory.Exists(finaldir))
					Directory.CreateDirectory(finaldir);
				var files = (from file in Directory.EnumerateFiles(Source, "*", SearchOption.AllDirectories)
							 where FileTypes.Contains(Path.GetExtension(file), StringComparer.InvariantCultureIgnoreCase)
							 select new
							 {
								 Source = file,
								 Destination = Path.Combine(finaldir, file.Replace(Source,""))
							 });
				foreach (var file in files)
				{
					try
					{
						FileInfo fi = new FileInfo(file.Source);
						new FileInfo(file.Destination).Directory.Create();
						if(!filestoignore.Contains(fi.Name) && !directoriestoignore.Contains(fi.Directory.Name))
							File.Copy(file.Source, file.Destination, Overwrite);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return false;
					}
				}
				return true;
			}
		}
	}
}
