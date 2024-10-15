using Agencia_Espacial___Agustín_López.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Espacial___Agustín_López.Misiones
{
    public  class Exploracion : Mision
    {
        public Exploracion(string NombreMision, Planetas destinoMision, int CantidadAstronautas) : base(NombreMision, destinoMision, CantidadAstronautas) { }
       
        public override double CalcularDuracion()
        {
            return CantidadAstronautas * 1.5 + (int)DestinoMision * 2;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, {NombreMision} {DestinoMision}, {CantidadAstronautas}";
        }
    }
    }

