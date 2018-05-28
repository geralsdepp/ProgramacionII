using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c = new Competencia(5, 5, TipoCompetencia.F1);
            AutoF1 a1 = new AutoF1(1, "Escuderia1",600);
            AutoF1 a2 = new AutoF1(2, "Escuderia2",400);
            AutoF1 a3 = new AutoF1(3, "Escuderia3",230);
            AutoF1 a4 = new AutoF1(4, "Escuderia4",720);
            AutoF1 a5 = new AutoF1(4, "Escuderia4",1000);
            MotoCross m = new MotoCross(3, "Escuderia5", 122);

            Competencia c1 = new Competencia(4, 4, TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(1, "Escuderia1", 120);
            MotoCross m2 = new MotoCross(2, "Escuderia2", 400);
            MotoCross m3 = new MotoCross(3, "Escuderia3", 150);
            AutoF1 a = new AutoF1(4, "Escuderia4", 566);
            bool aux = false;

            try
            {
                aux = c + a1;
                aux = c + a2;
                aux = c + a3;
                aux = c + a4;
                aux = c + a5;
                aux = c + m;

                aux = c1 + m1;
                aux = c1 + m2;
                aux = c1 + m3;
                aux = c1 + a;

                Console.WriteLine(c.MostrarDatos());
                Console.ReadKey();
                Console.WriteLine(c1.MostrarDatos());
                Console.ReadKey();

                aux = c - a1;
                aux = c1 - m1;

                Console.WriteLine(c.MostrarDatos());
                Console.ReadKey();
                Console.WriteLine(c1.MostrarDatos());
                Console.ReadKey();
            }
            catch(CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            

           

        }
    }
}
