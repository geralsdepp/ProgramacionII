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
        public override float CostoLlamada { get { return CalcularCosto(); } }

        //RETORNA EL VALOR DE LA LLAMADA A PARTIR DE LA DURACION Y EL COSTO DE LA MISMA
        private float CalcularCosto()
        {
            float costo;
            costo = this._costo * base.Duracion;
            return costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo) { }
        
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this._costo = costo;
        }
             
        //EXPONDRA, ADEMAS DE LOS ATRIBUTOS DE LA CLASE BASE, LA PROPIEDAD COSTOLLAMADA. UTILIZAR STRINGBUILDER
        protected override string Mostrar()
        {
            StringBuilder SBuilder = new StringBuilder();
            string costo = "El costo de Local: ";
            
            SBuilder.Append(base.Mostrar());
            SBuilder.Append(costo);
            SBuilder.Append(this.CostoLlamada + "\n\n");
            return SBuilder.ToString();
        }
        public new string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Local)
                retorno = true;
            return retorno;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
