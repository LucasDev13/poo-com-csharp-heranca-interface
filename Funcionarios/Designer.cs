namespace poo_heranca_interface.Funcionarios
{
    public class Designer : Funcionario{

        public Designer(double salario, string cpf):base(salario, cpf){
        }
        //Override do método GetBonificação
        public override double GetBonificacao(){
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}