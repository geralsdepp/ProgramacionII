using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar:Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get { return this.periodicidad; }
        }

        private float CalcularInteres()
        {
            float total = 0;

            switch (Periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    total = (base.Monto * (float)0.25) + base.Monto;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    total = (base.Monto * (float)0.35) + base.Monto;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    total = (base.Monto * (float)0.40) + base.Monto;
                    break;
            }
            return total;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            base.monto += (float)(nuevoVencimiento - base.Vencimiento).Days * (float)0.025;
            base.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat("Periodicidad: {0}\n",this.Periodicidad);
            sb.AppendFormat("Interes: {0}\n\n", this.Interes);
            return sb.ToString();
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
            :base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)
            : this(prestamo.Monto, prestamo.Vencimiento, periodicidad) { }
    }
}
