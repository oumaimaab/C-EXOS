namespace TP1_DB
{
    partial class ShowStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.listCNE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentFirstName = new System.Windows.Forms.TextBox();
            this.StudentLastName = new System.Windows.Forms.TextBox();
            this.StudentFiliere = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNE Recherché";
            // 
            // listCNE
            // 
            this.listCNE.FormattingEnabled = true;
            this.listCNE.Location = new System.Drawing.Point(429, 57);
            this.listCNE.Name = "listCNE";
            this.listCNE.Size = new System.Drawing.Size(218, 24);
            this.listCNE.TabIndex = 1;
            this.listCNE.SelectedIndexChanged += new System.EventHandler(this.listCNE_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prénom : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filière : ";
            // 
            // StudentFirstName
            // 
            this.StudentFirstName.Location = new System.Drawing.Point(197, 53);
            this.StudentFirstName.Name = "StudentFirstName";
            this.StudentFirstName.Size = new System.Drawing.Size(249, 22);
            this.StudentFirstName.TabIndex = 2;
            // 
            // StudentLastName
            // 
            this.StudentLastName.Location = new System.Drawing.Point(197, 103);
            this.StudentLastName.Name = "StudentLastName";
            this.StudentLastName.Size = new System.Drawing.Size(249, 22);
            this.StudentLastName.TabIndex = 2;
            // 
            // StudentFiliere
            // 
            this.StudentFiliere.Location = new System.Drawing.Point(197, 152);
            this.StudentFiliere.Name = "StudentFiliere";
            this.StudentFiliere.Size = new System.Drawing.Size(249, 22);
            this.StudentFiliere.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentFiliere);
            this.groupBox1.Controls.Add(this.StudentLastName);
            this.groupBox1.Controls.Add(this.StudentFirstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(112, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultat";
            // 
            // ShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listCNE);
            this.Controls.Add(this.label1);
            this.Name = "ShowStudent";
            this.Text = "showStudent";
            this.Load += new System.EventHandler(this.showStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listCNE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StudentFirstName;
        private System.Windows.Forms.TextBox StudentLastName;
        private System.Windows.Forms.TextBox StudentFiliere;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}