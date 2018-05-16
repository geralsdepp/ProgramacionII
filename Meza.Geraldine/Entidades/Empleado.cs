using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Persona
    {
        private Departamentos departamento;
        private short piso;

        public string PisoDepartamento
        {
            get
            {
                return String.Format(this.piso + "º" + this.departamento);
            }
        }

        public Empleado(string nombre, string apellido, string documento, short piso, Departamentos departamento)
            : base(nombre, apellido, documento)
        {
            this.departamento = departamento;
            this.piso = piso;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ExponerDatos());
            sb.AppendFormat("Piso/Departamento: {0}\n\n", this.PisoDepartamento);
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            int num;
            bool bandera = false;
            bool retorno = false;
            for (int i = 0; i < doc.Length; i++)
            {
                if (int.TryParse(doc[i].ToString(), out num))
                {
                    bandera = true;
                }
                else if (doc[2].ToString() == "-" || doc[7].ToString() == "-" && bandera == true)

                    retorno = true;
                
            }
            return retorno;
        }

    
    }
}
