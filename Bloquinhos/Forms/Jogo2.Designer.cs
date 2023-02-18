namespace Bloquinhos
{
    partial class Jogo2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solucionarIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animarSoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.animarSoluçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 28);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorirToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.solucionarIAToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // colorirToolStripMenuItem
            // 
            this.colorirToolStripMenuItem.Name = "colorirToolStripMenuItem";
            this.colorirToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.colorirToolStripMenuItem.Text = "Colorir";
            this.colorirToolStripMenuItem.Click += new System.EventHandler(this.colorirToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // solucionarIAToolStripMenuItem
            // 
            this.solucionarIAToolStripMenuItem.Name = "solucionarIAToolStripMenuItem";
            this.solucionarIAToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.solucionarIAToolStripMenuItem.Text = "Solucionar (IA)";
            this.solucionarIAToolStripMenuItem.Click += new System.EventHandler(this.solucionarIAToolStripMenuItem_Click);
            // 
            // animarSoluçãoToolStripMenuItem
            // 
            this.animarSoluçãoToolStripMenuItem.Name = "animarSoluçãoToolStripMenuItem";
            this.animarSoluçãoToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.animarSoluçãoToolStripMenuItem.Text = "Automação";
            this.animarSoluçãoToolStripMenuItem.Click += new System.EventHandler(this.animarSoluçãoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Jogo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(409, 490);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Jogo2";
            this.Text = "Blocos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solucionarIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animarSoluçãoToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}