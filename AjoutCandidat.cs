using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        Form1 form;
    
        public AjoutCandidat(Form1 fm)
        {
            
            InitializeComponent();
            this.form = fm;
          
        }

        private void BtnValiderAjoutCandidat_Click(object sender, EventArgs e)
        {
           

            form.dataGridView1.Rows.Add(
                form.dataGridView1.Rows.Count+1,
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

                string csv = string.Empty;

                //ajout des colonnes
                foreach (DataGridViewColumn column in form.dataGridView1.Columns)
                {
                    csv += column.HeaderText + ',';
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
                            csv += cell.Value.ToString().TrimEnd(',').Replace(",", ";") + ',';
                        }

                    }

                    csv += "\r\n";
                }

                //export
                string folderPath = @"./data/";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileExport = "hrdata.csv";

                File.WriteAllText(folderPath + fileExport, csv);
                MessageBox.Show("fichier save");
            }
            catch
            {
                MessageBox.Show("[ERREUR]: fichier non save");
            }
        }

        private void AjoutCandidat_Load(object sender, EventArgs e)
        {
           
        }

     
    }
}
