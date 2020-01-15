namespace ex3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.TextBox();
            this.afficherButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.montantInput = new System.Windows.Forms.TextBox();
            this.deposerButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de compte";
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(156, 28);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(130, 22);
            this.numInput.TabIndex = 1;
            // 
            // afficherButton
            // 
            this.afficherButton.Location = new System.Drawing.Point(395, 26);
            this.afficherButton.Name = "afficherButton";
            this.afficherButton.Size = new System.Drawing.Size(94, 24);
            this.afficherButton.TabIndex = 2;
            this.afficherButton.Text = "Afficher";
            this.afficherButton.UseVisualStyleBackColor = true;
            this.afficherButton.Click += new System.EventHandler(this.afficherButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Montant";
            // 
            // montantInput
            // 
            this.montantInput.Location = new System.Drawing.Point(156, 83);
            this.montantInput.Name = "montantInput";
            this.montantInput.Size = new System.Drawing.Size(130, 22);
            this.montantInput.TabIndex = 1;
            // 
            // deposerButton
            // 
            this.deposerButton.Location = new System.Drawing.Point(123, 158);
            this.deposerButton.Name = "deposerButton";
            this.deposerButton.Size = new System.Drawing.Size(94, 24);
            this.deposerButton.TabIndex = 2;
            this.deposerButton.Text = "Deposer";
            this.deposerButton.UseVisualStyleBackColor = true;
            this.deposerButton.Click += new System.EventHandler(this.deposerButton_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(314, 68);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(465, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.deposerButton);
            this.Controls.Add(this.afficherButton);
            this.Controls.Add(this.montantInput);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numInput;
        private System.Windows.Forms.Button afficherButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox montantInput;
        private System.Windows.Forms.Button deposerButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

