namespace ECF1_CVTHEQUE_M_BECQUER
{
    partial class AjoutCandidat
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.LblAjoutPrenom = new System.Windows.Forms.Label();
            this.TxtAjoutNom = new System.Windows.Forms.TextBox();
            this.TxtAjoutPrenom = new System.Windows.Forms.TextBox();
            this.LblAjoutNom = new System.Windows.Forms.Label();
            this.TxtIdentite = new System.Windows.Forms.TextBox();
            this.BtnValiderAjoutCandidat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAjoutPrenom
            // 
            this.LblAjoutPrenom.AutoSize = true;
            this.LblAjoutPrenom.Location = new System.Drawing.Point(89, 92);
            this.LblAjoutPrenom.Name = "LblAjoutPrenom";
            this.LblAjoutPrenom.Size = new System.Drawing.Size(43, 13);
            this.LblAjoutPrenom.TabIndex = 1;
            this.LblAjoutPrenom.Text = "Prenom";
            // 
            // TxtAjoutNom
            // 
            this.TxtAjoutNom.Location = new System.Drawing.Point(169, 45);
            this.TxtAjoutNom.Name = "TxtAjoutNom";
            this.TxtAjoutNom.Size = new System.Drawing.Size(100, 20);
            this.TxtAjoutNom.TabIndex = 2;
            // 
            // TxtAjoutPrenom
            // 
            this.TxtAjoutPrenom.Location = new System.Drawing.Point(169, 85);
            this.TxtAjoutPrenom.Name = "TxtAjoutPrenom";
            this.TxtAjoutPrenom.Size = new System.Drawing.Size(100, 20);
            this.TxtAjoutPrenom.TabIndex = 3;
            // 
            // LblAjoutNom
            // 
            this.LblAjoutNom.AutoSize = true;
            this.LblAjoutNom.Location = new System.Drawing.Point(89, 52);
            this.LblAjoutNom.Name = "LblAjoutNom";
            this.LblAjoutNom.Size = new System.Drawing.Size(29, 13);
            this.LblAjoutNom.TabIndex = 5;
            this.LblAjoutNom.Text = "Nom";
            // 
            // TxtIdentite
            // 
            this.TxtIdentite.Location = new System.Drawing.Point(92, 151);
            this.TxtIdentite.Name = "TxtIdentite";
            this.TxtIdentite.Size = new System.Drawing.Size(177, 20);
            this.TxtIdentite.TabIndex = 6;
            // 
            // BtnValiderAjoutCandidat
            // 
            this.BtnValiderAjoutCandidat.Location = new System.Drawing.Point(194, 208);
            this.BtnValiderAjoutCandidat.Name = "BtnValiderAjoutCandidat";
            this.BtnValiderAjoutCandidat.Size = new System.Drawing.Size(75, 23);
            this.BtnValiderAjoutCandidat.TabIndex = 7;
            this.BtnValiderAjoutCandidat.Text = "&VALIDER";
            this.BtnValiderAjoutCandidat.UseVisualStyleBackColor = true;
            this.BtnValiderAjoutCandidat.Click += new System.EventHandler(this.BtnValiderAjoutCandidat_Click);
            // 
            // AjoutCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnValiderAjoutCandidat);
            this.Controls.Add(this.TxtIdentite);
            this.Controls.Add(this.LblAjoutNom);
            this.Controls.Add(this.TxtAjoutPrenom);
            this.Controls.Add(this.TxtAjoutNom);
            this.Controls.Add(this.LblAjoutPrenom);
            this.Name = "AjoutCandidat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutCandidat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label LblAjoutPrenom;
        private System.Windows.Forms.TextBox TxtAjoutNom;
        private System.Windows.Forms.TextBox TxtAjoutPrenom;
        private System.Windows.Forms.Label LblAjoutNom;
        private System.Windows.Forms.TextBox TxtIdentite;
        private System.Windows.Forms.Button BtnValiderAjoutCandidat;
    }
}