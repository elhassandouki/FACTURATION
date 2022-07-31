namespace FACTURATION
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.combrechclient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecherchclient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilitreParDate = new System.Windows.Forms.GroupBox();
            this.datede = new System.Windows.Forms.DateTimePicker();
            this.datea = new System.Windows.Forms.DateTimePicker();
            this.de = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfilterpardate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.FilitreParDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 85);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(754, 436);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // combrechclient
            // 
            this.combrechclient.FormattingEnabled = true;
            this.combrechclient.Location = new System.Drawing.Point(51, 29);
            this.combrechclient.Name = "combrechclient";
            this.combrechclient.Size = new System.Drawing.Size(106, 21);
            this.combrechclient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client :";
            // 
            // btnRecherchclient
            // 
            this.btnRecherchclient.Location = new System.Drawing.Point(160, 26);
            this.btnRecherchclient.Name = "btnRecherchclient";
            this.btnRecherchclient.Size = new System.Drawing.Size(69, 30);
            this.btnRecherchclient.TabIndex = 5;
            this.btnRecherchclient.Text = "Filtre";
            this.btnRecherchclient.UseVisualStyleBackColor = true;
            this.btnRecherchclient.Click += new System.EventHandler(this.btnRecherchclient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRecherchclient);
            this.groupBox1.Controls.Add(this.combrechclient);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filitre Par Client :";
            // 
            // FilitreParDate
            // 
            this.FilitreParDate.Controls.Add(this.btnfilterpardate);
            this.FilitreParDate.Controls.Add(this.label3);
            this.FilitreParDate.Controls.Add(this.de);
            this.FilitreParDate.Controls.Add(this.datea);
            this.FilitreParDate.Controls.Add(this.datede);
            this.FilitreParDate.Location = new System.Drawing.Point(247, 3);
            this.FilitreParDate.Name = "FilitreParDate";
            this.FilitreParDate.Size = new System.Drawing.Size(300, 76);
            this.FilitreParDate.TabIndex = 7;
            this.FilitreParDate.TabStop = false;
            this.FilitreParDate.Text = "Filitre Par Date ";
            this.FilitreParDate.Enter += new System.EventHandler(this.FilitreParDate_Enter);
            // 
            // datede
            // 
            this.datede.Location = new System.Drawing.Point(45, 19);
            this.datede.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.datede.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.datede.Name = "datede";
            this.datede.Size = new System.Drawing.Size(170, 20);
            this.datede.TabIndex = 0;
            this.datede.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // datea
            // 
            this.datea.Location = new System.Drawing.Point(45, 47);
            this.datea.Name = "datea";
            this.datea.Size = new System.Drawing.Size(170, 20);
            this.datea.TabIndex = 1;
            // 
            // de
            // 
            this.de.AutoSize = true;
            this.de.Location = new System.Drawing.Point(4, 22);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(38, 13);
            this.de.TabIndex = 2;
            this.de.Text = "Entre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "et :";
            // 
            // btnfilterpardate
            // 
            this.btnfilterpardate.Location = new System.Drawing.Point(221, 26);
            this.btnfilterpardate.Name = "btnfilterpardate";
            this.btnfilterpardate.Size = new System.Drawing.Size(69, 30);
            this.btnfilterpardate.TabIndex = 6;
            this.btnfilterpardate.Text = "Filtre";
            this.btnfilterpardate.UseVisualStyleBackColor = true;
            this.btnfilterpardate.Click += new System.EventHandler(this.btnfilterpardate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 521);
            this.Controls.Add(this.FilitreParDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FilitreParDate.ResumeLayout(false);
            this.FilitreParDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox combrechclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecherchclient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox FilitreParDate;
        private System.Windows.Forms.Button btnfilterpardate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label de;
        private System.Windows.Forms.DateTimePicker datea;
        private System.Windows.Forms.DateTimePicker datede;

    }
}

