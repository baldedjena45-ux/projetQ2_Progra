using System;
using System.Drawing;
using System.Windows.Forms;

namespace projetQ2_Progra

{
    public partial class Form1 : Form
    {
        // On garde 2 images en mémoire
        private Image imgA;
        private Image imgB;
        private bool permute = false;

        public Form1()
        {
            InitializeComponent();

           
            imgA = pictureBox1.Image;
            imgB = pictureBox2.Image;

            // Centrage initial
            CentrerPictureBoxes();
        }

        private void btnPermuter_Click(object sender, EventArgs e)
        {
            // Permute les images
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

            // Recentrer si nécessaire
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

            using (EcranPrincipal f = new EcranPrincipal())
            {
                f.ShowDialog(); 
            }
            
            this.Show();
        }
    }
}
