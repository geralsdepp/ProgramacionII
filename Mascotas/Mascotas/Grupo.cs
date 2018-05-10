using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Grupo
    {
        public enum TipoManada
        {
            Unica, Mixta
        }

        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        public TipoManada Tipo
        {
            set { tipo = value; }
        }

        static Grupo()
        {
            tipo = TipoManada.Unica;
        }

        Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            :this(nombre)
        {
            this.Tipo = tipo;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("**{0}**\n\nIntegrantes:\n", e.nombre);
            foreach (Mascota item in e.manada) 
            {
                if (item is Perro)
                {
                    Perro p = item as Perro;
                    sb.AppendFormat(p.ToString() + "\n");
                }
                else if (item is Gato)
                {
                    Gato g = item as Gato;
                    sb.AppendFormat(g.ToString() + "\n");
                }
            }
            return sb.ToString();
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool retorno = false;

            if (g.manada.Contains(m))
            {
                retorno = true;
            }
            return retorno;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g.manada.Remove(m);
            }
            return g;
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g.manada.Add(m);
            }
            return g;
        }
        
    }

}
