using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poo_heranca_interface.Funcionarios;

namespace poo_heranca_interface
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        //Sobrecarga de método do método registrar.
        public void Registrar(Funcionario funcionario){
            _totalBonificacao += funcionario.GetBonificacao();
        }
        public double GetTotalBonificacao(){
            return _totalBonificacao;
        }                               
        
    }
}