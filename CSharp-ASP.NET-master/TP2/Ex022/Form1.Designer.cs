namespace Ex022
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
            this.menu = new System.Windows.Forms.TabControl();
            this.personnel = new System.Windows.Forms.TabPage();
            this.representant = new System.Windows.Forms.TabPage();
            this.vendeur = new System.Windows.Forms.TabPage();
            this.producteur = new System.Windows.Forms.TabPage();
            this.ListPersonnel = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.nb_unit = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.personnel.SuspendLayout();
            this.producteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.personnel);
            this.menu.Controls.Add(this.representant);
            this.menu.Controls.Add(this.vendeur);
            this.menu.Controls.Add(this.producteur);
            this.menu.Location = new System.Drawing.Point(-2, -1);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(804, 452);
            this.menu.TabIndex = 0;
            // 
            // personnel
            // 
            this.personnel.Controls.Add(this.textBox2);
            this.personnel.Controls.Add(this.button3);
            this.personnel.Controls.Add(this.textBox1);
            this.personnel.Controls.Add(this.button2);
            this.personnel.Controls.Add(this.button1);
            this.personnel.Controls.Add(this.ListPersonnel);
            this.personnel.Location = new System.Drawing.Point(4, 25);
            this.personnel.Name = "personnel";
            this.personnel.Padding = new System.Windows.Forms.Padding(3);
            this.personnel.Size = new System.Drawing.Size(796, 423);
            this.personnel.TabIndex = 0;
            this.personnel.Text = "Personnel";
            this.personnel.UseVisualStyleBackColor = true;
            // 
            // representant
            // 
            this.representant.Location = new System.Drawing.Point(4, 25);
            this.representant.Name = "representant";
            this.representant.Padding = new System.Windows.Forms.Padding(3);
            this.representant.Size = new System.Drawing.Size(796, 423);
            this.representant.TabIndex = 1;
            this.representant.Text = "Représentant";
            this.representant.UseVisualStyleBackColor = true;
            // 
            // vendeur
            // 
            this.vendeur.Location = new System.Drawing.Point(4, 25);
            this.vendeur.Name = "vendeur";
            this.vendeur.Size = new System.Drawing.Size(796, 423);
            this.vendeur.TabIndex = 2;
            this.vendeur.Text = "Vendeur";
            this.vendeur.UseVisualStyleBackColor = true;
            // 
            // producteur
            // 
            this.producteur.Controls.Add(this.ajouter);
            this.producteur.Controls.Add(this.textBox6);
            this.producteur.Controls.Add(this.textBox5);
            this.producteur.Controls.Add(this.textBox4);
            this.producteur.Controls.Add(this.textBox3);
            this.producteur.Controls.Add(this.nb_unit);
            this.producteur.Controls.Add(this.age);
            this.producteur.Controls.Add(this.prenom);
            this.producteur.Controls.Add(this.nom);
            this.producteur.Location = new System.Drawing.Point(4, 25);
            this.producteur.Name = "producteur";
            this.producteur.Size = new System.Drawing.Size(796, 423);
            this.producteur.TabIndex = 3;
            this.producteur.Text = "Producteur";
            this.producteur.UseVisualStyleBackColor = true;
            // 
            // ListPersonnel
            // 
            this.ListPersonnel.FormattingEnabled = true;
            this.ListPersonnel.ItemHeight = 16;
            this.ListPersonnel.Location = new System.Drawing.Point(26, 143);
            this.ListPersonnel.Name = "ListPersonnel";
            this.ListPersonnel.Size = new System.Drawing.Size(229, 100);
            this.ListPersonnel.TabIndex = 0;
            this.ListPersonnel.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "List Personnel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salaire Moyen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Nombe d\'employés";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(544, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 22);
            this.textBox2.TabIndex = 5;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(259, 85);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(55, 17);
            this.nom.TabIndex = 0;
            this.nom.Text = "Nom : ";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(259, 132);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(78, 17);
            this.prenom.TabIndex = 1;
            this.prenom.Text = "Prenom : ";
            this.prenom.Click += new System.EventHandler(this.Label1_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(259, 179);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(51, 17);
            this.age.TabIndex = 2;
            this.age.Text = "Age : ";
            // 
            // nb_unit
            // 
            this.nb_unit.AutoSize = true;
            this.nb_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_unit.Location = new System.Drawing.Point(259, 226);
            this.nb_unit.Name = "nb_unit";
            this.nb_unit.Size = new System.Drawing.Size(77, 17);
            this.nb_unit.TabIndex = 3;
            this.nb_unit.Text = "Nb Unit : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(359, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(359, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(359, 176);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(359, 223);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 22);
            this.textBox6.TabIndex = 7;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(262, 279);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(262, 30);
            this.ajouter.TabIndex = 8;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.personnel.ResumeLayout(false);
            this.personnel.PerformLayout();
            this.producteur.ResumeLayout(false);
            this.producteur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage personnel;
        private System.Windows.Forms.TabPage representant;
        private System.Windows.Forms.ListBox ListPersonnel;
        private System.Windows.Forms.TabPage vendeur;
        private System.Windows.Forms.TabPage producteur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nb_unit;
        private System.Windows.Forms.Label age;
    }
}

