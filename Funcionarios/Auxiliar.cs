using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_heranca_interface.Funcionarios
{
    public class Auxiliar : Funcionario{

        public Auxiliar(double salario, string cpf):base(salario, cpf){
        }
        //Override do método GetBonificação
        public override double GetBonificacao(){
            return Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}