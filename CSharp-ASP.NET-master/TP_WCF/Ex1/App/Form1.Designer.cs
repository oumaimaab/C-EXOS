namespace App
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.clickButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.personData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.decrire = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.filiereData = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereData)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(45, 83);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(146, 22);
            this.textBox.TabIndex = 0;
            // 
            // clickButton
            // 
            this.clickButton.Location = new System.Drawing.Point(76, 123);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(75, 29);
            this.clickButton.TabIndex = 1;
            this.clickButton.Text = "Click";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(28, 190);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 17);
            this.label.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.clickButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(25, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ex1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "nom : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.personData);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.decrire);
            this.groupBox2.Controls.Add(this.age);
            this.groupBox2.Controls.Add(this.prenom);
            this.groupBox2.Controls.Add(this.nom);
            this.groupBox2.Location = new System.Drawing.Point(293, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 248);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ex2";
            // 
            // personData
            // 
            this.personData.AutoSize = true;
            this.personData.Location = new System.Drawing.Point(19, 207);
            this.personData.Name = "personData";
            this.personData.Size = new System.Drawing.Size(0, 17);
            this.personData.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "nom : ";
            // 
            // decrire
            // 
            this.decrire.Location = new System.Drawing.Point(107, 148);
            this.decrire.Name = "decrire";
            this.decrire.Size = new System.Drawing.Size(75, 32);
            this.decrire.TabIndex = 1;
            this.decrire.Text = "Decrire";
            this.decrire.UseVisualStyleBackColor = true;
            this.decrire.Click += new System.EventHandler(this.decrire_Click);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(129, 96);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(138, 22);
            this.age.TabIndex = 0;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(129, 61);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(138, 22);
            this.prenom.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(129, 23);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(138, 22);
            this.nom.TabIndex = 0;
            // 
            // filiereData
            // 
            this.filiereData.AllowUserToAddRows = false;
            this.filiereData.AllowUserToDeleteRows = false;
            this.filiereData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filiereData.Location = new System.Drawing.Point(621, 61);
            this.filiereData.Name = "filiereData";
            this.filiereData.ReadOnly = true;
            this.filiereData.RowHeadersWidth = 51;
            this.filiereData.RowTemplate.Height = 24;
            this.filiereData.Size = new System.Drawing.Size(407, 222);
            this.filiereData.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Liste des Filieres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 326);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filiereData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decrire;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label personData;
        private System.Windows.Forms.DataGridView filiereData;
        private System.Windows.Forms.Label label5;
    }
}

