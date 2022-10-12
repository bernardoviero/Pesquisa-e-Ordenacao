using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    internal class Informacoes
    {
        public String exibeInformacoes(int index)
        {
            String informacoes = "";
            switch (index)
            {
                case 0:
                    informacoes = ("Método: Bolha\r\nNome em inglês: Bubble sort\r\nÉ um método estável\r\nPossui uma alta complexidade(muito esforço)\r\nA estrutura possui 2 partes (1a é a desordenada; 2a parte é a ordenada)");
                    break;

                case 1:
                    informacoes = ("Método: Seleção\r\nNome em inglês:Selection sort\r\nÉ um método instável\r\nPossui uma alta complexidade(muito esforço)\r\nA estrutura possui 2 partes (1a é a ordenada; 2a parte é a desordenada)");
                    break;

                case 2:
                    informacoes = ("Método: Inserção\r\nNome em inglês: Insertion sort\r\nÉ um método estável\r\nPossui uma alta complexidade(muito esforço)\r\nA estrutura possui 2 partes (1a é a ordenada; 2a parte é a desordenada)");
                    break;

                case 3:
                    informacoes = ("Método: Agitação\r\nNome em inglês: Shake sort\r\nÉ um método estável\r\nPossui uma alta complexidade(muito esforço)\r\nA estrutura possui 3 partes/porções (1a é a ordenada pelos menores; 2a é a desordenada; 3a é ordenada pelos maiores)");
                    break;

                case 4:
                    informacoes = ("Método: Pente\r\nNome em inglês: Comb sort\r\nÉ um método instável\r\nPossui uma média complexidade\r\nA estrutura possui 2 porções (1a é a ordenada; 2a é a desordenada)");
                    break;

                case 5:
                    informacoes = ("Método: Classificação\r\nNome em inglês: Shell sort\r\nÉ um método instável\r\nPossui uma média complexidade\r\nÉ uma tentativa de melhoria o INSERÇÃO via o uso da ANÁLISE A DISTÂNCIA");
                    break;

                case 6:
                    informacoes = ("Método: Ordenação rápida\r\nNome em inglês: Quick sort\r\nÉ um método instável\r\nPossui uma média complexidade\r\nUtiliza-se uma divisão da estrutura para acelerar a ordenação. Essa divisão é realizada por meio de RECURSÃO.");
                    break;

                case 7:
                    informacoes = ("Método: Ordenação por Pilha\r\nNome em inglês: Heap sort\r\nÉ um método estável\r\nPossui uma média complexidade\r\nHeapmáximo: garantir que raiz da subarvore seja maior ou igual que seus filhos. Se isso não ocorrer, fazer as trocas");
                    break;

                case 8:
                    informacoes = ("Método: Ordenação Mesclada\r\r\nNome em inglês: Marge sort\r\r\nÉ um método instável\r\nPossui uma alta complexidade(muito esforço)\r\nUtiliza-se a divisão da estrutura para acelerar a ordenação. Essa divisão é realizada por meio de RECURSÃO.Contudo, diferente do QUICKSORT, o MERGESORT sempre divide a estrutura no meio (vai existir uma variável meio)");
                    break;
                default:
                    informacoes = String.Format("Erro!!!\r\r\nSelecione um método válido.");
                    break;
            }
            return informacoes;
        }
    }
}
