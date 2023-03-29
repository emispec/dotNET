//INDIZADORES -> INDEXADORES
//nos permite acceder a una estructura de datos de tipo matriz.

var TemperaturasDiarias = new Temperaturas();

//actulaizando valores del registro
TemperaturasDiarias[3] = 11.5f;
TemperaturasDiarias[9] = 7.5f;

var semana = new DiasSemana();
Console.WriteLine(semana["lun"]);

try
{
    System.Console.WriteLine(semana["ASDF"]);
}
catch (ArgumentOutOfRangeException e)
{
    System.Console.WriteLine(e.Message);
}


//ver los datos
for (int i = 0; i < TemperaturasDiarias.len; i++)
{
    System.Console.WriteLine($"Item: {TemperaturasDiarias[i]}");
}

public class Temperaturas
{
    float[] temp = new float[10]
    {
        10f , 11f, 12f, 11f, 9f,
        8f, 10f, 15f, 10f, 11f
    };

    public int len => temp.Length;

    //indizador
    public float this[int index]
    {
        get => temp[index];
        set => temp[index] = value;
    }
}

class DiasSemana
{
    public string[] dias = {
        "lun", "mar", "mie", "jue", "vie", "sab", "dom"
    };
    public int this[string dia] => FindDayIndex(dia);

    private int FindDayIndex(string dia)
    {
        for (int j = 0; j < dias.Length; j++)
        {
            if (dias[j] == dia)
            {
                return j;
            }
        }
        throw new ArgumentOutOfRangeException(nameof(dia), $"El dia {dia} no esta en la lista. Comprueba si esta bien escrito.");
    }
}