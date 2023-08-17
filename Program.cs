using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //DEclaracion de variables
            // viables tipo texto con captura desde consola

            string? universidad ="";

            // Variables tipo texto con asignacion desde codigo

            string facultad ="Ingieneria y Arquitectura";
            string profesion ="Tecnico en Desarrollo de software";

            // variables entera captura desde consola

            int anioIngreso =0;

            // Declaracion de variables enteras asignando valores
            int edadIngreso =22;
            int edadEngreso =24;

            // variables double asignado valor desde consola

            double cuotaUniversidad = 0.0;

            // varibales decimales asignando valores
            double gastoTransporte =35.50;

            // captura de datos desde consola

            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("\n----------------Capturando datos de tipo texto----------------*");
            Console.WriteLine("Ingrese nombre de la universidad deone estudia >> ");
            universidad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n----------------Fin de captura de tipo texto----------------*");

            Console.WriteLine("\n----------Capturando datos de tipo entero----------*");
            Console.WriteLine("Ingrese año en que inicio la universidad >> ");
            anioIngreso=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n----------------Fin de captura de tipo entero----------------*");

            Console.WriteLine("\n----------Capturando datos de tipo decimal----------*");
            Console.WriteLine("Ingrese Su cuota de universidad >> ");
            cuotaUniversidad=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n----------------Fin de captura de tipo decimal----------------*");


            // Impresion de datos en consola
            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("\n----------------impresion de datos de tipo texto----------------*");
            Console.WriteLine("\n La universidad en la que estudia es >>" + universidad);
            Console.WriteLine("\n Pertenece a la facultad de  >>" + facultad);
            Console.WriteLine("\n Estudiando la carrera de  >>" + profesion);
            Console.WriteLine("\n***************************************************************"); 


            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("\n----------------impresion de datos enteros----------------*");
            Console.WriteLine("\n El año que ingreso a la universidad fue >>" + anioIngreso);
            Console.WriteLine("\n La edad cuando inicio sus estudios es   >>" + edadIngreso+" años");
            Console.WriteLine("\n La edad cuando finalize sus estudias sera  >>" + edadEngreso+ " años");
            Console.WriteLine("\n***************************************************************"); 


            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("\n----------------impresion de datos de tipo double----------------*");
            Console.WriteLine("\n La Cuota de su universidad es >>" + cuotaUniversidad);
            Console.WriteLine("\n Su gasto en transporte es   >>" + gastoTransporte);
            Console.WriteLine("\n***************************************************************"); 

            Console.ReadKey();

        }
    }
}