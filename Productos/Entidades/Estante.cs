using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        public float ValorEstanteTotal
        {
            get { return this.GetValorEstante(); }
        }

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad)
            :this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        private float GetValorEstante()
        {
            return this.GetValorEstante(Producto.ETipoProducto.Todos);
        }

        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float producto = 0;
            foreach (Producto item in this._productos)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (item is Galletita)
                        {
                            Galletita g = (Galletita)item;
                            producto += g.Precio;
                        }
                        
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (item is Gaseosa)
                        {
                            Gaseosa g = (Gaseosa)item;
                            producto += g.Precio;
                        }
                        
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (item is Jugo)
                        {
                            Jugo j = (Jugo)item;
                            producto += j.Precio;
                        }
                        
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (item is Harina)
                        {
                            Harina h = (Harina)item;
                            producto += h.Precio;
                        }
                       
                        break;
                    case Producto.ETipoProducto.Todos:
                        producto += item.Precio;
                        break;
                }
            }
            return producto;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append(e.ValorEstanteTotal + "\n");
            //sb.Append(e.GetValorEstante() + "\n");
            sb.AppendFormat("CAPACIDAD: {0}\n", e._capacidad);
            foreach (Producto item in e._productos)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        public static bool operator ==(Estante e, Producto prod)
        {
            bool retorno = false;

            foreach (Producto item in e._productos)
            {
                if (item == prod)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator +(Estante e, Producto prod)
        {
            bool retorno = false;

            if (e._productos.Count < e._capacidad && e != prod)
            {
                e._productos.Add(prod);
                retorno = true;
            }
            return retorno;
        }
        public static Estante operator -(Estante e, Producto prod)
        {
            if (e == prod)
            {                             
                e.GetProductos().Remove(prod);    
            }
            
            return e;
        }
        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)
        {
            for (int i = 0; i < e.GetProductos().Count; i++)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (e.GetProductos()[i] is Galletita)
                        {
                            Galletita g = (Galletita)e.GetProductos()[i];
                            e -= g;
                        }
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (e.GetProductos()[i] is Gaseosa)
                        {
                            Gaseosa g = (Gaseosa)e.GetProductos()[i];
                            e -= g;
                        }
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (e.GetProductos()[i] is Jugo)
                        {
                            Jugo j = (Jugo)e.GetProductos()[i];
                            e -= j;
                        }
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (e.GetProductos()[i] is Harina)
                        {
                            Harina h = (Harina)e.GetProductos()[i];
                            e -= h;
                        }
                        break;
                    case Producto.ETipoProducto.Todos:
                        e -= e.GetProductos()[i];
                        break;
                }
            }
            return e;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
