namespace ExemploPOO.Models
{
    public class Aluno : Pessoa  //Herda de Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar(){ //"override" permite que ela sobrescreva
            Console.WriteLine($"\nOlá, meu nome é {Nome} e tenho {Idade} anos. Sou um aluno nota {Nota}");
        }

        
    }
}