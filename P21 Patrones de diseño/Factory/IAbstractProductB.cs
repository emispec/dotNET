using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P21_Patrones_de_diseño.Factory
{
    public interface IAbstractProductB
    {
        string MetodoB();
        string OtroMEtodoB(IAbstractProductA colaborador);
    }
}