namespace projetQ2_Progra
{
    partial class EcranProgression
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
            this.lPrincipal = new System.Windows.Forms.Label();
            this.lSecondaire = new System.Windows.Forms.Label();
            this.pbPrincipal = new System.Windows.Forms.ProgressBar();
            this.pbSecondaire = new System.Windows.Forms.ProgressBar();
            this.bExecuter = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPrincipal
            // 
            this.lPrincipal.AutoSize = true;
            this.lPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrincipal.Location = new System.Drawing.Point(184, 47);
            this.lPrincipal.Name = "lPrincipal";
            this.lPrincipal.Size = new System.Drawing.Size(169, 29);
            this.lPrincipal.TabIndex = 0;
            this.lPrincipal.Text = "Index principal";
            // 
            // lSecondaire
            // 
            this.lSecondaire.AutoSize = true;
            this.lSecondaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSecondaire.Location = new System.Drawing.Point(187, 170);
            this.lSecondaire.Name = "lSecondaire";
            this.lSecondaire.Size = new System.Drawing.Size(197, 29);
            this.lSecondaire.TabIndex = 1;
            this.lSecondaire.Text = "Index secondaire";
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.Location = new System.Drawing.Point(188, 85);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(339, 62);
            this.pbPrincipal.TabIndex = 2;
            // 
            // pbSecondaire
            // 
            this.pbSecondaire.Location = new System.Drawing.Point(188, 206);
            this.pbSecondaire.Name = "pbSecondaire";
            this.pbSecondaire.Size = new System.Drawing.Size(339, 59);
            this.pbSecondaire.TabIndex = 3;
            // 
            // bExecuter
            // 
            this.bExecuter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExecuter.Location = new System.Drawing.Point(198, 322);
            this.bExecuter.Name = "bExecuter";
            this.bExecuter.Size = new System.Drawing.Size(96, 43);
            this.bExecuter.TabIndex = 4;
            this.bExecuter.Text = "Exécuter";
            this.bExecuter.UseVisualStyleBackColor = true;
            this.bExecuter.Click += new System.EventHandler(this.bExecuter_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitter.Location = new System.Drawing.Point(381, 322);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(101, 43);
            this.bQuitter.TabIndex = 5;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // EcranProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bExecuter);
            this.Controls.Add(this.pbSecondaire);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.lSecondaire);
            this.Controls.Add(this.lPrincipal);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "EcranProgression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Barres de progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPrincipal;
        private System.Windows.Forms.Label lSecondaire;
        private System.Windows.Forms.ProgressBar pbPrincipal;
        private System.Windows.Forms.ProgressBar pbSecondaire;
        private System.Windows.Forms.Button bExecuter;
        private System.Windows.Forms.Button bQuitter;
    }
}