using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;



namespace projetQ2_Progra
{
    public partial class EcranListe : Form
    {
        private void EcrireDonneeCachee(int index, int valeur)
        {
            SendMessage(lbPersonne.Handle, smEcrire, index, valeur);
        }

        private int LireDonneeCachee(int index)
        {
            return SendMessage(lbPersonne.Handle, smLire, index, 0);
        }
        private int compteurEncodage = 0;

        private string NomFichier = "";
        private int indexModification = -1;
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        
        private const int smLire = 0x0199;   
        private const int smEcrire = 0x019A; 


        public EcranListe()
        {
            InitializeComponent();
        }

        private void Activer(bool modeListe)
        {

            lbPersonne.Enabled = modeListe;

            bOuvrir.Enabled = modeListe;
            bEnregistrer.Enabled = modeListe;
            bAjouter.Enabled = modeListe;
            bSupprimer.Enabled = modeListe;

            gbDetail.Enabled = !modeListe;
            bConfirmer.Enabled = !modeListe;
            bAnnuler.Enabled = !modeListe;

            bModifier.Enabled = modeListe;
        }

        private void EcranListe_Load(object sender, EventArgs e)
        {
            cbQualite.SelectedIndex = 0; 
            tbNom.Clear();

            Activer(true);
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            tbNom.Clear();
            cbQualite.SelectedIndex = 0;

            Activer(false); 
            tbNom.Focus();
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            int idx = lbPersonne.SelectedIndex;
            if (idx < 0)
            {
                MessageBox.Show("Sélectionne une personne à supprimer.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            int encSupprime = LireDonneeCachee(idx);

            
            lbPersonne.Items.RemoveAt(idx);

            
            for (int i = 0; i < lbPersonne.Items.Count; i++)
            {
                int enc = LireDonneeCachee(i);
                if (enc > encSupprime)
                {
                    EcrireDonneeCachee(i, enc - 1);
                }
            }

            int maxEnc = 0;
            for (int i = 0; i < lbPersonne.Items.Count; i++)
            {
                int enc = LireDonneeCachee(i);
                if (enc > maxEnc) maxEnc = enc;
            }
            compteurEncodage = maxEnc;
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text.Trim();
            string qualite = cbQualite.Text;

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Veuillez entrer un nom.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNom.Focus();
                return;
            }

            string item = $"{nom} ({qualite})";

           
            if (indexModification >= 0)
            {
                int encodageExistant = LireDonneeCachee(indexModification);

                lbPersonne.Items.RemoveAt(indexModification);
                int nouvelIndex = lbPersonne.Items.Add(item);

                
                EcrireDonneeCachee(nouvelIndex, encodageExistant);

                indexModification = -1;
            }
            
            else
            {
                compteurEncodage++; 

                int indexAjoute = lbPersonne.Items.Add(item); 
                EcrireDonneeCachee(indexAjoute, compteurEncodage);
            }

            Activer(true);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            indexModification = -1;
            Activer(true);
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            if (ofdOuvrir.ShowDialog() != DialogResult.OK)
                return;

            NomFichier = ofdOuvrir.FileName;

            try
            {
                lbPersonne.Items.Clear();
                string[] lignes = File.ReadAllLines(NomFichier);

                int maxEnc = 0;

                foreach (string ligne in lignes)
                {
                    if (string.IsNullOrWhiteSpace(ligne))
                        continue;

                    string l = ligne.Trim();

                    
                    int p = l.LastIndexOf('#');
                    if (p <= 0 || p == l.Length - 1)
                        continue; 

                    string texte = l.Substring(0, p).Trim();
                    string encStr = l.Substring(p + 1).Trim();

                    if (!int.TryParse(encStr, out int enc))
                        continue; 

                    int indexAjoute = lbPersonne.Items.Add(texte);
                    EcrireDonneeCachee(indexAjoute, enc);

                    if (enc > maxEnc) maxEnc = enc;
                }

                
                compteurEncodage = maxEnc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() != DialogResult.OK)
                return;

            NomFichier = sfdEnregistrer.FileName;

            try
            {
                var lignes = new List<string>();

                for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    string texte = lbPersonne.Items[i].ToString();
                    int enc = LireDonneeCachee(i);

                    lignes.Add($"{texte}#{enc}");
                }

                File.WriteAllLines(NomFichier, lignes);

                MessageBox.Show("Données enregistrées.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            int idx = lbPersonne.SelectedIndex;
            if (idx < 0) return;

            string contenu = lbPersonne.SelectedItem.ToString();
            int encodage = LireDonneeCachee(idx);

            MessageBox.Show(
                $"Index : {idx}\nDonnées : {contenu}\nDonnée cachée (encodage) : {encodage}",
                "Détail",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            int idx = lbPersonne.SelectedIndex;
            if (idx < 0)
            {
                MessageBox.Show("Sélectionne une personne à modifier.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            indexModification = idx;

            
            string txt = lbPersonne.SelectedItem.ToString();

            
            int p1 = txt.LastIndexOf(" (");
            int p2 = txt.LastIndexOf(")");

            if (p1 > 0 && p2 > p1)
            {
                tbNom.Text = txt.Substring(0, p1).Trim();
                string q = txt.Substring(p1 + 2, p2 - (p1 + 2)).Trim();
                int iQ = cbQualite.FindStringExact(q);
                cbQualite.SelectedIndex = (iQ >= 0) ? iQ : 0;
            }
            else
            {
                tbNom.Text = txt;
                cbQualite.SelectedIndex = 0;
            }

            Activer(false);
            tbNom.Focus();
        }







    }

}
