using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        float auxLocales = 0, auxProvinciales = 0;

        //retornarán el precio de lo facturado según el criterio.
        //Dichos valores se calcularán en el método CalcularGanancia().
        public float GananciasPorLocal { get { return this.CalcularGanancia(TipoLlamada.Local); } }

        public float GananciasPorProvincial { get { return this.CalcularGanancia(TipoLlamada.Provinicial); } }

        public float GanancialPorTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); } }

        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        //RECIBE UN ENUMERADO Y RETORNARA EL VALOR DE LO RECAUDADO, SEGUN EL CRITERIO ELEGIDO
        //(GANANCIAS POR LAS LLAMADAS DEL TIPO LOCAL, PROVINCIAL O DE TODAS SEGUN CORRESPONDA)
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno = 0;
           
            foreach (Llamada elements in this.listaDeLlamadas)
            {
                if (tipo == TipoLlamada.Local && elements is Local)
                {
                    // CASTEO DE LA CLASE PADRE (Llamada) A LA CLASE HIJA (Local)
                    Local loc = elements as Local;
                    
                    this.auxLocales = loc.CostoLlamada + this.auxLocales;
                    retorno = this.auxLocales;
                }
                else if(tipo == TipoLlamada.Provinicial && elements is Provincial)
                {
                    Provincial prov = elements as Provincial;
                   
                    this.auxProvinciales = prov.CostoLlamada + this.auxProvinciales;
                    retorno = this.auxProvinciales;
                }
                else if(tipo == TipoLlamada.Todas)
                {
                    retorno = this.auxLocales + this.auxProvinciales;
                }
            }

            return retorno;
        }

        //SE INICIALIZA LA LISTA
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this() //con el :this() Llamo a mi constructor que no contiene parametros
        {
            this.razonSocial = nombreEmpresa;
        }

        //expondrá la razón social, la ganancia total, ganancia por llamados locales 
        //y provinciales y el detalle de las llamadas realizadas.
        public string Mostrar()
        {
            StringBuilder SBuilder = new StringBuilder();

            SBuilder.Append(this.razonSocial +"\n");
            SBuilder.Append("Ganancias Locales: ");
            SBuilder.Append(GananciasPorLocal +"\n");
            SBuilder.Append("Ganancias Provinciales: ");
            SBuilder.Append(GananciasPorProvincial +"\n");
            SBuilder.Append("Ganancias Totales: ");
            SBuilder.Append(GanancialPorTotal +"\n\n");
            SBuilder.Append("***************DETALLE DE LAS LLAMADAS**************\n\n");

            foreach (Llamada elements in this.listaDeLlamadas)
            {
                if (elements is Local)
                {
                    // CASTEO DE LA CLASE PADRE (Llamada) A LA CLASE HIJA (Local)
                    Local loc = elements as Local;
                    SBuilder.Append(loc.Mostrar());
                }
                if (elements is Provincial)
                {
                    Provincial prov = elements as Provincial;
                    SBuilder.Append(prov.Mostrar());
                }            
            }

            return SBuilder.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
