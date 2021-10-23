using System;
using poo_heranca_interface.Sistema;

namespace poo_heranca_interface.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf): base(salario, cpf){
            
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}