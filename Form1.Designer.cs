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
            this.tabPageRelatorio = new System.Windows.Forms.TabPage();
            this.dataGridViewRelatorio = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabPageCadastroInformacao = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).BeginInit();
            this.tabPageCadastroInformacao.SuspendLayout();
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
            // dataGridViewRelatorio
            // 
            this.dataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRelatorio.Location = new System.Drawing.Point(3, 140);
            this.dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            this.dataGridViewRelatorio.Size = new System.Drawing.Size(1030, 457);
            this.dataGridViewRelatorio.TabIndex = 1;
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
            this.textBox1.Location = new System.Drawing.Point(124, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(21, 545);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(188, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar Informação";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resumo profissional";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(581, 48);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade/UF";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(491, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-mail";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(124, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(581, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefone";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(124, 164);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(581, 20);
            this.textBox6.TabIndex = 12;
            // 
            // tabPageCadastroInformacao
            // 
            this.tabPageCadastroInformacao.Controls.Add(this.textBox9);
            this.tabPageCadastroInformacao.Controls.Add(this.label9);
            this.tabPageCadastroInformacao.Controls.Add(this.textBox7);
            this.tabPageCadastroInformacao.Controls.Add(this.label7);
            this.tabPageCadastroInformacao.Controls.Add(this.textBox8);
            this.tabPageCadastroInformacao.Controls.Add(this.label8);
            this.tabPageCadastroInformacao.Controls.Add(this.textBox6);
            this.tabPageCadastroInformacao.Controls.Add(this.label6);
            this.tabPageCadastroInformacao.Controls.Add(this.textBox5);
            this.tabPageCadastroInformacao.Controls.Add(this.label5);
            this.tabPageCadastroInformacao.Controls.Add(this.textBox4);
            this.tabPageCadastroInformacao.Controls.Add(this.label4);
            this.tabPageCadastroInformacao.Controls.Add(this.textBox3);
            this.tabPageCadastroInformacao.Controls.Add(this.label3);
            this.tabPageCadastroInformacao.Controls.Add(this.textBox2);
            this.tabPageCadastroInformacao.Controls.Add(this.label2);
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(124, 216);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(581, 20);
            this.textBox7.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Linkedin";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(124, 190);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(581, 20);
            this.textBox8.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Site pessoal";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(124, 242);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(581, 48);
            this.textBox9.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Objetivo profissional";
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
            this.tabPageRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).EndInit();
            this.tabPageCadastroInformacao.ResumeLayout(false);
            this.tabPageCadastroInformacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageRelatorio;
        private System.Windows.Forms.DataGridView dataGridViewRelatorio;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TabPage tabPageCadastroInformacao;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

