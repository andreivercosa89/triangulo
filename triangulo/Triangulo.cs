using System;
namespace triangulo
{
    public class Triangulo
    {

        private int ladoA;
        private int ladoB;
        private int ladoC;

        public void defineValorLadoA(int valorDaTelaA){
            ladoA = valorDaTelaA;
        }

        public string pegaValorladoA(){
            return "Lado A: " + ladoA.ToString();
        }

        public void defineValorLadoB(int valorDaTelaB)
        {
            ladoB = valorDaTelaB;
        }

        public int pegaValorladoB()
        {
            return ladoB;
        }

        public void defineValorLadoC(int valorDaTelaC)
        {
            ladoC = valorDaTelaC;
        }

        public int pegaValorladoC()
        {
            return ladoC;
        }

        public Triangulo()
        {

        }
    }
}
