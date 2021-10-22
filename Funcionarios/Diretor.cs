using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_heranca_interface.Funcionarios
{
    public class Diretor : Funcionario{
        public override double GetBonificacao(){
            return Salario + base.GetBonificacao();
        }
    }
}