namespace projetQ2_Progra
{
    partial class EcranDemarrage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPermuter = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuControles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgression = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditeur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPermuter
            // 
            this.btnPermuter.BackColor = System.Drawing.SystemColors.Info;
            this.btnPermuter.Location = new System.Drawing.Point(164, 200);
            this.btnPermuter.Name = "btnPermuter";
            this.btnPermuter.Size = new System.Drawing.Size(92, 68);
            this.btnPermuter.TabIndex = 0;
            this.btnPermuter.Text = "Permuter";
            this.btnPermuter.UseVisualStyleBackColor = false;
            this.btnPermuter.Click += new System.EventHandler(this.btnPermuter_Click);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOuvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuvrir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnOuvrir.Location = new System.Drawing.Point(342, 200);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(111, 68);
            this.btnOuvrir.TabIndex = 3;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = false;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuControles,
            this.mnuApplications,
            this.mnuAide});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuControles
            // 
            this.mnuControles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListe,
            this.mnuProgression,
            this.toolStripMenuItem1,
            this.mnuQuitter});
            this.mnuControles.Name = "mnuControles";
            this.mnuControles.Size = new System.Drawing.Size(104, 29);
            this.mnuControles.Text = "Contrôles";
            // 
            // mnuListe
            // 
            this.mnuListe.Name = "mnuListe";
            this.mnuListe.Size = new System.Drawing.Size(279, 34);
            this.mnuListe.Text = "Liste";
            this.mnuListe.Click += new System.EventHandler(this.mnuListe_Click);
            // 
            // mnuProgression
            // 
            this.mnuProgression.Name = "mnuProgression";
            this.mnuProgression.Size = new System.Drawing.Size(279, 34);
            this.mnuProgression.Text = "Barre de progression";
            this.mnuProgression.Click += new System.EventHandler(this.mnuProgression_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(276, 6);
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.Size = new System.Drawing.Size(279, 34);
            this.mnuQuitter.Text = "Quitter";
            this.mnuQuitter.Click += new System.EventHandler(this.mnuQuitter_Click);
            // 
            // mnuApplications
            // 
            this.mnuApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditeur});
            this.mnuApplications.Name = "mnuApplications";
            this.mnuApplications.Size = new System.Drawing.Size(126, 29);
            this.mnuApplications.Text = "Applications";
            // 
            // mnuEditeur
            // 
            this.mnuEditeur.Name = "mnuEditeur";
            this.mnuEditeur.Size = new System.Drawing.Size(169, 34);
            this.mnuEditeur.Text = "Editeur";
            this.mnuEditeur.Click += new System.EventHandler(this.FonctionNonImplantee);
            // 
            // mnuAide
            // 
            this.mnuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAPropos});
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(64, 29);
            this.mnuAide.Text = "Aide";
            // 
            // mnuAPropos
            // 
            this.mnuAPropos.Name = "mnuAPropos";
            this.mnuAPropos.Size = new System.Drawing.Size(188, 34);
            this.mnuAPropos.Text = "A Propos";
            this.mnuAPropos.Click += new System.EventHandler(this.mnuAPropos_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projetQ2_Progra.Properties.Resources.snoop;
            this.pictureBox2.Location = new System.Drawing.Point(323, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetQ2_Progra.Properties.Resources.freeky;
            this.pictureBox1.Location = new System.Drawing.Point(136, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // EcranDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPermuter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EcranDemarrage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EcranDemarrage_Load);
            this.Click += new System.EventHandler(this.btnPermuter_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPermuter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuControles;
        private System.Windows.Forms.ToolStripMenuItem mnuApplications;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.ToolStripMenuItem mnuListe;
        private System.Windows.Forms.ToolStripMenuItem mnuProgression;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuEditeur;
        private System.Windows.Forms.ToolStripMenuItem mnuAPropos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

