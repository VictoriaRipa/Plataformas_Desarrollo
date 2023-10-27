using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true; // declara una variable booleana para controlar si el programa sigue
           do
            { // bucle do-while
                Console.WriteLine("Menú: "); 
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
        
            Console.WriteLine("\nElige una operacion (1,2,3,4): ");
            
            int numero = int.Parse(Console.ReadLine()); // se almacena en la variable numero
                switch (numero) // un switch para que el usuario elija que operacion quiere ejecutar
                {
                    case 1:
                        int numero1 = 10;
                        int numero2 = 5;
                        int suma = numero1 + numero2;
                        Console.WriteLine("\nLa suma es: " + suma);
                        break;

                    case 2:
                        int num1 = 10;
                        int num2 = 5;
                        int resta = num1 - num2;
                        Console.WriteLine("\nLa resta es " + resta);
                        break;

                    case 3:
                        int nu1 = 6;
                        int nu2 = 3;
                        int producto = nu1 * nu2;
                        Console.WriteLine("\nEl producto es " + producto);
                        break;

                    case 4:
                        int n1 = 6;
                        int n2 = 3;
                        int division = n1 / n2;
                        Console.WriteLine("\nLa division es: " + division);
                        break;

                    default:
                        Console.WriteLine("\nOperacion invalida, ingrese un numero del 1 al 4");
                        break;
                }
                Console.Write("\n¿Desea realizar otra operación? (Si/No): ");
                string respuesta = Console.ReadLine(); // se le pregunta al usuario si desea realizar otra operación y su respuesta se almacena en la variable respuesta

                if (respuesta.ToLower() != "si")
                { // verifica si la respuesta del usuario no es igual a "si", si es así, se cambia el valor de continuar a false, lo que hace que el bucle do-while termine
                 continuar = false;
                }

            } while (continuar); // se repetirá siempre que la variable continuar sea true,
        }
    }
        }