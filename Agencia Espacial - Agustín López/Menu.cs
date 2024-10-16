using Agencia_Espacial___Agustín_López.enums;
using Agencia_Espacial___Agustín_López.Misiones;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Agencia_Espacial___Agustín_López
{
    static public class Menu
    {
        private static List<Action> acciones = new List<Action>
        {
            AgregarMision,
            MostrarMenu,
            ModificarMision,
            EliminarMision
        };
        
        
        static bool salir = false;
        

        
        static public void AgregarMision()
        {
            Console.WriteLine($"Ingrese el nombre de la misón: ");
            string nombre = Console.ReadLine();
            Destino destinoSeleccion = 0;
            Console.WriteLine($"Seleccione el destino\n");
            foreach (var destino in Enum.GetValues(typeof(Destino)))
            {
                Console.WriteLine($"{(int)destino}. {(string)destino}");
                destinoSeleccion = (Destino)destino;
            }
            


            Console.WriteLine($"Defina cuantos astronautas han de abordar:  ");
            int CantidadAstronautas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Elija un tipo de misión respectivo: ");
            int tipoMision = int.Parse(Console.ReadLine());
            Mision NuevaMision = null;
            switch (tipoMision)
            {
                case 1:
                    {
                        Console.WriteLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Ingrese la cantidad de colonos: ");
                        int colonos = int.Parse(Console.ReadLine());
                        NuevaMision = new Colonizacion(colonos, nombre, destinoSeleccion, CantidadAstronautas);
                        break;
                    } 
                case 3:
                    {
                        Console.WriteLine($"Ingrese el campo de investigación: ");
                        string campo = Console.ReadLine();
                        NuevaMision = new InvestigacionCientifica(nombre, destinoSeleccion, CantidadAstronautas, campo);
                        break;
                        
                    }
            }
            GestionMisiones.AgregarMision(NuevaMision);
        }
        public static void MostrarMenu()
        {
            while (!salir)
            {
                Console.WriteLine($"\n -- Menú de misiones ---\n");
                Console.WriteLine($"1. Agregar Mision\n 2. Mostrar Misiones\n 3. Modificar Mision\n 4. Eliminar Mision\n 5. Salir\n");
                Console.WriteLine($"Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (int.TryParse(opcion, out int indice) && indice >= 1 && indice <= acciones.Count+1)
                {
                   
                    if ( indice == 5)
                    {
                        salir = true;
                    }
                    else
                    {
                        acciones[indice - 1].Invoke();
                        Console.WriteLine($"No hay misiones para mostrar.\n");
                        salir = true;
                    }
                }
                else {
                    Console.WriteLine($"No hay misiones para mostrar");
                    salir = true;
                }
            }
            
        }
        
        static public void ModificarMision()
        {

        }
        static public void EliminarMision()
        {

        }
    }
}
