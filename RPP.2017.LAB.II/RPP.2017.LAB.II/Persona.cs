using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP._2017.LAB.II
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;

        public string Apellido { get { return this.apellido; } }
        public string Nombre { get { return this.nombre; } }

        //Lo desarrollo en la clase derivada porque es un metodo abstracto
        protected abstract string FichaTecnica();

        //RETORNARA EL NOMBRE Y EL APELLIDO
        protected virtual string NombreCompleto()
        {
            string retorno;

            retorno = string.Format(Nombre + " " + Apellido);

            return retorno;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
