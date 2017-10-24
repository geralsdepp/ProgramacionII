using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
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
            get
            {
                return this.periodicidad;
            }
        }

        private float CalcularInteres()
        {
            float total = this.Monto;
            float interes;

            switch (this.Periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    interes = base.Monto * 25/100;
                    total = base.Monto + interes;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    interes = base.Monto * 35/100;
                    total = base.Monto + interes;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    interes = base.Monto * 40/100;
                    total = base.Monto + interes;
                    break;
            }
            return total;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            base.monto = ((float)(nuevoVencimiento - base.Vencimiento).Days) * 25/10;
            base.vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder SBuilder = new StringBuilder();

            SBuilder.Append(base.Mostrar());
            SBuilder.AppendFormat("Peridicidad: {0}\n", this.Periodicidad);
            SBuilder.AppendFormat("Interes: {0}\n", this.Interes);

            return SBuilder.ToString();
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
            :base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)
            :this(prestamo.Monto, prestamo.Vencimiento, periodicidad) { }


        
            
    }
}
