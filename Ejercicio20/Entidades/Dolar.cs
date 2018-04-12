using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private float cotizRespectoDolar;

        private Dolar();

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
            :this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            

        }

        public static explicit operator Pesos(Dolar d)
        {

        }

        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return d;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            
        }

        public static bool operator !=(Dolar d, Pesos p)
        {

        }
        
        public static bool operator !=(Dolar d1, Dolar d2)
        {

        }

        public static Dolar operator -(Dolar d, Euro e)
        {

        }

        public static Dolar operator -(Dolar d, Pesos p)
        {

        }
        
        public static Dolar operator +(Dolar d, Euro e)
        {

        }

        public static Dolar operator +(Dolar d, Pesos p)
        {

        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;

            Dolar aux = 1.3642;

            if (1)
            {
                
            }
        }

        public static bool operator ==(Dolar d, Pesos p)
        {

        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {

        }
    }
}
