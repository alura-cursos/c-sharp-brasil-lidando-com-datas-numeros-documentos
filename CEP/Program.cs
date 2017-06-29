using Caelum.Stella.CSharp.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep = "01001000";
            string result = GetEndereco(cep);
            Debug.WriteLine(result);

            ViaCEP viaCEP = new ViaCEP();
            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Debug.WriteLine(enderecoJson);

            string enderecoXml = viaCEP.GetEnderecoXml(cep);
            Debug.WriteLine(enderecoXml);

            var task = viaCEP.GetEnderecoJsonAsync(cep);
            Debug.WriteLine(task.Result);

            var endereco = viaCEP.GetEndereco(cep);
            Debug.WriteLine(string.Format("Logradouro: {0}, Bairro: {1}", endereco.Logradouro, endereco.Bairro));
        }

        private static string GetEndereco(string cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            string result = new HttpClient().GetStringAsync(url).Result;
            return result;
        }
    }
}
