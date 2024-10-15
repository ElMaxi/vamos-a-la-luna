using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Espacial___Agustín_López
{
    static class GestionMisiones
    {
        static List<Mision> Misiones = new();
        static string ArchivoMisiones = "ArchivoMisiones.txt";

        static void AgregarMision(Mision Mision) => Misiones.Add(Mision);
        static void QuitarMision(Mision Mision) => Misiones.Remove(Mision);
        static public void ModificarMision(string nombre)
        {
            var j = Misiones.FirstOrDefault(j => nombre.Equals(j));

            


        }
        static public void MostrarMisiones()
        {
            foreach (Mision Mision in Misiones)
            {
                Mision.MostrarDetalles();
                Console.WriteLine($"\n");
            }
        }

        static public void GuardarDatos()
        {


        }
        //CargarDatos,   GuardarDatos


    }
}
