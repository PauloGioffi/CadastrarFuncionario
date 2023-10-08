using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarFuncionario
{
    internal class Empresa
    {
        public Funcionario Funcionario { get; set; }
        public int Matricula { get; set; }
        public string Cargo { get; set; }
        public DateOnly DataContratacao { get; set; }
        private double salariomensal;
        public double SalarioMensal
        {
            get
            {
                return salariomensal;
            }
            set
            {
                if (value < 1320.00)
                {
                    salariomensal = 1320.00;
                }
                else salariomensal = value;
            }
        }

        public Empresa(Funcionario funcionario, int matricula, string cargo, DateOnly dataContratacao, double salarioMensal)
        {
            this.Funcionario = funcionario;
            this.Matricula = matricula;
            this.Cargo = cargo;
            this.DataContratacao = dataContratacao;
            this.SalarioMensal = salarioMensal;
        }
        public void PromoverEmpregado(string nome, string sobrenome, string cargo, double salario)
        {
            Cargo = cargo;
            salariomensal = salario;

            Console.WriteLine($"O funcionário {nome}" + $" {sobrenome} foi promovido para o cargo de {Cargo} com sucesso!");
        }
        public void DemitirEmpregado(string nome, string sobrenome)
        {
            Console.WriteLine($"O funcionário {nome}" + $" {sobrenome} foi desligado da empresa.");
        }
        public void ReajusteSalarial()
        {
            salariomensal += (salariomensal*0.1);
        }
        public void ListarSalarioAnual()
        {
            Console.WriteLine($"O salário anual do colaborador {Funcionario.Nome} {Funcionario.Sobrenome} é: R$ {salariomensal * 13}");
        }
    }
}
