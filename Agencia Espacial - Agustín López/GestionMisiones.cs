using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Espacial___Agustín_López
{
    static class GestionMisiones
    {
        static List<Mision> Misiones { get; set; } = new();
        static string ArchivoMisiones = "ArchivoMisiones.txt";

        static public void AgregarMision(Mision Mision) => Misiones.Add(Mision);
        static public void QuitarMision(Mision Mision) => Misiones.Remove(Mision);
        static public void ModificarMision(string nombre)
        {
            var j = Misiones.FirstOrDefault(j => nombre.Equals(j));

            


        }
        static public void MostrarMisiones()
        {
            if (Misiones.Count == 0)
            {
                Console.WriteLine($"No hay misiones registradas.\n");
            }
            else
            {
                Console.WriteLine($"Lista de misiones:\n");
                foreach (Mision Mision in Misiones)
                {
                    Mision.MostrarDetalles();
                    Console.WriteLine($"\n");
                }
            }
        }

        static public void ModificarMision (string nombre, Mision NuevaMision)
        {

            var mision = Misiones.Find(m => m.NombreMision == nombre);
            
            if (mision == null) { Console.WriteLine($"La mision '{nombre}' no fue encontrada."); }
            else { Misiones.Remove(mision);
                Misiones.Add(NuevaMision);
                Console.WriteLine($"Mision '{nombre}' ha sido modificada");

            }
        }
        static public void GuardarDatos()
        {


        }
        //CargarDatos,   GuardarDatos


    }
}
