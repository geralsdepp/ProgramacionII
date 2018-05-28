using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross:VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Cilindrada: " + this.Cilindrada + "\n");
            return sb.ToString();
        }

        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia) { }

        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool retorno = false;

            if (m1.Cilindrada == m2.Cilindrada)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
