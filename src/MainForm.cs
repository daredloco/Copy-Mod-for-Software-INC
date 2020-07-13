using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CopyMod
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if(Backend.Initialize())
			{
				tb_sincdir.Text = Backend.SincPath;
			}
			else
			{
				tc_main.SelectedIndex = 2;
				MessageBox.Show("Please add the directory of Software Inc manually...");
			}

			ReloadLists();
		}

		void ReloadLists()
		{
			lb_codemods.Items.Clear();
			lb_datamods.Items.Clear();
			foreach (Backend.Project project in Backend.GetCodeProjects())
			{
				lb_codemods.Items.Add(project.Name);
			}
			foreach (Backend.Project project in Backend.GetDataProjects())
			{
				lb_datamods.Items.Add(project.Name);
			}
		}

		private void bt_savesettings_Click(object sender, EventArgs e)
		{
			//Check if the directory is valid (has the Software Inc executable)
			if(!File.Exists(Path.Combine(tb_sincdir.Text,"Software Inc.exe")))
			{
				MessageBox.Show("The Software Inc directory seems to be wrong, please select the right directory!");
				return;
			}
			Backend.UpdatePaths(tb_sincdir.Text);
			Backend.SaveSettings();
		}

		private void lb_codemods_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lb_codemods.SelectedItem == null)
				return;
			Backend.Project p = Backend.GetCodeProjects().Find(x => x.Name == (string)lb_codemods.SelectedItem);
			tb_codename.Text = p.Name;
			tb_codesource.Text = p.Source;
			cb_codeoverwrite.Checked = p.Overwrite;
			while (clb_codetypes.CheckedIndices.Count > 0)
				clb_codetypes.SetItemChecked(clb_codetypes.CheckedIndices[0], false);
			foreach(string ft in p.FileTypes)
				clb_codetypes.SetItemChecked(clb_codetypes.FindString(ft),true);
		}

		private void bt_codesave_Click(object sender, EventArgs e)
		{
			if (tb_codename.Text == "")
			{
				MessageBox.Show("Please enter a name for the mod!");
				return;
			}
			if (tb_codesource.Text == "")
			{
				MessageBox.Show("Please enter a source directory to your mod!");
				return;
			}
			if (clb_codetypes.CheckedItems.Count < 1)
			{
				MessageBox.Show("Please select at least one filetype!");
				return;
			}
			if (!Directory.Exists(tb_codesource.Text))
			{
				MessageBox.Show("The source directory couldn't be found!");
				return;
			}
			Backend.Project p = new Backend.Project(tb_codename.Text, tb_codesource.Text, tb_codename.Text, Backend.ProjectType.codemod);
			p.Overwrite = cb_codeoverwrite.Checked;
			foreach(object item in clb_codetypes.CheckedItems)
			{
				p.AddFileType((string)item);
			}
			Backend.SaveProject(p);
			ReloadLists();
		}

		private void bt_codecopy_Click(object sender, EventArgs e)
		{
			if (tb_codename.Text == "")
			{
				MessageBox.Show("You didn't select a mod!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (Backend.GetCodeProjects().Find(x => x.Name == tb_codename.Text) == null)
			{
				MessageBox.Show("Couldn't find a mod with this name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			bt_codesave_Click(null, null);
			if(Backend.GetCodeProjects().Find(x => x.Name == tb_codename.Text).CopyFiles())
			{
				MessageBox.Show("Mod copied!");
			}
		}

		private void bt_codedelete_Click(object sender, EventArgs e)
		{
			if(tb_codename.Text == "")
			{
				MessageBox.Show("You didn't select a mod!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if(Backend.GetCodeProjects().Find(x => x.Name == tb_codename.Text) == null)
			{
				MessageBox.Show("Couldn't find a mod with this name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if(MessageBox.Show("Do you want to delete the mod project?\nThere won't be deleted any mod files, just the project inside the application.","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Backend.DeleteProject(Backend.GetCodeProjects().Find(x => x.Name == tb_codename.Text));
				ReloadLists();
			}
		}

		private void bt_codecopyall_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to copy all mods?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				foreach (Backend.Project p in Backend.GetCodeProjects())
					if(!p.CopyFiles())
					{
						MessageBox.Show("Couldn't copy mod '" + p.Name + "'");
						return;
					}
				MessageBox.Show("All mods copied!");
			}
		}

		private void tb_sincdir_DoubleClick(object sender, EventArgs e)
		{
			fbd.RootFolder = Environment.SpecialFolder.Desktop;
			fbd.ShowNewFolderButton = false;
			fbd.ShowDialog();
			if (fbd.SelectedPath != "")
				tb_sincdir.Text = fbd.SelectedPath;
		}

		private void tb_codesource_DoubleClick(object sender, EventArgs e)
		{
			fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
			fbd.ShowNewFolderButton = false;
			fbd.ShowDialog();
			if (fbd.SelectedPath != "")
				tb_codesource.Text = fbd.SelectedPath;
		}

		private void bt_datasave_Click(object sender, EventArgs e)
		{
			if (tb_dataname.Text == "")
			{
				MessageBox.Show("Please enter a name for the mod!");
				return;
			}
			if (tb_datasource.Text == "")
			{
				MessageBox.Show("Please enter a source directory to your mod!");
				return;
			}
			if (clb_datatypes.CheckedItems.Count < 1)
			{
				MessageBox.Show("Please select at least one filetype!");
				return;
			}
			if (!Directory.Exists(tb_datasource.Text))
			{
				MessageBox.Show("The source directory couldn't be found!");
				return;
			}
			Backend.Project p = new Backend.Project(tb_dataname.Text, tb_datasource.Text, tb_dataname.Text, Backend.ProjectType.datamod);
			p.Overwrite = cb_dataoverwrite.Checked;
			foreach (object item in clb_datatypes.CheckedItems)
			{
				p.AddFileType((string)item);
			}
			Backend.SaveProject(p);
			ReloadLists();
		}

		private void tb_datasource_DoubleClick(object sender, EventArgs e)
		{
			fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
			fbd.ShowNewFolderButton = false;
			fbd.ShowDialog();
			if (fbd.SelectedPath != "")
				tb_datasource.Text = fbd.SelectedPath;
		}

		private void bt_datacopy_Click(object sender, EventArgs e)
		{
			if (tb_dataname.Text == "")
			{
				MessageBox.Show("You didn't select a mod!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (Backend.GetDataProjects().Find(x => x.Name == tb_dataname.Text) == null)
			{
				MessageBox.Show("Couldn't find a mod with this name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			bt_datasave_Click(null, null);
			if (Backend.GetDataProjects().Find(x => x.Name == tb_dataname.Text).CopyFiles())
			{
				MessageBox.Show("Mod copied!");
			}
		}

		private void bt_dataall_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to copy all mods?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				foreach (Backend.Project p in Backend.GetDataProjects())
					if (!p.CopyFiles())
					{
						MessageBox.Show("Couldn't copy mod '" + p.Name + "'");
						return;
					}
				MessageBox.Show("All mods copied!");
			}
		}

		private void bt_datadelete_Click(object sender, EventArgs e)
		{
			if (tb_dataname.Text == "")
			{
				MessageBox.Show("You didn't select a mod!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (Backend.GetDataProjects().Find(x => x.Name == tb_dataname.Text) == null)
			{
				MessageBox.Show("Couldn't find a mod with this name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (MessageBox.Show("Do you want to delete the mod project?\nThere won't be deleted any mod files, just the project inside the application.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Backend.DeleteProject(Backend.GetCodeProjects().Find(x => x.Name == tb_dataname.Text));
				ReloadLists();
			}
		}

		private void lb_datamods_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lb_datamods.SelectedItem == null)
				return;
			Backend.Project p = Backend.GetDataProjects().Find(x => x.Name == (string)lb_datamods.SelectedItem);
			tb_dataname.Text = p.Name;
			tb_datasource.Text = p.Source;
			cb_dataoverwrite.Checked = p.Overwrite;
			while (clb_datatypes.CheckedIndices.Count > 0)
				clb_datatypes.SetItemChecked(clb_datatypes.CheckedIndices[0], false);
			foreach (string ft in p.FileTypes)
				clb_datatypes.SetItemChecked(clb_datatypes.FindString(ft), true);
		}
	}
}
