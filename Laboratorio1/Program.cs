using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de tipo Vehiculo llamada vehiculos
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            //Objeto de tipo Automovil y agregarlo a la lista "vehiculos"
            Automovil autoLista = new Automovil("Toyota", "Etios", 2022, "Gas");
            vehiculos.Add(autoLista);

            //Objeto de tipo Camion y agregarlo a la lista "vehiculos"
            Camion camionLista = new Camion("Kia", "SportStage", 2022, 5.5);
            vehiculos.Add(camionLista);

            //Objeto tipo Automovil
            Automovil auto = new Automovil("Toyota", "Yaris", 2023, "Gasolina");

            //Objeto tipo Camion
            Camion camion = new Camion("Ford", "F-200", 2023, 2.5);

            //Objeto tipo Flota
            Flota flota = new Flota();


            //Agregando los objetos a la lista de Flota
            flota.AgregarVehiculo(auto);
            flota.AgregarVehiculo(camion);
                
            Console.WriteLine("Informacion de la Flota:");
            flota.MostrarFlota();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Mostrar Información de Vehículos");
                Console.WriteLine("2. Calcular Costo de Viaje");
                Console.WriteLine("3. Salir");
                Console.Write("Ingrese el número de la opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        flota.MostrarFlota();
                        Console.WriteLine();
                        break;
                    case "2":
                        flota.CalcularCostoViaje();
                        Console.WriteLine();
                        break;
                    case "3":
                        salir = true;
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
        }
    }
}
