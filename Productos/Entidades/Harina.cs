using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina:Producto
    {
        public enum ETipoHarina
        {
            CuatroCeros, TresCeros, Integral
        }

        private ETipoHarina _tipo;
        protected static bool DeConsumo;

        public override float CalcularCostoDeProducción
        {
            get { return base.Precio * (float)0.60; }
        }

        static Harina()
        {
            DeConsumo = false;
        }

        public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo)
            :base(codigo, marca, precio)
        {
            this._tipo = tipo;
        }

        private string MostrarHarina()
        {
            StringBuilder sb = new StringBuilder();
            string prod = (string)this;
            sb.Append(prod);
            //sb.Append(base.ToString());
            sb.AppendFormat("Tipo: {0}\n\n", this._tipo);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        } 
    }
}
