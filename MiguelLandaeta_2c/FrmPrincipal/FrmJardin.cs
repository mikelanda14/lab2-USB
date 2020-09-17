using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmPrincipal
{
    public partial class FrmJardin : Form
    {
        Jardin jardin;
        #region Constructor
        /// <summary>
        /// contructor por defecto
        /// </summary>
        
        public FrmJardin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Sobrecarga de constructor.
        /// </summary>
        /// <param name="jardin"></param>
        public FrmJardin(Jardin jardin) : this()
        {
            
        }
        #endregion

        /// <summary>
        /// Load del formulario y carga de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmJardin_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Jardin";
            this.BackColor = Color.DarkGreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.jardin = new Jardin(100);
           bool pudo = this.jardin + new Arbusto("Arbusto 1", 10);
            pudo = this.jardin + new Arbusto("Arbusto 2", 15);
            pudo = this.jardin + new Rosal("Rosa 1", 20, Rosal.Color.Amarilla);
            pudo = this.jardin + new Rosal("Rosa clásica", 25);
            pudo = this.jardin + new Banano("Banano ecuador", 30, "ECU001");
            if (!(this.jardin + new Banano("No carga", 1, "ARG028"))) 
            { MessageBox.Show("ERROR!"); }
            


        }
        #region Evento
        /// <summary>
        /// Precion del boton ver datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerdatos_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = jardin.ToString();
        }
        #endregion

    }
}
