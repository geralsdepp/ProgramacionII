using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita:Producto
    {
        protected float _peso;
        protected static bool DeConsumo;

        public override float CalcularCostoDeProducción
        {
            get
            {
                return base.Precio * (float)0.33;
            }
        }

        public override string Consumir()
        {
            return "Comestible";
        }

        static Galletita()
        {
            DeConsumo = true;
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso)
            :base(codigoBarra, marca, precio)
        {
            this._peso = peso;
        }

        private static string  MostrarGalletita(Galletita g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("MARCA: {0}\nCODIGO: {1}\nPRECIO: {2}\nPESO: {3}\n\n", g.Marca, g._codigoBarra, g.Precio, g._peso);
            return sb.ToString();
        }

        public override string ToString()
        {
            return Galletita.MostrarGalletita(this);
        }

    }
}
