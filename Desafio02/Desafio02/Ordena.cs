using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Desafio02
{
    internal class Ordena
    {
        public String ordenarNumeros(int metodo, List<int> listaNumeros)
        {
            MetodosOrdenacao metodosOrdenacao = new MetodosOrdenacao();
            String tempoExecucao="";
            switch (metodo)
            {
                case 0:
                    metodosOrdenacao.bolha(listaNumeros);
                    tempoExecucao = tempoOrdenacao();
                    break;
                case 1:
                    metodosOrdenacao.selecao(listaNumeros);
                    tempoExecucao = tempoOrdenacao();
                    break;
                case 2:
                    metodosOrdenacao.insercao(listaNumeros);
                    tempoExecucao = tempoOrdenacao();
                    break;
                case 3:
                    metodosOrdenacao.agitacao(listaNumeros);
                    tempoExecucao = tempoOrdenacao();
                    break;
                case 4:
                    metodosOrdenacao.pente(listaNumeros);
                    tempoExecucao = tempoOrdenacao();
                    break;
                case 5:
                    metodosOrdenacao.shell(listaNumeros);
                    tempoExecucao = tempoOrdenacao();
                    break;
                case 6:
                    metodosOrdenacao.quick(listaNumeros,0,listaNumeros.Count -1);
                    tempoExecucao = tempoOrdenacao();
                    break;
                case 7:
                    metodosOrdenacao.heap(listaNumeros);
                    tempoExecucao = tempoOrdenacao();
                    break;
                case 8:
                    /*
                    metodosOrdenacao.marge(listaNumeros);
                    tempoExecucao = tempoOrdenacao();
                    */
                    break;
                default:
                    tempoExecucao = "Erro!!\r\nNenhum número foi digitado\r\nPor favor digite um número.";
                    break;
            }

            return tempoExecucao;
        }
        private String tempoOrdenacao()
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                //não faz nada
            }
            sw.Stop();
            return ("Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds.ToString() + "milisegundos");
        }
    }
}
