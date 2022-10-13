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

            Stopwatch sw = new Stopwatch();
            sw.Reset();
            String tempoExecucao="";
            switch (metodo)
            {
                case 0:
                    sw.Start();
                    metodosOrdenacao.bolha(listaNumeros);
                    sw.Stop();
                    tempoExecucao = "Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds + "milisegundos";
                    break;
   
                case 1:
                    sw.Start();
                    metodosOrdenacao.selecao(listaNumeros);
                    sw.Stop();
                    tempoExecucao = "Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds + "milisegundos";
                    break;
                case 2:
                    sw.Start();
                    metodosOrdenacao.insercao(listaNumeros);
                    sw.Stop();
                    tempoExecucao = "Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds + "milisegundos";
                    break;
                case 3:
                    sw.Start();
                    metodosOrdenacao.agitacao(listaNumeros);
                    sw.Stop();
                    tempoExecucao = "Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds + "milisegundos";
                    break;
                case 4:
                    sw.Start();
                    metodosOrdenacao.pente(listaNumeros);
                    sw.Stop();
                    tempoExecucao = "Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds + "milisegundos";
                    break;
                case 5:
                    sw.Start();
                    metodosOrdenacao.shell(listaNumeros);
                    sw.Stop();
                    tempoExecucao = "Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds + "milisegundos";
                    break;
                case 6:
                    sw.Start();
                    metodosOrdenacao.quick(listaNumeros,0,listaNumeros.Count -1);
                    sw.Stop();
                    tempoExecucao = "Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds + "milisegundos";
                    break;
                case 7:
                    sw.Start();
                    metodosOrdenacao.heap(listaNumeros);
                    sw.Stop();
                    tempoExecucao = "Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds + "milisegundos";
                    break;
                case 8:
                    /*
                    sw.Start();
                    metodosOrdenacao.marge(listaNumeros);
                    sw.Stop();
                    tempoExecucao = "Tempo gasto para ordenar : " + "\r\n" + sw.ElapsedMilliseconds + "milisegundos";
                    
                    break;*/
                    
                default:
                    tempoExecucao = "Erro!!\r\nNenhum número foi digitado\r\nPor favor digite um número.";
                    break;
            }

            return tempoExecucao;
        }
    }
}
