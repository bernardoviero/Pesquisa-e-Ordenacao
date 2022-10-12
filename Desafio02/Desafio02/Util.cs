using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    internal class Util
    {
        public List<int> gerarNumeros(int quantidade)
        {
            List<int> lista = new List<int>();
            Random gerador = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                lista.Add(gerador.Next(1000));
            }
            return lista;
        }
    }
}
