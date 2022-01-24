using System;
using System.IO;
using System.Collections.Generic;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;

namespace ExemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Teste1");
            var caminhoArquivo =  Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-backup.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste3", "arquivo-teste-stream.txt");
    
            var listaString = new List<string> {"linha1", "linha2", "linha3"};
            var listaStringContinuacao = new List<string> {"linha4", "linha5", "linha6"};
            
            FileHelper helper = new FileHelper();

            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ApagarDiretorio(caminhoPathCombine, true);
            // helper.CriarArquivoTexto(caminhoArquivo, "Olá, teste de escrita");
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            // helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            // helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
            
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));
            
            // Computador pc = new Computador();
            // Console.WriteLine(pc.ToString());
           
            // Corrente conta = new Corrente();
            // conta.Creditar(1000);

            // conta.ExibirSaldo();

            
            // Calculadora c = new Calculadora();
            // Console.WriteLine("Resultado da primeira soma: "+ c.Somar(50, 19));
            // Console.WriteLine("\nResultado da segunda soma: "+ c.Somar(10, 20, 20));
            
            // Aluno p1 = new Aluno();
            // p1.Nome = "David";
            // p1.Idade = 21;
            // p1.Nota = 10;

            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "João";
            // p2.Idade = 50;
            // p2.Salario = 1200;

            // p2.Apresentar();

            
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(-1, 10);
            // Console.WriteLine($"Área: {r.ObterArea()}");
            
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 30;

            // p1.Apresentar();
        }
    }
}
