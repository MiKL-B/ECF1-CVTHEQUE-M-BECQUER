using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF1_CVTHEQUE_M_BECQUER
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
          
            InitializeComponent();
       
            //lit le contenu du fichier CSV ligne par ligne
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\User-15\source\repos\ECF1-CVTHEQUE-M-BECQUER\data\hrdata.csv");
            BtnModifCandidat.Enabled = false;
            ////List des candidats
            var candidats = new List<Candidat>();

            //commencer a 1 pour ne pas parser la premiere ligne qui correspond au header de nos datas
            //instanciations des candidats





            for (int i = 1; i < csvLines.Length; i++)
            {
                Candidat candidat = new Candidat(csvLines[i]);
                candidats.Add(candidat);
            }
            //remplissage du tableau
            for (int i = 0; i < candidats.Count; i++)
            {

          
                this.dataGridView1.Rows.Add(
                    candidats[i].Id,
                    candidats[i].LastName,
                    candidats[i].FirstName,
                    candidats[i].Age,
                    candidats[i].BirthDate,
                    candidats[i].Address,
                    candidats[i].Address1,
                    candidats[i].CodePostal,
                    candidats[i].Ville,
                    candidats[i].SmartPhone,
                    candidats[i].Phone,
                    candidats[i].Email,
                    candidats[i].Profil,
                    candidats[i].Skill1,
                    candidats[i].Skill2,
                    candidats[i].Skill3,
                    candidats[i].Skill4,
                    candidats[i].Skill5,
                    candidats[i].Skill6,
                    candidats[i].Skill7,
                    candidats[i].Skill8,
                    candidats[i].Skill9,
                    candidats[i].Skill10,
                    candidats[i].WebSite,
                    candidats[i].LinkedinProfil,
                    candidats[i].ViadeoProfil,
                    candidats[i].FacebookProfil
                    );

            }

        }
      
   
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void BtnAjoutCandidat_Click(object sender, EventArgs e)
        {
            //Instanciation du formulaire ajout candidat
            AjoutCandidat ajoutCandidat = new AjoutCandidat();
            //Affichage du formulaire au click
            ajoutCandidat.ShowDialog();
        }

        private void BtnModifCandidat_Click(object sender, EventArgs e)
        {
            //Instanciation du formulaire modification candidat
            ModificationCandidat modificationCandidat = new ModificationCandidat();
            //Affichage du formulaire au click
            modificationCandidat.ShowDialog();
       
        }

        //exporter en csv
        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
               
                string csv = string.Empty;

                //ajout des colonnes
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    csv += column.HeaderText + ',';
                }

                //ajout retour a la ligne.
                csv += "\r\n";

                //ajout de lignes
                foreach (DataGridViewRow row in dataGridView1.Rows)
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
                string folderPath = "C:\\CSV\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                File.WriteAllText(folderPath + "dataExport.csv", csv);
                MessageBox.Show("");
            }
            catch
            {
                MessageBox.Show("");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //double click pour afficher le cv  ( edge pour pdf , word pour docx)
            //string filename = @"C:\Users\User-15\Desktop\faits\2.pdf";
            //System.Diagnostics.Process.Start(filename);

            //récupération de l'id de la ligne cliquée
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                string id = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
                //servira pour la modification du candidat
                // TxtSearch.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
                Console.WriteLine("[DOUBLE CLICK] ID:" + id + "\n ouvrir le cv");
            }
      
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                Console.WriteLine("[CLICK] ID:" +id + "\n pour modification candidat");
                BtnModifCandidat.Enabled = true;
            }
        }
    }
}
