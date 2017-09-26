using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP._2017.LAB.II
{
    public enum Deportes
    {
       Basquet, Futbol, Handball, Rugby
    }

    public class Equipo
    {
        private Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;
        
        public Deportes Deporte { set { this.deporte = value; } }
                
        private Equipo()
        {
            jugadores = new List<Jugador>();
            this.deporte = Deportes.Futbol;
        }

        public Equipo(string nombre, DirectorTecnico dt):this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte):this(nombre,dt)
        {
            this.Deporte = deporte;
        }

        public static implicit operator string(Equipo e)
        {
            StringBuilder SBuilder = new StringBuilder();
            SBuilder.Append(e.nombre + e.deporte + "\n");
            SBuilder.Append("Nomina jugadores:\n");

            foreach (Jugador i in e.jugadores)
	        {
		        SBuilder.Append(i.ToString()+"\n");
	        }
            SBuilder.Append("Dirigido por: "+ e.dt.ToString()+"\n");

            return SBuilder.ToString();
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        //Un equipo será igual a un Jugador si este último forma parte de la lista.
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;

            if (e.jugadores.Contains(j) == true)
            {
                retorno = true;
            }
            
            return retorno;
        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if (e.jugadores.Contains(j) == true)
            {
                e.jugadores.Remove(j);
            }
           
            return e;
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Contains(j) == false)
            {
                e.jugadores.Add(j);
            }
                
            
            return e;
        }
        
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Equipo)//si mi obj es Jugador
            {
                if ((Equipo)obj == this) //si obj es igual a mi instancia actual
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
    }
}
