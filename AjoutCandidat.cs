using System;
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
            //si il n'y a pas de candidats, les champs se remplissent suivant la saisie de l'utilisateur
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
               TxtAjoutWebSite.Text,
               TxtAjoutLinkedin.Text,
               TxtAjoutViadeo.Text,
               TxtAjoutFacebook.Text

               );
             
                try
                {
                    form.Export_Save_data();
                }
                catch
                {
                    
                }
                Close();
            }
            else
            {
                //permet de mettre a jour l'affichage pour un candidat a modifier
                int i;
                i = form.dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = form.dataGridView1.Rows[i];
                row.Cells[1].Value = TxtAjoutNom.Text;
                row.Cells[2].Value = TxtAjoutPrenom.Text;
                row.Cells[3].Value = TxtAjoutAge.Text;
                row.Cells[4].Value = TxtAjoutBirthDate.Text;
                row.Cells[5].Value = TxtAjoutAddress.Text;
                row.Cells[6].Value = TxtAjoutAddress1.Text;
                row.Cells[7].Value = TxtAjoutCodePostal.Text;
                row.Cells[8].Value = TxtAjoutVille.Text;
                row.Cells[9].Value = TxtAjoutSmartPhone.Text;
                row.Cells[10].Value = TxtAjoutPhone.Text;
                row.Cells[11].Value = TxtAjoutEmail.Text;
                row.Cells[12].Value = TxtAjoutProfil.Text;
                row.Cells[13].Value = TxtAjoutSkill1.Text;
                row.Cells[14].Value = TxtAjoutWebSite.Text;
                row.Cells[15].Value = TxtAjoutLinkedin.Text;
                row.Cells[16].Value = TxtAjoutViadeo.Text;
                row.Cells[17].Value = TxtAjoutFacebook.Text;

           
             
                MessageBox.Show("update");
                try
                {
                    form.Export_Save_data();
                }
                catch
                {
              
                }
                Close();
            }
        }

 
        //lors du clic sur la modification pour un candidat, affichera les champs remplis avec les données du candidats
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
                TxtAjoutWebSite.Text = candidat.WebSite;
                TxtAjoutLinkedin.Text = candidat.LinkedinProfil;
                TxtAjoutViadeo.Text = candidat.ViadeoProfil;
                TxtAjoutFacebook.Text = candidat.FacebookProfil;
            
            }
         
        }

    }
    }

