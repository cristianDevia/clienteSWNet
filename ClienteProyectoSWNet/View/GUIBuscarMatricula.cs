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
    public partial class GUIBuscarMatricula : Form
    {
        public GUIBuscarMatricula()
        {
            InitializeComponent();
        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
    

                        txtCodigo.Text = mat.codigoEstudiante;
                        txtCedula.Text = Convert.ToString(mat.cedulaEstudiante);
                        txtNumeroCreditos.Text = Convert.ToString(mat.numCreditos);
                        txtPPA.Text = Convert.ToString(mat.ppa); 
                        txtValor.Text = Convert.ToString(mat.valor);
                        txtPrograma.Text = mat.programa;

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
