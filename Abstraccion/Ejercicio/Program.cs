using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo unVehiculo = new Vehiculo("FRT 123");
            //Auto unAuto = new Auto("ASD 111");
            //unAuto.cantPuertas = 4;
            //Console.WriteLine(unVehiculo.MostrarDatos());
            //Console.WriteLine(unAuto.MostrarDatos());

            Familiar autoFamiliar = new Familiar("ASD 123");
            Deportivo autoDeportivo = new Deportivo("ZXC 321");
            Carreta unaCarreta = new Carreta("SSDFG");
            Avion unAvion = new Avion("1235 A");

            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            listaVehiculos.Add(autoDeportivo);
            listaVehiculos.Add(autoFamiliar);
            listaVehiculos.Add(unaCarreta);
            listaVehiculos.Add(unAvion);

            foreach (Vehiculo item in listaVehiculos)
            {
                Console.WriteLine(item.CalcularCosto());
            }

            List<Iafip> listaIafip = new List<Iafip>();
            listaIafip.Add(autoDeportivo);
            listaIafip.Add(unAvion);

            foreach (Iafip item in listaIafip)
            {
                Console.WriteLine(item.RetornarImpuesto());
            }

            Console.ReadKey();
        }
    }
}
