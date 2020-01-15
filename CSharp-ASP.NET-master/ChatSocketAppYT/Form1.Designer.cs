namespace ChatSocketAppYT
{
    partial class Chat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ipServer = new System.Windows.Forms.TextBox();
            this.portServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.portClient = new System.Windows.Forms.TextBox();
            this.ipClient = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.chatTextArea = new System.Windows.Forms.RichTextBox();
            this.writeNewMessage = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.portServer);
            this.groupBox1.Controls.Add(this.ipServer);
            this.groupBox1.Location = new System.Drawing.Point(36, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // ipServer
            // 
            this.ipServer.Location = new System.Drawing.Point(55, 28);
            this.ipServer.Name = "ipServer";
            this.ipServer.Size = new System.Drawing.Size(246, 22);
            this.ipServer.TabIndex = 0;
            // 
            // portServer
            // 
            this.portServer.Location = new System.Drawing.Point(377, 28);
            this.portServer.Name = "portServer";
            this.portServer.Size = new System.Drawing.Size(228, 22);
            this.portServer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.connect);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.portClient);
            this.groupBox2.Controls.Add(this.ipClient);
            this.groupBox2.Location = new System.Drawing.Point(36, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 75);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "IP";
            // 
            // portClient
            // 
            this.portClient.Location = new System.Drawing.Point(377, 28);
            this.portClient.Name = "portClient";
            this.portClient.Size = new System.Drawing.Size(228, 22);
            this.portClient.TabIndex = 0;
            // 
            // ipClient
            // 
            this.ipClient.Location = new System.Drawing.Point(55, 28);
            this.ipClient.Name = "ipClient";
            this.ipClient.Size = new System.Drawing.Size(246, 22);
            this.ipClient.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(626, 23);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(85, 30);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(626, 26);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(85, 27);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            // 
            // chatTextArea
            // 
            this.chatTextArea.Location = new System.Drawing.Point(36, 220);
            this.chatTextArea.Name = "chatTextArea";
            this.chatTextArea.Size = new System.Drawing.Size(730, 219);
            this.chatTextArea.TabIndex = 1;
            this.chatTextArea.Text = "";
            // 
            // writeNewMessage
            // 
            this.writeNewMessage.Location = new System.Drawing.Point(36, 456);
            this.writeNewMessage.Name = "writeNewMessage";
            this.writeNewMessage.Size = new System.Drawing.Size(605, 47);
            this.writeNewMessage.TabIndex = 2;
            this.writeNewMessage.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(647, 456);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(118, 47);
            this.send.TabIndex = 3;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.send);
            this.Controls.Add(this.writeNewMessage);
            this.Controls.Add(this.chatTextArea);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chat";
            this.Text = "Chat App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipServer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox portClient;
        private System.Windows.Forms.TextBox ipClient;
        private System.Windows.Forms.RichTextBox chatTextArea;
        private System.Windows.Forms.RichTextBox writeNewMessage;
        private System.Windows.Forms.Button send;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

