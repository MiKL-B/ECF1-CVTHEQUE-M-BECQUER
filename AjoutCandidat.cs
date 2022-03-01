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
                null,
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
        }

        private void AjoutCandidat_Load(object sender, EventArgs e)
        {
           
        }

     
    }
}
