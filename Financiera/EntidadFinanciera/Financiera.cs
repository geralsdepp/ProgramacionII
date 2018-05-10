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

        public float InteresEnDolares
        {
            get{return this.CalcularInteresGanado(TipoDePrestamo.Dolares);}
        }

        public float InteresesEnPesos
        {
            get{return this.CalcularInteresGanado(TipoDePrestamo.Pesos);}
        }

        public float InteresesTotales
        {
            get{return this.CalcularInteresGanado(TipoDePrestamo.Todos);}
        }

        public List<Prestamo> ListaDePrestamos
        {
            get{return this.listaDePrestamos;}
        }

        public string RazonSocial
        {
            get { return this.razonSocial; }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float interes = 0;

            foreach (Prestamo item in this.ListaDePrestamos)
	        {
		        switch (tipoPrestamo)
	            {
		            case TipoDePrestamo.Pesos:
                        if (item is PrestamoPesos)
	                    {
		                    PrestamoPesos p = (PrestamoPesos)item;
                            interes += p.Interes; 
	                    }
                     break;
                    case TipoDePrestamo.Dolares:
                        if (item is PrestamoDolar)
	                    {
		                    PrestamoDolar p = (PrestamoDolar)item;
                            interes+=p.Interes;
	                    }
                     break;
                    case TipoDePrestamo.Todos:
                        if (item is PrestamoPesos)
	                    {
		                    PrestamoPesos p = (PrestamoPesos)item;
                            interes += p.Interes; 
	                    }
                        if (item is PrestamoDolar)
	                    {
		                    PrestamoDolar p = (PrestamoDolar)item;
                            interes+=p.Interes;
	                    } 
                     break;
	            }
	        }
            return interes;
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(financiera.RazonSocial + "\n\n");
            sb.AppendFormat("Intereses totales: {0}\n", financiera.InteresesTotales);
            sb.AppendFormat("Intereses en Pesos: {0}\n", financiera.InteresesEnPesos);
            sb.AppendFormat("Intereses en Dolares: {0}\n", financiera.InteresEnDolares);
            foreach (Prestamo item in financiera.ListaDePrestamos)
	        {
		        sb.Append(item.Mostrar());    
	        }

            financiera.OrdenarPrestamos();
            return sb.ToString();
        }

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial)
            :this()
        {
            this.razonSocial = razonSocial;
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static bool  operator ==(Financiera financiera, Prestamo prestamo)
        {
            bool retorno = false;
            if (financiera.ListaDePrestamos.Contains(prestamo))
	        {
		        retorno = true;
	        }
            return retorno;
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if (financiera != prestamoNuevo)
            {
                financiera.ListaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;
        }

        public void OrdenarPrestamos()
        {
            listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
    }
}
