using System;

namespace Tarea_3_Caso_3_Progra_2_UH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float gradosCelsius;
            float gradosFahrenheit;
            bool datoEsValido = false;

            do
            {
                Console.WriteLine("Digite los grados Celsius:");

                datoEsValido = float.TryParse(Console.ReadLine(), out gradosCelsius);//esta linea la conoci/comprendi investigando
                                                                                     //es la forma que encontre para verificar que el dato que ingresa el usuario no es de otro tipo
                                                                                     //lo que entendi es que TryParse intenta convertir lo que escribió el usuario a float, pero en vez de lanzar un error si no puede, devuelve true o false.

                if (datoEsValido != true)
                {
                    Console.WriteLine("Dato inválido");
                }

            } while (datoEsValido == false);

            // Calcular grados Fahrenheit
            gradosFahrenheit = (gradosCelsius * 9 / 5) + 32;

            // Mostrar los resultados
            Console.WriteLine("\n--- CONVERSION DE LOS GRADOS ---");
            Console.WriteLine(gradosCelsius + " grados Celsius es igual a " + gradosFahrenheit + " grados Fahrenheit");

            Console.Read();
        }
    }
}