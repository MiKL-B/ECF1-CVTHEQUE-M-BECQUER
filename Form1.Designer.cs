namespace ECF1_CVTHEQUE_M_BECQUER
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnModifCandidat = new System.Windows.Forms.Button();
            this.BtnAjoutCandidat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SmartPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkedinProfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViadeoProfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacebookProfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.BtnExport);
            this.panel1.Controls.Add(this.BtnModifCandidat);
            this.panel1.Controls.Add(this.BtnAjoutCandidat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Rechercher :";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(650, 17);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(144, 20);
            this.TxtSearch.TabIndex = 61;
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.Location = new System.Drawing.Point(1225, 15);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(120, 23);
            this.BtnExport.TabIndex = 7;
            this.BtnExport.Text = "&EXPORT";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnModifCandidat
            // 
            this.BtnModifCandidat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModifCandidat.Location = new System.Drawing.Point(848, 15);
            this.BtnModifCandidat.Name = "BtnModifCandidat";
            this.BtnModifCandidat.Size = new System.Drawing.Size(174, 23);
            this.BtnModifCandidat.TabIndex = 6;
            this.BtnModifCandidat.Text = "&MODIFICATION CANDIDAT";
            this.BtnModifCandidat.UseVisualStyleBackColor = true;
            this.BtnModifCandidat.Click += new System.EventHandler(this.BtnModifCandidat_Click);
            // 
            // BtnAjoutCandidat
            // 
            this.BtnAjoutCandidat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAjoutCandidat.Location = new System.Drawing.Point(1028, 15);
            this.BtnAjoutCandidat.Name = "BtnAjoutCandidat";
            this.BtnAjoutCandidat.Size = new System.Drawing.Size(174, 23);
            this.BtnAjoutCandidat.TabIndex = 5;
            this.BtnAjoutCandidat.Text = "&AJOUT CANDIDAT";
            this.BtnAjoutCandidat.UseVisualStyleBackColor = true;
            this.BtnAjoutCandidat.Click += new System.EventHandler(this.BtnAjoutCandidat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CV THEQUE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1357, 416);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.Age,
            this.BirthDate,
            this.Address,
            this.Address1,
            this.CodePostal,
            this.Ville,
            this.SmartPhone,
            this.Phone,
            this.Email,
            this.Profil,
            this.Skill1,
            this.Skill2,
            this.Skill3,
            this.Skill4,
            this.Skill5,
            this.Skill6,
            this.Skill7,
            this.Skill8,
            this.Skill9,
            this.Skill10,
            this.WebSite,
            this.LinkedinProfil,
            this.ViadeoProfil,
            this.FacebookProfil});
            this.dataGridView1.Location = new System.Drawing.Point(9, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1335, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Nom";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Prénom";
            this.FirstName.Name = "FirstName";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Date de naissance";
            this.BirthDate.Name = "BirthDate";
            // 
            // Address
            // 
            this.Address.HeaderText = "Adresse";
            this.Address.Name = "Address";
            // 
            // Address1
            // 
            this.Address1.HeaderText = "Adresse 1";
            this.Address1.Name = "Address1";
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "Code postal";
            this.CodePostal.Name = "CodePostal";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // SmartPhone
            // 
            this.SmartPhone.HeaderText = "Portable";
            this.SmartPhone.Name = "SmartPhone";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Fixe";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Profil
            // 
            this.Profil.HeaderText = "Profil";
            this.Profil.Name = "Profil";
            // 
            // Skill1
            // 
            this.Skill1.HeaderText = "Comp1";
            this.Skill1.Name = "Skill1";
            // 
            // Skill2
            // 
            this.Skill2.HeaderText = "Comp2";
            this.Skill2.Name = "Skill2";
            // 
            // Skill3
            // 
            this.Skill3.HeaderText = "Skill3";
            this.Skill3.Name = "Skill3";
            // 
            // Skill4
            // 
            this.Skill4.HeaderText = "Comp4";
            this.Skill4.Name = "Skill4";
            // 
            // Skill5
            // 
            this.Skill5.HeaderText = "Comp5";
            this.Skill5.Name = "Skill5";
            // 
            // Skill6
            // 
            this.Skill6.HeaderText = "Comp6";
            this.Skill6.Name = "Skill6";
            // 
            // Skill7
            // 
            this.Skill7.HeaderText = "Comp7";
            this.Skill7.Name = "Skill7";
            // 
            // Skill8
            // 
            this.Skill8.HeaderText = "Comp8";
            this.Skill8.Name = "Skill8";
            // 
            // Skill9
            // 
            this.Skill9.HeaderText = "Comp9";
            this.Skill9.Name = "Skill9";
            // 
            // Skill10
            // 
            this.Skill10.HeaderText = "Comp10";
            this.Skill10.Name = "Skill10";
            // 
            // WebSite
            // 
            this.WebSite.HeaderText = "Site web";
            this.WebSite.Name = "WebSite";
            // 
            // LinkedinProfil
            // 
            this.LinkedinProfil.HeaderText = "Linkedin";
            this.LinkedinProfil.Name = "LinkedinProfil";
            // 
            // ViadeoProfil
            // 
            this.ViadeoProfil.HeaderText = "Viadeo";
            this.ViadeoProfil.Name = "ViadeoProfil";
            // 
            // FacebookProfil
            // 
            this.FacebookProfil.HeaderText = "Facebook";
            this.FacebookProfil.Name = "FacebookProfil";
            // 
            // candidatBindingSource
            // 
            this.candidatBindingSource.DataSource = typeof(ECF1_CVTHEQUE_M_BECQUER.Candidat);
            // 
            // candidatBindingSource1
            // 
            this.candidatBindingSource1.DataSource = typeof(ECF1_CVTHEQUE_M_BECQUER.Candidat);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV THEQUE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button BtnAjoutCandidat;
        private System.Windows.Forms.Button BtnModifCandidat;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smartPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webSiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkedinProfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viadeoProfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebookProfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource candidatBindingSource;
        private System.Windows.Forms.BindingSource candidatBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmartPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill10;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkedinProfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViadeoProfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacebookProfil;
    }
}

