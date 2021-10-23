using System;
using poo_heranca_interface.Comercial;
using poo_heranca_interface.Funcionarios;
using poo_heranca_interface.Funcionarios.Sistema;

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
            var sistemaInterno = new SistemaInterno();

            var pedro = new Designer(3000, "000.000.000-00");
            pedro.Nome = "Pedro";

            var roberta = new Diretor(5000, "111.111.111-11");
            roberta.Nome = "Roberta";

            var igor = new Auxiliar(2000, "222.222.222-22");
            igor.Nome = "Igor";

            var camila = new GerenteDeConta(4000, "333.333.333-33");
            camila.Nome = "Camila";

            var lucas = new Desenvolvedor(5000, "444.444.444-44");
            lucas.Nome = "Lucas";

            var parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "123456";

            roberta.Senha = "123";
            camila.Senha = "1234";

            sistemaInterno.Logar(parceiroComercial, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "1234");
            

            gerenciarBonificacao.Registrar(pedro);
            gerenciarBonificacao.Registrar(roberta);
            gerenciarBonificacao.Registrar(igor);
            gerenciarBonificacao.Registrar(camila);
            gerenciarBonificacao.Registrar(lucas);

            Console.WriteLine("Total de bonificações do mês: " 
            + gerenciarBonificacao.GetTotalBonificacao());
        }
    }
}
