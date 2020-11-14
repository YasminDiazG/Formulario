using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioAlumno
{
    public partial class formAlumno : Form
    {
        Queue<Alumno> Estudiante = new Queue<Alumno>();
        public formAlumno()
        {
            InitializeComponent();
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string nombre = textBox.Text; // Obtengo valor de textBox

            if (string.IsNullOrWhiteSpace(nombre) == false)
            {
                aceptarAlumno CargarAlumno = new aceptarAlumno(nombre); // Instancio 2do form con el nombre cargado
                CargarAlumno.ShowDialog(); // Lo muestro

                if (CargarAlumno.Estado == "Aceptar")
                {
                    Alumno estudiante = new Alumno();

                    listBox.Items.Add(textBox.Text); // Agrego nombre al listBox

                    estudiante.Nombre = textBox.Text; // Agrego nombre al nodo
                    Estudiante.Enqueue(estudiante);  // Agrego nodo a la lista

                    datoLabel.Text = "Agregado:\n " + estudiante.Nombre;
                    textBox.Text = string.Empty; // Limpio textBox
                }
            }
            else
                datoLabel.Text = "Sin datos!";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTope_Click(object sender, EventArgs e)
        {
            Alumno estudiante = new Alumno();

            if (Estudiante.Count != 0)
            {
                estudiante = Estudiante.Peek(); // Busco primer nodo sin borrar

                datoLabel.Text = "Primero:\n" + estudiante.Nombre; // Muestro nombre de alumno en label
            }
            else
                datoLabel.Text = "Sin alumnos";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Alumno estudiante = new Alumno();

            if (Estudiante.Count != 0)
            {
                estudiante = Estudiante.Dequeue(); // Busco primer nodo para borrar

                datoLabel.Text = "Eliminado:\n" + estudiante.Nombre; // Muestro nombre de alumno en label
                listBox.Items.Remove(estudiante.Nombre);
            }
            else
                datoLabel.Text = "Sin alumnos";
        }
    }

    class Alumno
    {
        public string Nombre { get; set; }
    }
}