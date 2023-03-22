
Puerta door = new Puerta(150, 200, 300, false);
door.MostrarEstado();

Puerta door2 = new Puerta();
door2.MostrarEstado();

class Puerta 
{
    //ATRIBUTOS
    int ancho;
    int alto;
    int color;
    bool abierto;

    //CONSTRUCTOR/ES
       public Puerta() 
    {
        ancho = 400;
        alto = 800;
        color = 8989;
        abierto = true;
    }
    public Puerta (int ancho, int alto, int color, bool abierto)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
        this.abierto = abierto;
    }
    //METODOS
    public void MostrarEstado()
    {
        Console.WriteLine("{0}", ancho);
        Console.WriteLine("{0}", alto);
        Console.WriteLine("{0}", color);
        Console.WriteLine("{0}", abierto);
    }

    //DESTRUCTOR
    ~Puerta() {
        Console.WriteLine("Puerta destruida !");
    }
}