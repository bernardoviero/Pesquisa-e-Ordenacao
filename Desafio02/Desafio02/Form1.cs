using System.Collections.Generic;

namespace Desafio02
{
    public partial class Form1 : Form
    {
        Informacoes informacoes = new Informacoes();
        Util geradorNumeros = new Util();
        Ordena ordena = new Ordena();

        int index;

        public Form1()
        {
            InitializeComponent();
            textBox_exibeInformacoes.ReadOnly = true;
            textBox_exibeOrdenacao.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = Int32.Parse(comboBox_metodosOrdenacao.GetItemText(comboBox_metodosOrdenacao.SelectedIndex));
            textBox_exibeInformacoes.Text = informacoes.exibeInformacoes(index);
        }

        private void button_ordenarNumeros_Click(object sender, EventArgs e)
        {
            int qtdNumeros = Int32.Parse(textBox_qtdNumeros.Text);
            List<int> listaNumeros =  geradorNumeros.gerarNumeros(qtdNumeros);

            textBox_exibeOrdenacao.Text = ordena.ordenarNumeros(index, listaNumeros); ;

        }

        private void button_limparTelas_Click(object sender, EventArgs e)
        {
            textBox_exibeOrdenacao.Text = "";
            textBox_exibeInformacoes.Text = "";
            textBox_qtdNumeros.Text = "";
        }
    }
}