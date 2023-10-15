using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();            
        }
        public int Soma(int n1, int n2)
        {
            listaHistorico.Insert(0, "Resultado: " + (n1 + n2));
            return n1 + n2;
        }

        public List<string> historicoTresUltimasOperacoes()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            listaHistorico.Reverse();
            return listaHistorico;
        }

    }
}