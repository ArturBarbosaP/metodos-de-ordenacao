namespace Pratica5
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçaoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.rbt_cres = new System.Windows.Forms.RadioButton();
            this.rbt_des = new System.Windows.Forms.RadioButton();
            this.rbt_ale = new System.Windows.Forms.RadioButton();
            this.cbx_tamanho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem,
            this.seleçãoToolStripMenuItem,
            this.inserçãoToolStripMenuItem,
            this.shellSortToolStripMenuItem,
            this.heapSortToolStripMenuItem,
            this.quickSortToolStripMenuItem,
            this.mergeSortToolStripMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.algoritmoToolStripMenuItem.Text = "Animações";
            // 
            // bolhaToolStripMenuItem
            // 
            this.bolhaToolStripMenuItem.Name = "bolhaToolStripMenuItem";
            this.bolhaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.bolhaToolStripMenuItem.Text = "Bolha";
            this.bolhaToolStripMenuItem.Click += new System.EventHandler(this.bolhaToolStripMenuItem_Click);
            // 
            // seleçãoToolStripMenuItem
            // 
            this.seleçãoToolStripMenuItem.Name = "seleçãoToolStripMenuItem";
            this.seleçãoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.seleçãoToolStripMenuItem.Text = "Seleção";
            this.seleçãoToolStripMenuItem.Click += new System.EventHandler(this.seleçãoToolStripMenuItem_Click);
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            this.inserçãoToolStripMenuItem.Click += new System.EventHandler(this.inserçãoToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.shellSortToolStripMenuItem.Text = "ShellSort";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.shellSortToolStripMenuItem_Click);
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            this.heapSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.heapSortToolStripMenuItem.Text = "HeapSort";
            this.heapSortToolStripMenuItem.Click += new System.EventHandler(this.heapSortToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.quickSortToolStripMenuItem.Text = "QuickSort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.quickSortToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.mergeSortToolStripMenuItem.Text = "MergeSort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.mergeSortToolStripMenuItem_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem1,
            this.seleçaoToolStripMenuItem1,
            this.inserçãoToolStripMenuItem1,
            this.shellSortToolStripMenuItem1,
            this.heapSortToolStripMenuItem1,
            this.quickSortToolStripMenuItem1,
            this.mergeSortToolStripMenuItem1});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            this.estatísticasToolStripMenuItem.Click += new System.EventHandler(this.estatísticasToolStripMenuItem_Click);
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // seleçaoToolStripMenuItem1
            // 
            this.seleçaoToolStripMenuItem1.Name = "seleçaoToolStripMenuItem1";
            this.seleçaoToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.seleçaoToolStripMenuItem1.Text = "Seleçao";
            this.seleçaoToolStripMenuItem1.Click += new System.EventHandler(this.seleçaoToolStripMenuItem1_Click);
            // 
            // inserçãoToolStripMenuItem1
            // 
            this.inserçãoToolStripMenuItem1.Name = "inserçãoToolStripMenuItem1";
            this.inserçãoToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.inserçãoToolStripMenuItem1.Text = "Inserção";
            this.inserçãoToolStripMenuItem1.Click += new System.EventHandler(this.inserçãoToolStripMenuItem1_Click);
            // 
            // shellSortToolStripMenuItem1
            // 
            this.shellSortToolStripMenuItem1.Name = "shellSortToolStripMenuItem1";
            this.shellSortToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.shellSortToolStripMenuItem1.Text = "ShellSort";
            this.shellSortToolStripMenuItem1.Click += new System.EventHandler(this.shellSortToolStripMenuItem1_Click);
            // 
            // heapSortToolStripMenuItem1
            // 
            this.heapSortToolStripMenuItem1.Name = "heapSortToolStripMenuItem1";
            this.heapSortToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.heapSortToolStripMenuItem1.Text = "HeapSort";
            this.heapSortToolStripMenuItem1.Click += new System.EventHandler(this.heapSortToolStripMenuItem1_Click);
            // 
            // quickSortToolStripMenuItem1
            // 
            this.quickSortToolStripMenuItem1.Name = "quickSortToolStripMenuItem1";
            this.quickSortToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.quickSortToolStripMenuItem1.Text = "QuickSort";
            this.quickSortToolStripMenuItem1.Click += new System.EventHandler(this.quickSortToolStripMenuItem1_Click);
            // 
            // mergeSortToolStripMenuItem1
            // 
            this.mergeSortToolStripMenuItem1.Name = "mergeSortToolStripMenuItem1";
            this.mergeSortToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.mergeSortToolStripMenuItem1.Text = "MergeSort";
            this.mergeSortToolStripMenuItem1.Click += new System.EventHandler(this.mergeSortToolStripMenuItem1_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // rbt_cres
            // 
            this.rbt_cres.AutoSize = true;
            this.rbt_cres.Location = new System.Drawing.Point(12, 33);
            this.rbt_cres.Name = "rbt_cres";
            this.rbt_cres.Size = new System.Drawing.Size(101, 17);
            this.rbt_cres.TabIndex = 2;
            this.rbt_cres.Text = "Vetor Crescente";
            this.rbt_cres.UseVisualStyleBackColor = true;
            // 
            // rbt_des
            // 
            this.rbt_des.AutoSize = true;
            this.rbt_des.Location = new System.Drawing.Point(205, 33);
            this.rbt_des.Name = "rbt_des";
            this.rbt_des.Size = new System.Drawing.Size(114, 17);
            this.rbt_des.TabIndex = 3;
            this.rbt_des.Text = "Vetor Decrescente";
            this.rbt_des.UseVisualStyleBackColor = true;
            // 
            // rbt_ale
            // 
            this.rbt_ale.AutoSize = true;
            this.rbt_ale.Checked = true;
            this.rbt_ale.Location = new System.Drawing.Point(418, 33);
            this.rbt_ale.Name = "rbt_ale";
            this.rbt_ale.Size = new System.Drawing.Size(94, 17);
            this.rbt_ale.TabIndex = 4;
            this.rbt_ale.TabStop = true;
            this.rbt_ale.Text = "Vetor Aleatório";
            this.rbt_ale.UseVisualStyleBackColor = true;
            // 
            // cbx_tamanho
            // 
            this.cbx_tamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tamanho.FormattingEnabled = true;
            this.cbx_tamanho.Items.AddRange(new object[] {
            "10.000",
            "50.000",
            "100.000",
            "500.000"});
            this.cbx_tamanho.Location = new System.Drawing.Point(334, 2);
            this.cbx_tamanho.Name = "cbx_tamanho";
            this.cbx_tamanho.Size = new System.Drawing.Size(121, 21);
            this.cbx_tamanho.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tamanho do Vetor:";
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_tamanho);
            this.Controls.Add(this.rbt_ale);
            this.Controls.Add(this.rbt_des);
            this.Controls.Add(this.rbt_cres);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 2023/1 - Métodos de Ordenação";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleçaoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rbt_cres;
        private System.Windows.Forms.RadioButton rbt_des;
        private System.Windows.Forms.RadioButton rbt_ale;
        private System.Windows.Forms.ComboBox cbx_tamanho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

