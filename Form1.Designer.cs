namespace RelatorioInHTMLToPDF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCadastroInformacao = new System.Windows.Forms.TabPage();
            this.tabPageRelatorio = new System.Windows.Forms.TabPage();
            this.panelTop = new System.Windows.Forms.Panel();
            this.dataGridViewRelatorio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageCadastroInformacao.SuspendLayout();
            this.tabPageRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCadastroInformacao);
            this.tabControl.Controls.Add(this.tabPageRelatorio);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1044, 626);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCadastroInformacao
            // 
            this.tabPageCadastroInformacao.Controls.Add(this.btnCadastrar);
            this.tabPageCadastroInformacao.Controls.Add(this.textBox1);
            this.tabPageCadastroInformacao.Controls.Add(this.label1);
            this.tabPageCadastroInformacao.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastroInformacao.Name = "tabPageCadastroInformacao";
            this.tabPageCadastroInformacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastroInformacao.Size = new System.Drawing.Size(1036, 600);
            this.tabPageCadastroInformacao.TabIndex = 0;
            this.tabPageCadastroInformacao.Text = "Cadastro";
            this.tabPageCadastroInformacao.UseVisualStyleBackColor = true;
            // 
            // tabPageRelatorio
            // 
            this.tabPageRelatorio.Controls.Add(this.dataGridViewRelatorio);
            this.tabPageRelatorio.Controls.Add(this.panelTop);
            this.tabPageRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabPageRelatorio.Name = "tabPageRelatorio";
            this.tabPageRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRelatorio.Size = new System.Drawing.Size(1036, 600);
            this.tabPageRelatorio.TabIndex = 1;
            this.tabPageRelatorio.Text = "Relatório";
            this.tabPageRelatorio.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.IndianRed;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1030, 137);
            this.panelTop.TabIndex = 0;
            // 
            // dataGridViewRelatorio
            // 
            this.dataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRelatorio.Location = new System.Drawing.Point(3, 140);
            this.dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            this.dataGridViewRelatorio.Size = new System.Drawing.Size(1030, 457);
            this.dataGridViewRelatorio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(11, 64);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(188, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar Informação";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 626);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Gera um relatório PDF a partir de um template HTML";
            this.tabControl.ResumeLayout(false);
            this.tabPageCadastroInformacao.ResumeLayout(false);
            this.tabPageCadastroInformacao.PerformLayout();
            this.tabPageRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCadastroInformacao;
        private System.Windows.Forms.TabPage tabPageRelatorio;
        private System.Windows.Forms.DataGridView dataGridViewRelatorio;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

