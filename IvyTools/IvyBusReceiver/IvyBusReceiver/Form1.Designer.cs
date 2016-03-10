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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.lbxData = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cbxChooseData = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(23, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.Location = new System.Drawing.Point(23, 38);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(134, 20);
            this.tbxAdresse.TabIndex = 1;
            this.tbxAdresse.Text = "127.0.0.1";
            // 
            // lbxData
            // 
            this.lbxData.FormattingEnabled = true;
            this.lbxData.Location = new System.Drawing.Point(23, 77);
            this.lbxData.Name = "lbxData";
            this.lbxData.Size = new System.Drawing.Size(531, 212);
            this.lbxData.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(454, 305);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cbxChooseData
            // 
            this.cbxChooseData.FormattingEnabled = true;
            this.cbxChooseData.Items.AddRange(new object[] {
            "Position changed",
            "Orientation changed",
            "Position X only",
            "Position Y only",
            "Sending engine",
            "Received Bluetooth"});
            this.cbxChooseData.Location = new System.Drawing.Point(433, 37);
            this.cbxChooseData.Name = "cbxChooseData";
            this.cbxChooseData.Size = new System.Drawing.Size(121, 21);
            this.cbxChooseData.TabIndex = 4;
            this.cbxChooseData.SelectedIndexChanged += new System.EventHandler(this.cbxChooseData_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "choice of the value to be recovered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Connection address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxChooseData);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbxData);
            this.Controls.Add(this.tbxAdresse);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IvyTool Spy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.ListBox lbxData;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cbxChooseData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

