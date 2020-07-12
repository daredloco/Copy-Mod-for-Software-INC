﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CopyMod
{
	internal static class Backend
	{
		internal static string settingsFile { get; private set; } = Application.StartupPath + @"\app.cfg";
		internal static string sourceDir;
		internal static string destDir;
		internal static bool overwrite;
		internal static string[] filetypes = new string[0];

		internal static void AddFileType(string ft)
		{
			if (ContainsFileType(ft))
				return;
			List<string> fts = new List<string>();
			fts.AddRange(filetypes);
			fts.Add(ft);
			filetypes = fts.ToArray();
		}

		internal static void RemoveFileType(string ft)
		{
			List<string> fts = new List<string>();
			foreach (string filetype in filetypes)
				if (filetype != ft)
					fts.Add(filetype);
			filetypes = fts.ToArray();
		}

		internal static bool ContainsFileType(string ft)
		{
			foreach (string filetype in filetypes)
				if (filetype == ft)
					return true;
			return false;
		}
		internal static bool LoadSettings()
		{
			if(File.Exists(settingsFile))
			{
				string[] flines = File.ReadAllLines(settingsFile);
				if(flines.Length < 4)
				{
					return false;
				}
				sourceDir = flines[0];
				destDir = flines[1];
				overwrite = bool.Parse(flines[2]);
				filetypes = flines[3].Split(',');
				return true;
			}
			sourceDir = "";
			destDir = "";
			overwrite = false;
			filetypes = new string[0];
			return true;
		}

		internal static void SaveSettings()
		{
			string ftstr = "";
			foreach(string ft in filetypes)
			{
				if(ftstr == "")
				{
					ftstr = ft;
				}
				else
				{
					ftstr += "," + ft;
				}
			}
			string[] flines = new string[4] {sourceDir, destDir, overwrite.ToString(), ftstr};
			if (File.Exists(settingsFile))
				File.Delete(settingsFile);
			File.WriteAllLines(settingsFile, flines);
		}

		internal static bool CopyContent(string[] extensions)
		{
			if (filetypes.Length < 1)
			{
				MessageBox.Show("You need to choose at least one filetype!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (sourceDir == "")
			{
				MessageBox.Show("You need to choose a source directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (destDir == "")
			{
				MessageBox.Show("You need to choose a destination directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (!Directory.Exists(sourceDir))
			{
				MessageBox.Show("The source directory couldn't be found! Did you delete it?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (!Directory.Exists(destDir))
				Directory.CreateDirectory(destDir);

			var files = (from file in Directory.EnumerateFiles(sourceDir,"*",SearchOption.TopDirectoryOnly)
						 where extensions.Contains(Path.GetExtension(file), StringComparer.InvariantCultureIgnoreCase)
						 select new
						 {
							 Source = file,
							 Destination = Path.Combine(destDir, Path.GetFileName(file))
						 });
			foreach (var file in files)
			{
				try
				{
					File.Copy(file.Source, file.Destination, overwrite);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
					return false;
				}
			}
			return true;
		}
	}
}