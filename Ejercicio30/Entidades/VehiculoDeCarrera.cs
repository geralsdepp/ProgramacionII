using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombusible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get { return this.cantidadCombusible; }
            set { this.cantidadCombusible = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }

        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public virtual string MostrarDatos()
        {
            if (EnCompetencia)
            {
                return String.Format("{0} {1} En Competencia\nCantidad de Combustible: {2}\nVueltas Restantes: {3}\n", this.escuderia, this.numero, this.CantidadCombustible, this.vueltasRestantes);
            }
            else
            {
                return String.Format("{0} {1} Fuera de Competencia\nCantidad de Combustible: {2}\nVueltas Restantes: {3}\n", this.escuderia, this.numero, this.cantidadCombusible, this.VueltasRestantes);
            }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool retorno = false;
            if (v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
