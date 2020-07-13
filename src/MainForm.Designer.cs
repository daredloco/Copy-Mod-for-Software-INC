namespace CopyMod
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tc_main = new System.Windows.Forms.TabControl();
			this.tp_data = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.bt_datasave = new System.Windows.Forms.Button();
			this.bt_datadelete = new System.Windows.Forms.Button();
			this.bt_datacopy = new System.Windows.Forms.Button();
			this.bt_dataall = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.clb_datatypes = new System.Windows.Forms.CheckedListBox();
			this.cb_dataoverwrite = new System.Windows.Forms.CheckBox();
			this.tb_datasource = new System.Windows.Forms.TextBox();
			this.tb_dataname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lb_datamods = new System.Windows.Forms.ListBox();
			this.tp_code = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.bt_codesave = new System.Windows.Forms.Button();
			this.bt_codedelete = new System.Windows.Forms.Button();
			this.bt_codecopy = new System.Windows.Forms.Button();
			this.bt_codecopyall = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.clb_codetypes = new System.Windows.Forms.CheckedListBox();
			this.cb_codeoverwrite = new System.Windows.Forms.CheckBox();
			this.tb_codesource = new System.Windows.Forms.TextBox();
			this.tb_codename = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_codemods = new System.Windows.Forms.ListBox();
			this.tp_settings = new System.Windows.Forms.TabPage();
			this.bt_savesettings = new System.Windows.Forms.Button();
			this.tb_sincdir = new System.Windows.Forms.TextBox();
			this.l_sincdir = new System.Windows.Forms.Label();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.tc_main.SuspendLayout();
			this.tp_data.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tp_code.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tp_settings.SuspendLayout();
			this.SuspendLayout();
			// 
			// tc_main
			// 
			this.tc_main.Controls.Add(this.tp_data);
			this.tc_main.Controls.Add(this.tp_code);
			this.tc_main.Controls.Add(this.tp_settings);
			this.tc_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tc_main.Location = new System.Drawing.Point(0, 0);
			this.tc_main.Name = "tc_main";
			this.tc_main.SelectedIndex = 0;
			this.tc_main.Size = new System.Drawing.Size(591, 420);
			this.tc_main.TabIndex = 0;
			// 
			// tp_data
			// 
			this.tp_data.Controls.Add(this.groupBox3);
			this.tp_data.Controls.Add(this.groupBox4);
			this.tp_data.Controls.Add(this.label8);
			this.tp_data.Controls.Add(this.lb_datamods);
			this.tp_data.Location = new System.Drawing.Point(4, 25);
			this.tp_data.Name = "tp_data";
			this.tp_data.Size = new System.Drawing.Size(583, 391);
			this.tp_data.TabIndex = 0;
			this.tp_data.Text = "Data Mods";
			this.tp_data.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.bt_datasave);
			this.groupBox3.Controls.Add(this.bt_datadelete);
			this.groupBox3.Controls.Add(this.bt_datacopy);
			this.groupBox3.Controls.Add(this.bt_dataall);
			this.groupBox3.Location = new System.Drawing.Point(403, 41);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(171, 186);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Actions";
			// 
			// bt_datasave
			// 
			this.bt_datasave.Location = new System.Drawing.Point(6, 26);
			this.bt_datasave.Name = "bt_datasave";
			this.bt_datasave.Size = new System.Drawing.Size(158, 32);
			this.bt_datasave.TabIndex = 6;
			this.bt_datasave.Text = "Save Mod";
			this.bt_datasave.UseVisualStyleBackColor = true;
			this.bt_datasave.Click += new System.EventHandler(this.bt_datasave_Click);
			// 
			// bt_datadelete
			// 
			this.bt_datadelete.Location = new System.Drawing.Point(5, 140);
			this.bt_datadelete.Name = "bt_datadelete";
			this.bt_datadelete.Size = new System.Drawing.Size(158, 32);
			this.bt_datadelete.TabIndex = 4;
			this.bt_datadelete.Text = "Delete Mod";
			this.bt_datadelete.UseVisualStyleBackColor = true;
			this.bt_datadelete.Click += new System.EventHandler(this.bt_datadelete_Click);
			// 
			// bt_datacopy
			// 
			this.bt_datacopy.Location = new System.Drawing.Point(5, 64);
			this.bt_datacopy.Name = "bt_datacopy";
			this.bt_datacopy.Size = new System.Drawing.Size(158, 32);
			this.bt_datacopy.TabIndex = 3;
			this.bt_datacopy.Text = "Copy Mod";
			this.bt_datacopy.UseVisualStyleBackColor = true;
			this.bt_datacopy.Click += new System.EventHandler(this.bt_datacopy_Click);
			// 
			// bt_dataall
			// 
			this.bt_dataall.Location = new System.Drawing.Point(5, 102);
			this.bt_dataall.Name = "bt_dataall";
			this.bt_dataall.Size = new System.Drawing.Size(158, 32);
			this.bt_dataall.TabIndex = 3;
			this.bt_dataall.Text = "Copy all Mods";
			this.bt_dataall.UseVisualStyleBackColor = true;
			this.bt_dataall.Click += new System.EventHandler(this.bt_dataall_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.clb_datatypes);
			this.groupBox4.Controls.Add(this.cb_dataoverwrite);
			this.groupBox4.Controls.Add(this.tb_datasource);
			this.groupBox4.Controls.Add(this.tb_dataname);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Location = new System.Drawing.Point(137, 41);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(260, 324);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Details";
			// 
			// clb_datatypes
			// 
			this.clb_datatypes.CheckOnClick = true;
			this.clb_datatypes.FormattingEnabled = true;
			this.clb_datatypes.Items.AddRange(new object[] {
            ".tyd",
            ".txt",
            ".png"});
			this.clb_datatypes.Location = new System.Drawing.Point(33, 163);
			this.clb_datatypes.Name = "clb_datatypes";
			this.clb_datatypes.Size = new System.Drawing.Size(197, 157);
			this.clb_datatypes.TabIndex = 3;
			this.clb_datatypes.UseCompatibleTextRendering = true;
			// 
			// cb_dataoverwrite
			// 
			this.cb_dataoverwrite.AutoSize = true;
			this.cb_dataoverwrite.Location = new System.Drawing.Point(33, 119);
			this.cb_dataoverwrite.Name = "cb_dataoverwrite";
			this.cb_dataoverwrite.Size = new System.Drawing.Size(123, 21);
			this.cb_dataoverwrite.TabIndex = 2;
			this.cb_dataoverwrite.Text = "Overwrite Files";
			this.cb_dataoverwrite.UseVisualStyleBackColor = true;
			// 
			// tb_datasource
			// 
			this.tb_datasource.Location = new System.Drawing.Point(33, 46);
			this.tb_datasource.Name = "tb_datasource";
			this.tb_datasource.Size = new System.Drawing.Size(202, 22);
			this.tb_datasource.TabIndex = 1;
			this.tb_datasource.DoubleClick += new System.EventHandler(this.tb_datasource_DoubleClick);
			// 
			// tb_dataname
			// 
			this.tb_dataname.Location = new System.Drawing.Point(33, 91);
			this.tb_dataname.Name = "tb_dataname";
			this.tb_dataname.Size = new System.Drawing.Size(202, 22);
			this.tb_dataname.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "File Types:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 71);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Mod Name:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(30, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Source Directory:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 17);
			this.label8.TabIndex = 6;
			this.label8.Text = "Mods:";
			// 
			// lb_datamods
			// 
			this.lb_datamods.FormattingEnabled = true;
			this.lb_datamods.ItemHeight = 16;
			this.lb_datamods.Location = new System.Drawing.Point(11, 41);
			this.lb_datamods.Name = "lb_datamods";
			this.lb_datamods.Size = new System.Drawing.Size(120, 324);
			this.lb_datamods.TabIndex = 5;
			this.lb_datamods.SelectedIndexChanged += new System.EventHandler(this.lb_datamods_SelectedIndexChanged);
			// 
			// tp_code
			// 
			this.tp_code.Controls.Add(this.groupBox2);
			this.tp_code.Controls.Add(this.groupBox1);
			this.tp_code.Controls.Add(this.label1);
			this.tp_code.Controls.Add(this.lb_codemods);
			this.tp_code.Location = new System.Drawing.Point(4, 25);
			this.tp_code.Name = "tp_code";
			this.tp_code.Size = new System.Drawing.Size(583, 391);
			this.tp_code.TabIndex = 1;
			this.tp_code.Text = "Code Mods";
			this.tp_code.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.bt_codesave);
			this.groupBox2.Controls.Add(this.bt_codedelete);
			this.groupBox2.Controls.Add(this.bt_codecopy);
			this.groupBox2.Controls.Add(this.bt_codecopyall);
			this.groupBox2.Location = new System.Drawing.Point(403, 41);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(171, 186);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Actions";
			// 
			// bt_codesave
			// 
			this.bt_codesave.Location = new System.Drawing.Point(6, 26);
			this.bt_codesave.Name = "bt_codesave";
			this.bt_codesave.Size = new System.Drawing.Size(158, 32);
			this.bt_codesave.TabIndex = 6;
			this.bt_codesave.Text = "Save Mod";
			this.bt_codesave.UseVisualStyleBackColor = true;
			this.bt_codesave.Click += new System.EventHandler(this.bt_codesave_Click);
			// 
			// bt_codedelete
			// 
			this.bt_codedelete.Location = new System.Drawing.Point(5, 140);
			this.bt_codedelete.Name = "bt_codedelete";
			this.bt_codedelete.Size = new System.Drawing.Size(158, 32);
			this.bt_codedelete.TabIndex = 4;
			this.bt_codedelete.Text = "Delete Mod";
			this.bt_codedelete.UseVisualStyleBackColor = true;
			this.bt_codedelete.Click += new System.EventHandler(this.bt_codedelete_Click);
			// 
			// bt_codecopy
			// 
			this.bt_codecopy.Location = new System.Drawing.Point(5, 64);
			this.bt_codecopy.Name = "bt_codecopy";
			this.bt_codecopy.Size = new System.Drawing.Size(158, 32);
			this.bt_codecopy.TabIndex = 3;
			this.bt_codecopy.Text = "Copy Mod";
			this.bt_codecopy.UseVisualStyleBackColor = true;
			this.bt_codecopy.Click += new System.EventHandler(this.bt_codecopy_Click);
			// 
			// bt_codecopyall
			// 
			this.bt_codecopyall.Location = new System.Drawing.Point(5, 102);
			this.bt_codecopyall.Name = "bt_codecopyall";
			this.bt_codecopyall.Size = new System.Drawing.Size(158, 32);
			this.bt_codecopyall.TabIndex = 3;
			this.bt_codecopyall.Text = "Copy all Mods";
			this.bt_codecopyall.UseVisualStyleBackColor = true;
			this.bt_codecopyall.Click += new System.EventHandler(this.bt_codecopyall_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.clb_codetypes);
			this.groupBox1.Controls.Add(this.cb_codeoverwrite);
			this.groupBox1.Controls.Add(this.tb_codesource);
			this.groupBox1.Controls.Add(this.tb_codename);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(137, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 324);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Details";
			// 
			// clb_codetypes
			// 
			this.clb_codetypes.CheckOnClick = true;
			this.clb_codetypes.FormattingEnabled = true;
			this.clb_codetypes.Items.AddRange(new object[] {
            ".cs",
            ".tyd",
            ".png"});
			this.clb_codetypes.Location = new System.Drawing.Point(33, 163);
			this.clb_codetypes.Name = "clb_codetypes";
			this.clb_codetypes.Size = new System.Drawing.Size(197, 157);
			this.clb_codetypes.TabIndex = 3;
			this.clb_codetypes.UseCompatibleTextRendering = true;
			// 
			// cb_codeoverwrite
			// 
			this.cb_codeoverwrite.AutoSize = true;
			this.cb_codeoverwrite.Location = new System.Drawing.Point(33, 119);
			this.cb_codeoverwrite.Name = "cb_codeoverwrite";
			this.cb_codeoverwrite.Size = new System.Drawing.Size(123, 21);
			this.cb_codeoverwrite.TabIndex = 2;
			this.cb_codeoverwrite.Text = "Overwrite Files";
			this.cb_codeoverwrite.UseVisualStyleBackColor = true;
			// 
			// tb_codesource
			// 
			this.tb_codesource.Location = new System.Drawing.Point(33, 46);
			this.tb_codesource.Name = "tb_codesource";
			this.tb_codesource.Size = new System.Drawing.Size(202, 22);
			this.tb_codesource.TabIndex = 1;
			this.tb_codesource.DoubleClick += new System.EventHandler(this.tb_codesource_DoubleClick);
			// 
			// tb_codename
			// 
			this.tb_codename.Location = new System.Drawing.Point(33, 91);
			this.tb_codename.Name = "tb_codename";
			this.tb_codename.Size = new System.Drawing.Size(202, 22);
			this.tb_codename.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "File Types:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mod Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Source Directory:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mods:";
			// 
			// lb_codemods
			// 
			this.lb_codemods.FormattingEnabled = true;
			this.lb_codemods.ItemHeight = 16;
			this.lb_codemods.Location = new System.Drawing.Point(11, 41);
			this.lb_codemods.Name = "lb_codemods";
			this.lb_codemods.Size = new System.Drawing.Size(120, 324);
			this.lb_codemods.TabIndex = 0;
			this.lb_codemods.SelectedIndexChanged += new System.EventHandler(this.lb_codemods_SelectedIndexChanged);
			// 
			// tp_settings
			// 
			this.tp_settings.Controls.Add(this.bt_savesettings);
			this.tp_settings.Controls.Add(this.tb_sincdir);
			this.tp_settings.Controls.Add(this.l_sincdir);
			this.tp_settings.Location = new System.Drawing.Point(4, 25);
			this.tp_settings.Name = "tp_settings";
			this.tp_settings.Size = new System.Drawing.Size(583, 391);
			this.tp_settings.TabIndex = 2;
			this.tp_settings.Text = "Settings";
			this.tp_settings.UseVisualStyleBackColor = true;
			// 
			// bt_savesettings
			// 
			this.bt_savesettings.Location = new System.Drawing.Point(11, 69);
			this.bt_savesettings.Name = "bt_savesettings";
			this.bt_savesettings.Size = new System.Drawing.Size(120, 40);
			this.bt_savesettings.TabIndex = 2;
			this.bt_savesettings.Text = "Save Settings";
			this.bt_savesettings.UseVisualStyleBackColor = true;
			this.bt_savesettings.Click += new System.EventHandler(this.bt_savesettings_Click);
			// 
			// tb_sincdir
			// 
			this.tb_sincdir.Location = new System.Drawing.Point(11, 41);
			this.tb_sincdir.Name = "tb_sincdir";
			this.tb_sincdir.Size = new System.Drawing.Size(360, 22);
			this.tb_sincdir.TabIndex = 1;
			this.tb_sincdir.DoubleClick += new System.EventHandler(this.tb_sincdir_DoubleClick);
			// 
			// l_sincdir
			// 
			this.l_sincdir.AutoSize = true;
			this.l_sincdir.Location = new System.Drawing.Point(8, 21);
			this.l_sincdir.Name = "l_sincdir";
			this.l_sincdir.Size = new System.Drawing.Size(150, 17);
			this.l_sincdir.TabIndex = 0;
			this.l_sincdir.Text = "Software Inc Directory:";
			// 
			// fbd
			// 
			this.fbd.RootFolder = System.Environment.SpecialFolder.MyDocuments;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 420);
			this.Controls.Add(this.tc_main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Software Inc Mod Copy";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tc_main.ResumeLayout(false);
			this.tp_data.ResumeLayout(false);
			this.tp_data.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tp_code.ResumeLayout(false);
			this.tp_code.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tp_settings.ResumeLayout(false);
			this.tp_settings.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tc_main;
		private System.Windows.Forms.TabPage tp_data;
		private System.Windows.Forms.TabPage tp_code;
		private System.Windows.Forms.TabPage tp_settings;
		private System.Windows.Forms.TextBox tb_sincdir;
		private System.Windows.Forms.Label l_sincdir;
		private System.Windows.Forms.Button bt_savesettings;
		private System.Windows.Forms.Button bt_codecopyall;
		private System.Windows.Forms.Button bt_codecopy;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckedListBox clb_codetypes;
		private System.Windows.Forms.CheckBox cb_codeoverwrite;
		private System.Windows.Forms.TextBox tb_codesource;
		private System.Windows.Forms.TextBox tb_codename;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lb_codemods;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button bt_codedelete;
		private System.Windows.Forms.Button bt_codesave;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button bt_datasave;
		private System.Windows.Forms.Button bt_datadelete;
		private System.Windows.Forms.Button bt_datacopy;
		private System.Windows.Forms.Button bt_dataall;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckedListBox clb_datatypes;
		private System.Windows.Forms.CheckBox cb_dataoverwrite;
		private System.Windows.Forms.TextBox tb_datasource;
		private System.Windows.Forms.TextBox tb_dataname;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListBox lb_datamods;
		private System.Windows.Forms.FolderBrowserDialog fbd;
	}
}