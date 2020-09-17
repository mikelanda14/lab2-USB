using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Banano:Planta
    {

        private string codigo;
        public Banano(string nombre, int tamanio) : base(nombre, tamanio)
        {

        }
        public Banano(string nombre, int tamanio,string codigo) : this(nombre, tamanio)
        {
            this.codigo =codigo;
        }
        public override bool TieneFlores
        {
            get { return true; }
        }

        public override bool TieneFruto
        {
            get { return true; }
        }

        public string ResumenDeDatos()
        {
            StringBuilder sv = new StringBuilder();

            sv.AppendLine($"Código internacional:  {this.codigo.ToString()}");

            return sv.ToString();
        }

    }
}
