namespace Exo2TP2Bis
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Personnel = new System.Windows.Forms.TabPage();
            this.textBoxNbEmp = new System.Windows.Forms.TextBox();
            this.textBoxSalaire = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NombreEmploye = new System.Windows.Forms.Button();
            this.Salaire_Moyen = new System.Windows.Forms.Button();
            this.List_du_personnel_Button = new System.Windows.Forms.Button();
            this.Representant = new System.Windows.Forms.TabPage();
            this.Vendeur = new System.Windows.Forms.TabPage();
            this.Prodecteur = new System.Windows.Forms.TabPage();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Personnel.SuspendLayout();
            this.Prodecteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Personnel);
            this.tabControl1.Controls.Add(this.Representant);
            this.tabControl1.Controls.Add(this.Vendeur);
            this.tabControl1.Controls.Add(this.Prodecteur);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // Personnel
            // 
            this.Personnel.BackColor = System.Drawing.Color.Lavender;
            this.Personnel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Personnel.Controls.Add(this.textBoxNbEmp);
            this.Personnel.Controls.Add(this.textBoxSalaire);
            this.Personnel.Controls.Add(this.listBox1);
            this.Personnel.Controls.Add(this.NombreEmploye);
            this.Personnel.Controls.Add(this.Salaire_Moyen);
            this.Personnel.Controls.Add(this.List_du_personnel_Button);
            this.Personnel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Personnel.Location = new System.Drawing.Point(4, 29);
            this.Personnel.Name = "Personnel";
            this.Personnel.Padding = new System.Windows.Forms.Padding(3);
            this.Personnel.Size = new System.Drawing.Size(768, 393);
            this.Personnel.TabIndex = 0;
            this.Personnel.Text = "Personnel";
            // 
            // textBoxNbEmp
            // 
            this.textBoxNbEmp.Location = new System.Drawing.Point(534, 138);
            this.textBoxNbEmp.Name = "textBoxNbEmp";
            this.textBoxNbEmp.Size = new System.Drawing.Size(192, 26);
            this.textBoxNbEmp.TabIndex = 5;
            // 
            // textBoxSalaire
            // 
            this.textBoxSalaire.Location = new System.Drawing.Point(261, 139);
            this.textBoxSalaire.Name = "textBoxSalaire";
            this.textBoxSalaire.Size = new System.Drawing.Size(192, 26);
            this.textBoxSalaire.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(20, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 204);
            this.listBox1.TabIndex = 3;
            // 
            // NombreEmploye
            // 
            this.NombreEmploye.Location = new System.Drawing.Point(534, 20);
            this.NombreEmploye.Name = "NombreEmploye";
            this.NombreEmploye.Size = new System.Drawing.Size(192, 36);
            this.NombreEmploye.TabIndex = 2;
            this.NombreEmploye.Text = "Nombre des employe";
            this.NombreEmploye.UseVisualStyleBackColor = true;
            this.NombreEmploye.Click += new System.EventHandler(this.NombreEmploye_Click);
            // 
            // Salaire_Moyen
            // 
            this.Salaire_Moyen.Location = new System.Drawing.Point(261, 20);
            this.Salaire_Moyen.Name = "Salaire_Moyen";
            this.Salaire_Moyen.Size = new System.Drawing.Size(192, 36);
            this.Salaire_Moyen.TabIndex = 1;
            this.Salaire_Moyen.Text = "Salaire moyen";
            this.Salaire_Moyen.UseVisualStyleBackColor = true;
            this.Salaire_Moyen.Click += new System.EventHandler(this.Salaire_Moyen_Click);
            // 
            // List_du_personnel_Button
            // 
            this.List_du_personnel_Button.Location = new System.Drawing.Point(20, 20);
            this.List_du_personnel_Button.Name = "List_du_personnel_Button";
            this.List_du_personnel_Button.Size = new System.Drawing.Size(192, 36);
            this.List_du_personnel_Button.TabIndex = 0;
            this.List_du_personnel_Button.Text = "List du personnel";
            this.List_du_personnel_Button.UseVisualStyleBackColor = true;
            this.List_du_personnel_Button.Click += new System.EventHandler(this.List_du_personnel_Button_Click);
            // 
            // Representant
            // 
            this.Representant.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Representant.Location = new System.Drawing.Point(4, 29);
            this.Representant.Name = "Representant";
            this.Representant.Padding = new System.Windows.Forms.Padding(3);
            this.Representant.Size = new System.Drawing.Size(768, 393);
            this.Representant.TabIndex = 1;
            this.Representant.Text = "Representant";
            // 
            // Vendeur
            // 
            this.Vendeur.BackColor = System.Drawing.Color.PaleGreen;
            this.Vendeur.Location = new System.Drawing.Point(4, 29);
            this.Vendeur.Name = "Vendeur";
            this.Vendeur.Padding = new System.Windows.Forms.Padding(3);
            this.Vendeur.Size = new System.Drawing.Size(768, 393);
            this.Vendeur.TabIndex = 2;
            this.Vendeur.Text = "Vendeur";
            // 
            // Prodecteur
            // 
            this.Prodecteur.BackColor = System.Drawing.Color.MistyRose;
            this.Prodecteur.Controls.Add(this.textBoxUnit);
            this.Prodecteur.Controls.Add(this.unit);
            this.Prodecteur.Controls.Add(this.textBoxAge);
            this.Prodecteur.Controls.Add(this.age);
            this.Prodecteur.Controls.Add(this.textBoxPrenom);
            this.Prodecteur.Controls.Add(this.prenom);
            this.Prodecteur.Controls.Add(this.textBoxNom);
            this.Prodecteur.Controls.Add(this.Nom);
            this.Prodecteur.Location = new System.Drawing.Point(4, 29);
            this.Prodecteur.Name = "Prodecteur";
            this.Prodecteur.Padding = new System.Windows.Forms.Padding(3);
            this.Prodecteur.Size = new System.Drawing.Size(768, 393);
            this.Prodecteur.TabIndex = 3;
            this.Prodecteur.Text = "Prodecteur";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(152, 258);
            this.textBoxUnit.Multiline = true;
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(187, 26);
            this.textBoxUnit.TabIndex = 7;
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.Location = new System.Drawing.Point(60, 264);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(86, 20);
            this.unit.TabIndex = 6;
            this.unit.Text = "NB Unit : ";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(152, 185);
            this.textBoxAge.Multiline = true;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(187, 26);
            this.textBoxAge.TabIndex = 5;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(60, 185);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(56, 20);
            this.age.TabIndex = 4;
            this.age.Text = "Age : ";
            this.age.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(152, 113);
            this.textBoxPrenom.Multiline = true;
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(187, 26);
            this.textBoxPrenom.TabIndex = 3;
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(56, 116);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(85, 20);
            this.prenom.TabIndex = 2;
            this.prenom.Text = "Prénom : ";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(152, 48);
            this.textBoxNom.Multiline = true;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(187, 26);
            this.textBoxNom.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(56, 48);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(60, 20);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom : ";
            this.Nom.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Personnel.ResumeLayout(false);
            this.Personnel.PerformLayout();
            this.Prodecteur.ResumeLayout(false);
            this.Prodecteur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Personnel;
        private System.Windows.Forms.TabPage Representant;
        private System.Windows.Forms.TabPage Vendeur;
        private System.Windows.Forms.TabPage Prodecteur;
        private System.Windows.Forms.Button List_du_personnel_Button;
        private System.Windows.Forms.Button Salaire_Moyen;
        private System.Windows.Forms.Button NombreEmploye;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxNbEmp;
        private System.Windows.Forms.TextBox textBoxSalaire;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label unit;
    }
}

