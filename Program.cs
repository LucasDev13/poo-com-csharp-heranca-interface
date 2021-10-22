using System;
using poo_heranca_interface.Funcionarios;

namespace poo_heranca_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new GerenciadorBonificacao();

            var funcionarioCarlos = new Funcionario(2000, "000.000.000-00");

            funcionarioCarlos.Nome = "Carlos";

            funcionarioCarlos.AumentarSalario();
            Console.WriteLine("Novo salario do Carlos: " + funcionarioCarlos.Salario);

            var diretorRoberta = new Diretor(5000, "111.111.111-11");
            diretorRoberta.Nome = "Roberta";

            diretorRoberta.AumentarSalario();
            Console.WriteLine("Novo salario do Roberta: " + diretorRoberta.Salario);

            gerenciador.Registrar(funcionarioCarlos);

            gerenciador.Registrar(diretorRoberta);

            Console.WriteLine(funcionarioCarlos.Nome);
            Console.WriteLine(funcionarioCarlos.GetBonificacao());

            Console.WriteLine(diretorRoberta.Nome);
            Console.WriteLine(diretorRoberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

        }
    }
}
