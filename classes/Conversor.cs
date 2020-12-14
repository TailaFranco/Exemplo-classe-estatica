using System;
namespace classe_estatica.classes
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.07f;
        public static float RealParaDolar(float valorRS)
        {
            return valorRS / cotacaoDolar;
        }
        public static float DolarParaReais(float valorUS)
        {
            return cotacaoDolar * valorUS;
        }
    }   
}