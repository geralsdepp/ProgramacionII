using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public class Local:Llamada
    {
        protected float _costo;

        //RETORNARA EL PRECIO, QUE SE CALCULARA EN EL METODO CALCULARCOSTO
        public float CostoLlamada { get { return CalcularCosto(); } }

        //RETORNA EL VALOR DE LA LLAMADA A PARTIR DE LA DURACION Y EL COSTO DE LA MISMA
        private float CalcularCosto()
        {
            float costo;
            costo = this._costo * base.Duracion;
            return costo;
        }
   
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this._costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo)
            : this(new Llamada(duracion, destino, origen), costo) { }
        

        //EXPONDRA, ADEMAS DE LOS ATRIBUTOS DE LA CLASE BASE, LA PROPIEDAD COSTOLLAMADA. UTILIZAR STRINGBUILDER
        public new string Mostrar()
        {
            StringBuilder SBuilder = new StringBuilder();
            string costo = "El costo de Local: ";
            
            SBuilder.Append(base.Mostrar());
            SBuilder.Append(costo);
            SBuilder.Append(this.CostoLlamada + "\n\n");
            return SBuilder.ToString();
        }
    }
}
