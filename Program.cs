using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Top isso ae certinho, se esta funcionando esta certo....kkkkk
            string produto1 = "computador";
            string produto2 = "mesa de escritorio";
            
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0} cujo preço é {1}",produto1, preco1);
        
            
            
            
            
            Console.WriteLine("{0} cujo preço é {1}",produto2, preco2);
            Console.WriteLine("registro: " + idade + " anos de idade " + "codigo "  + codigo + " genero " + genero);
            Console.WriteLine("Medida com oito casa dedcimais: " + medida.ToString("f8"));
            Console.WriteLine("arredondado tres casa decimais: " + medida.ToString("f3"));
            Console.WriteLine(medida.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
