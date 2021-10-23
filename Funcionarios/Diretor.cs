using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poo_heranca_interface.Sistema;

namespace poo_heranca_interface.Funcionarios
{
    public class Diretor : Autenticavel{

        public Diretor(double salario, string cpf):base(salario, cpf){
        }
        //Override do método GetBonificação
        public override double GetBonificacao(){
            return Salario * 0.50;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}