using Caelum.Stella.CSharp.Inwords;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            string extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            valor = 1532987;
            extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            Debug.WriteLine(extenso + " Reais");

            string extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);

            valor = 1532987.89;
            extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);
        }
    }
}
