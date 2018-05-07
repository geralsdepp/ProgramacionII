using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo:Producto
    {
        public enum ESaborJugo
        {
            Asqueroso, Pasable, Rico
        }

        protected ESaborJugo _sabor;
        protected static bool DeConsumo;

        public override float CalcularCostoDeProducción
        {
            get
            {
                return base.Precio * (float)0.4;
            }
        }
        public override string Consumir()
        {
            return "Bebible";
        }

        static Jugo()
        {
            DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            :base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;
        }

        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            string prod = (string)this;
            sb.Append(prod);
            sb.AppendFormat("SABOR: {0}\n\n", this._sabor);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarJugo();
        }

    }
}
