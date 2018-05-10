using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Perro:Mascota
    {
        private int edad;
        private bool esAlfa;

        public int Edad
        {
            get{return this.edad;}
            set{this.edad = value;}
        }

        public bool EsAlfa
        {
            get{return this.esAlfa;}
            set{this.esAlfa = value;}
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj == this)
	        {
		        retorno = true;
	        }
            return retorno;
        }

        public static explicit operator int(Perro perro)
        {
            int retorno = (int)perro.Edad;
            return retorno;
        }

        protected override string Ficha()
        {
            if (EsAlfa)
	        {
		        return String.Format("{0}, alfa de la manada, edad {1}", base.DatosCompletos(), this.Edad);
	        }
            else
            {
                return String.Format("{0} edad {1}", base.DatosCompletos(), this.Edad);
            }
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retorno = false;

            if (p1.Edad == p2.Edad && p1.Nombre == p2.Nombre && p1.Raza == p2.Raza)
	        {
		        retorno = true;
	        }
            return retorno;
        }

        public Perro(string nombre, string raza)
            :base(nombre, raza)
        {
            this.Edad = 0;
            this.EsAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            :this(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }

        public override string ToString()
        {
 	         return this.Ficha();
        }

    }
}
