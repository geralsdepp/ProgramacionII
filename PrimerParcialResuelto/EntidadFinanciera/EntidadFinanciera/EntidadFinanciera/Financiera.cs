using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;
namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public float InteresesEnDolares
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Dolares); }
        }

        public float InteresesEnPesos
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Pesos); }
        }

        public float InteresesTotales
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Todos); }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get { return this.listaDePrestamos; }
        }

        public string RazonSocial
        {
            get { return this.razonSocial; }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float interesGanado = 0;

            foreach (Prestamo p in this.listaDePrestamos)
            {
                switch (tipoPrestamo)
                {
                    case TipoDePrestamo.Pesos:
                        if (p is PrestamoPesos)
                            interesGanado += ((PrestamoPesos)p).Interes;                      
                        break;
                    case TipoDePrestamo.Dolares:
                        if (p is PrestamoDolar)
                            interesGanado += ((PrestamoDolar)p).Interes;                        
                        break;
                    case TipoDePrestamo.Todos:
                        if(p is PrestamoPesos)
                            interesGanado += ((PrestamoPesos)p).Interes;
                        else
                            interesGanado += ((PrestamoDolar)p).Interes;
                        break;
                }
            }
            return interesGanado;
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder SBuilder = new StringBuilder();
            SBuilder.AppendFormat("Razon social: {0}", financiera.RazonSocial);
            SBuilder.AppendLine("\n");
            SBuilder.AppendFormat("Intereses totales ganados: {0}\n", financiera.InteresesTotales);
            SBuilder.AppendFormat("Intereses por prestamos en pesos: {0}\n", financiera.InteresesEnPesos);
            SBuilder.AppendFormat("Intereses por prestamos en dolares: {0}\n", financiera.InteresesEnDolares);

            foreach (Prestamo p in financiera.listaDePrestamos)
            {
                SBuilder.AppendLine(p.Mostrar() + "\n");
            }

            return SBuilder.ToString();
        }

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            bool retorno = false;

            if (financiera.listaDePrestamos.Contains(prestamo))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if(financiera!=prestamoNuevo)
            {
                financiera.listaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;    
        }
        
        
        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
