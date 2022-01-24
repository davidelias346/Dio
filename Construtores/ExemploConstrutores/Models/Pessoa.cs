using System;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome;
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome){
            
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor Classe Pessoa");
        }

        public void Apresentar(){

            // this.nome = "Teste"; //Não funciona devido o readonly
            
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }

                
    }
}
