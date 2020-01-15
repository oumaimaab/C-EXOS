namespace TP1_DB
{
    partial class CompteBanque
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nClient2 = new System.Windows.Forms.TextBox();
            this.nClient1 = new System.Windows.Forms.TextBox();
            this.afficherSolde = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.montantDeposer = new System.Windows.Forms.TextBox();
            this.MakeVirement = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sClient1 = new System.Windows.Forms.TextBox();
            this.sClient2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nClient2);
            this.groupBox1.Controls.Add(this.nClient1);
            this.groupBox1.Controls.Add(this.afficherSolde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisir les clients";
            // 
            // nClient2
            // 
            this.nClient2.Location = new System.Drawing.Point(198, 89);
            this.nClient2.Name = "nClient2";
            this.nClient2.Size = new System.Drawing.Size(244, 22);
            this.nClient2.TabIndex = 3;
            // 
            // nClient1
            // 
            this.nClient1.Location = new System.Drawing.Point(198, 45);
            this.nClient1.Name = "nClient1";
            this.nClient1.Size = new System.Drawing.Size(244, 22);
            this.nClient1.TabIndex = 3;
            // 
            // afficherSolde
            // 
            this.afficherSolde.Location = new System.Drawing.Point(144, 142);
            this.afficherSolde.Name = "afficherSolde";
            this.afficherSolde.Size = new System.Drawing.Size(162, 23);
            this.afficherSolde.TabIndex = 2;
            this.afficherSolde.Text = "Afficher les Soldes";
            this.afficherSolde.UseVisualStyleBackColor = true;
            this.afficherSolde.Click += new System.EventHandler(this.afficherSolde_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "N de compte Client 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "N de compte Client 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(513, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 183);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afficher les soldes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Solde Client 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Solde Client 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.montantDeposer);
            this.groupBox3.Controls.Add(this.MakeVirement);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(21, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 102);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Virement Client 1 Vers Client 2";
            // 
            // montantDeposer
            // 
            this.montantDeposer.Location = new System.Drawing.Point(466, 44);
            this.montantDeposer.Name = "montantDeposer";
            this.montantDeposer.Size = new System.Drawing.Size(151, 22);
            this.montantDeposer.TabIndex = 3;
            // 
            // MakeVirement
            // 
            this.MakeVirement.Location = new System.Drawing.Point(623, 44);
            this.MakeVirement.Name = "MakeVirement";
            this.MakeVirement.Size = new System.Drawing.Size(75, 23);
            this.MakeVirement.TabIndex = 2;
            this.MakeVirement.Text = "Deposer";
            this.MakeVirement.UseVisualStyleBackColor = true;
            this.MakeVirement.Click += new System.EventHandler(this.makeVirement_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Montant";
            // 
            // sClient1
            // 
            this.sClient1.Location = new System.Drawing.Point(633, 98);
            this.sClient1.Name = "sClient1";
            this.sClient1.Size = new System.Drawing.Size(119, 22);
            this.sClient1.TabIndex = 3;
            // 
            // sClient2
            // 
            this.sClient2.Location = new System.Drawing.Point(633, 142);
            this.sClient2.Name = "sClient2";
            this.sClient2.Size = new System.Drawing.Size(119, 22);
            this.sClient2.TabIndex = 3;
            // 
            // CompteBanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.sClient1);
            this.Controls.Add(this.sClient2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompteBanque";
            this.Text = "Compte Banque";
            this.Load += new System.EventHandler(this.CompteBanque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nClient2;
        private System.Windows.Forms.TextBox nClient1;
        private System.Windows.Forms.Button afficherSolde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox montantDeposer;
        private System.Windows.Forms.Button MakeVirement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sClient1;
        private System.Windows.Forms.TextBox sClient2;
    }
}