using ClienteProyectoSWNet.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteProyectoSWNet.View
{
    public partial class GUIEliminarMatricula : Form
    {
        public GUIEliminarMatricula()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioUniversidad.eliminarMatricula(txtBuscar.Text);
                MessageBox.Show("matricula Eliminado");

                txtBuscar.Text = "";
                txtCedulaEstu.Text = "";
                txtCodigoEstu.Text = "";
                txtFechaMatricula.Text = "";
                txtNumCreditos.Text = "";
                txtPPa.Text = "";
                txtProgramaAcademico.Text = "";
                txtValor.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el estudiante" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("El codigo no puede estar vacio");
            }
            else
            {
                ServicioProyectoUniversidadSW.matricula mat;

                try
                {
                    mat = ServicioUniversidad.buscarMatricula(txtBuscar.Text);

                    if (mat == null)
                    {
                        MessageBox.Show("La matricula no existe");
                    }
                    else
                    {


                        txtCodigoEstu.Text = mat.codigoEstudiante;
                        txtCedulaEstu.Text = Convert.ToString(mat.cedulaEstudiante);
                        txtNumCreditos.Text = Convert.ToString(mat.numCreditos);
                        txtPPa.Text = Convert.ToString(mat.ppa);
                        txtValor.Text = Convert.ToString(mat.valor);
                        txtProgramaAcademico.Text = mat.programa;

                        String fecha = Convert.ToString(mat.fechaMatricula);
                        int start = 0;
                        int lenght = 10;
                        txtFechaMatricula.Text = fecha.Substring(start, lenght);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al momento de buscar el estudiante" + ex);
                }
            }
        }
    }
}
