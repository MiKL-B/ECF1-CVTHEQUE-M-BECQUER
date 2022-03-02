using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF1_CVTHEQUE_M_BECQUER
{
    public partial class AjoutCandidat : Form
    {
        private Candidat candidat;
        private Form1 form;
    
        public AjoutCandidat(Form1 fm,Candidat data)
        {
            
            InitializeComponent();
            candidat = data;
            form = fm;
          
        }

        private void BtnValiderAjoutCandidat_Click(object sender, EventArgs e)
        {

            if (candidat == null)
            {
                form.dataGridView1.Rows.Add(
               form.dataGridView1.Rows.Count + 1,
               TxtAjoutNom.Text,
               TxtAjoutPrenom.Text,
               TxtAjoutAge.Text,
               TxtAjoutBirthDate.Text,
               TxtAjoutAddress.Text,
               TxtAjoutAddress1.Text,
               TxtAjoutCodePostal.Text,
               TxtAjoutVille.Text,
               TxtAjoutSmartPhone.Text,
               TxtAjoutPhone.Text,
               TxtAjoutEmail.Text,
               TxtAjoutProfil.Text,
               TxtAjoutSkill1.Text,
               TxtAjoutSkill2.Text,
               TxtAjoutSkill3.Text,
               TxtAjoutSkill4.Text,
               TxtAjoutSkill5.Text,
               TxtAjoutSkill6.Text,
               TxtAjoutSkill7.Text,
               TxtAjoutSkill8.Text,
               TxtAjoutSkill9.Text,
               TxtAjoutSkill10.Text,
               TxtAjoutWebSite.Text,
               TxtAjoutLinkedin.Text,
               TxtAjoutViadeo.Text,
               TxtAjoutFacebook.Text

               );
             
                try
                {
                    Save_data();
                }
                catch
                {
                    MessageBox.Show("[ERREUR]: fichier non exporté");
                }

            }
            else
            {
                MessageBox.Show("c'est pété");
                Close();
            }
        }
        private void Save_data()
        {
            string csv = string.Empty;

            //ajout des colonnes
            foreach (DataGridViewColumn column in form.dataGridView1.Columns)
            {
                csv += column.HeaderText + ';';
            }

            //ajout retour a la ligne.
            csv += "\r\n";

            //ajout de lignes
            foreach (DataGridViewRow row in form.dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        //ajout des datas
                        csv += cell.Value.ToString().TrimEnd(';').Replace(";", ",") + ';';
                    }


                }

                csv += "\r\n";
            }

            //export
            string folderPath = @".\data\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileExport = "hrdata.csv";

            File.WriteAllText(folderPath + fileExport, csv);
            MessageBox.Show("Candidat ajouté avec succés");
            Close();
        }
        private void AjoutCandidat_Load(object sender, EventArgs e)
        {
         
            if (candidat != null)
            {
               
                TxtAjoutNom.Text = candidat.LastName;
                TxtAjoutPrenom.Text = candidat.FirstName;
                TxtAjoutBirthDate.Text = candidat.BirthDate;
                TxtAjoutAddress.Text = candidat.Address;
                TxtAjoutAddress1.Text = candidat.Address1;
                TxtAjoutCodePostal.Text = candidat.CodePostal;
                TxtAjoutVille.Text = candidat.Ville;
                TxtAjoutSmartPhone.Text = candidat.SmartPhone;
                TxtAjoutPhone.Text = candidat.Phone;
                TxtAjoutEmail.Text = candidat.Email;
                TxtAjoutProfil.Text = candidat.Profil;
                TxtAjoutSkill1.Text = candidat.Skill1;
                TxtAjoutSkill2.Text = candidat.Skill2;
                TxtAjoutSkill3.Text = candidat.Skill3;
                TxtAjoutSkill4.Text = candidat.Skill4;
                TxtAjoutSkill5.Text = candidat.Skill5;
                TxtAjoutSkill6.Text = candidat.Skill6;
                TxtAjoutSkill7.Text = candidat.Skill7;
                TxtAjoutSkill8.Text = candidat.Skill8;
                TxtAjoutSkill9.Text = candidat.Skill9;
                TxtAjoutSkill10.Text = candidat.Skill10;
                TxtAjoutWebSite.Text = candidat.WebSite;
                TxtAjoutLinkedin.Text = candidat.LinkedinProfil;
                TxtAjoutViadeo.Text = candidat.ViadeoProfil;
                TxtAjoutFacebook.Text = candidat.FacebookProfil;
            
            }
         
        }

    }
    }

