using System;

namespace CourseProjectMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz: ");

            string[] tamanho = Console.ReadLine().Split(' ');

            int num1 = int.Parse(tamanho[0]);
            int num2 = int.Parse(tamanho[1]);

            int[,] matriz = new int[num1, num2];

            for (int i = 0; i < num1; i++) // linha
            {
                Console.Write("Digite os valores: ");
                string[] valor = (Console.ReadLine().Split(' '));

                for (int j = 0; j < num2; j++) // coluna
                {

                    matriz[i, j] = int.Parse(valor[j]);

                }
            }

            Console.Write("Main diagonal: ");

            for (int i = 0; i < num1; i++)
            {
                Console.WriteLine(matriz[i, i]);
            }

            // Verificador
            Console.Write("Digite o valor a ser buscado: ");
            int pesquisa = int.Parse(Console.ReadLine());


            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    if (matriz[i, j] == pesquisa)
                    {

                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (j < num2 - 1)
                        {


                            Console.WriteLine("Direita: " + matriz[i, j + 1]); ;
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + matriz[i - 1, j]);
                        }
                        if (i < num1 - 1)
                        {
                            Console.WriteLine("Baixo: " + matriz[i + 1, j]);
                        }

                    }

                }
            }

        }
    }
    
}
