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
      
        }
    }
}
