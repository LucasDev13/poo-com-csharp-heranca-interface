using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poo_heranca_interface.Funcionarios;

namespace poo_heranca_interface.Sistema
{
    public interface IAutenticavel{
        bool Autenticar(string senha);
    }
}