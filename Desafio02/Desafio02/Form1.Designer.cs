namespace Desafio02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_selecionarMetodo = new System.Windows.Forms.Button();
            this.button_limparTelas = new System.Windows.Forms.Button();
            this.comboBox_metodosOrdenacao = new System.Windows.Forms.ComboBox();
            this.textBox_exibeInformacoes = new System.Windows.Forms.TextBox();
            this.textBox_exibeOrdenacao = new System.Windows.Forms.TextBox();
            this.button_ordenarNumeros = new System.Windows.Forms.Button();
            this.textBox_qtdNumeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_selecionarMetodo
            // 
            this.button_selecionarMetodo.Location = new System.Drawing.Point(280, 31);
            this.button_selecionarMetodo.Name = "button_selecionarMetodo";
            this.button_selecionarMetodo.Size = new System.Drawing.Size(119, 23);
            this.button_selecionarMetodo.TabIndex = 0;
            this.button_selecionarMetodo.Text = "Selecionar";
            this.button_selecionarMetodo.UseVisualStyleBackColor = true;
            this.button_selecionarMetodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_limparTelas
            // 
            this.button_limparTelas.Location = new System.Drawing.Point(471, 31);
            this.button_limparTelas.Name = "button_limparTelas";
            this.button_limparTelas.Size = new System.Drawing.Size(75, 23);
            this.button_limparTelas.TabIndex = 1;
            this.button_limparTelas.Text = "LIMPAR";
            this.button_limparTelas.UseVisualStyleBackColor = true;
            this.button_limparTelas.Click += new System.EventHandler(this.button_limparTelas_Click);
            // 
            // comboBox_metodosOrdenacao
            // 
            this.comboBox_metodosOrdenacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_metodosOrdenacao.FormattingEnabled = true;
            this.comboBox_metodosOrdenacao.Items.AddRange(new object[] {
            "Bolha",
            "Seleção",
            "Inserção",
            "Agitação",
            "Pente",
            "Ord. Rápida (Quick)",
            "Ord. Pilha (Heap)",
            "Ord. Mesclada (Marge)"});
            this.comboBox_metodosOrdenacao.Location = new System.Drawing.Point(33, 31);
            this.comboBox_metodosOrdenacao.Name = "comboBox_metodosOrdenacao";
            this.comboBox_metodosOrdenacao.Size = new System.Drawing.Size(228, 23);
            this.comboBox_metodosOrdenacao.TabIndex = 2;
            // 
            // textBox_exibeInformacoes
            // 
            this.textBox_exibeInformacoes.Location = new System.Drawing.Point(33, 99);
            this.textBox_exibeInformacoes.Multiline = true;
            this.textBox_exibeInformacoes.Name = "textBox_exibeInformacoes";
            this.textBox_exibeInformacoes.Size = new System.Drawing.Size(306, 166);
            this.textBox_exibeInformacoes.TabIndex = 3;
            // 
            // textBox_exibeOrdenacao
            // 
            this.textBox_exibeOrdenacao.Location = new System.Drawing.Point(368, 99);
            this.textBox_exibeOrdenacao.Multiline = true;
            this.textBox_exibeOrdenacao.Name = "textBox_exibeOrdenacao";
            this.textBox_exibeOrdenacao.Size = new System.Drawing.Size(178, 166);
            this.textBox_exibeOrdenacao.TabIndex = 4;
            // 
            // button_ordenarNumeros
            // 
            this.button_ordenarNumeros.Location = new System.Drawing.Point(280, 283);
            this.button_ordenarNumeros.Name = "button_ordenarNumeros";
            this.button_ordenarNumeros.Size = new System.Drawing.Size(119, 23);
            this.button_ordenarNumeros.TabIndex = 5;
            this.button_ordenarNumeros.Text = "Ordenar";
            this.button_ordenarNumeros.UseVisualStyleBackColor = true;
            this.button_ordenarNumeros.Click += new System.EventHandler(this.button_ordenarNumeros_Click);
            // 
            // textBox_qtdNumeros
            // 
            this.textBox_qtdNumeros.Location = new System.Drawing.Point(121, 283);
            this.textBox_qtdNumeros.Name = "textBox_qtdNumeros";
            this.textBox_qtdNumeros.Size = new System.Drawing.Size(131, 23);
            this.textBox_qtdNumeros.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qtd números:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_qtdNumeros);
            this.Controls.Add(this.button_ordenarNumeros);
            this.Controls.Add(this.textBox_exibeOrdenacao);
            this.Controls.Add(this.textBox_exibeInformacoes);
            this.Controls.Add(this.comboBox_metodosOrdenacao);
            this.Controls.Add(this.button_limparTelas);
            this.Controls.Add(this.button_selecionarMetodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_selecionarMetodo;
        private Button button_limparTelas;
        private ComboBox comboBox_metodosOrdenacao;
        private TextBox textBox_exibeInformacoes;
        private TextBox textBox_exibeOrdenacao;
        private Button button_ordenarNumeros;
        private TextBox textBox_qtdNumeros;
        private Label label1;
    }
}