using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<Candidat> candidats;
        private string _Id = "1";
        public Form1()
        {


            InitializeComponent();

            //désactivation du bouton modification
            //il sera activé lors du clic sur le candidat
            BtnModifCandidat.Enabled = false;
    
            //lit le contenu du fichier CSV ligne par ligne
            string[] csvLines = File.ReadAllLines(@"./data/hrdata.csv");


            ////List des candidats

            candidats = new List<Candidat>();

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
                    //candidats[i].Skills,
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
                    ) ;
                }
            //tri par défaut par nom de candidat
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
     
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender,  EventArgs e)
        {
         

        }
        //affiche le formulaire d'ajout de candidat
        private void BtnAjoutCandidat_Click(object sender, EventArgs e)
        {
            //Instanciation du formulaire ajout candidat
            AjoutCandidat ajoutCandidat = new AjoutCandidat(this,null);
            ajoutCandidat.ShowDialog();
        }
        //affiche le formulaire (le meme qu'ajout mais avec les informations du candidat)
        private void BtnModifCandidat_Click(object sender, EventArgs e)
        {
            //Instanciation du formulaire modification candidat
            var candidat = candidats.Find(c => c.Id == _Id);
            AjoutCandidat ajoutCandidat = new AjoutCandidat(this, candidat);
            ajoutCandidat.ShowDialog();
        }

        //exporter en csv au click sur le bouton export
        private void BtnExport_Click(object sender, EventArgs e)
        {
            Export_data();
          
        }
        public void Export_data()
        {
            try
            {

                string csv = string.Empty;

                //ajout des colonnes
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    csv += column.HeaderText + ';';
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
                            csv += cell.Value.ToString().TrimEnd(';').Replace(";", ",") + ';';
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

                string fileExport = "dataExport.csv";

                File.WriteAllText(folderPath + fileExport, csv);

                //Console.WriteLine(folderPath + fileExport);
                Process.Start(folderPath + fileExport);
                MessageBox.Show("fichier exporté dans: C:\\CSV");
            }
            catch
            {
                MessageBox.Show("[ERREUR]: fichier non exporté");
            }
        }
        //double click sur une personne pour afficher son cv (.pdf / .docx)
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
     
            //récupération de l'id de la ligne cliquée
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    string filename = @".\data\faits\";
                    string filenamePdf = filename + id + ".pdf";
                    string filenameDocx = filename + id + ".docx";
                    try
                    {
                        Process.Start(filenamePdf);
                    }
                    catch
                    {
                        Process.Start(filenameDocx);
                    }
        
                }                
            }
            catch
            {
                MessageBox.Show("Le CV du candidat est manquant !");
            }
          

        }
        //choisit un candidat au clic et le surligne et permet sa modification 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    _Id = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    BtnModifCandidat.Enabled = true;

                }
               
            }
  
            catch(Exception ex)
            {


                Console.WriteLine(ex.Message);
            }
           
        }

       
        //filtre via la textbox TxtSearch
        //ville, age, compétence
        //8, 3 ,13-22
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
              
                if ((row.Cells[3].Value).ToString().ToUpper().Contains(TxtSearch.Text.ToUpper()) ||
                    (row.Cells[8].Value).ToString().ToUpper().Contains(TxtSearch.Text.ToUpper()) ||
                    (row.Cells[13].Value).ToString().ToUpper().Contains(TxtSearch.Text.ToUpper()))
                {
                    dataGridView1.Rows[row.Index].Visible = true;
                }
                else
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[row.Index].Visible = false;
                  
                }
                if(dataGridView1.Rows[row.Index].Visible  == true && dataGridView1.Rows.Count == 1)
                {
                    //dataGridView1.Update();
                
                    Console.WriteLine(dataGridView1.Rows[row.Index].Cells[1].Value);
                }
   
      
                
            }
        }
        //nom, ville profil
        //1 8 12
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {




    
            if(e.ColumnIndex == 1)
            {
                Console.WriteLine("1");
               dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
                
            }
         
    



        }


    }
}
