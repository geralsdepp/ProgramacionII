using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro("Luna", "Caniche", 7, false);
            Gato g1 = new Gato("Nieves", "Alvina");
            Grupo g = new Grupo("Casa Meza", Grupo.TipoManada.Mixta);
            g += p1;
            g += g1;

            Console.WriteLine(g);
            Console.ReadKey();


        }
    }
}
