namespace CopyMod
{
	partial class Main
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tb_source = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_dest = new System.Windows.Forms.TextBox();
			this.bt_do = new System.Windows.Forms.Button();
			this.clb_types = new System.Windows.Forms.CheckedListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cb_overwrite = new System.Windows.Forms.CheckBox();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source Folder:";
			// 
			// tb_source
			// 
			this.tb_source.Location = new System.Drawing.Point(47, 61);
			this.tb_source.Name = "tb_source";
			this.tb_source.Size = new System.Drawing.Size(187, 22);
			this.tb_source.TabIndex = 1;
			this.tb_source.TextChanged += new System.EventHandler(this.tb_source_TextChanged);
			this.tb_source.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_source_MouseDoubleClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Destination Folder:";
			// 
			// tb_dest
			// 
			this.tb_dest.Location = new System.Drawing.Point(47, 111);
			this.tb_dest.Name = "tb_dest";
			this.tb_dest.Size = new System.Drawing.Size(187, 22);
			this.tb_dest.TabIndex = 1;
			this.tb_dest.TextChanged += new System.EventHandler(this.tb_dest_TextChanged);
			this.tb_dest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_dest_MouseDoubleClick);
			// 
			// bt_do
			// 
			this.bt_do.Location = new System.Drawing.Point(268, 150);
			this.bt_do.Name = "bt_do";
			this.bt_do.Size = new System.Drawing.Size(187, 38);
			this.bt_do.TabIndex = 2;
			this.bt_do.Text = "Copy Content";
			this.bt_do.UseVisualStyleBackColor = true;
			this.bt_do.Click += new System.EventHandler(this.bt_do_Click);
			// 
			// clb_types
			// 
			this.clb_types.CheckOnClick = true;
			this.clb_types.FormattingEnabled = true;
			this.clb_types.Items.AddRange(new object[] {
            ".cs",
            ".tyd",
            ".png"});
			this.clb_types.Location = new System.Drawing.Point(268, 61);
			this.clb_types.Name = "clb_types";
			this.clb_types.ScrollAlwaysVisible = true;
			this.clb_types.Size = new System.Drawing.Size(187, 72);
			this.clb_types.TabIndex = 3;
			this.clb_types.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_types_ItemCheck);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(265, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Filetypes:";
			// 
			// cb_overwrite
			// 
			this.cb_overwrite.AutoSize = true;
			this.cb_overwrite.Location = new System.Drawing.Point(47, 160);
			this.cb_overwrite.Name = "cb_overwrite";
			this.cb_overwrite.Size = new System.Drawing.Size(143, 21);
			this.cb_overwrite.TabIndex = 4;
			this.cb_overwrite.Text = "Overwrite Content";
			this.cb_overwrite.UseVisualStyleBackColor = true;
			this.cb_overwrite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_overwrite_MouseClick);
			// 
			// fbd
			// 
			this.fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 220);
			this.Controls.Add(this.cb_overwrite);
			this.Controls.Add(this.clb_types);
			this.Controls.Add(this.bt_do);
			this.Controls.Add(this.tb_dest);
			this.Controls.Add(this.tb_source);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.Text = "SINC Copy Mod";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_source;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_dest;
		private System.Windows.Forms.Button bt_do;
		private System.Windows.Forms.CheckedListBox clb_types;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cb_overwrite;
		private System.Windows.Forms.FolderBrowserDialog fbd;
	}
}

