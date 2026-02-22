using System;
using System.Drawing;
using System.Windows.Forms;

namespace projetQ2_Progra

{
    public partial class EcranDemarrage : Form
    {
        
        private Image imgA;
        private Image imgB;
        private bool permute = false;

        public EcranDemarrage()
        {
            InitializeComponent();

           
            imgA = pictureBox1.Image;
            imgB = pictureBox2.Image;

            
            CentrerPictureBoxes();
        }

        private void btnPermuter_Click(object sender, EventArgs e)
        {
            
            permute = !permute;

            if (permute)
            {
                pictureBox1.Image = imgB;
                pictureBox2.Image = imgA;
            }
            else
            {
                pictureBox1.Image = imgA;
                pictureBox2.Image = imgB;
            }

            
            CentrerPictureBoxes();
        }

        private void CentrerPictureBoxes()
        {
            
            int espace = 20; 

            int totalLargeur = pictureBox1.Width + espace + pictureBox2.Width;
            int startX = (this.ClientSize.Width - totalLargeur) / 2;

            int y = pictureBox1.Top; 

            pictureBox1.Left = startX;
            pictureBox2.Left = startX + pictureBox1.Width + espace;

            pictureBox1.Top = y;
            pictureBox2.Top = y;
        }

        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CentrerPictureBoxes();
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            this.Hide(); 

            using (EcranSecondaire f = new EcranSecondaire())
            {
                f.ShowDialog(); 
            }
            
            this.Show();
        }

        private void FonctionNonImplantee(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
                MessageBox.Show($"La fonction '{item.Text}' n'est pas encore implémentée.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Fonction non implémentée.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAPropos_Click(object sender, EventArgs e)
        {
            using (EcranAPropos f = new EcranAPropos())
            {
                f.ShowDialog();
            }
        }

        private void mnuProgression_Click(object sender, EventArgs e)
        {
            using (EcranProgression f = new EcranProgression())
            {
                f.ShowDialog();
            }
        }

        private void mnuListe_Click(object sender, EventArgs e)
        {
            using (EcranListe f = new EcranListe())
            {
                f.ShowDialog();
            }
        }


        private void EcranDemarrage_Load(object sender, EventArgs e)
        {

        }
    }
}
