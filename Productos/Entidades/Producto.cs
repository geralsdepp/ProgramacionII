using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        public enum EMarcaProducto
        {
            Manaos, Pitusas, Naranjú, Diversión, Swift, Favorita
        }
        public enum ETipoProducto
        {
            Galletita, Gaseosa, Jugo, Harina, Todos
        }
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public abstract float CalcularCostoDeProducción { get; }
        public EMarcaProducto Marca { get { return this._marca; } }
        public float Precio { get { return this._precio; } }

        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }
        public override bool Equals(object obj)
        {
            return obj is Producto;
        }
        public static explicit operator int(Producto p)
        {
            return p._codigoBarra;
        }

        public static implicit operator string(Producto p)
        {
            return p.MostrarProducto(p);
        }

        private string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("MARCA: {0}\nCODIGO: {1}\nPRECIO: {2}\n", p.Marca, p._codigoBarra, p.Precio);
            return sb.ToString();
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }

        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            bool retorno = false;
            if (prodUno.Marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            bool retorno = false;
            if (prodUno.Equals(prodDos) && prodUno.Marca == prodDos.Marca && prodUno._codigoBarra == prodDos._codigoBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
