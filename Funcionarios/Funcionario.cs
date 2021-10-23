namespace poo_heranca_interface.Funcionarios
{
    public abstract class Funcionario
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

        public abstract void AumentarSalario();
        public abstract double GetBonificacao(); 
        
    }
}