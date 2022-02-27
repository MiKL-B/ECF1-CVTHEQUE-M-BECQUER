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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnModifCandidat = new System.Windows.Forms.Button();
            this.BtnAjoutCandidat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SmartPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ProfilViadeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacebookProfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnExport);
            this.panel1.Controls.Add(this.BtnModifCandidat);
            this.panel1.Controls.Add(this.BtnAjoutCandidat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.Location = new System.Drawing.Point(930, 15);
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
            this.BtnModifCandidat.Location = new System.Drawing.Point(553, 15);
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
            this.BtnAjoutCandidat.Location = new System.Drawing.Point(733, 15);
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 697);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.lastName,
            this.firstName,
            this.Age,
            this.birthDate,
            this.Address,
            this.Address1,
            this.CodePostal,
            this.Ville,
            this.SmartPhone,
            this.Phone,
            this.email,
            this.profile,
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
            this.ProfilViadeo,
            this.FacebookProfil});
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1059, 952);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1062, 710);
            this.panel2.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Width = 50;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Nom";
            this.lastName.Name = "lastName";
            this.lastName.Width = 50;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Prénom";
            this.firstName.Name = "firstName";
            this.firstName.Width = 50;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.Width = 50;
            // 
            // birthDate
            // 
            this.birthDate.HeaderText = "Date de naissance";
            this.birthDate.Name = "birthDate";
            this.birthDate.Width = 50;
            // 
            // Address
            // 
            this.Address.HeaderText = "Adresse";
            this.Address.Name = "Address";
            // 
            // Address1
            // 
            this.Address1.HeaderText = "Adresse1";
            this.Address1.Name = "Address1";
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "Code Postal";
            this.CodePostal.Name = "CodePostal";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // SmartPhone
            // 
            this.SmartPhone.HeaderText = "Numéro de téléphone portable";
            this.SmartPhone.Name = "SmartPhone";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Numéro de tel fixe";
            this.Phone.Name = "Phone";
            // 
            // email
            // 
            this.email.HeaderText = "Email personnel";
            this.email.Name = "email";
            // 
            // profile
            // 
            this.profile.HeaderText = "Profil recherché";
            this.profile.Name = "profile";
            // 
            // Skill1
            // 
            this.Skill1.HeaderText = "Compétence1";
            this.Skill1.Name = "Skill1";
            this.Skill1.Width = 50;
            // 
            // Skill2
            // 
            this.Skill2.HeaderText = "Compétence2";
            this.Skill2.Name = "Skill2";
            this.Skill2.Width = 50;
            // 
            // Skill3
            // 
            this.Skill3.HeaderText = "Compétence3";
            this.Skill3.Name = "Skill3";
            this.Skill3.Width = 50;
            // 
            // Skill4
            // 
            this.Skill4.HeaderText = "Compétence4";
            this.Skill4.Name = "Skill4";
            this.Skill4.Width = 50;
            // 
            // Skill5
            // 
            this.Skill5.HeaderText = "Compétence5";
            this.Skill5.Name = "Skill5";
            this.Skill5.Width = 50;
            // 
            // Skill6
            // 
            this.Skill6.HeaderText = "Compétence6";
            this.Skill6.Name = "Skill6";
            this.Skill6.Width = 50;
            // 
            // Skill7
            // 
            this.Skill7.HeaderText = "Compétence7";
            this.Skill7.Name = "Skill7";
            this.Skill7.Width = 50;
            // 
            // Skill8
            // 
            this.Skill8.HeaderText = "Compétence8";
            this.Skill8.Name = "Skill8";
            this.Skill8.Width = 50;
            // 
            // Skill9
            // 
            this.Skill9.HeaderText = "Compétence9";
            this.Skill9.Name = "Skill9";
            this.Skill9.Width = 50;
            // 
            // Skill10
            // 
            this.Skill10.HeaderText = "Compétence10";
            this.Skill10.Name = "Skill10";
            this.Skill10.Width = 50;
            // 
            // WebSite
            // 
            this.WebSite.HeaderText = "Site web";
            this.WebSite.Name = "WebSite";
            this.WebSite.Width = 50;
            // 
            // LinkedinProfil
            // 
            this.LinkedinProfil.HeaderText = "Profil Linkedin";
            this.LinkedinProfil.Name = "LinkedinProfil";
            this.LinkedinProfil.Width = 50;
            // 
            // ProfilViadeo
            // 
            this.ProfilViadeo.HeaderText = "Profil Viadeo";
            this.ProfilViadeo.Name = "ProfilViadeo";
            this.ProfilViadeo.Width = 50;
            // 
            // FacebookProfil
            // 
            this.FacebookProfil.HeaderText = "Profil Facebook";
            this.FacebookProfil.Name = "FacebookProfil";
            this.FacebookProfil.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV THEQUE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button BtnAjoutCandidat;
        private System.Windows.Forms.Button BtnModifCandidat;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmartPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn profile;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfilViadeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacebookProfil;
    }
}

