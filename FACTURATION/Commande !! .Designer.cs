namespace FACTURATION
{
    partial class Commande___
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumfacteur = new System.Windows.Forms.TextBox();
            this.datetimefacteur = new System.Windows.Forms.DateTimePicker();
            this.Commande = new System.Windows.Forms.GroupBox();
            this.btnclients = new System.Windows.Forms.Button();
            this.btntroncaction = new System.Windows.Forms.Button();
            this.combclient = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datagriddetail = new System.Windows.Forms.DataGridView();
            this.comref = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Qté = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Commande.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num Facteur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Facteur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client :";
            // 
            // txtnumfacteur
            // 
            this.txtnumfacteur.Location = new System.Drawing.Point(140, 17);
            this.txtnumfacteur.Name = "txtnumfacteur";
            this.txtnumfacteur.Size = new System.Drawing.Size(207, 20);
            this.txtnumfacteur.TabIndex = 1;
            // 
            // datetimefacteur
            // 
            this.datetimefacteur.Location = new System.Drawing.Point(140, 47);
            this.datetimefacteur.Name = "datetimefacteur";
            this.datetimefacteur.Size = new System.Drawing.Size(207, 20);
            this.datetimefacteur.TabIndex = 2;
            // 
            // Commande
            // 
            this.Commande.Controls.Add(this.btnclients);
            this.Commande.Controls.Add(this.btntroncaction);
            this.Commande.Controls.Add(this.combclient);
            this.Commande.Controls.Add(this.label1);
            this.Commande.Controls.Add(this.datetimefacteur);
            this.Commande.Controls.Add(this.label2);
            this.Commande.Controls.Add(this.label3);
            this.Commande.Controls.Add(this.txtnumfacteur);
            this.Commande.Location = new System.Drawing.Point(8, 4);
            this.Commande.Name = "Commande";
            this.Commande.Size = new System.Drawing.Size(516, 107);
            this.Commande.TabIndex = 3;
            this.Commande.TabStop = false;
            this.Commande.Text = "Commande :";
            // 
            // btnclients
            // 
            this.btnclients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclients.Location = new System.Drawing.Point(391, 15);
            this.btnclients.Name = "btnclients";
            this.btnclients.Size = new System.Drawing.Size(99, 37);
            this.btnclients.TabIndex = 5;
            this.btnclients.Text = "Clients";
            this.btnclients.UseVisualStyleBackColor = true;
            this.btnclients.Click += new System.EventHandler(this.btnclients_Click);
            // 
            // btntroncaction
            // 
            this.btntroncaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntroncaction.Location = new System.Drawing.Point(391, 58);
            this.btntroncaction.Name = "btntroncaction";
            this.btntroncaction.Size = new System.Drawing.Size(99, 37);
            this.btntroncaction.TabIndex = 4;
            this.btntroncaction.Text = "Transaction ";
            this.btntroncaction.UseVisualStyleBackColor = true;
            this.btntroncaction.Click += new System.EventHandler(this.btntroncaction_Click);
            // 
            // combclient
            // 
            this.combclient.FormattingEnabled = true;
            this.combclient.Location = new System.Drawing.Point(141, 74);
            this.combclient.Name = "combclient";
            this.combclient.Size = new System.Drawing.Size(206, 21);
            this.combclient.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datagriddetail);
            this.groupBox1.Location = new System.Drawing.Point(8, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter Commande :";
            // 
            // datagriddetail
            // 
            this.datagriddetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagriddetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriddetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comref,
            this.Qté});
            this.datagriddetail.Location = new System.Drawing.Point(12, 23);
            this.datagriddetail.Name = "datagriddetail";
            this.datagriddetail.Size = new System.Drawing.Size(494, 211);
            this.datagriddetail.TabIndex = 0;
            // 
            // comref
            // 
            this.comref.HeaderText = "Réf";
            this.comref.Name = "comref";
            this.comref.Width = 300;
            // 
            // Qté
            // 
            this.Qté.HeaderText = "Qté";
            this.Qté.Name = "Qté";
            this.Qté.Width = 150;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(533, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Les Facteur Commande";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commande___
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(647, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Commande);
            this.Name = "Commande___";
            this.Text = "Commande___";
            this.Load += new System.EventHandler(this.Commande____Load);
            this.Commande.ResumeLayout(false);
            this.Commande.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagriddetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumfacteur;
        private System.Windows.Forms.DateTimePicker datetimefacteur;
        private System.Windows.Forms.GroupBox Commande;
        private System.Windows.Forms.ComboBox combclient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datagriddetail;
        private System.Windows.Forms.Button btntroncaction;
        private System.Windows.Forms.DataGridViewComboBoxColumn comref;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qté;
        private System.Windows.Forms.Button btnclients;
        private System.Windows.Forms.Button button1;
    }
}