using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public enum Franja
    {
        Franja_1, Franja_2, Franja_3
    }
    public class Provincial:Llamada
    {
        protected Franja FranjaHoraria;

        public float CostoLlamada { get { return CalcularCosto(); } }
        

        //RETORNARA EL VALOR DE LA LLAMADA A PARTIR DE LA DURACION Y EL COSTO  DE LA MISMA. LOS VALORES SERAN 
        //FRANJA_1: 0.99  FRANJA_2: 1.25   FRANJA_3: 0.66
        private float CalcularCosto()
        {
            float retorno = (float)0.66;
            if (this.FranjaHoraria == Franja.Franja_1)
                retorno = (float)0.99;
            else if (this.FranjaHoraria == Franja.Franja_2)
                retorno = (float)1.25;

            return retorno;
        }

        //EXPONDRA ADEMAS DE LOS ATRIBUTOS DE LA CLASE BASE, LA PROPIEDAD COSTOLLAMADA Y FRANJAHORARIA. UTILIZAR STRINGBUILDER
        public new string Mostrar()
        {
            StringBuilder SBuilder = new StringBuilder();
            string costoLlamada = "El costo de Provincial: ";
            string franjaHor = "Franja horaria: ";
            SBuilder.Append(base.Mostrar());
            SBuilder.Append(costoLlamada);
            SBuilder.Append(this.CostoLlamada + "\n");
            SBuilder.Append(franjaHor);
            SBuilder.Append(this.FranjaHoraria + "\n\n");

            return SBuilder.ToString();
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.FranjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : this(miFranja, new Llamada(duracion, destino, origen)) { }


    }
}
