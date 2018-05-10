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

        private float CalcularInteres()
        {
            float total = 0;
            total = (base.Monto * (this.porcentajeInteres/100)) + base.Monto;
            return total;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.porcentajeInteres += (float)(nuevoVencimiento - base.Vencimiento).Days * (float)0.25/100;
            base.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat("PorcentajeInteres: {0}\n", this.porcentajeInteres);
            sb.AppendFormat("Interes: {0}\n\n", this.Interes);
            return sb.ToString();
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
