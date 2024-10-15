using Agencia_Espacial___Agustín_López.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Espacial___Agustín_López
{
    public abstract class Mision
    {
        public string NombreMision { get; set; }
        public Planetas DestinoMision { get; set; }
        public int CantidadAstronautas;

            public Mision(string nombreMision, Planetas destinoMision, int cantidadAstronautas)
        {
            NombreMision = nombreMision;
            DestinoMision = destinoMision;
            CantidadAstronautas = cantidadAstronautas;
        }


        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {NombreMision}, Destino: {DestinoMision}, Cantidad de astronautas: {CantidadAstronautas}");
        }

        public abstract double CalcularDuracion()
        {

        }
            public abstract string ToString()
        {

        }
    }
}
