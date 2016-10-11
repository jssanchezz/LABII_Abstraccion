using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public abstract class Vehiculo
    {
        public string patente;

        public override string ToString()
        {
            return this.patente;
        }

        public Vehiculo(string patente)
        {
            this.patente = patente;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder mySb = new StringBuilder();
            mySb.AppendLine("Vehiculo");
            mySb.AppendLine(this.patente);
            return mySb.ToString();
        }

        public abstract float CalcularCosto();
        
    }
}
