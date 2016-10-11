using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Avion:Vehiculo,Iafip
    {
        public Avion(string patente)
            : base(patente)
        {
        }

        public override float CalcularCosto()
        {
            return 1500f;
        }

        public float RetornarImpuesto()
        {
            return 200f;
        }
    }
}
