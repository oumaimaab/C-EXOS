namespace EXO5TPThreads
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.couleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rougeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bleuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moyenneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cercleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 417);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleurToolStripMenuItem,
            this.vitesseToolStripMenuItem,
            this.formeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // couleurToolStripMenuItem
            // 
            this.couleurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rougeToolStripMenuItem,
            this.bleuToolStripMenuItem});
            this.couleurToolStripMenuItem.Name = "couleurToolStripMenuItem";
            this.couleurToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.couleurToolStripMenuItem.Text = "Couleur";
            // 
            // rougeToolStripMenuItem
            // 
            this.rougeToolStripMenuItem.Name = "rougeToolStripMenuItem";
            this.rougeToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.rougeToolStripMenuItem.Text = "Rouge";
            this.rougeToolStripMenuItem.Click += new System.EventHandler(this.rougeToolStripMenuItem_Click);
            // 
            // bleuToolStripMenuItem
            // 
            this.bleuToolStripMenuItem.Name = "bleuToolStripMenuItem";
            this.bleuToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.bleuToolStripMenuItem.Text = "Bleu";
            this.bleuToolStripMenuItem.Click += new System.EventHandler(this.bleuToolStripMenuItem_Click);
            // 
            // vitesseToolStripMenuItem
            // 
            this.vitesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lenteToolStripMenuItem,
            this.moyenneToolStripMenuItem,
            this.grandeToolStripMenuItem});
            this.vitesseToolStripMenuItem.Name = "vitesseToolStripMenuItem";
            this.vitesseToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.vitesseToolStripMenuItem.Text = "Vitesse";
            // 
            // lenteToolStripMenuItem
            // 
            this.lenteToolStripMenuItem.Name = "lenteToolStripMenuItem";
            this.lenteToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.lenteToolStripMenuItem.Text = "Lente";
            this.lenteToolStripMenuItem.Click += new System.EventHandler(this.lenteToolStripMenuItem_Click);
            // 
            // moyenneToolStripMenuItem
            // 
            this.moyenneToolStripMenuItem.Name = "moyenneToolStripMenuItem";
            this.moyenneToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.moyenneToolStripMenuItem.Text = "Moyenne";
            this.moyenneToolStripMenuItem.Click += new System.EventHandler(this.moyenneToolStripMenuItem_Click);
            // 
            // grandeToolStripMenuItem
            // 
            this.grandeToolStripMenuItem.Name = "grandeToolStripMenuItem";
            this.grandeToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.grandeToolStripMenuItem.Text = "Grande";
            this.grandeToolStripMenuItem.Click += new System.EventHandler(this.grandeToolStripMenuItem_Click);
            // 
            // formeToolStripMenuItem
            // 
            this.formeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.cercleToolStripMenuItem});
            this.formeToolStripMenuItem.Name = "formeToolStripMenuItem";
            this.formeToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.formeToolStripMenuItem.Text = "Forme";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // cercleToolStripMenuItem
            // 
            this.cercleToolStripMenuItem.Name = "cercleToolStripMenuItem";
            this.cercleToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.cercleToolStripMenuItem.Text = "Cercle";
            this.cercleToolStripMenuItem.Click += new System.EventHandler(this.cercleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem couleurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rougeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bleuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moyenneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cercleToolStripMenuItem;
    }
}

