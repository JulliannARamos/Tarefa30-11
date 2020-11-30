using System;
using System.Collections.Generic;

namespace FolhaPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
           
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Digite a quantidade de Funcionário: ");
            count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Funcionario funcionario = new Funcionario();

                Console.WriteLine("Digite o nome do Funcionário: ");
                funcionario.Nome = Console.ReadLine();

                Console.WriteLine("Digite quantas horas trabalhada: ");
                funcionario.Horas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite valor por horas trabalha: ");
                funcionario.ValorHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Funcionário é tercerizado? (Sim/Não): ");
                string confirma = Console.ReadLine();

                if (confirma == "Sim")
                {
                    Terceirizados funcionarioTercerizado = new Terceirizados(funcionario.Nome, funcionario.Horas, funcionario.ValorHora);
                    Console.WriteLine("Digite o valor do adicional: ");
                    funcionarioTercerizado.Adicional = double.Parse(Console.ReadLine());
                    funcionarios.Add(funcionarioTercerizado);
                }
                else
                {
                    funcionarios.Add(funcionario);
                }
            }

            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
