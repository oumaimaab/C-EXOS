namespace TP2DB
{
    partial class mainWindow
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
            this.listCneSelect = new System.Windows.Forms.ComboBox();
            this.reportingBtn = new System.Windows.Forms.Button();
            this.statistiqueBtn = new System.Windows.Forms.Button();
            this.studentsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chercher un étudiant : ";
            // 
            // listCneSelect
            // 
            this.listCneSelect.FormattingEnabled = true;
            this.listCneSelect.Location = new System.Drawing.Point(296, 96);
            this.listCneSelect.Name = "listCneSelect";
            this.listCneSelect.Size = new System.Drawing.Size(207, 24);
            this.listCneSelect.TabIndex = 1;
            this.listCneSelect.SelectedIndexChanged += new System.EventHandler(this.listCneSelect_SelectedIndexChanged);
            // 
            // reportingBtn
            // 
            this.reportingBtn.Location = new System.Drawing.Point(558, 90);
            this.reportingBtn.Name = "reportingBtn";
            this.reportingBtn.Size = new System.Drawing.Size(127, 35);
            this.reportingBtn.TabIndex = 2;
            this.reportingBtn.Text = "Reporting";
            this.reportingBtn.UseVisualStyleBackColor = true;
            // 
            // statistiqueBtn
            // 
            this.statistiqueBtn.Location = new System.Drawing.Point(712, 92);
            this.statistiqueBtn.Name = "statistiqueBtn";
            this.statistiqueBtn.Size = new System.Drawing.Size(124, 33);
            this.statistiqueBtn.TabIndex = 2;
            this.statistiqueBtn.Text = "Statistique";
            this.statistiqueBtn.UseVisualStyleBackColor = true;
            // 
            // studentsTable
            // 
            this.studentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsTable.Location = new System.Drawing.Point(140, 147);
            this.studentsTable.Name = "studentsTable";
            this.studentsTable.RowHeadersWidth = 51;
            this.studentsTable.RowTemplate.Height = 24;
            this.studentsTable.Size = new System.Drawing.Size(696, 283);
            this.studentsTable.TabIndex = 3;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 562);
            this.Controls.Add(this.studentsTable);
            this.Controls.Add(this.statistiqueBtn);
            this.Controls.Add(this.reportingBtn);
            this.Controls.Add(this.listCneSelect);
            this.Controls.Add(this.label1);
            this.Name = "mainWindow";
            this.Text = "Gestion des étudiants";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listCneSelect;
        private System.Windows.Forms.Button reportingBtn;
        private System.Windows.Forms.Button statistiqueBtn;
        private System.Windows.Forms.DataGridView studentsTable;
    }
}

