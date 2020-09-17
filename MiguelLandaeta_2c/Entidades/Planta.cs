using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        #region Contructores

        
        /// <summary>
        /// Contructor 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Planta(string nombre,int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }
        #endregion

        #region Propiedades

        
        /// <summary>
        /// propiedad tamanio retorna el tamanio
        /// </summary>
        public int Tamannio  
        {
            get { return this.tamanio; }
        }
        public abstract bool TieneFlores { get; }
        public abstract bool TieneFruto { get; }
        #endregion

        #region Metodos

        
        /// <summary>
        /// Resumen de datos retorna un string cojon los datos de planta.
        /// </summary>
        /// <returns></returns>
        public string ResumenDeDatos()
        {
            StringBuilder sv = new StringBuilder();
            sv.AppendLine($"{this.nombre} tiene un tamaño de {this.tamanio}");
            sv.AppendLine($"Tiene flores {this.TieneFlores}");
            sv.AppendLine($"Tiene fruto {this.TieneFruto}");

            return sv.ToString();
        }
        #endregion
    }
}
