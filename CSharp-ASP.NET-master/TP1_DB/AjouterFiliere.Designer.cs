namespace TP1_DB
{
    partial class AjouterFiliere
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
            this.filiereNameInput = new System.Windows.Forms.TextBox();
            this.addFiliere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de filiere";
            // 
            // filiereNameInput
            // 
            this.filiereNameInput.Location = new System.Drawing.Point(234, 130);
            this.filiereNameInput.Name = "filiereNameInput";
            this.filiereNameInput.Size = new System.Drawing.Size(191, 22);
            this.filiereNameInput.TabIndex = 1;
            // 
            // addFiliere
            // 
            this.addFiliere.Location = new System.Drawing.Point(431, 130);
            this.addFiliere.Name = "addFiliere";
            this.addFiliere.Size = new System.Drawing.Size(75, 23);
            this.addFiliere.TabIndex = 2;
            this.addFiliere.Text = "Ajouter";
            this.addFiliere.UseVisualStyleBackColor = true;
            this.addFiliere.Click += new System.EventHandler(this.addFiliere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 365);
            this.Controls.Add(this.addFiliere);
            this.Controls.Add(this.filiereNameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ajouter une filière";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filiereNameInput;
        private System.Windows.Forms.Button addFiliere;
    }
}

