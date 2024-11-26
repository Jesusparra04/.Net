/*Fecha de creacion: 26/11/2024
 Prueba tecnica
 Autor: Jesus David Parra Chamorro
 Descripcion: Crea una aplicación de consola que realice la conversión de pesos colombianos (COP) a dólares estadounidenses (USD) y euros (EUR).

*/

using System;

class Convertidor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos al convertidor de pesos colombianos a dolares y euros");
        //Solicitar la cantidad en pesos colombianos
        double pesos;
        Console.Write("Ingrese la cantidad en pesos colombianos: ");
        //Validacion de posibles entradas erroneas
        while (!double.TryParse(Console.ReadLine(), out pesos))
        {
            Console.WriteLine("Por favor, ingrese un numero valido.");
            Console.Write("Ingrese la cantidad en pesos colombianos: ");
        }
        //Se realizan las conversiones directamente
        double dolares = pesos / 4000.0;
        double euros = pesos / 4500.0;

        //Mostrar los resultados con dos decimales
        Console.WriteLine($"{pesos} COP son: ");
        Console.WriteLine($"{dolares:F2} USD (DOLARES) ");
        Console.WriteLine($"{euros:F2} EUR  (EUROS): ");
         Console.WriteLine("Gracias por usar el convertidor de monedas.");


    }
}
    
