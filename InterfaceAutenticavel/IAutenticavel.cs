using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public interface IAutenticavel
    {
        //assinatyra de método
        bool Autenticar(int senha);
    }
}