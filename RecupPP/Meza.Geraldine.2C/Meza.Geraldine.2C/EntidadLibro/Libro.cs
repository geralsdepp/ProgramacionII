using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLibro
{
    public abstract class Libro
    {
        private int altoHoja;
        private int anchoHoja;
        private List<string> pagina;
        private float tamanioLetra;
        private string titulo;

        public int AltoHoja
        {
            get
            {
                return this.altoHoja;
            }
        }

        public int AnchoHoja
        {
            get
            {
                return this.anchoHoja;
            }
        }

        public int CantidadPaginas
        {
            get
            {
                return this.pagina.Count;
            }
        }

        public float TamanioLetra
        {
            get
            {
                return this.tamanioLetra;
            }
            set
            {
                if (value < ((this.AltoHoja + this.AnchoHoja) * 10 / 100))
                {
                    this.tamanioLetra = value;
                }
                else
                    this.tamanioLetra = 12;
            }
        }

        public string this[int index]
        {
            get
            {
                string retorno = "";
                foreach (string item in pagina)
                {
                    if (pagina[index] == item)
                    {
                        retorno = this.pagina[index];
                    }
                }
                return retorno;
            }
            set
            {
                this.pagina.Add(value);
            }

        }

        public abstract ETipoImpresion TipoImpresion
        {
            get;
        }

        private Libro()
        {
            pagina = new List<string>();
        }

        public Libro(string titulo, float tamanioLetra, int ancho, int alto):this()
        {
            this.titulo = titulo;
            this.TamanioLetra = tamanioLetra;
            this.anchoHoja = ancho;
            this.altoHoja = alto;
        }

        public virtual string Mostrar()
        {
            string aux = "Titulo: " + this.titulo;
            return aux;
        }

        public enum ETipoImpresion
        {
            Color, BlancoNegro, Mixto
        }


    }
}
