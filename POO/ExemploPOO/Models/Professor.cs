using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public sealed override void Apresentar(){ //"override" permite que ela sobrescreva
            Console.WriteLine($"\nOlá, meu nome é {Nome} e tenho {Idade} anos. Sou um professor que ganha R${Salario}");
        }
    }
}