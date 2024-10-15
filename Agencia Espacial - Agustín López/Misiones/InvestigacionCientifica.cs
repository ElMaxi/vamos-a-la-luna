using Agencia_Espacial___Agustín_López.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Espacial___Agustín_López.Misiones
{
    class InvestigacionCientifica : Mision
    {
        private string CampoInvestigacion { get; set; }

        public InvestigacionCientifica(int colonos, string NombreMision, Planetas destinoMision, int CantidadAstronautas, string campoInvestigacion) : base(NombreMision, destinoMision, CantidadAstronautas)
        {   CampoInvestigacion = campoInvestigacion;      }

        public override double CalcularDuracion()
        {
            return CantidadAstronautas * 1.5 + (int)DestinoMision * 1.5;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, {NombreMision} {DestinoMision}, {CantidadAstronautas}, {CampoInvestigacion}";
        }
    }
}

