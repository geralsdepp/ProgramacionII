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
        {   get { return this.vencimiento; }
            set 
            {
                if (value > DateTime.Today)
                    this.vencimiento = value;
                else
                    this.vencimiento = DateTime.Today;
            }  
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            string retorno;

            retorno = string.Format("Monto: {0}\nVencimiento: {1}\n",this.Monto, this.Vencimiento);
            return retorno;
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int retorno = 0;

           retorno =  p1.Vencimiento.CompareTo(p2.Vencimiento);

            return retorno;
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }


    }
}
