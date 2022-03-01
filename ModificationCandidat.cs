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
    public partial class ModificationCandidat : Form
    {
        public string LastNameModif;
        public string FirstNameModif;
        public string AddressModif;
        public string Address1Modif;
        public string CodePostalModif;
        public string VilleModif;
        public string SmartPhoneModif;
        public string PhoneModif;
        public string EmailModif;
        public string ProfilModif;
        public string Skill1Modif;
        public string Skill2Modif;
        public string Skill3Modif;
        public string Skill4Modif;
        public string Skill5Modif;
        public string Skill6Modif;
        public string Skill7Modif;
        public string Skill8Modif;
        public string Skill9Modif;
        public string Skill10Modif;
        public string WebSiteModif;
        public string LinkedinModif;
        public string ViadeoModif;
        public string FacebookModif;
        public ModificationCandidat()
        {
            InitializeComponent();
        }

        private void BtnValiderModifCandidat_Click(object sender, EventArgs e)
        {
        }

        private void ModificationCandidat_Load(object sender, EventArgs e)
        {
            TxtModifNom.Text = LastNameModif;
            TxtModifPrenom.Text = FirstNameModif;
            TxtModifAddress.Text = AddressModif;
            TxtModifAddress1.Text = Address1Modif;
            TxtModifCodePostal.Text = CodePostalModif;
            TxtModifVille.Text = VilleModif;
            TxtModifSmartPhone.Text = SmartPhoneModif;
            TxtModifPhone.Text = PhoneModif;
            TxtModifEmail.Text = EmailModif;
            TxtModifProfil.Text = ProfilModif;
            TxtModifSkill1.Text = Skill1Modif;
            TxtModifSkill2.Text = Skill2Modif;
            TxtModifSkill3.Text = Skill3Modif;
            TxtModifSkill4.Text = Skill4Modif;
            TxtModifSkill5.Text = Skill5Modif;
            TxtModifSkill6.Text = Skill6Modif;
            TxtModifSkill7.Text = Skill7Modif;
            TxtModifSkill8.Text = Skill8Modif;
            TxtModifSkill9.Text = Skill9Modif;
            TxtModifSkill10.Text = Skill10Modif;
            TxtModifLinkedin.Text = LinkedinModif;
            TxtModifViadeo.Text = ViadeoModif;
            TxtModifFacebook.Text = FacebookModif;

        }
    }
}
