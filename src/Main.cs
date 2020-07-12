using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CopyMod
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			Backend.LoadSettings();
			if(Backend.sincDir == "")
			{
				if(MessageBox.Show("It seems like you didn't set a destination folder,\ndo you want the Application to search the Software INC installation for you?","Destination Folder",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
				{
					object regreturn = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamPath", null);
					if(regreturn != null)
					{
						string steaminstall = regreturn as string;
						if(steaminstall != null)
						{
							steaminstall = Path.Combine(steaminstall, "steamapps/common/Software Inc/DLLMods").Replace('/','\\');						
							tb_dest.Text = steaminstall;
						}
					}
					else
					{
						MessageBox.Show("Couldn't find Software Inc installation directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
			tb_source.Text = Backend.sourceDir;
			tb_dest.Text = Backend.sincDir;
			tb_modfolder.Text = Backend.modDir;
			cb_overwrite.Checked = Backend.overwrite;
			foreach(string ftype in Backend.filetypes)
			{
				clb_types.SetItemChecked(int.Parse(ftype), true);
			}
		}

		private void tb_source_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			fbd.Description = "Select source folder";
			fbd.ShowNewFolderButton = false;
			fbd.ShowDialog(this);
			tb_source.Text = fbd.SelectedPath;
		}

		private void tb_dest_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			fbd.Description = "Select destination folder";
			fbd.ShowNewFolderButton = true;
			fbd.ShowDialog(this);
			tb_dest.Text = fbd.SelectedPath;
		}

		private void tb_dest_TextChanged(object sender, EventArgs e)
		{
			Backend.sincDir = tb_dest.Text;
		}

		private void tb_mod_TextChanged(object sender, EventArgs e)
		{
			Backend.modDir = tb_modfolder.Text;
		}

		private void tb_source_TextChanged(object sender, EventArgs e)
		{
			Backend.sourceDir = tb_source.Text;
		}

		private void cb_overwrite_MouseClick(object sender, MouseEventArgs e)
		{
			Backend.overwrite = cb_overwrite.Checked;
		}

		private void clb_types_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if(e.NewValue == CheckState.Checked)
			{
				Backend.AddFileType(e.Index + "");
			}
			else
			{
				Backend.RemoveFileType(e.Index + "");
			}
		}

		private void bt_do_Click(object sender, EventArgs e)
		{
			Backend.SaveSettings();
			List<string> extensions = new List<string>();
			foreach (object obj in clb_types.CheckedItems)
				extensions.Add((string)obj);
			if (Backend.CopyContent(extensions.ToArray()))
			{
				MessageBox.Show("Content copy successful!");
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					Arguments = Path.Combine(Backend.sincDir, Backend.modDir),
					FileName = "explorer.exe"
				};
				Process.Start(startInfo);
			}
		}
	}
}
