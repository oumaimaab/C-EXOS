namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.nbr = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nbEssai = new System.Windows.Forms.TextBox();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deviner le nombre";
            // 
            // nbr
            // 
            this.nbr.Location = new System.Drawing.Point(194, 39);
            this.nbr.Name = "nbr";
            this.nbr.Size = new System.Drawing.Size(117, 22);
            this.nbr.TabIndex = 1;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(373, 33);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 34);
            this.goBtn.TabIndex = 2;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(194, 100);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(117, 22);
            this.res.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre de votre tentatives";
            // 
            // nbEssai
            // 
            this.nbEssai.Location = new System.Drawing.Point(240, 173);
            this.nbEssai.Name = "nbEssai";
            this.nbEssai.Size = new System.Drawing.Size(71, 22);
            this.nbEssai.TabIndex = 1;
            // 
            // scoreBtn
            // 
            this.scoreBtn.Location = new System.Drawing.Point(222, 273);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(89, 35);
            this.scoreBtn.TabIndex = 3;
            this.scoreBtn.Text = "Score";
            this.scoreBtn.UseVisualStyleBackColor = true;
            this.scoreBtn.Click += new System.EventHandler(this.scoreBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scoreLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nbr);
            this.groupBox1.Controls.Add(this.res);
            this.groupBox1.Controls.Add(this.nbEssai);
            this.groupBox1.Controls.Add(this.goBtn);
            this.groupBox1.Controls.Add(this.scoreBtn);
            this.groupBox1.Location = new System.Drawing.Point(134, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 338);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guess Number";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(317, 282);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 17);
            this.scoreLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nbr;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nbEssai;
        private System.Windows.Forms.Button scoreBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label scoreLabel;
    }
}

