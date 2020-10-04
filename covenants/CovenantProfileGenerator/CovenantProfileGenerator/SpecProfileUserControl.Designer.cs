namespace CovenantProfileGenerator
{
    partial class SpecProfileUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.tbGeneral = new System.Windows.Forms.TextBox();
            this.gbEquip = new System.Windows.Forms.GroupBox();
            this.tbEquip = new System.Windows.Forms.TextBox();
            this.gbAPL = new System.Windows.Forms.GroupBox();
            this.tbApl = new System.Windows.Forms.TextBox();
            this.gbCovenant = new System.Windows.Forms.GroupBox();
            this.tabCondSoulbCond = new System.Windows.Forms.TabControl();
            this.tabKyr = new System.Windows.Forms.TabPage();
            this.tbKyr = new System.Windows.Forms.TextBox();
            this.tabNec = new System.Windows.Forms.TabPage();
            this.tbNec = new System.Windows.Forms.TextBox();
            this.tabFae = new System.Windows.Forms.TabPage();
            this.tbFae = new System.Windows.Forms.TextBox();
            this.tabVenthyr = new System.Windows.Forms.TabPage();
            this.tbVen = new System.Windows.Forms.TextBox();
            this.specProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbGeneral.SuspendLayout();
            this.gbEquip.SuspendLayout();
            this.gbAPL.SuspendLayout();
            this.gbCovenant.SuspendLayout();
            this.tabCondSoulbCond.SuspendLayout();
            this.tabKyr.SuspendLayout();
            this.tabNec.SuspendLayout();
            this.tabFae.SuspendLayout();
            this.tabVenthyr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specProfileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.gbGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGeneral.Controls.Add(this.tbGeneral);
            this.gbGeneral.Location = new System.Drawing.Point(3, 3);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(883, 124);
            this.gbGeneral.TabIndex = 0;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // tbGeneral
            // 
            this.tbGeneral.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specProfileBindingSource, "General", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGeneral.Location = new System.Drawing.Point(3, 16);
            this.tbGeneral.Multiline = true;
            this.tbGeneral.Name = "tbGeneral";
            this.tbGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbGeneral.Size = new System.Drawing.Size(877, 105);
            this.tbGeneral.TabIndex = 2;
            // 
            // gbEquip
            // 
            this.gbEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEquip.Controls.Add(this.tbEquip);
            this.gbEquip.Location = new System.Drawing.Point(3, 133);
            this.gbEquip.Name = "gbEquip";
            this.gbEquip.Size = new System.Drawing.Size(880, 143);
            this.gbEquip.TabIndex = 0;
            this.gbEquip.TabStop = false;
            this.gbEquip.Text = "Equip";
            // 
            // tbEquip
            // 
            this.tbEquip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specProfileBindingSource, "Equip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbEquip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEquip.Location = new System.Drawing.Point(3, 16);
            this.tbEquip.Multiline = true;
            this.tbEquip.Name = "tbEquip";
            this.tbEquip.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbEquip.Size = new System.Drawing.Size(874, 124);
            this.tbEquip.TabIndex = 2;
            // 
            // gbAPL
            // 
            this.gbAPL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAPL.Controls.Add(this.tbApl);
            this.gbAPL.Location = new System.Drawing.Point(6, 282);
            this.gbAPL.Name = "gbAPL";
            this.gbAPL.Size = new System.Drawing.Size(874, 123);
            this.gbAPL.TabIndex = 0;
            this.gbAPL.TabStop = false;
            this.gbAPL.Text = "APL";
            // 
            // tbApl
            // 
            this.tbApl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specProfileBindingSource, "Apl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbApl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbApl.Location = new System.Drawing.Point(3, 16);
            this.tbApl.Multiline = true;
            this.tbApl.Name = "tbApl";
            this.tbApl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbApl.Size = new System.Drawing.Size(868, 104);
            this.tbApl.TabIndex = 2;
            // 
            // gbCovenant
            // 
            this.gbCovenant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCovenant.Controls.Add(this.tabCondSoulbCond);
            this.gbCovenant.Location = new System.Drawing.Point(9, 411);
            this.gbCovenant.Name = "gbCovenant";
            this.gbCovenant.Size = new System.Drawing.Size(871, 209);
            this.gbCovenant.TabIndex = 0;
            this.gbCovenant.TabStop = false;
            this.gbCovenant.Text = "Covenant / Soulbinds / Conduits";
            // 
            // tabCondSoulbCond
            // 
            this.tabCondSoulbCond.Controls.Add(this.tabKyr);
            this.tabCondSoulbCond.Controls.Add(this.tabNec);
            this.tabCondSoulbCond.Controls.Add(this.tabFae);
            this.tabCondSoulbCond.Controls.Add(this.tabVenthyr);
            this.tabCondSoulbCond.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.specProfileBindingSource, "SoulbindsVenthyr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabCondSoulbCond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCondSoulbCond.Location = new System.Drawing.Point(3, 16);
            this.tabCondSoulbCond.Name = "tabCondSoulbCond";
            this.tabCondSoulbCond.SelectedIndex = 0;
            this.tabCondSoulbCond.Size = new System.Drawing.Size(865, 190);
            this.tabCondSoulbCond.TabIndex = 0;
            // 
            // tabKyr
            // 
            this.tabKyr.Controls.Add(this.tbKyr);
            this.tabKyr.Location = new System.Drawing.Point(4, 22);
            this.tabKyr.Name = "tabKyr";
            this.tabKyr.Padding = new System.Windows.Forms.Padding(3);
            this.tabKyr.Size = new System.Drawing.Size(857, 164);
            this.tabKyr.TabIndex = 0;
            this.tabKyr.Text = "Kyrian";
            this.tabKyr.UseVisualStyleBackColor = true;
            // 
            // tbKyr
            // 
            this.tbKyr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specProfileBindingSource, "SoulbindsKyr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbKyr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKyr.Location = new System.Drawing.Point(3, 3);
            this.tbKyr.Multiline = true;
            this.tbKyr.Name = "tbKyr";
            this.tbKyr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbKyr.Size = new System.Drawing.Size(851, 158);
            this.tbKyr.TabIndex = 0;
            // 
            // tabNec
            // 
            this.tabNec.Controls.Add(this.tbNec);
            this.tabNec.Location = new System.Drawing.Point(4, 22);
            this.tabNec.Name = "tabNec";
            this.tabNec.Padding = new System.Windows.Forms.Padding(3);
            this.tabNec.Size = new System.Drawing.Size(857, 164);
            this.tabNec.TabIndex = 1;
            this.tabNec.Text = "Necrolords";
            this.tabNec.UseVisualStyleBackColor = true;
            // 
            // tbNec
            // 
            this.tbNec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specProfileBindingSource, "SoulbindsNec", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbNec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNec.Location = new System.Drawing.Point(3, 3);
            this.tbNec.Multiline = true;
            this.tbNec.Name = "tbNec";
            this.tbNec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNec.Size = new System.Drawing.Size(851, 158);
            this.tbNec.TabIndex = 1;
            // 
            // tabFae
            // 
            this.tabFae.Controls.Add(this.tbFae);
            this.tabFae.Location = new System.Drawing.Point(4, 22);
            this.tabFae.Name = "tabFae";
            this.tabFae.Padding = new System.Windows.Forms.Padding(3);
            this.tabFae.Size = new System.Drawing.Size(857, 164);
            this.tabFae.TabIndex = 2;
            this.tabFae.Text = "Night Fae";
            this.tabFae.UseVisualStyleBackColor = true;
            // 
            // tbFae
            // 
            this.tbFae.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specProfileBindingSource, "SoulbindsNightfae", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbFae.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFae.Location = new System.Drawing.Point(3, 3);
            this.tbFae.Multiline = true;
            this.tbFae.Name = "tbFae";
            this.tbFae.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbFae.Size = new System.Drawing.Size(851, 158);
            this.tbFae.TabIndex = 1;
            // 
            // tabVenthyr
            // 
            this.tabVenthyr.Controls.Add(this.tbVen);
            this.tabVenthyr.Location = new System.Drawing.Point(4, 22);
            this.tabVenthyr.Name = "tabVenthyr";
            this.tabVenthyr.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenthyr.Size = new System.Drawing.Size(857, 164);
            this.tabVenthyr.TabIndex = 3;
            this.tabVenthyr.Text = "Venthyr";
            this.tabVenthyr.UseVisualStyleBackColor = true;
            // 
            // tbVen
            // 
            this.tbVen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specProfileBindingSource, "SoulbindsVenthyr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbVen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVen.Location = new System.Drawing.Point(3, 3);
            this.tbVen.Multiline = true;
            this.tbVen.Name = "tbVen";
            this.tbVen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbVen.Size = new System.Drawing.Size(851, 158);
            this.tbVen.TabIndex = 1;
            // 
            // specProfileBindingSource
            // 
            this.specProfileBindingSource.DataSource = typeof(SpecProfile);
            // 
            // SpecProfileUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCovenant);
            this.Controls.Add(this.gbAPL);
            this.Controls.Add(this.gbEquip);
            this.Controls.Add(this.gbGeneral);
            this.Name = "SpecProfileUserControl";
            this.Size = new System.Drawing.Size(889, 630);
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.gbEquip.ResumeLayout(false);
            this.gbEquip.PerformLayout();
            this.gbAPL.ResumeLayout(false);
            this.gbAPL.PerformLayout();
            this.gbCovenant.ResumeLayout(false);
            this.tabCondSoulbCond.ResumeLayout(false);
            this.tabKyr.ResumeLayout(false);
            this.tabKyr.PerformLayout();
            this.tabNec.ResumeLayout(false);
            this.tabNec.PerformLayout();
            this.tabFae.ResumeLayout(false);
            this.tabFae.PerformLayout();
            this.tabVenthyr.ResumeLayout(false);
            this.tabVenthyr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specProfileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.GroupBox gbEquip;
        private System.Windows.Forms.GroupBox gbAPL;
        private System.Windows.Forms.GroupBox gbCovenant;
        private System.Windows.Forms.TabControl tabCondSoulbCond;
        private System.Windows.Forms.TabPage tabKyr;
        private System.Windows.Forms.TextBox tbKyr;
        private System.Windows.Forms.TabPage tabNec;
        private System.Windows.Forms.TabPage tabFae;
        private System.Windows.Forms.TabPage tabVenthyr;
        private System.Windows.Forms.TextBox tbGeneral;
        private System.Windows.Forms.TextBox tbEquip;
        private System.Windows.Forms.TextBox tbApl;
        private System.Windows.Forms.TextBox tbNec;
        private System.Windows.Forms.TextBox tbFae;
        private System.Windows.Forms.TextBox tbVen;
        private System.Windows.Forms.BindingSource specProfileBindingSource;
    }
}
