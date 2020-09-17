using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Jardin
    {
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        #region Constructores

        
        /// <summary>
        /// Constructor Jardin inicializa la lista.
        /// </summary>
        private Jardin()
        {
            this.plantas = new List<Planta>();

        }
        /// <summary>
        /// Constructor Estatico
        /// </summary>
        static Jardin()
        {
            Jardin.suelo = Tipo.Terrozo;
        }
        
        /// <summary>
        /// constructores.
        /// </summary>
        /// <param name="espacioTotal"></param>
        public Jardin(int espacioTotal):this()
        {
            this.espacioTotal = espacioTotal;
        }
        #endregion

        #region propiedades

        
        /// <summary>
        /// propiedad EspacioOcupado
        /// </summary>
        /// <returns></returns>
        private int EspacioOcupado()
        {
            int total = 0;
            
            foreach (Planta item in this.plantas)
            {
                total += item.Tamannio;
            }
            return total;
        }
        /// <summary>
        /// propiedad Que calcula Espacio Ocupado inclueyendo la nueva planta.
        /// </summary>
        /// <param name="planta"></param>
        /// <returns></returns>
        private int EspacioOcupado(Planta planta)
        {
            
            return this.EspacioOcupado()+planta.Tamannio;
        }
        #endregion

        #region Sobrecarga de operador
        /// <summary>
        /// Sobrecarca de operador +
        /// </summary>
        /// <param name="jardin"></param>
        /// <param name="planta"></param>
        /// <returns></returns>
        
        public static bool operator +(Jardin jardin,Planta planta)
        {


            if ((jardin.EspacioOcupado(planta) <=jardin.espacioTotal))
            {
                jardin.plantas.Add(planta);
                return true;
            }
            else
            {
                return false;
            }

        }

        #endregion

        #region Sobre Escritura de ToString

        /// <summary>
        /// Sobrecarga de ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sv = new StringBuilder();
            sv.AppendLine($"Composición del Jardín: {Jardin.suelo.ToString()} ");
            sv.AppendLine($"Espacio ocupado {this.EspacioOcupado()} de {this.espacioTotal.ToString()}   ");
            sv.AppendLine($"LISTA DE PLANTAS");
            foreach (Planta item in plantas)
            {
                sv.AppendLine(item.ResumenDeDatos());
            }
            return sv.ToString();
        }
        #endregion
        public enum Tipo
        {
            Terrozo,
            Arenozo
        }
    }
}
