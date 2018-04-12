using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private float cotizRespectoDolar;

        private Euro();

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
            :this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro e)
        {
            

        }

        public static explicit operator Pesos(Euro e)
        {

        }

        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }

        public static implicit operator Euro(double d)
        {
            return d;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            
        }

        public static bool operator !=(Euro e, Dolar d)
        {

        }
        
        public static bool operator !=(Euro e1, Euro e2)
        {

        }

        public static Pesos operator -(Euro e, Pesos p)
        {

        }

        public static Pesos operator -(Euro e, Dolar d)
        {

        }
        
        public static Pesos operator +(Euro e, Pesos p)
        {

        }

        public static Pesos operator +(Euro e, Dolar d)
        {

        }

        public static bool operator ==(Euro e, Pesos p)
        {
            
        }

        public static bool operator ==(Euro e, Dolar d)
        {

        }

        public static bool operator ==(Euro e1, Euro e2)
        {

        }
    }
}
