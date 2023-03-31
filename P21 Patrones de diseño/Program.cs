//Singleton
//EJ lo usamos para un logger

using P21_Patrones_de_diseño.Factory;

Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

if (s1 == s2)
{
    System.Console.WriteLine("Singleton funciona");
}
else
{
    System.Console.WriteLine("Singleton fallo. las instancias son distintas !");
}

//Factory

new Cliente().Main();

//DEFINICION
class Cliente {
    public void Main()
    {
        System.Console.WriteLine("Probando Factory");
        ClienteMetodo(new P21_Patrones_de_diseño.Factory.ConcretoFactory1());
        System.Console.WriteLine();
    }
    public void ClienteMetodo(IAbstractFactory factory)
    {
        var ProductA = factory.CreateProductA();
        System.Console.WriteLine(ProductA.MetodoA());
    }
}

