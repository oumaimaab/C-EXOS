namespace App
{
    partial class Convertisseur
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
            this.label2 = new System.Windows.Forms.Label();
            this.currenciesFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currenciesTo = new System.Windows.Forms.ComboBox();
            this.convert = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(280, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Real Time Currency Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose The Currency";
            // 
            // currenciesFrom
            // 
            this.currenciesFrom.FormattingEnabled = true;
            this.currenciesFrom.Location = new System.Drawing.Point(85, 138);
            this.currenciesFrom.Name = "currenciesFrom";
            this.currenciesFrom.Size = new System.Drawing.Size(197, 24);
            this.currenciesFrom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choose The Currency";
            // 
            // currenciesTo
            // 
            this.currenciesTo.FormattingEnabled = true;
            this.currenciesTo.Location = new System.Drawing.Point(513, 138);
            this.currenciesTo.Name = "currenciesTo";
            this.currenciesTo.Size = new System.Drawing.Size(197, 24);
            this.currenciesTo.TabIndex = 2;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(351, 199);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(87, 30);
            this.convert.TabIndex = 3;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            // 
            // resultat
            // 
            this.resultat.Enabled = false;
            this.resultat.Location = new System.Drawing.Point(283, 270);
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.Size = new System.Drawing.Size(233, 22);
            this.resultat.TabIndex = 4;
            // 
            // Convertisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.currenciesTo);
            this.Controls.Add(this.currenciesFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Convertisseur";
            this.Text = "Convertisseur";
            this.Load += new System.EventHandler(this.Convertisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox currenciesFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox currenciesTo;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.TextBox resultat;
    }
}