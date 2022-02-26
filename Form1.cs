using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void BtnExport_Click(object sender, EventArgs e)
        {
          
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\micha\source\repos\ECF1-CVTHEQUE-M-BECQUER\data\hrdata.csv");

            //create list withe the csv data
            var idCv  = new List<int>();
            var lastNames = new List<string>();
            var firstNames = new List<string>();
            var age = new List<int>();
            var birthDate = new List<int>();
            var address = new List<string>();
            var address1 = new List<string>();
            var codePostal = new List<int>();
            var town = new List<string>();
            var smartPhone = new List<int>();
            var phone = new List<int>();
            var email = new List<string>();
            var profil = new List<string>();
            var skill1 = new List<string>();
            var skill2 = new List<string>();
            var skill3 = new List<string>();
            var skill4 = new List<string>();
            var skill5 = new List<string>();
            var skill6 = new List<string>();
            var skill7 = new List<string>();
            var skill8 = new List<string>();
            var skill9 = new List<string>();
            var skill10 = new List<string>();
            var webSite = new List<string>();
            var linkedinProfil = new List<string>();
            var viadeoProfil = new List<string>();
            var facebookProfil = new List<string>();



            //commencer a 1 pour ne pas parser la premiere ligne qui correspond au header de nos datas
            for (int i = 1; i < csvLines.Length; i++)
            {
           
                string[] rowData = csvLines[i].Split(';');
                int id = int.Parse(rowData[0]);
                idCv.Add(id);
                lastNames.Add(rowData[1]);
                firstNames.Add(rowData[2]);

                //int a = int.Parse(rowData[3]);
                //age.Add(a);
                //int bd = int.Parse(rowData[4]);
                //birthDate.Add(bd);
                //address.Add(rowData[5]);
                //address1.Add(rowData[6]);
                //int cp = int.Parse(rowData[7]);
                //codePostal.Add(cp);
                //town.Add(rowData[8]);
                //int sp = int.Parse(rowData[9]);
                //smartPhone.Add(sp);
                //int p = int.Parse(rowData[10]);
                //phone.Add(p);
                email.Add(rowData[11]);
                profil.Add(rowData[12]);
                skill1.Add(rowData[13]);
                skill2.Add(rowData[14]);
                skill3.Add(rowData[15]);
                skill4.Add(rowData[16]);
                skill5.Add(rowData[17]);
                skill6.Add(rowData[18]);
                skill7.Add(rowData[19]);
                skill8.Add(rowData[20]);
                skill9.Add(rowData[21]);
                skill10.Add(rowData[22]);
                webSite.Add(rowData[23]);
                linkedinProfil.Add(rowData[24]);
                viadeoProfil.Add(rowData[25]);
                facebookProfil.Add(rowData[26]);


            }

            Console.WriteLine("ID :");
            for (int i = 0; i < idCv.Count; i++)
            {

                Console.WriteLine(idCv[i]);

            }
            Console.WriteLine("FIRST NAMES :");
            for (int i = 0; i < firstNames.Count; i++)
            {

             Console.WriteLine(firstNames[i]);

            }
        }
    }
}
