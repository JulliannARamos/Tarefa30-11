using System;
using System.Collections.Generic;
using System.Text;

namespace FolhaPagamento
{
    class Funcionario
    {
        string nome;
        int horas;
        double valorHora;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public int Horas
        {
            get => horas;
            set => horas = value;
        }

        public double ValorHora
        {
            get => valorHora;
            set => valorHora = value;
        }

        public Funcionario() { }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        void pagamento()
        {

        }

        public override string ToString()
        {
            return "Nome: " + Nome
                  + "\nHoras: " + Horas
                  + "\nValor Horas: " + ValorHora
                  + "\nSalário: " + (horas * valorHora);
        }
    }
}
