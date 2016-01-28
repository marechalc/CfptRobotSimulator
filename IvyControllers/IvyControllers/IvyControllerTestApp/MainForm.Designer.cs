namespace IvyControllerTestApp
{
    partial class MainForm
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
            this.gbSend = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSendOrientation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrientationName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSendPos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numPosY = new System.Windows.Forms.NumericUpDown();
            this.numPosX = new System.Windows.Forms.NumericUpDown();
            this.gbReceived = new System.Windows.Forms.GroupBox();
            this.lbxReceived = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.gbSend.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
            this.gbReceived.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSend
            // 
            this.gbSend.Controls.Add(this.groupBox4);
            this.gbSend.Controls.Add(this.groupBox3);
            this.gbSend.Enabled = false;
            this.gbSend.Location = new System.Drawing.Point(12, 37);
            this.gbSend.Name = "gbSend";
            this.gbSend.Size = new System.Drawing.Size(260, 272);
            this.gbSend.TabIndex = 0;
            this.gbSend.TabStop = false;
            this.gbSend.Text = "Send";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSendOrientation);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtOrientationName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.numAngle);
            this.groupBox4.Location = new System.Drawing.Point(7, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 108);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Orientation";
            // 
            // btnSendOrientation
            // 
            this.btnSendOrientation.Location = new System.Drawing.Point(10, 72);
            this.btnSendOrientation.Name = "btnSendOrientation";
            this.btnSendOrientation.Size = new System.Drawing.Size(231, 23);
            this.btnSendOrientation.TabIndex = 6;
            this.btnSendOrientation.Text = "Send";
            this.btnSendOrientation.UseVisualStyleBackColor = true;
            this.btnSendOrientation.Click += new System.EventHandler(this.btnSendOrientation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // txtOrientationName
            // 
            this.txtOrientationName.Location = new System.Drawing.Point(48, 46);
            this.txtOrientationName.Name = "txtOrientationName";
            this.txtOrientationName.Size = new System.Drawing.Size(193, 20);
            this.txtOrientationName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Angle";
            // 
            // numAngle
            // 
            this.numAngle.Location = new System.Drawing.Point(48, 20);
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(193, 20);
            this.numAngle.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSendPos);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtPosName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numPosY);
            this.groupBox3.Controls.Add(this.numPosX);
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 132);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position";
            // 
            // btnSendPos
            // 
            this.btnSendPos.Location = new System.Drawing.Point(10, 97);
            this.btnSendPos.Name = "btnSendPos";
            this.btnSendPos.Size = new System.Drawing.Size(231, 23);
            this.btnSendPos.TabIndex = 6;
            this.btnSendPos.Text = "Send";
            this.btnSendPos.UseVisualStyleBackColor = true;
            this.btnSendPos.Click += new System.EventHandler(this.btnSendPos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txtPosName
            // 
            this.txtPosName.Location = new System.Drawing.Point(48, 71);
            this.txtPosName.Name = "txtPosName";
            this.txtPosName.Size = new System.Drawing.Size(193, 20);
            this.txtPosName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // numPosY
            // 
            this.numPosY.Location = new System.Drawing.Point(48, 45);
            this.numPosY.Name = "numPosY";
            this.numPosY.Size = new System.Drawing.Size(193, 20);
            this.numPosY.TabIndex = 1;
            // 
            // numPosX
            // 
            this.numPosX.Location = new System.Drawing.Point(48, 20);
            this.numPosX.Name = "numPosX";
            this.numPosX.Size = new System.Drawing.Size(193, 20);
            this.numPosX.TabIndex = 0;
            // 
            // gbReceived
            // 
            this.gbReceived.Controls.Add(this.lbxReceived);
            this.gbReceived.Enabled = false;
            this.gbReceived.Location = new System.Drawing.Point(279, 37);
            this.gbReceived.Name = "gbReceived";
            this.gbReceived.Size = new System.Drawing.Size(271, 272);
            this.gbReceived.TabIndex = 1;
            this.gbReceived.TabStop = false;
            this.gbReceived.Text = "Received";
            // 
            // lbxReceived
            // 
            this.lbxReceived.FormattingEnabled = true;
            this.lbxReceived.Location = new System.Drawing.Point(6, 20);
            this.lbxReceived.Name = "lbxReceived";
            this.lbxReceived.Size = new System.Drawing.Size(257, 238);
            this.lbxReceived.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(475, 7);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Broadcast address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(114, 9);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(217, 20);
            this.tbxAddress.TabIndex = 4;
            this.tbxAddress.Text = "255.255.255.255";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Port";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(369, 9);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 20);
            this.tbxPort.TabIndex = 6;
            this.tbxPort.Text = "2010";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 321);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbReceived);
            this.Controls.Add(this.gbSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ivy Controller test app";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.gbSend.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
            this.gbReceived.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSend;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSendOrientation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrientationName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSendPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPosY;
        private System.Windows.Forms.NumericUpDown numPosX;
        private System.Windows.Forms.GroupBox gbReceived;
        private System.Windows.Forms.ListBox lbxReceived;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPort;
    }
}

