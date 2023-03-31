using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P21_Patrones_de_diseño.Factory
{
    public interface IConcretoProductA2 : IAbstractProductA
    {
        public string MetodoA()
        {
            return "Desde MetodoA en ConcretoProductA2";
        }
    }
}