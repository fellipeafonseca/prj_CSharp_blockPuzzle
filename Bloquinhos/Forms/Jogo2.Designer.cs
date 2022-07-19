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
            this.numericUpDown_Cores = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_Matriz = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solucionarIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animarSoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Matriz)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown_Cores
            // 
            this.numericUpDown_Cores.Location = new System.Drawing.Point(13, 437);
            this.numericUpDown_Cores.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_Cores.Name = "numericUpDown_Cores";
            this.numericUpDown_Cores.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_Cores.TabIndex = 40;
            this.numericUpDown_Cores.ValueChanged += new System.EventHandler(this.numericUpDown_Cores_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 31);
            this.label5.TabIndex = 43;
            this.label5.Text = "Matriz";
            // 
            // numericUpDown_Matriz
            // 
            this.numericUpDown_Matriz.Location = new System.Drawing.Point(145, 437);
            this.numericUpDown_Matriz.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_Matriz.Name = "numericUpDown_Matriz";
            this.numericUpDown_Matriz.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_Matriz.TabIndex = 41;
            this.numericUpDown_Matriz.ValueChanged += new System.EventHandler(this.numericUpDown_Matriz_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.animarSoluçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 28);
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
            this.solucionarIAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.solucionarIAToolStripMenuItem.Text = "Solucionar (IA)";
            this.solucionarIAToolStripMenuItem.Click += new System.EventHandler(this.solucionarIAToolStripMenuItem_Click);
            // 
            // colorirToolStripMenuItem
            // 
            this.colorirToolStripMenuItem.Name = "colorirToolStripMenuItem";
            this.colorirToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.colorirToolStripMenuItem.Text = "Colorir";
            this.colorirToolStripMenuItem.Click += new System.EventHandler(this.colorirToolStripMenuItem_Click);
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
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(938, 490);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_Matriz);
            this.Controls.Add(this.numericUpDown_Cores);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Jogo2";
            this.Text = "Bloquinhos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Matriz)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_Matriz;
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