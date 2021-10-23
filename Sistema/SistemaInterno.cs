using System;

namespace poo_heranca_interface.Funcionarios.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(Funcionario funcionario, string senha){
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }else{
                Console.WriteLine("Senha incorreta!");
                return false; 
            }
        }
    }
}