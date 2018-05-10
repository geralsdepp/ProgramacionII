using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Gato:Mascota
    {
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if ((Gato)obj == this)
            {
                retorno = true;
            }
            return retorno;
        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public Gato(string nombre, string raza)
            :base(nombre, raza)
        {
            
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        public static bool operator ==(Gato g1, Gato g2)
        {
            bool retorno = false;

            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        
    }
}
