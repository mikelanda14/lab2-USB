using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal : Planta
    {
        private Color florColor;

        #region Constructores
        /// <summary>
        /// Constructor sobrecarga a Base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        
        public Rosal(string nombre,int tamanio):base(nombre,tamanio)
        {

        }
        /// <summary>
        /// Contructor con sobre carga
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        /// <param name="flor"></param>
        public Rosal(string nombre,int tamanio,Color flor):this(nombre,tamanio)
        {
            this.florColor = flor;
        }
        #endregion

        #region Propiedades

        
        public override bool TieneFlores
        { 
            get{ return true; } 
        }

        public override bool TieneFruto 
        { 
            get { return false; }
        }
        #endregion

        #region Metodo

        
        public string ResumenDeDatos()
        {
            StringBuilder sv = new StringBuilder();
           
            sv.AppendLine($"Flores de color: {this.florColor.ToString()}");

            return sv.ToString();
        }
        #endregion

        /// <summary>
        /// Enumerado COLOR opciones para color de Rosas
        /// </summary>
        public enum Color
        {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }
    }
}
