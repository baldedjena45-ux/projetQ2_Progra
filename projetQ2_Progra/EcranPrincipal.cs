using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetQ2_Progra
{
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }

        private void EcranPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void EcranPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = MessageBox.Show(
        "Voulez-vous vraiment fermer cette fenêtre ?",
        "Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (rep == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }
    }
}
