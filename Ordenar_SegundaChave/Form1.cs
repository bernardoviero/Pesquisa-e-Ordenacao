namespace Ordenar_SegundaChave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            lista.Clear();
            Random gerador = new Random();
            try
            {
                long qtdNumeros = long.Parse(textBox_qtdDados.Text);
                Dado dado;
                for(; qtdNumeros > 0; qtdNumeros--)
                {
                    dado = (new Dado(gerador.Next(0, 100), gerador.Next(0, 500)));
                    lista.Add(dado);
                    textBox_qtdDados.AppendText(dado.Chave1 + " - " + dado.Chave2 + Environment.NewLine);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de dados inválidos!");
                textBox_qtdDados.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Confira seus dados no Text Box!!");
                textBox_qtdDados.Text = "";
            }

            List<Dado> lista = new List<Dado>();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Clear();
                textBox_dados.Clear();
                OpenFileDialog openFileDialog1;
                OpenFileDialog = new OpenFileDialog();
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.ShowDialog();
                Dado dado;

                string[] linhas = File.ReadAllLines(openFileDialog1.FileName);
                string[] numeros;
                for(int i = 0; i < linhas.Length; i++)
                {
                    numeros = linhas[i].Split(';');
                    dado = new Dado(int.Parse(linhas[0]), int.Parse(linhas[1]));
                    lista.Add(dado);
                    textBox_qtdDados.AppendText(dado.Chave1 + " - " + dado.Chave2 + Environment.NewLine);

                }
                textBox_qtdDados.Text = lista.Count.toString();
            }
            catch (Exception)
            {
            
            }
        }
    }
}