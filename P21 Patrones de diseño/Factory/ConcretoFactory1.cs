using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P21_Patrones_de_diseño.Factory
{
    public class ConcretoFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcretoProductA1();
        }

        public IAbstractProductB createProductB()
        {
            return new ConcretoProductB1();
        }

        IAbstractProductA IAbstractFactory.CreateProductA()
        {
            throw new NotImplementedException();
        }

        IAbstractProductB IAbstractFactory.CreateProductB()
        {
            throw new NotImplementedException();
        }
    }
}