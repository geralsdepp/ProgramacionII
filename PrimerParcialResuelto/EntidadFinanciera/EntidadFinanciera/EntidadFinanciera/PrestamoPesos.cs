using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos:Prestamo
    {
        private float porcentajeInteres;

        public float Interes 
        { 
            get { return this.CalcularInteres(); }         
        }

        //Calculara y retornara el total del prestamo (cant de dinero prestado + intereses)
        private float CalcularInteres()
        {
            float total = 0;
            float interes;

            interes = base.Monto * (this.porcentajeInteres / 100);
            total = base.Monto + interes;
            return total;
        }

        /* se deberá aplicar un incremento del 0.25% al interés
           original por cada día de extendido el plazo y se actualizará la fecha original de vencimiento a
           la nueva fecha*/
        public override void ExtenderPlazo(DateTime nuevoVencimmiento)
        {
            //obtengo el numero de dias extendido el plazo con la resta  y por cada dia aumento un 0.25
            this.porcentajeInteres += ((float)(nuevoVencimmiento - base.Vencimiento).Days) * 25 / 100;
            base.Vencimiento = nuevoVencimmiento;
        }

        public override string Mostrar()
        {
            StringBuilder SBuilder = new StringBuilder();

            SBuilder.Append(base.Mostrar());
            SBuilder.AppendFormat("Porcentaje Interes: {0}\n",this.porcentajeInteres);
            SBuilder.AppendFormat("Interes: {0}\n", Interes);
            return SBuilder.ToString();
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            :base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) 
            : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres) { }
    }
}
