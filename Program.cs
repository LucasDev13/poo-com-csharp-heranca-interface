using System;
using poo_heranca_interface.Funcionarios;

namespace poo_heranca_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new GerenciadorBonificacao();

            var funcionarioCarlos = new Funcionario("000.000.000-00");

            funcionarioCarlos.Nome = "Carlos";
            funcionarioCarlos.Salario = 2000;

            var diretorRoberta = new Diretor("111.111.111-11");
            diretorRoberta.Nome = "Roberta";
            diretorRoberta.Salario = 5000;


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
