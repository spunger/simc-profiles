namespace CovenantProfileGenerator
{
    partial class CovenantProfileGenerator
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
            this.components = new System.ComponentModel.Container();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenerateProfiles = new System.Windows.Forms.Button();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.btnSelectPathResult = new System.Windows.Forms.Button();
            this.btnSelectPathProfiles = new System.Windows.Forms.Button();
            this.cbOutputJson = new System.Windows.Forms.CheckBox();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbOutputHtml = new System.Windows.Forms.CheckBox();
            this.cbOutputText = new System.Windows.Forms.CheckBox();
            this.tbNamePrefix = new System.Windows.Forms.TextBox();
            this.tbPathProfiles = new System.Windows.Forms.TextBox();
            this.tbPathResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnSelectPathTemplate = new System.Windows.Forms.Button();
            this.tbOptionsRankConduits = new System.Windows.Forms.NumericUpDown();
            this.tbOptionsGlobal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPathTemplate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOptionsRankConduits)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabGeneral);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1096, 620);
            this.tcMain.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.textBox1);
            this.tabGeneral.Controls.Add(this.btnGenerateProfiles);
            this.tabGeneral.Controls.Add(this.gbOutput);
            this.tabGeneral.Controls.Add(this.gbOptions);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(1088, 594);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 501);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(517, 90);
            this.textBox1.TabIndex = 2;
            // 
            // btnGenerateProfiles
            // 
            this.btnGenerateProfiles.Location = new System.Drawing.Point(6, 563);
            this.btnGenerateProfiles.Name = "btnGenerateProfiles";
            this.btnGenerateProfiles.Size = new System.Drawing.Size(112, 23);
            this.btnGenerateProfiles.TabIndex = 1;
            this.btnGenerateProfiles.Text = "Generate Profiles";
            this.btnGenerateProfiles.UseVisualStyleBackColor = true;
            this.btnGenerateProfiles.Click += new System.EventHandler(this.BtnGenerateProfiles_Click);
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.btnSelectPathResult);
            this.gbOutput.Controls.Add(this.btnSelectPathProfiles);
            this.gbOutput.Controls.Add(this.cbOutputJson);
            this.gbOutput.Controls.Add(this.cbOutputHtml);
            this.gbOutput.Controls.Add(this.cbOutputText);
            this.gbOutput.Controls.Add(this.tbNamePrefix);
            this.gbOutput.Controls.Add(this.tbPathProfiles);
            this.gbOutput.Controls.Add(this.tbPathResult);
            this.gbOutput.Controls.Add(this.label3);
            this.gbOutput.Controls.Add(this.label2);
            this.gbOutput.Controls.Add(this.label1);
            this.gbOutput.Location = new System.Drawing.Point(6, 324);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(1063, 171);
            this.gbOutput.TabIndex = 0;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // btnSelectPathResult
            // 
            this.btnSelectPathResult.Location = new System.Drawing.Point(1026, 65);
            this.btnSelectPathResult.Name = "btnSelectPathResult";
            this.btnSelectPathResult.Size = new System.Drawing.Size(31, 23);
            this.btnSelectPathResult.TabIndex = 3;
            this.btnSelectPathResult.Text = "...";
            this.btnSelectPathResult.UseVisualStyleBackColor = true;
            this.btnSelectPathResult.Click += new System.EventHandler(this.BtnSelectPathResult_Click);
            // 
            // btnSelectPathProfiles
            // 
            this.btnSelectPathProfiles.Location = new System.Drawing.Point(1026, 40);
            this.btnSelectPathProfiles.Name = "btnSelectPathProfiles";
            this.btnSelectPathProfiles.Size = new System.Drawing.Size(31, 23);
            this.btnSelectPathProfiles.TabIndex = 3;
            this.btnSelectPathProfiles.Text = "...";
            this.btnSelectPathProfiles.UseVisualStyleBackColor = true;
            this.btnSelectPathProfiles.Click += new System.EventHandler(this.BtnSelectPathProfiles_Click);
            // 
            // cbOutputJson
            // 
            this.cbOutputJson.AutoSize = true;
            this.cbOutputJson.Checked = true;
            this.cbOutputJson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOutputJson.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.profileBindingSource, "OutputJson", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbOutputJson.Location = new System.Drawing.Point(79, 116);
            this.cbOutputJson.Name = "cbOutputJson";
            this.cbOutputJson.Size = new System.Drawing.Size(48, 17);
            this.cbOutputJson.TabIndex = 2;
            this.cbOutputJson.Text = "Json";
            this.cbOutputJson.UseVisualStyleBackColor = true;
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataSource = typeof(Profile);
            // 
            // cbOutputHtml
            // 
            this.cbOutputHtml.AutoSize = true;
            this.cbOutputHtml.Checked = true;
            this.cbOutputHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOutputHtml.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.profileBindingSource, "OutputHtml", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbOutputHtml.Location = new System.Drawing.Point(79, 139);
            this.cbOutputHtml.Name = "cbOutputHtml";
            this.cbOutputHtml.Size = new System.Drawing.Size(47, 17);
            this.cbOutputHtml.TabIndex = 2;
            this.cbOutputHtml.Text = "Html";
            this.cbOutputHtml.UseVisualStyleBackColor = true;
            // 
            // cbOutputText
            // 
            this.cbOutputText.AutoSize = true;
            this.cbOutputText.Checked = true;
            this.cbOutputText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOutputText.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.profileBindingSource, "OutputText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbOutputText.Location = new System.Drawing.Point(79, 93);
            this.cbOutputText.Name = "cbOutputText";
            this.cbOutputText.Size = new System.Drawing.Size(47, 17);
            this.cbOutputText.TabIndex = 2;
            this.cbOutputText.Text = "Text";
            this.cbOutputText.UseVisualStyleBackColor = true;
            // 
            // tbNamePrefix
            // 
            this.tbNamePrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbNamePrefix.Location = new System.Drawing.Point(79, 16);
            this.tbNamePrefix.Name = "tbNamePrefix";
            this.tbNamePrefix.Size = new System.Drawing.Size(336, 20);
            this.tbNamePrefix.TabIndex = 1;
            this.tbNamePrefix.Text = "ST_RenMAX_R7";
            // 
            // tbPathProfiles
            // 
            this.tbPathProfiles.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "PathProfiles", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbPathProfiles.Location = new System.Drawing.Point(79, 42);
            this.tbPathProfiles.Name = "tbPathProfiles";
            this.tbPathProfiles.Size = new System.Drawing.Size(944, 20);
            this.tbPathProfiles.TabIndex = 1;
            // 
            // tbPathResult
            // 
            this.tbPathResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "PathOutput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbPathResult.Location = new System.Drawing.Point(79, 67);
            this.tbPathResult.Name = "tbPathResult";
            this.tbPathResult.Size = new System.Drawing.Size(944, 20);
            this.tbPathResult.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name Prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Path Profiles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Result";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnSelectPathTemplate);
            this.gbOptions.Controls.Add(this.tbOptionsRankConduits);
            this.gbOptions.Controls.Add(this.tbOptionsGlobal);
            this.gbOptions.Controls.Add(this.label5);
            this.gbOptions.Controls.Add(this.tbPathTemplate);
            this.gbOptions.Controls.Add(this.label6);
            this.gbOptions.Controls.Add(this.label4);
            this.gbOptions.Location = new System.Drawing.Point(8, 6);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(1061, 312);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // btnSelectPathTemplate
            // 
            this.btnSelectPathTemplate.Location = new System.Drawing.Point(431, 19);
            this.btnSelectPathTemplate.Name = "btnSelectPathTemplate";
            this.btnSelectPathTemplate.Size = new System.Drawing.Size(31, 23);
            this.btnSelectPathTemplate.TabIndex = 3;
            this.btnSelectPathTemplate.Text = "...";
            this.btnSelectPathTemplate.UseVisualStyleBackColor = true;
            this.btnSelectPathTemplate.Click += new System.EventHandler(this.BtnSelectPathTemplate_Click);
            // 
            // tbOptionsRankConduits
            // 
            this.tbOptionsRankConduits.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.profileBindingSource, "RankConduits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbOptionsRankConduits.Location = new System.Drawing.Point(89, 286);
            this.tbOptionsRankConduits.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.tbOptionsRankConduits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbOptionsRankConduits.Name = "tbOptionsRankConduits";
            this.tbOptionsRankConduits.Size = new System.Drawing.Size(120, 20);
            this.tbOptionsRankConduits.TabIndex = 2;
            this.tbOptionsRankConduits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbOptionsRankConduits.Leave += new System.EventHandler(this.TbOptionsRankConduits_Leave);
            // 
            // tbOptionsGlobal
            // 
            this.tbOptionsGlobal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "GlobalOptions", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbOptionsGlobal.Location = new System.Drawing.Point(89, 47);
            this.tbOptionsGlobal.Multiline = true;
            this.tbOptionsGlobal.Name = "tbOptionsGlobal";
            this.tbOptionsGlobal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOptionsGlobal.Size = new System.Drawing.Size(966, 233);
            this.tbOptionsGlobal.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rank Conduits";
            // 
            // tbPathTemplate
            // 
            this.tbPathTemplate.Location = new System.Drawing.Point(89, 21);
            this.tbPathTemplate.Name = "tbPathTemplate";
            this.tbPathTemplate.Size = new System.Drawing.Size(336, 20);
            this.tbPathTemplate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Path Template";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Global";
            // 
            // CovenantProfileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 620);
            this.Controls.Add(this.tcMain);
            this.Name = "CovenantProfileGenerator";
            this.Text = "Covenant Profile Generator";
            this.tcMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOptionsRankConduits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.CheckBox cbOutputJson;
        private System.Windows.Forms.CheckBox cbOutputHtml;
        private System.Windows.Forms.CheckBox cbOutputText;
        private System.Windows.Forms.TextBox tbNamePrefix;
        private System.Windows.Forms.TextBox tbPathProfiles;
        private System.Windows.Forms.TextBox tbPathResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.NumericUpDown tbOptionsRankConduits;
        private System.Windows.Forms.TextBox tbOptionsGlobal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private System.Windows.Forms.Button btnSelectPathResult;
        private System.Windows.Forms.Button btnSelectPathProfiles;
        private System.Windows.Forms.Button btnSelectPathTemplate;
        private System.Windows.Forms.TextBox tbPathTemplate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateProfiles;
        private System.Windows.Forms.TextBox textBox1;
    }
}

