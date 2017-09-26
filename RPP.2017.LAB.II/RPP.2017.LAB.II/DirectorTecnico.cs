using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP._2017.LAB.II
{
    public class DirectorTecnico:Persona
    {
        public DirectorTecnico(string nombre, string apellido):base(nombre,apellido){}      
       
        protected override string FichaTecnica()
        {
            return base.NombreCompleto();             
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }
    }
}
