using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa:Producto
    {
        protected float _litros;
        protected static bool DeConsumo;

        public override float CalcularCostoDeProducción
        {
            get{return base.Precio*(float)0.42;}
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        static Gaseosa()
        {
            DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            :base(codigoBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto p, float litros)
            : this((int)p, p.Precio, p.Marca, litros)
        { }

        private string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Litros: {0}\n\n", this._litros);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarGaseosa();
        }
    }
}
