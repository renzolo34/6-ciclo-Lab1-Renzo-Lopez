using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Vehiculo
    {
        private string marca { get; set; }
        private string modelo { get; set; }
        private int año { get; set; }

        public Vehiculo(string marca, string modelo, int año) 
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
        }

        // Método virtual para mostrar información del vehículo
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Año: {año}");
        }
    }
}
