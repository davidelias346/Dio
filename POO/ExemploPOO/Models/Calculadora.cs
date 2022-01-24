using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int n1, int n2){
            return n1 + n2;

        }

        public int Somar(int n1, int n2, int n3){
            return n1 + n2 + n3;
            
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}