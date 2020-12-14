using System;
namespace classe_estatica.classes
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.07f;
        private static float cotacaoEuro = 6.16f;
        public static float RealParaDolar(float valorRS)
        {
            return valorRS / cotacaoDolar;
        }
        public static float DolarParaReais(float valorUS)
        {
            return cotacaoDolar * valorUS;
        }
        public static float RealParaEuro(float valorRS)
        {
            return valorRS / cotacaoEuro;
        }
        public static float EuroParaReais(float valorER)
        {
            return cotacaoEuro * valorER;
        }
    }   
}