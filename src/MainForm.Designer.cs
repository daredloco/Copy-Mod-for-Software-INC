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
			this.tp_code = new System.Windows.Forms.TabPage();
			this.tp_settings = new System.Windows.Forms.TabPage();
			this.bt_savesettings = new System.Windows.Forms.Button();
			this.tb_sincdir = new System.Windows.Forms.TextBox();
			this.l_sincdir = new System.Windows.Forms.Label();
			this.lb_codemods = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_codename = new System.Windows.Forms.TextBox();
			this.tb_codesource = new System.Windows.Forms.TextBox();
			this.cb_codeoverwrite = new System.Windows.Forms.CheckBox();
			this.clb_codetypes = new System.Windows.Forms.CheckedListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bt_codecopy = new System.Windows.Forms.Button();
			this.bt_codecopyall = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.bt_codedelete = new System.Windows.Forms.Button();
			this.bt_codesave = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tc_main.SuspendLayout();
			this.tp_data.SuspendLayout();
			this.tp_code.SuspendLayout();
			this.tp_settings.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			this.tp_data.Controls.Add(this.listBox1);
			this.tp_data.Location = new System.Drawing.Point(4, 25);
			this.tp_data.Name = "tp_data";
			this.tp_data.Size = new System.Drawing.Size(583, 391);
			this.tp_data.TabIndex = 0;
			this.tp_data.Text = "Data Mods";
			this.tp_data.UseVisualStyleBackColor = true;
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
			// tp_settings
			// 
			this.tp_settings.Controls.Add(this.bt_savesettings);
			this.tp_settings.Controls.Add(this.tb_sincdir);
			this.tp_settings.Controls.Add(this.l_sincdir);
			this.tp_settings.Location = new System.Drawing.Point(4, 25);
			this.tp_settings.Name = "tp_settings";
			this.tp_settings.Size = new System.Drawing.Size(792, 421);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mods:";
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Source Directory:";
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
			// tb_codename
			// 
			this.tb_codename.Location = new System.Drawing.Point(33, 91);
			this.tb_codename.Name = "tb_codename";
			this.tb_codename.Size = new System.Drawing.Size(202, 22);
			this.tb_codename.TabIndex = 1;
			// 
			// tb_codesource
			// 
			this.tb_codesource.Location = new System.Drawing.Point(33, 46);
			this.tb_codesource.Name = "tb_codesource";
			this.tb_codesource.Size = new System.Drawing.Size(202, 22);
			this.tb_codesource.TabIndex = 1;
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
			// clb_codetypes
			// 
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "File Types:";
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Location = new System.Drawing.Point(403, 43);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(171, 186);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Actions";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 26);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(158, 32);
			this.button1.TabIndex = 6;
			this.button1.Text = "Save Mod";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(5, 140);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(158, 32);
			this.button2.TabIndex = 4;
			this.button2.Text = "Delete Mod";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(5, 64);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(158, 32);
			this.button3.TabIndex = 3;
			this.button3.Text = "Copy Mod";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(5, 102);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(158, 32);
			this.button4.TabIndex = 3;
			this.button4.Text = "Copy all Mods";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.checkedListBox1);
			this.groupBox4.Controls.Add(this.checkBox1);
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Controls.Add(this.textBox2);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Location = new System.Drawing.Point(137, 43);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(260, 324);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Details";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            ".cs",
            ".tyd",
            ".png"});
			this.checkedListBox1.Location = new System.Drawing.Point(33, 163);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(197, 157);
			this.checkedListBox1.TabIndex = 3;
			this.checkedListBox1.UseCompatibleTextRendering = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(33, 119);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(123, 21);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Overwrite Files";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(33, 46);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(202, 22);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(33, 91);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(202, 22);
			this.textBox2.TabIndex = 1;
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
			this.label8.Location = new System.Drawing.Point(8, 23);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 17);
			this.label8.TabIndex = 6;
			this.label8.Text = "Mods:";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(11, 43);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 324);
			this.listBox1.TabIndex = 5;
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
			this.tp_code.ResumeLayout(false);
			this.tp_code.PerformLayout();
			this.tp_settings.ResumeLayout(false);
			this.tp_settings.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListBox listBox1;
	}
}