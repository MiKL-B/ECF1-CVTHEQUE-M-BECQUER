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
        public AjoutCandidat()
        {
            InitializeComponent();
        }

        private void BtnValiderAjoutCandidat_Click(object sender, EventArgs e)
        {
            TxtAjoutSkill4.Text = TxtAjoutNom.Text + " " + TxtAjoutPrenom.Text;
        }

        private void AjoutCandidat_Load(object sender, EventArgs e)
        {

        }
    }
}
