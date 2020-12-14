using System;
using classe_estatica.classes;
namespace classe_estatica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamamos nossa classe estática, sem precisar instanciar
            Console.WriteLine($"Conversor de Dolar para reais, sendo 4 doláres, o resultado será: \n  Resultado:{Conversor.DolarParaReais(4f)} RS");

            Console.WriteLine($"Conversor de reais para dolares, sendo 50 reais, o resultado será: \n  Resultado:{Conversor.RealParaDolar(50f)} US");
        }
    }
}
