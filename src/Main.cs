using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
			tb_source.Text = Backend.sourceDir;
			tb_dest.Text = Backend.destDir;
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
			Backend.destDir = tb_dest.Text;
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
			}
		}
	}
}
