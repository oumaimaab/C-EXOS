namespace TP2
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
            this.menu = new System.Windows.Forms.TabControl();
            this.personnel = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ListPersonnel = new System.Windows.Forms.ListBox();
            this.representant = new System.Windows.Forms.TabPage();
            this.vendeur = new System.Windows.Forms.TabPage();
            this.producteur = new System.Windows.Forms.TabPage();
            this.ajouterProducteur = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nb_unit = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.ajouterVendeur = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ajouterRep = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.personnel.SuspendLayout();
            this.representant.SuspendLayout();
            this.vendeur.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(1171, 528);
            this.menu.TabIndex = 1;
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
            this.personnel.Size = new System.Drawing.Size(1163, 499);
            this.personnel.TabIndex = 0;
            this.personnel.Text = "Personnel";
            this.personnel.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(889, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 22);
            this.textBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(889, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Nombe d\'employés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(625, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salaire Moyen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(534, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "List Personnel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ListPersonnel
            // 
            this.ListPersonnel.FormattingEnabled = true;
            this.ListPersonnel.ItemHeight = 16;
            this.ListPersonnel.Location = new System.Drawing.Point(26, 143);
            this.ListPersonnel.Name = "ListPersonnel";
            this.ListPersonnel.Size = new System.Drawing.Size(534, 100);
            this.ListPersonnel.TabIndex = 0;
            // 
            // representant
            // 
            this.representant.Controls.Add(this.ajouterRep);
            this.representant.Controls.Add(this.textBox11);
            this.representant.Controls.Add(this.textBox12);
            this.representant.Controls.Add(this.textBox13);
            this.representant.Controls.Add(this.textBox14);
            this.representant.Controls.Add(this.label5);
            this.representant.Controls.Add(this.label6);
            this.representant.Controls.Add(this.label7);
            this.representant.Controls.Add(this.label8);
            this.representant.Location = new System.Drawing.Point(4, 25);
            this.representant.Name = "representant";
            this.representant.Padding = new System.Windows.Forms.Padding(3);
            this.representant.Size = new System.Drawing.Size(1163, 499);
            this.representant.TabIndex = 1;
            this.representant.Text = "Représentant";
            this.representant.UseVisualStyleBackColor = true;
            // 
            // vendeur
            // 
            this.vendeur.Controls.Add(this.ajouterVendeur);
            this.vendeur.Controls.Add(this.textBox7);
            this.vendeur.Controls.Add(this.textBox8);
            this.vendeur.Controls.Add(this.textBox9);
            this.vendeur.Controls.Add(this.textBox10);
            this.vendeur.Controls.Add(this.label1);
            this.vendeur.Controls.Add(this.label2);
            this.vendeur.Controls.Add(this.label3);
            this.vendeur.Controls.Add(this.label4);
            this.vendeur.Location = new System.Drawing.Point(4, 25);
            this.vendeur.Name = "vendeur";
            this.vendeur.Size = new System.Drawing.Size(1163, 499);
            this.vendeur.TabIndex = 2;
            this.vendeur.Text = "Vendeur";
            this.vendeur.UseVisualStyleBackColor = true;
            // 
            // producteur
            // 
            this.producteur.Controls.Add(this.ajouterProducteur);
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
            this.producteur.Size = new System.Drawing.Size(1163, 499);
            this.producteur.TabIndex = 3;
            this.producteur.Text = "Producteur";
            this.producteur.UseVisualStyleBackColor = true;
            this.producteur.Click += new System.EventHandler(this.Producteur_Click);
            // 
            // ajouterProducteur
            // 
            this.ajouterProducteur.Location = new System.Drawing.Point(452, 333);
            this.ajouterProducteur.Name = "ajouterProducteur";
            this.ajouterProducteur.Size = new System.Drawing.Size(262, 30);
            this.ajouterProducteur.TabIndex = 8;
            this.ajouterProducteur.Text = "Ajouter";
            this.ajouterProducteur.UseVisualStyleBackColor = true;
            this.ajouterProducteur.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(549, 277);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 22);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(549, 230);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(549, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(549, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 22);
            this.textBox3.TabIndex = 4;
            // 
            // nb_unit
            // 
            this.nb_unit.AutoSize = true;
            this.nb_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_unit.Location = new System.Drawing.Point(449, 280);
            this.nb_unit.Name = "nb_unit";
            this.nb_unit.Size = new System.Drawing.Size(77, 17);
            this.nb_unit.TabIndex = 3;
            this.nb_unit.Text = "Nb Unit : ";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(449, 233);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(51, 17);
            this.age.TabIndex = 2;
            this.age.Text = "Age : ";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(449, 186);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(78, 17);
            this.prenom.TabIndex = 1;
            this.prenom.Text = "Prenom : ";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(449, 139);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(55, 17);
            this.nom.TabIndex = 0;
            this.nom.Text = "Nom : ";
            // 
            // ajouterVendeur
            // 
            this.ajouterVendeur.Location = new System.Drawing.Point(452, 333);
            this.ajouterVendeur.Name = "ajouterVendeur";
            this.ajouterVendeur.Size = new System.Drawing.Size(262, 30);
            this.ajouterVendeur.TabIndex = 17;
            this.ajouterVendeur.Text = "Ajouter";
            this.ajouterVendeur.UseVisualStyleBackColor = true;
            this.ajouterVendeur.Click += new System.EventHandler(this.AjouterVendeur_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(549, 277);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 22);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(549, 230);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(165, 22);
            this.textBox8.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(549, 183);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(165, 22);
            this.textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(549, 136);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(165, 22);
            this.textBox10.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chiffre Affaire  : ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prenom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom : ";
            // 
            // ajouterRep
            // 
            this.ajouterRep.Location = new System.Drawing.Point(452, 333);
            this.ajouterRep.Name = "ajouterRep";
            this.ajouterRep.Size = new System.Drawing.Size(262, 30);
            this.ajouterRep.TabIndex = 17;
            this.ajouterRep.Text = "Ajouter";
            this.ajouterRep.UseVisualStyleBackColor = true;
            this.ajouterRep.Click += new System.EventHandler(this.AjouterRep_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(549, 277);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(165, 22);
            this.textBox11.TabIndex = 16;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(549, 230);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(165, 22);
            this.textBox12.TabIndex = 15;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(549, 183);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(165, 22);
            this.textBox13.TabIndex = 14;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(549, 136);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(165, 22);
            this.textBox14.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nb Unit : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Age : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Prenom : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nom : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 524);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.personnel.ResumeLayout(false);
            this.personnel.PerformLayout();
            this.representant.ResumeLayout(false);
            this.representant.PerformLayout();
            this.vendeur.ResumeLayout(false);
            this.vendeur.PerformLayout();
            this.producteur.ResumeLayout(false);
            this.producteur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage personnel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListPersonnel;
        private System.Windows.Forms.TabPage representant;
        private System.Windows.Forms.TabPage vendeur;
        private System.Windows.Forms.TabPage producteur;
        private System.Windows.Forms.Button ajouterProducteur;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nb_unit;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Button ajouterVendeur;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ajouterRep;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}