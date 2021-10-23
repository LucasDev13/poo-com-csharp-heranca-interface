using poo_heranca_interface.Sistema;

namespace poo_heranca_interface.Comercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha {get; set;}
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}