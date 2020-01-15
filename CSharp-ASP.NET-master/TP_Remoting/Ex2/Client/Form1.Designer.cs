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
            this.inputAdd1 = new System.Windows.Forms.TextBox();
            this.inputAdd2 = new System.Windows.Forms.TextBox();
            this.inputAddRes = new System.Windows.Forms.TextBox();
            this.equalAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputMult1 = new System.Windows.Forms.TextBox();
            this.inputMult2 = new System.Windows.Forms.TextBox();
            this.inputMultRes = new System.Windows.Forms.TextBox();
            this.equalMult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nbIncrment = new System.Windows.Forms.TextBox();
            this.IncrementerBtn = new System.Windows.Forms.Button();
            this.incrementRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputAdd1
            // 
            this.inputAdd1.Location = new System.Drawing.Point(40, 82);
            this.inputAdd1.Name = "inputAdd1";
            this.inputAdd1.Size = new System.Drawing.Size(100, 22);
            this.inputAdd1.TabIndex = 0;
            // 
            // inputAdd2
            // 
            this.inputAdd2.Location = new System.Drawing.Point(249, 82);
            this.inputAdd2.Name = "inputAdd2";
            this.inputAdd2.Size = new System.Drawing.Size(100, 22);
            this.inputAdd2.TabIndex = 0;
            // 
            // inputAddRes
            // 
            this.inputAddRes.Location = new System.Drawing.Point(627, 82);
            this.inputAddRes.Name = "inputAddRes";
            this.inputAddRes.Size = new System.Drawing.Size(100, 22);
            this.inputAddRes.TabIndex = 0;
            // 
            // equalAdd
            // 
            this.equalAdd.Location = new System.Drawing.Point(462, 82);
            this.equalAdd.Name = "equalAdd";
            this.equalAdd.Size = new System.Drawing.Size(104, 23);
            this.equalAdd.TabIndex = 1;
            this.equalAdd.Text = "=";
            this.equalAdd.UseVisualStyleBackColor = true;
            this.equalAdd.Click += new System.EventHandler(this.equalAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // inputMult1
            // 
            this.inputMult1.Location = new System.Drawing.Point(40, 145);
            this.inputMult1.Name = "inputMult1";
            this.inputMult1.Size = new System.Drawing.Size(100, 22);
            this.inputMult1.TabIndex = 0;
            // 
            // inputMult2
            // 
            this.inputMult2.Location = new System.Drawing.Point(249, 145);
            this.inputMult2.Name = "inputMult2";
            this.inputMult2.Size = new System.Drawing.Size(100, 22);
            this.inputMult2.TabIndex = 0;
            // 
            // inputMultRes
            // 
            this.inputMultRes.Location = new System.Drawing.Point(627, 145);
            this.inputMultRes.Name = "inputMultRes";
            this.inputMultRes.Size = new System.Drawing.Size(100, 22);
            this.inputMultRes.TabIndex = 0;
            // 
            // equalMult
            // 
            this.equalMult.Location = new System.Drawing.Point(462, 145);
            this.equalMult.Name = "equalMult";
            this.equalMult.Size = new System.Drawing.Size(104, 23);
            this.equalMult.TabIndex = 1;
            this.equalMult.Text = "=";
            this.equalMult.UseVisualStyleBackColor = true;
            this.equalMult.Click += new System.EventHandler(this.equalMult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "*";
            // 
            // nbIncrment
            // 
            this.nbIncrment.Location = new System.Drawing.Point(40, 216);
            this.nbIncrment.Name = "nbIncrment";
            this.nbIncrment.Size = new System.Drawing.Size(100, 22);
            this.nbIncrment.TabIndex = 0;
            // 
            // IncrementerBtn
            // 
            this.IncrementerBtn.Location = new System.Drawing.Point(245, 210);
            this.IncrementerBtn.Name = "IncrementerBtn";
            this.IncrementerBtn.Size = new System.Drawing.Size(104, 31);
            this.IncrementerBtn.TabIndex = 1;
            this.IncrementerBtn.Text = "Incrementer";
            this.IncrementerBtn.UseVisualStyleBackColor = true;
            this.IncrementerBtn.Click += new System.EventHandler(this.IncrementerBtn_Click);
            // 
            // incrementRes
            // 
            this.incrementRes.Location = new System.Drawing.Point(466, 216);
            this.incrementRes.Name = "incrementRes";
            this.incrementRes.Size = new System.Drawing.Size(100, 22);
            this.incrementRes.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "nombre 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "nombre 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Resultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncrementerBtn);
            this.Controls.Add(this.equalMult);
            this.Controls.Add(this.equalAdd);
            this.Controls.Add(this.incrementRes);
            this.Controls.Add(this.inputMultRes);
            this.Controls.Add(this.inputAddRes);
            this.Controls.Add(this.inputMult2);
            this.Controls.Add(this.nbIncrment);
            this.Controls.Add(this.inputMult1);
            this.Controls.Add(this.inputAdd2);
            this.Controls.Add(this.inputAdd1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputAdd1;
        private System.Windows.Forms.TextBox inputAdd2;
        private System.Windows.Forms.TextBox inputAddRes;
        private System.Windows.Forms.Button equalAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputMult1;
        private System.Windows.Forms.TextBox inputMult2;
        private System.Windows.Forms.TextBox inputMultRes;
        private System.Windows.Forms.Button equalMult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nbIncrment;
        private System.Windows.Forms.Button IncrementerBtn;
        private System.Windows.Forms.TextBox incrementRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

