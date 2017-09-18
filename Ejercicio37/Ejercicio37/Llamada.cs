using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public enum TipoLlamada
    {
        Local,Provinicial,Todas
    }
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino, _nroOrigen;

        public float Duracion{get{return this._duracion;}}

        public string NroDestino { get { return this._nroDestino; } }

        public string NroOrigen { get { return this._nroOrigen; } }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        //METODO DE INSTANCIA. UTILIZA STRING BUILDER
        public string Mostrar()
        {
            string numero_duracion = "Numero de Duracion: ";
            string numero_destino = "Numero de Destion: ";
            string numero_origen = "Numero de Origen: ";

            StringBuilder SBuilder = new StringBuilder();

            SBuilder.Append(numero_duracion);
            SBuilder.Append(Duracion + "\n");

            SBuilder.Append(numero_destino);
            SBuilder.Append(NroDestino + "\n");

            SBuilder.Append(numero_origen);
            SBuilder.Append(NroOrigen + "\n");             

            return SBuilder.ToString();
        }

        //ORDENAR UNA LISTA DE LLAMADAS DE FORMA ASCENDENTE. HAGO UN COMPARE
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = llamada1.Duracion.CompareTo(llamada2.Duracion);
            return retorno;
        }
    }
}
