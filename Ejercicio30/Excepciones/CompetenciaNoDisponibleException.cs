using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get { return this.nombreClase; }
            set { this.nombreClase = value; }
        }

        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
            set { this.nombreMetodo = value; }
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : base(mensaje)
        {
            this.NombreClase = clase;
            this.NombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.NombreClase = clase;
            this.NombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("i. Excepcion en el metodo {0} de la clase {1}\n", this.NombreMetodo, this.NombreClase);
            sb.AppendLine("ii. " + base.Message);
            sb.AppendLine("iii. " + base.InnerException);

            return sb.ToString();
        }
    }
}
