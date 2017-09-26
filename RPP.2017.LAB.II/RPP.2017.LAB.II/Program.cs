using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP._2017.LAB.II
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico dt1 = new DirectorTecnico("Guillermo","Schelotto");
            Equipo e = new Equipo("Boca Juniors", dt1);
            Jugador j1 = new Jugador("Agustin", "Rossi",12,false);
            e = e + j1;
            Jugador j2 = new Jugador("Cristian", "Pavon", 7, false);
            e = e + j2;
            Jugador j3 = new Jugador("Fernando", "Gago", 5, true);
            e = e + j3;
            Jugador j4 = new Jugador("Pablo", "Perez", 8, false);
            e = e + j4;

            Console.WriteLine(e);
            
            Console.ReadKey();

        }
    }
}
