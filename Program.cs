using System;
using poo_heranca_interface.Funcionarios;

namespace poo_heranca_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
        }

        public static void CalcularBonificacao(){
            var gerenciarBonificacao = new GerenciadorBonificacao();

            var pedro = new Designer(3000, "000.000.000-00");
            pedro.Nome = "Pedro";

            var roberta = new Diretor(5000, "111.111.111-11");
            roberta.Nome = "Roberta";

            var igor = new Auxiliar(2000, "222.222.222-22");
            igor.Nome = "Igor";

            var camila = new GerenteDeConta(4000, "333.333.333-33");
            camila.Nome = "Camila";

            gerenciarBonificacao.Registrar(pedro);
            gerenciarBonificacao.Registrar(roberta);
            gerenciarBonificacao.Registrar(igor);
            gerenciarBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " 
            + gerenciarBonificacao.GetTotalBonificacao());
        }
    }
}
