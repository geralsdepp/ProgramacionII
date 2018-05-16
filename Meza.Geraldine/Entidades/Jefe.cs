using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jefe:Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {
                return DateTime.Today.Day - fechaIngreso.Day;
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ExponerDatos());
            sb.AppendFormat("Antiguedad: {0} dias", this.Antiguedad);
            return sb.ToString();
        }

        public Jefe(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento) { }

        public Jefe(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento) 
        {
            this.fechaIngreso = fechaIngreso;
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            if (doc.Length == 8)
            {
                return true;
            }
            return false;
        }
        
    }
}
