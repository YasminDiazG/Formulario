using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioAlumno
{
    public partial class aceptarAlumno : Form
    {

        public aceptarAlumno(string nombre)
        {
            InitializeComponent();

            pregunta.Text = "¿Desea agregar a " + nombre + " al listado?";
        }

        private void aceptarAlumno_Load(object sender, EventArgs e)
        {

        }

        private string estado;
        public string Estado
        {
            get { return estado; }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            formAlumno inicioAlumno = new formAlumno();

            estado = "Aceptar";

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pregunta_Click(object sender, EventArgs e)
        {

        }
    }
}
