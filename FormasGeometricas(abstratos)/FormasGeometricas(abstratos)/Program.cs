using System;
using System.Collections.Generic;
using System.Globalization;


namespace FormasGeometricas_abstratos_
{
    class Program
    {
        static void Main(string[] args)
        {
            
                List<Forma> list = new List<Forma>();
                Console.WriteLine("Entre com o número de formas: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Forma #{i}:");
                    Console.Write("Retangulo ou Circulo (R/C? ");
                    char ch = char.Parse(Console.ReadLine());
                    Console.Write("Cor: (Preto/Azul/Vermelho): ");
                    Cor cor = Enum.Parse<Cor>(Console.ReadLine());
                    if (ch == 'R')
                    {
                        Console.Write("Largura: ");
                        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Altura: ");
                        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Retangulo(largura, altura, cor));
                    }
                    else
                    {
                        Console.WriteLine("Raio: ");
                        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Circulo(raio, cor));
                    }

                    Console.WriteLine();
                    Console.WriteLine("Área de cada forma: ");
                    foreach (Forma forma in list)
                    {
                        Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
        }
    }

