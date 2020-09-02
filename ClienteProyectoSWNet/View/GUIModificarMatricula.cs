using ClienteProyectoSWNet.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteProyectoSWNet.View
{
    public partial class GUIModificarMatricula : Form
    {
        public GUIModificarMatricula()
        {
            InitializeComponent();
        }

        private void panelBuscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labCorreo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServicioProyectoUniversidadSW.matricula mat = null;
            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("El código no puede estar vacio");
            }
            else
            {
                        
               
                    try
                    {
                    mat = ServicioUniversidad.buscarMatricula(txtBuscar.Text);
                        if(mat == null)
                        {
                        MessageBox.Show("No existe matricula");
                        }
                       else
                        {
                        
                        txtCedula.Text = Convert.ToString(mat.cedulaEstudiante);
                        txtPrograma.Text = mat.programa;
                        txtPPA.Text = Convert.ToString(mat.ppa);
                        txtNumCreditos.Text = Convert.ToString(mat.numCreditos);
                        txtCodigo.Text = mat.codigoEstudiante;
                        txtValor.Text = Convert.ToString(mat.valor);
                        String c = Convert.ToString(mat.fechaMatricula);
                        String fecha = c.Substring(0, 5);
                        timePickerFechaMatricula.Value = Convert.ToDateTime(fecha);
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar Matricula");
                    }
                

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.Equals("") || txtPPA.Text.Equals("")
               || txtValor.Text.Equals("") )
            {
                MessageBox.Show("No pueden haber campos vacios");
            }
            else
            {
                int numCreditos;
                double ppa, valor;
                DateTime fecha;

                try
                {
                    numCreditos = Convert.ToInt32(txtNumCreditos.Text);
                    ppa = Convert.ToDouble(txtPPA.Text);
                    valor = Convert.ToDouble(txtValor.Text);
                    fecha = timePickerFechaMatricula.Value;
                    ServicioUniversidad.actualizarMatricula(Convert.ToInt32(txtBuscar.Text),numCreditos,fecha,valor,ppa) ;

                    MessageBox.Show("Estudiante Actualizado");

                    txtBuscar.Text = "";
                    txtValor.Text = "";
                    txtCedula.Text = "";
                    txtPrograma.Text = "";
                    txtPPA.Text = "";
                    txtNumCreditos.Text = "";
                    txtCodigo.Text = "";
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al momento de actualizar estudiante" + ex);
                }
            }
        
    }
    }
}
