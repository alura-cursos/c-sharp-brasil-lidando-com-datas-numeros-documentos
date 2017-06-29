using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2017, 9, 23);
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("d"));
            Debug.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Debug.WriteLine(data.ToString("dd/MM"));
            Debug.WriteLine(data.ToString("dd/MM/yy"));

            data = new DateTime(2017, 9, 23, 13, 14, 15, 987);
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("HH:mm"));
            Debug.WriteLine(data.ToString("HH:mm:ss.fff"));

            Debug.WriteLine(data.ToString("D"));
            Debug.WriteLine(data.ToString("m"));
            Debug.WriteLine(data.ToString("Y"));

            Debug.WriteLine(data.ToString("G"));
            Debug.WriteLine(data.ToString("g"));

            Debug.WriteLine(data.ToString("O"));
            Debug.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));

            Debug.WriteLine(data.ToString("t"));
            Debug.WriteLine(data.ToString("T"));

        }
    }
}
