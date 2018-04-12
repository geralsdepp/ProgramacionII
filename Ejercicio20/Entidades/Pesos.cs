using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private float cotizRespectoDolar;

        private Pesos();

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
            :this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Pesos p)
        {
            

        }

        public static explicit operator Euro(Pesos p)
        {

        }

        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            return d;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            
        }

        public static bool operator !=(Pesos p, Dolar d)
        {

        }
        
        public static bool operator !=(Pesos p1, Pesos p2)
        {

        }

        public static Pesos operator -(Pesos p, Euro e)
        {

        }

        public static Pesos operator -(Pesos p, Dolar d)
        {

        }
        
        public static Pesos operator +(Pesos p, Euro e)
        {

        }

        public static Pesos operator +(Pesos p, Dolar d)
        {

        }

        public static bool operator ==(Pesos p, Euro e)
        {
            
        }

        public static bool operator ==(Pesos p, Dolar d)
        {

        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {

        }
    }
}
