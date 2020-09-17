using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbusto:Planta
    {
        #region Constructores

        
        /// <summary>
        /// contructor que sobrecarga a clase base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Arbusto(string nombre, int tamanio) : base(nombre, tamanio)
        {

        }
        #endregion

        #region propiedades

        /// <summary>
        /// Override de propiedades tiene Flores.
        /// </summary>
        public override bool TieneFlores
        {
            get { return false; }
        }
        /// <summary>
        /// Override de propiedad tiene fruto
        /// </summary>
        public override bool TieneFruto
        {
            get { return false; }
        }

        #endregion
    }
}
