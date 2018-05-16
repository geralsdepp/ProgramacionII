using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Oficina
    {
        private Departamentos departamento;
        private List<Empleado> empleados;
        private Jefe jefe;
        private short piso;

        public string PisoDivision
        {
            get { return String.Format(this.piso + "º" + this.departamento); }

        }

        Oficina()
        {
            this.empleados = new List<Empleado>();
        }

        public static explicit operator string(Oficina o)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(o.PisoDivision + "\n" + "Jefe: " + o.jefe.ExponerDatos()+ "\n\n");
            foreach (Empleado item in o.empleados)
            {
                sb.Append(item.ExponerDatos());
            }
            return sb.ToString();
        }

        public Oficina(short piso, Departamentos departamento, Jefe jefe)
            :this()
        {
            this.piso = piso;
            this.departamento = departamento;
            this.jefe = jefe;
        }

        public static bool operator !=(Oficina o, Empleado e)
        {
            return !(o == e);
        }

        public static bool operator ==(Oficina o, Empleado e)
        {
            bool retorno = false;
            if (o.PisoDivision == e.PisoDepartamento)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Oficina operator +(Oficina o, Empleado e)
        {
            if (o == e)
            {
                o.empleados.Add(e);                
            }
            return o;
        }
    }
}
