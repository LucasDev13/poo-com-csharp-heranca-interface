using System;
using poo_heranca_interface.Funcionario;

namespace poo_heranca_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionarioCarlos = new Funcionario(1);

            funcionarioCarlos.Nome = "Carlos";
            funcionarioCarlos.CPF = "000.000.000-00";
            funcionarioCarlos.Salario = 2000;

            Console.WriteLine(funcionarioCarlos.Nome);
            Console.WriteLine(funcionarioCarlos.GetBonificacao());

            Console.ReadLine();

            
        }
    }
}
