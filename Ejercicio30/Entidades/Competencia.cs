using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
            :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Competencia: {0} Competidores: {1} Vueltas: {2}\n", this.tipo, this.cantidadCompetidores, this.cantidadVueltas);

            foreach (VehiculoDeCarrera item in this.competidores)
            {
                if(this == item)
                    sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            for (int i = 0; i < c.competidores.Count; i++)
            {
                if (c.competidores[i] == a)
                {
                    c.competidores.Remove(a);
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            Random random = new Random();
            bool retorno = false;

            try
            {
                if (c.cantidadCompetidores > c.competidores.Count && c != v)
                {
                    c.competidores.Add(v);
                    v.EnCompetencia = true;
                    v.VueltasRestantes = c.cantidadVueltas;
                    v.CantidadCombustible = (short)random.Next(15, 100);
                    retorno = true;
                }
                return retorno;
            }
            catch(CompetenciaNoDisponibleException e)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", e.NombreClase, "+", e);
            }
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        { 
            bool retorno = false;

            foreach (VehiculoDeCarrera item in c.competidores)
            {
                if (item == a)
                {
                    switch (c.tipo)
                    {
                        case TipoCompetencia.F1:
                            if (a is AutoF1)
                            {
                                retorno = true;
                            }
                            break;
                        case TipoCompetencia.MotoCross:
                            if (a is MotoCross)
                            {
                                retorno = true;
                            }
                            break;

                    }
                }
                else
                    throw new CompetenciaNoDisponibleException("El vehiculo no corresponda a la competencia", a.GetType().Name, "==");
            }
            return retorno;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
    }
    public enum TipoCompetencia
    {
        F1, MotoCross
    }
}
