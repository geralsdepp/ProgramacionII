using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLibro
{
    public class Novela:Libro
    {
        private int cantPaginas;

        public override ETipoImpresion TipoImpresion
        {
            get
            {
                return ETipoImpresion.BlancoNegro;
            }
        }

        public override string Mostrar()
        {
            string aux;
            aux = string.Format(base.Mostrar() + " \n Cantidad de Paginas: " + this.cantPaginas + "\nTipo de impresion: " + this.TipoImpresion);
           
            return aux;
        }

        public Novela(int cantPaginas, string titulo, float tamanioLetra, int ancho, int alto)
            :base(titulo, tamanioLetra, ancho, alto)
        {
            this.cantPaginas = cantPaginas;
        }

    }
}
