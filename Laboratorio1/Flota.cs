using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Flota
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }
        public void MostrarFlota()
        {
            foreach (var vehiculo in vehiculos)
            {
                vehiculo.MostrarInformacion();
                Console.WriteLine();
            }
        }
        public void CalcularCostoViaje()
        {
            //calcular el costo de un viaje
            Console.WriteLine("Ingrese los detalles del viaje y calcule el costo.");

            Console.WriteLine("El costo del viaje ha sido calculado.");
        }
    }
}
