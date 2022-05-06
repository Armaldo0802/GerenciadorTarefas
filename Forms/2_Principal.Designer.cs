namespace Prototipo1_GT.Forms
{
    partial class Fr_Prin
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastrarTarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTarefaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(371, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cadastrarTarefaToolStripMenuItem
            // 
            this.cadastrarTarefaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTarefasToolStripMenuItem,
            this.minhasTarefasToolStripMenuItem});
            this.cadastrarTarefaToolStripMenuItem.Name = "cadastrarTarefaToolStripMenuItem";
            this.cadastrarTarefaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.cadastrarTarefaToolStripMenuItem.Text = "Tarefas";
            this.cadastrarTarefaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTarefaToolStripMenuItem_Click);
            // 
            // cadastrarTarefasToolStripMenuItem
            // 
            this.cadastrarTarefasToolStripMenuItem.Name = "cadastrarTarefasToolStripMenuItem";
            this.cadastrarTarefasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cadastrarTarefasToolStripMenuItem.Text = "Cadastrar Tarefa";
            this.cadastrarTarefasToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTarefasToolStripMenuItem_Click);
            // 
            // minhasTarefasToolStripMenuItem
            // 
            this.minhasTarefasToolStripMenuItem.Name = "minhasTarefasToolStripMenuItem";
            this.minhasTarefasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.minhasTarefasToolStripMenuItem.Text = "Minhas Tarefas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Fr_Prin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 211);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Fr_Prin";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Fr_Prin_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhasTarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}