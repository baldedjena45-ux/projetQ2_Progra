using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetQ2_Progra
{
    public partial class EcranProgression : Form
    {
        private readonly Random _rnd = new Random();
        public EcranProgression()
        {
            InitializeComponent();

            pbPrincipal.Minimum = 0;
            pbPrincipal.Maximum = 100;
            pbPrincipal.Value = 0;

            pbSecondaire.Minimum = 0;
            pbSecondaire.Maximum = 100;
            pbSecondaire.Value = 0;

            pbPrincipal.Style = ProgressBarStyle.Continuous;
            pbSecondaire.Style = ProgressBarStyle.Continuous;
        }
        

        private void bQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void bExecuter_Click(object sender, EventArgs e)
        {
            Cursor ancienCurseur = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            bExecuter.Enabled = false;
            bQuitter.Enabled = false;

            try
            {
                int nbFichiers = _rnd.Next(5, 16);

                pbPrincipal.Minimum = 0;
                pbPrincipal.Maximum = nbFichiers;
                pbPrincipal.Value = 0;

                for (int f = 1; f <= nbFichiers; f++)
                {
                    int taille = _rnd.Next(60, 120);
                    pbSecondaire.Minimum = 0;
                    pbSecondaire.Maximum = taille;
                    pbSecondaire.Value = 0;

                    for (int i = 0; i <= taille; i++)
                    {
                        pbSecondaire.Value = i;

                        await Task.Delay(_rnd.Next(40, 100)); 
                    }
                    pbSecondaire.Value = pbSecondaire.Maximum;
                    await Task.Delay(200);
                    pbPrincipal.Value = f;
                }

                MessageBox.Show("Copie terminée !", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.Cursor = ancienCurseur;
                bExecuter.Enabled = true;
                bQuitter.Enabled = true;
            }
        }


        /*private void bExecuter_Click(object sender, EventArgs e)
        {
            
            Cursor ancienCurseur = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            bExecuter.Enabled = false;
            bQuitter.Enabled = false;

            try
            {
                
                int nbFichiers = _rnd.Next(5, 16); 

                pbPrincipal.Minimum = 0;
                pbPrincipal.Maximum = nbFichiers;
                pbPrincipal.Value = 0;

                for (int f = 1; f <= nbFichiers; f++)
                {
                    
                    int taille = _rnd.Next(30, 121); 
                    pbSecondaire.Minimum = 0;
                    pbSecondaire.Maximum = taille;
                    pbSecondaire.Value = 0;

                    
                    for (int i = 1; i <= taille; i++)
                    {
                        pbSecondaire.Value = i;

                       
                        Thread.Sleep(_rnd.Next(10, 40));

                        
                        Application.DoEvents();
                    }

                   
                    pbPrincipal.Value = f;
                    Application.DoEvents();
                }

                MessageBox.Show("Copie terminée !", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                
                this.Cursor = ancienCurseur;
                bExecuter.Enabled = true;
                bQuitter.Enabled = true;
            }
        }*/
    }
}
    

