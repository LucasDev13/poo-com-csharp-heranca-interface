using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poo_heranca_interface.Funcionarios;

namespace poo_heranca_interface.Sistema
{
    public abstract class Autenticavel: Funcionario
    {
        public string Senha {get; set;}

        //construtor
        public Autenticavel(double salario, string cpf): base(salario, cpf){}

        public bool Autenticar(string senha){
            return Senha == senha;
        }

    }
}