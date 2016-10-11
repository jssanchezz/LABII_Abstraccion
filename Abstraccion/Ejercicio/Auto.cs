using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public abstract class Auto:Vehiculo
    {
        public int cantPuertas;

        public Auto(string patente)
            : base(patente)
        {
        }

        public override string MostrarDatos()
        {
            StringBuilder mySb = new StringBuilder();
            mySb.AppendLine(base.MostrarDatos());
            mySb.AppendLine("Auto");
            mySb.AppendLine(this.cantPuertas.ToString());
            return mySb.ToString();
        }

        /*public override float CalcularCosto()
        {
            return 7f;
        }*/
    }
}
