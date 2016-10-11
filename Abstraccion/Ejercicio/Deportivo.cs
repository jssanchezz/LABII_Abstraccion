using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Deportivo:Auto,Iafip
    {
        public Deportivo(string patente)
            : base(patente)
        {
        }

        public override float CalcularCosto()
        {
            return 150f;
        }

        public float RetornarImpuesto()
        {
            return 15f;
        }
    }
}
