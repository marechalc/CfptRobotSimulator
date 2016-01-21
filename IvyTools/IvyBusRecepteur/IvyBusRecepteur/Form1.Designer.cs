namespace IvyTools
{
    partial class Form1
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
            this.btnConenxion = new System.Windows.Forms.Button();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.lbxDonnees = new System.Windows.Forms.ListBox();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.cbxChoixRegle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConenxion
            // 
            this.btnConenxion.Location = new System.Drawing.Point(82, 43);
            this.btnConenxion.Name = "btnConenxion";
            this.btnConenxion.Size = new System.Drawing.Size(75, 23);
            this.btnConenxion.TabIndex = 0;
            this.btnConenxion.Text = "Connexion";
            this.btnConenxion.UseVisualStyleBackColor = true;
            this.btnConenxion.Click += new System.EventHandler(this.btnConenxion_Click);
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.Location = new System.Drawing.Point(23, 12);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(201, 20);
            this.tbxAdresse.TabIndex = 1;
            this.tbxAdresse.Text = "127.0.0.1";
            // 
            // lbxDonnees
            // 
            this.lbxDonnees.FormattingEnabled = true;
            this.lbxDonnees.Location = new System.Drawing.Point(23, 77);
            this.lbxDonnees.Name = "lbxDonnees";
            this.lbxDonnees.Size = new System.Drawing.Size(354, 212);
            this.lbxDonnees.TabIndex = 2;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(23, 307);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(201, 23);
            this.btnDeconnexion.TabIndex = 3;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // cbxChoixRegle
            // 
            this.cbxChoixRegle.FormattingEnabled = true;
            this.cbxChoixRegle.Items.AddRange(new object[] {
            "PositionChanged",
            "Valeur X",
            "Valeur Y",
            "Valeur X et valeur Y"});
            this.cbxChoixRegle.Location = new System.Drawing.Point(256, 41);
            this.cbxChoixRegle.Name = "cbxChoixRegle";
            this.cbxChoixRegle.Size = new System.Drawing.Size(121, 21);
            this.cbxChoixRegle.TabIndex = 4;
            this.cbxChoixRegle.SelectedIndexChanged += new System.EventHandler(this.cbxChoixRegle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choix de la valeur à récupéer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxChoixRegle);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.lbxDonnees);
            this.Controls.Add(this.tbxAdresse);
            this.Controls.Add(this.btnConenxion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConenxion;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.ListBox lbxDonnees;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.ComboBox cbxChoixRegle;
        private System.Windows.Forms.Label label1;
    }
}

