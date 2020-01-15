namespace Ex03
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
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(352, 63);
            this.add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(56, 19);
            this.add.TabIndex = 0;
            this.add.Text = "Ok";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrer un nombre";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(25, 111);
            this.list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(385, 134);
            this.list.TabIndex = 2;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(181, 63);
            this.input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(150, 20);
            this.input.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 366);
            this.Controls.Add(this.input);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.TextBox input;
    }
}

