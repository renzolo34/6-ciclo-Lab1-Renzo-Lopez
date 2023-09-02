using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Automovil : Vehiculo
    {
        private string combustible { get; set; }
        public Automovil(string marca, string modelo, int año, string combustible) : base(marca, modelo, año)
        {
            this.combustible = combustible;
        }

        // Sobrescribe el método MostrarInformacion para mostrar información específica de Automovil
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();  // Llama al método de la clase base para mostrar detalles comunes
            Console.WriteLine($"Combustible: {combustible}");
        }

    }
}
