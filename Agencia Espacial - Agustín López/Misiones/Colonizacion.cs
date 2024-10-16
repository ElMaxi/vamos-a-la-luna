using Agencia_Espacial___Agustín_López.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Espacial___Agustín_López.Misiones
{
     class Colonizacion : Mision
    {
        public int Colonos { get; private set; }

        public Colonizacion(int colonos, string NombreMision, Destino destinoMision, int CantidadAstronautas) : base(NombreMision, destinoMision, CantidadAstronautas)
        {
            Colonos = colonos;

        }

        public override double CalcularDuracion()
        {
            return CantidadAstronautas * 1.5 + Colonos * 1.5 + (int)DestinoMision * 2;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, {NombreMision} {DestinoMision}, {CantidadAstronautas}";
        }
    }
}
