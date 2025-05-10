using Parcial.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaAlumno alumnos = new ListaAlumno();

        private int? legajoSeleccionado = null;
        public void Actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alumnos.ObtenerLista();

        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            
            try
            {
                int nroLegajo = Convert.ToInt32(txtNroLegajo.Text);
                string apellido = txtApellido.Text;
                string nombre = txtNombre.Text;
                int DNI = Convert.ToInt32(txtDNI.Text);

                Alumno nuevoAlumno = new Alumno(nroLegajo, apellido, nombre, DNI);
                alumnos.agregarAlumno(nuevoAlumno);

                Actualizar();
                MessageBox.Show("AGREGO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al agregar el alumno: " + ex.Message);
            }
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            legajoSeleccionado = Convert.ToInt32(row.Cells["NroLegajo"].Value);
            try
            {
                               
                Alumno alumnoEncontrado = alumnos.BuscarAlumno((int)legajoSeleccionado);
                MessageBox.Show("El alumno encontrado: " + alumnoEncontrado.NroLegajo);


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCURRIO UN ERROR: " + ex.Message);
            }
        }
        private void btnOtorgarBeca_Click(object sender, EventArgs e)
        {
            if (legajoSeleccionado == null)
            {
                MessageBox.Show("Elija un legajo ");
                return;
            }

            try
            {
                alumnos.DarBeca((int)legajoSeleccionado);
                Actualizar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error beca");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        


    }
}
