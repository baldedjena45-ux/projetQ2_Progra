namespace projetQ2_Progra
{
    partial class EcranListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lFichier = new System.Windows.Forms.Label();
            this.lQualite = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.cbQualite = new System.Windows.Forms.ComboBox();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.lbPersonne = new System.Windows.Forms.ListBox();
            this.bOuvrir = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.ofdOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.bModifier = new System.Windows.Forms.Button();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lFichier
            // 
            this.lFichier.AutoSize = true;
            this.lFichier.Location = new System.Drawing.Point(45, 9);
            this.lFichier.Name = "lFichier";
            this.lFichier.Size = new System.Drawing.Size(110, 20);
            this.lFichier.TabIndex = 0;
            this.lFichier.Text = "Nom de fichier";
            // 
            // lQualite
            // 
            this.lQualite.AutoSize = true;
            this.lQualite.Location = new System.Drawing.Point(6, 31);
            this.lQualite.Name = "lQualite";
            this.lQualite.Size = new System.Drawing.Size(59, 20);
            this.lQualite.TabIndex = 1;
            this.lQualite.Text = "Qualité";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(6, 104);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(42, 20);
            this.lNom.TabIndex = 2;
            this.lNom.Text = "Nom";
            // 
            // gbDetail
            // 
            this.gbDetail.BackColor = System.Drawing.Color.Beige;
            this.gbDetail.Controls.Add(this.tbNom);
            this.gbDetail.Controls.Add(this.cbQualite);
            this.gbDetail.Controls.Add(this.bAnnuler);
            this.gbDetail.Controls.Add(this.bConfirmer);
            this.gbDetail.Controls.Add(this.lQualite);
            this.gbDetail.Controls.Add(this.lNom);
            this.gbDetail.Location = new System.Drawing.Point(255, 185);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(450, 225);
            this.gbDetail.TabIndex = 3;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Détail personne";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(10, 127);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(231, 26);
            this.tbNom.TabIndex = 12;
            // 
            // cbQualite
            // 
            this.cbQualite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQualite.FormattingEnabled = true;
            this.cbQualite.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur",
            "Mondamoiseau",
            "Indéfini"});
            this.cbQualite.Location = new System.Drawing.Point(10, 54);
            this.cbQualite.Name = "cbQualite";
            this.cbQualite.Size = new System.Drawing.Size(231, 28);
            this.cbQualite.TabIndex = 11;
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(255, 175);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(128, 35);
            this.bAnnuler.TabIndex = 10;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bConfirmer
            // 
            this.bConfirmer.Location = new System.Drawing.Point(37, 177);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(128, 33);
            this.bConfirmer.TabIndex = 9;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = true;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // lbPersonne
            // 
            this.lbPersonne.FormattingEnabled = true;
            this.lbPersonne.ItemHeight = 20;
            this.lbPersonne.Location = new System.Drawing.Point(49, 32);
            this.lbPersonne.Name = "lbPersonne";
            this.lbPersonne.Size = new System.Drawing.Size(656, 124);
            this.lbPersonne.Sorted = true;
            this.lbPersonne.TabIndex = 4;
            this.lbPersonne.DoubleClick += new System.EventHandler(this.lbPersonne_DoubleClick);
            // 
            // bOuvrir
            // 
            this.bOuvrir.Location = new System.Drawing.Point(40, 185);
            this.bOuvrir.Name = "bOuvrir";
            this.bOuvrir.Size = new System.Drawing.Size(128, 35);
            this.bOuvrir.TabIndex = 5;
            this.bOuvrir.Text = "Ouvrir";
            this.bOuvrir.UseVisualStyleBackColor = true;
            this.bOuvrir.Click += new System.EventHandler(this.bOuvrir_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(40, 235);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(128, 32);
            this.bEnregistrer.TabIndex = 6;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(40, 289);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(128, 33);
            this.bAjouter.TabIndex = 7;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(40, 343);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(128, 35);
            this.bSupprimer.TabIndex = 8;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // ofdOuvrir
            // 
            this.ofdOuvrir.FileName = "openFileDialog1";
            // 
            // bModifier
            // 
            this.bModifier.Location = new System.Drawing.Point(40, 393);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(128, 36);
            this.bModifier.TabIndex = 9;
            this.bModifier.Text = "Modifier";
            this.bModifier.UseVisualStyleBackColor = true;
            this.bModifier.Click += new System.EventHandler(this.bModifier_Click);
            // 
            // EcranListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bOuvrir);
            this.Controls.Add(this.lbPersonne);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.lFichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EcranListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manipulation d\'une liste";
            this.Load += new System.EventHandler(this.EcranListe_Load);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFichier;
        private System.Windows.Forms.Label lQualite;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ListBox lbPersonne;
        private System.Windows.Forms.Button bOuvrir;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.ComboBox cbQualite;
        private System.Windows.Forms.OpenFileDialog ofdOuvrir;
        private System.Windows.Forms.SaveFileDialog sfdEnregistrer;
        private System.Windows.Forms.Button bModifier;
    }
}