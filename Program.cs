using CadastrarFuncionario;
using System.Numerics;

namespace ExercicioemDupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario dadospessoaisColaborador1 = new("null", "null", 0, new DateOnly());
            Empresa colaborador1 = new(dadospessoaisColaborador1, 000000, "null", new DateOnly(), 00.00);
            Funcionario dadospessoaisColaborador2 = new("null", "null", 0, new DateOnly());
            Empresa colaborador2 = new(dadospessoaisColaborador2, 000000, "null", new DateOnly(), 00.00);
            Funcionario dadospessoaisColaborador3 = new("null", "null", 0, new DateOnly());
            Empresa colaborador3 = new(dadospessoaisColaborador3, 000000, "null", new DateOnly(), 00.00);

            List<Empresa> colaboradores = new();
            colaboradores.Add(colaborador1);
            colaboradores.Add(colaborador2);
            colaboradores.Add(colaborador3);

            int continuar = 1;
            while (continuar == 1)
            {
                Console.WriteLine("Selecione a opção da tarefa que deseja executar!");
                Console.WriteLine("");
                Console.WriteLine("Digite 1 para: Cadastrar funcionário.");
                Console.WriteLine("Digite 2 para: Listar todos os empregados cadastrados.");
                Console.WriteLine("Digite 3 para: Promover empregado.");
                Console.WriteLine("Digite 4 para: Demitir empregado.");
                Console.WriteLine("Digite 5 para: listar salário anual do empregado.");
                Console.WriteLine("Digite 6 para: Reajustar salário mensal.");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        foreach (var colaborador in colaboradores)
                        {
                            Console.WriteLine("Digite o nome: ");
                            colaborador.Funcionario.Nome = Console.ReadLine();
                            Console.WriteLine("Digite o sobrenome: ");
                            colaborador.Funcionario.Sobrenome = Console.ReadLine();
                            Console.WriteLine("Digite a idade: ");
                            colaborador.Funcionario.Idade = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a data de nascimento: ");
                            colaborador.Funcionario.DataNascimento = DateOnly.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a matricula: ");
                            colaborador.Matricula = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o cargo: ");
                            colaborador.Cargo = Console.ReadLine();
                            Console.WriteLine("Digite a data de contratação: ");
                            colaborador.DataContratacao = DateOnly.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o salário: ");
                            colaborador.SalarioMensal = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                        }
                        break;
                    case 2:

                        foreach (var colaborador in colaboradores)
                        {
                            Console.WriteLine(colaborador.Funcionario.Nome + " " + colaborador.Funcionario.Sobrenome);
                            Console.WriteLine(colaborador.Matricula);
                            Console.WriteLine(colaborador.Cargo);
                            Console.WriteLine(colaborador.DataContratacao);
                            Console.WriteLine(colaborador.SalarioMensal);
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        foreach (var colaborador in colaboradores)
                        {
                            Console.WriteLine("Digite a matricula do colaborador: ");
                            int matricula = int.Parse(Console.ReadLine());
                            if (matricula == colaborador.Matricula)
                            {
                                Console.WriteLine("Digite o novo cargo: ");
                                string novocargo= Console.ReadLine();
                                Console.WriteLine("Digite o novo salario: ");
                                double novosalario = double.Parse(Console.ReadLine());
                                colaborador.PromoverEmpregado(colaborador.Funcionario.Nome, colaborador.Funcionario.Sobrenome, novocargo, novosalario);
                            }
                        }
                        break;
                    case 4:
                        foreach (var colaborador in colaboradores)
                        {
                            Console.WriteLine("Digite a matricula do colaborador: ");
                            int matricula = int.Parse(Console.ReadLine());
                            if (matricula == colaborador.Matricula) {
                                colaborador.DemitirEmpregado(colaborador.Funcionario.Nome, colaborador.Funcionario.Sobrenome);
                            } 
                        }

                        break;
                    case 5:
                        foreach (var colaborador in colaboradores)
                        {
                            colaborador.ListarSalarioAnual();
                        }
                        break;
                    case 6:
                        foreach (var colaborador in colaboradores)
                        {
                            colaborador.ReajusteSalarial();
                            Console.WriteLine(colaborador.SalarioMensal);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Para sair do menu, digite 0. Se deseja continuar, digite 1:");
                continuar=int.Parse(Console.ReadLine());
            }
        }
    }
}
