using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get { return this.monto; }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;    
            }
            set
            {
                if (value > DateTime.Today)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Today;
                }
            }
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("MONTO: {0}\nVENCIMIENTO: {1}\n", this.Monto, this.Vencimiento);
            return sb.ToString();
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return p1.Vencimiento.CompareTo(p2.Vencimiento);
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.Vencimiento = vencimiento;
            this.monto = monto;
        }
    }
}
