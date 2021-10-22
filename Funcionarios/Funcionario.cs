namespace poo_heranca_interface.Funcionarios
{
    public class Funcionario
    {
        //propriedade staytica compartilhada com todos os objetos.
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private  set; }
        public double Salario { get; set; }

        public Funcionario(string cpf)
        {
            //conta as instancias dos objetos a cada inicialização.
            TotalDeFuncionarios++;
            CPF = cpf;
        }

        public virtual double GetBonificacao(){
           return Salario * 0.10;
        }
        
    }
}