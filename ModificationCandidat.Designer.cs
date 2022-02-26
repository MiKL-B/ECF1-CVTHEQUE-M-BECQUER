namespace ECF1_CVTHEQUE_M_BECQUER
{
    partial class ModificationCandidat
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
            this.LblModifNom = new System.Windows.Forms.Label();
            this.LblModifPrenom = new System.Windows.Forms.Label();
            this.BtnValiderModifCandidat = new System.Windows.Forms.Button();
            this.TxtModifNom = new System.Windows.Forms.TextBox();
            this.TxtModifPrenom = new System.Windows.Forms.TextBox();
            this.TxtCsv = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LblModifNom
            // 
            this.LblModifNom.AutoSize = true;
            this.LblModifNom.Location = new System.Drawing.Point(34, 50);
            this.LblModifNom.Name = "LblModifNom";
            this.LblModifNom.Size = new System.Drawing.Size(29, 13);
            this.LblModifNom.TabIndex = 0;
            this.LblModifNom.Text = "Nom";
            // 
            // LblModifPrenom
            // 
            this.LblModifPrenom.AutoSize = true;
            this.LblModifPrenom.Location = new System.Drawing.Point(34, 97);
            this.LblModifPrenom.Name = "LblModifPrenom";
            this.LblModifPrenom.Size = new System.Drawing.Size(43, 13);
            this.LblModifPrenom.TabIndex = 1;
            this.LblModifPrenom.Text = "Prénom";
            // 
            // BtnValiderModifCandidat
            // 
            this.BtnValiderModifCandidat.Location = new System.Drawing.Point(137, 159);
            this.BtnValiderModifCandidat.Name = "BtnValiderModifCandidat";
            this.BtnValiderModifCandidat.Size = new System.Drawing.Size(75, 23);
            this.BtnValiderModifCandidat.TabIndex = 2;
            this.BtnValiderModifCandidat.Text = "&VALIDER";
            this.BtnValiderModifCandidat.UseVisualStyleBackColor = true;
            this.BtnValiderModifCandidat.Click += new System.EventHandler(this.BtnValiderModifCandidat_Click);
            // 
            // TxtModifNom
            // 
            this.TxtModifNom.Location = new System.Drawing.Point(112, 50);
            this.TxtModifNom.Name = "TxtModifNom";
            this.TxtModifNom.Size = new System.Drawing.Size(100, 20);
            this.TxtModifNom.TabIndex = 3;
            // 
            // TxtModifPrenom
            // 
            this.TxtModifPrenom.Location = new System.Drawing.Point(112, 97);
            this.TxtModifPrenom.Name = "TxtModifPrenom";
            this.TxtModifPrenom.Size = new System.Drawing.Size(100, 20);
            this.TxtModifPrenom.TabIndex = 4;
            // 
            // TxtCsv
            // 
            this.TxtCsv.Location = new System.Drawing.Point(265, 14);
            this.TxtCsv.Name = "TxtCsv";
            this.TxtCsv.Size = new System.Drawing.Size(507, 410);
            this.TxtCsv.TabIndex = 5;
            this.TxtCsv.Text = "";
            // 
            // ModificationCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtCsv);
            this.Controls.Add(this.TxtModifPrenom);
            this.Controls.Add(this.TxtModifNom);
            this.Controls.Add(this.BtnValiderModifCandidat);
            this.Controls.Add(this.LblModifPrenom);
            this.Controls.Add(this.LblModifNom);
            this.Name = "ModificationCandidat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificationCandidat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblModifNom;
        private System.Windows.Forms.Label LblModifPrenom;
        private System.Windows.Forms.Button BtnValiderModifCandidat;
        private System.Windows.Forms.TextBox TxtModifNom;
        private System.Windows.Forms.TextBox TxtModifPrenom;
        private System.Windows.Forms.RichTextBox TxtCsv;
    }
}