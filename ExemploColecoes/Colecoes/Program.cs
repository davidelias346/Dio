using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        for (int i = 1; i <=9; i+=2)
      {
        for(int j = 7; j > 4; j--)
        {
          Console.WriteLine($"i={i} j={j}");
        }
      }

    

        // ------------------ LINQ ---------------------

            // int[] arrayNumeros = new int[10]{1, 4, 11, 8, 10, 4, 50, 30, 10, 49};

            // var minimo = arrayNumeros.Min();
            // var maximo = arrayNumeros.Max();
            // var media = arrayNumeros.Average();
            // var soma = arrayNumeros.Sum();
            // var valoresDistintos = arrayNumeros.Distinct();

            // System.Console.WriteLine($"Mínimo: {minimo}\t Máximo: {maximo}\t Média: {media}");
            // System.Console.WriteLine($"Soma dos valores: {soma}");
            // System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            // System.Console.WriteLine($"Array com valores únicos: {string.Join(", ", valoresDistintos)}");
            
            // var numerosPares = 
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosPares));
            // System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));
        
        
        
        // ----------------- Dicionário ----------------

            // Dictionary<string, string> estados = new  Dictionary<string, string>();

            // estados.Add("GO", "Goiás");
            // estados.Add("TO", "Tocantins");
            // estados.Add("PB", "Paraíba");

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
            // }

            // string valorProcurado = "TO";

            // if(estados.TryGetValue(valorProcurado, out string? estadoEncontrado))//TryGetValue para não dar erro
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave: {valorProcurado} não existe no dicionário");
            // }

            // System.Console.WriteLine($"Removendo o valor: {estados[valorProcurado]}");

            // estados.Remove(valorProcurado);

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
            // }

            // System.Console.WriteLine("Valor original");
            // System.Console.WriteLine($"Estado: {estados[valorProcurado]}");

            // estados[valorProcurado] = "Goiânia";
            // System.Console.WriteLine("Valor alterado");
            // System.Console.WriteLine($"Estado: {estados[valorProcurado]}");
        
        
        // ------------------- Pilha ------------------- 
            
            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push("Herry Potter");
            // pilhaLivros.Push("Biografia de Albert Einstein");
            // pilhaLivros.Push("Volta ao Mundo");

            // System.Console.WriteLine($"Total de livros para leitura {pilhaLivros.Count()}");

            // while (pilhaLivros.Count > 0)
            // {
            //      System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}"); 
            //      System.Console.WriteLine($"{pilhaLivros.Pop()} retirado para leitura!\n");
            // }

            // System.Console.WriteLine($"Total de livros para leitura {pilhaLivros.Count()}");

        
        // ------------------- Fila -----------------

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("David");
            // fila.Enqueue("Josefina");
            // fila.Enqueue("Augustina");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count()}");

            // while (fila.Count > 0)
            // {
            //      System.Console.WriteLine($"Vez de: {fila.Peek()}"); //Lista a primeira pessoa da fila
            //      System.Console.WriteLine($"{fila.Dequeue()} atendido!");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count()}");


            
        // --------------- Lista ----------------  
            
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string> {"SP", "MG", "GO"};
            // string[] estadosArray = new string[2] {"SC", "PB"};

            // System.Console.WriteLine($"Quantidade de elementos da lista: {estados.Count}\n");
          
            // opLista.ImprimirListaString(estados);
            
            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");
            
            // estados.AddRange(estadosArray);
            // estados.Insert(1, "RO");

            // System.Console.WriteLine();
            // opLista.ImprimirListaString(estados);
       
       
        
        // ----------------- Array ---------------- 

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int [5] {2, 9, 18, 7, 10};
            // int[] arrayCopia = new int [10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // int valorProcurado = 7;

            // System.Console.WriteLine($"Capacidade antiga do array: {array.Length} ");

            // op.RedimensionarArray(ref array, 20);

            // System.Console.WriteLine($"Capacidade atual (após redimensionar) do array: {array.Length} ");



            // int indiceValor = op.ObterIndice(array, valorProcurado);

            // if(indiceValor > -1)
            // {
            //     System.Console.WriteLine("O índice do elemento {0} é {1}", valorProcurado, indiceValor);
            // }
            // else
            // {
            //     System.Console.WriteLine("O valor {0} não existe no array!", valorProcurado);
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // }
            // else{
            //     System.Console.WriteLine("Valor não encontrado!");
            // }
            
            
            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Algum valor que não é maior que {0}", valorProcurado);
            // }


            // bool existe = op.Existe(array, valorProcurado);

            // if(existe)
            // {
            //     System.Console.WriteLine($"Encontrei o valor {valorProcurado}.");
            // }
            // else
            // {
            //     System.Console.WriteLine($"O valor {valorProcurado} não foi encontrado!");
            // }
            
            // System.Console.WriteLine("Array Original:");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array Ordenado:");
            // op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia");
            // op.ImprimirArray(arrayCopia);

            // System.Console.WriteLine("Array depois da cópia");
            // op.CopiarArray(ref array, ref arrayCopia);
            // op.ImprimirArray(arrayCopia);

            
            //     int[,] matriz = new int[4,2]
            //     {
            //         {2, 3},
            //         {5, 7},
            //         {11, 13},
            //         {17, 19}
            //     };

            //    for (int i = 0; i < matriz.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matriz.GetLength(1); j++)
            //        {
            //            System.Console.Write($"matriz[{i}][{j}] = {matriz[i,j]}\t");
            //        }
            //        System.Console.Write("\n");
            //    } 
            
                
                
                // int[] arrayInteiros = new int[3];

                // arrayInteiros[0] = 2;
                // arrayInteiros[1] = 3;
                // arrayInteiros[2] = 5;

                // for (int i = 0; i < arrayInteiros.Length; i++)
                // {
                //     System.Console.WriteLine($"Array[{i}] = {arrayInteiros[i]}\n");
                // }

                // foreach (var item in arrayInteiros) //Onde
                // {
                //     System.Console.Write($"{item} ");
                // }
            }
    }
}
