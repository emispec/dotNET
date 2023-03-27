using System.Security.AccessControl;
//Conseguir JSON de API y usar contenido.

//importamos libreria
using System.Net;

//pedir el dato: Request peticion al servidor del api.
HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://cat-fact.herokuapp.com/facts");

//utilizar el dato: Response guardamos los datos que obtenemos de la peticion.
HttpWebResponse response = (HttpWebResponse)request.GetResponse();

//cramos el Stream
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);

//guardamos en esta variable la lectura del json
var json = reader.ReadToEnd();
Console.WriteLine(json);

//WebRequest esta obsoleto. Usar en su lugar: HttpClient
/*
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program {
    static async Task Main(string[] args) {
        using (var client = new HttpClient()) {
            // Hacer una solicitud GET a la API
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
            
            // Obtener el contenido de la respuesta como una cadena de texto
            var content = await response.Content.ReadAsStringAsync();
            
            // Deserializar el JSON en un objeto dinámico
            dynamic data = JsonConvert.DeserializeObject(content);
            
            // Mostrar algunos datos del objeto JSON en la consola
            Console.WriteLine("Título: " + data.title);
            Console.WriteLine("Contenido: " + data.body);
        }
    }
}
*/
