using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP._2017.LAB.II
{
    public class Jugador:Persona
    {
        private bool esCapitan;
        private int numero;

        public bool EsCapitan 
        { 
            get{return this.esCapitan;}
            set{this.esCapitan = value;}
        }
        public int Numero 
        { 
            get{return this.numero;}
            set{this.numero = value;}
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Jugador)//si mi obj es Jugador
            {
                if ((Jugador)obj == this) //si obj es igual a mi instancia actual
                {
                    retorno =  true;
                }
            }
            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
       

        public static explicit operator int(Jugador jug)
        {
            return jug.Numero;
        }

        public Jugador(string nombre, string apellido)
            : this(nombre, apellido, 0, false) { }
       
        public Jugador(string nombre, string apellido, int numero, bool capitan) : base(nombre, apellido)
        {
            this.Numero = numero;
            this.esCapitan = capitan;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if(j1.NombreCompleto() == j2.NombreCompleto() && j1.Numero == j2.Numero)
                retorno = true;
            return retorno;
        }
        public override string ToString()
        {
            return this.FichaTecnica();
        }

        protected override string FichaTecnica()
        {
            string retorno;
            if (esCapitan == true)
            {
                retorno = String.Format("{0}, capitan del equipo, camiseta numero {1}", base.NombreCompleto(), this.Numero);
            }
            else
            {
                retorno = String.Format("{0}, camiseta numero {1}", base.NombreCompleto(), this.Numero);
            }
            return retorno;
        }
    }
}
