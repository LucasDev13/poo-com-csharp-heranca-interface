using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_heranca_interface.Funcionarios
{
    public class Diretor{
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao(){
           return Salario;
        }
    }
}