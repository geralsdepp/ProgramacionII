using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballoDeFuerza;

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia) { }

        public AutoF1(short numero, string escuderia, short caballoDeFuerza)
            :this(numero, escuderia)
        {
            this.CaballoDeFuerza = caballoDeFuerza;
        }

        public short CaballoDeFuerza
        {
            get { return this.caballoDeFuerza; }
            set { this.caballoDeFuerza = value; }
        }
        

        public override string MostrarDatos()
        {
            return String.Format(base.MostrarDatos() + "Caballos de Fuerza: {0}\n", this.CaballoDeFuerza);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;

            if (a1.CaballoDeFuerza == a2.CaballoDeFuerza)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
