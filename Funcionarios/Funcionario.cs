namespace poo_heranca_interface.Funcionarios
{
    public class Funcionario
    {
        //propriedade staytica compartilhada com todos os objetos.
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private  set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            //conta as instancias dos objetos a cada inicialização.
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
        }

        public virtual void AumentarSalario(){
            Salario *= 1.1;
        }

        public virtual double GetBonificacao(){
           return Salario * 0.10;
        }
        
    }
}