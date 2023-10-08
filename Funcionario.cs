using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarFuncionario
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set;}
        public DateOnly DataNascimento { get; set; }

        public Funcionario(string nome, string sobrenome, int idade, DateOnly dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.DataNascimento = dataNascimento;
        }


    
    }
}
