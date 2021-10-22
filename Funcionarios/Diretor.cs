using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_heranca_interface.Funcionarios
{
    public class Diretor : Funcionario{

        public Diretor(double salario, string cpf):base(salario, cpf){
        }
        //Override do método GetBonificação
        public override double GetBonificacao(){
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}