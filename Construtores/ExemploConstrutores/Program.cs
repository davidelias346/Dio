using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    internal class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica mat = new Matematica(10, 20);
            mat.Somar();
            
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair; //Adiciona mais um método ao delegate
            // op.Invoke(20, 10);
        
            
            // Data data = new Data();
            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);

            
            // data.ApresentarMes();

            
            
            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);
            
            
            //  Aluno aluno = new Aluno("David", "Elias", "Matemática");
            //  aluno.Apresentar();
            
        }
    }
};
