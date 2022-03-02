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

        private Candidat candidat;
        private Form1 form;
        public ModificationCandidat(Candidat data, Form1 fm)
        {
            InitializeComponent();
           candidat = data;
            form = fm;
        }

        private void BtnValiderModifCandidat_Click(object sender, EventArgs e)
        {
        }

        private void ModificationCandidat_Load(object sender, EventArgs e)
        {
   
            TxtModifNom.Text = candidat.LastName;
            TxtModifPrenom.Text = candidat.FirstName;
      

        }
    }
}
