using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Camion: Vehiculo
    {
        private double capacidadCarga { get; set; }
        public Camion(string marca, string modelo, int año, double capacidadCarga) : base(marca, modelo, año)
        {
            this.capacidadCarga = capacidadCarga;
        }

        // Sobrescribe el método MostrarInformacion para mostrar información específica de Camion
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();  // Llama al método de la clase base para mostrar detalles comunes
            Console.WriteLine($"Capacidad de Carga: {capacidadCarga} toneladas");
        }

    }
}
