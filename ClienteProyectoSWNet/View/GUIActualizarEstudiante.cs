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
    public partial class GUIActualizarEstudiante : Form
    {
        private String codigo;

        public GUIActualizarEstudiante()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("El código no puede estar vacio");
            }
            else
            {
                ServicioProyectoUniversidadSW.estudiante estu = null;
                estu = ServicioUniversidad.buscarEstudiante(txtBuscar.Text);
                if (estu == null)
                {
                    MessageBox.Show("El estudiante no existe");
                }
                else
                {
                    try
                    {
                      

                        txtNombre.Text = estu.nombre;
                        txtCedula.Text = Convert.ToString(estu.cedula);
                        txtCorreo.Text = estu.correo;
                        txtCelularEstu.Text = Convert.ToString(estu.celular);

                        String genero = estu.genero;
                        if (genero.Equals("M"))
                        {
                            rbtMasculinoEstu.Checked = true;
                        }
                        else if (genero.Equals("F"))
                        {
                            rbtFemeninoEstu.Checked = true;
                        }

                        timePickerFechaEstu.Value = estu.fechaNacimiento;

                        codigo = txtBuscar.Text;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar estudiante");
                    }
                }

            }
 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Equals("") || txtCedula.Text.Equals("")
                || txtCelularEstu.Text.Equals("") || txtCorreo.Text.Equals("")
                || (rbtMasculinoEstu.Checked == false && rbtFemeninoEstu.Checked == false))
            {
                MessageBox.Show("No pueden haber campos vacios");
            }
            else
            {

                String nombre, pCodigo, correo;
                String genero = "";
                int cedula, celular;
                DateTime fecha;

                nombre = txtNombre.Text;
                cedula = Convert.ToInt32(txtCedula.Text);
                pCodigo = codigo;
                correo = txtCorreo.Text;
                celular = Convert.ToInt32(txtCelularEstu.Text);

                if (rbtMasculinoEstu.Checked == true)
                {
                    genero = "M";
                }
                else if (rbtFemeninoEstu.Checked == true)
                {
                    genero = "F";
                }

                fecha = timePickerFechaEstu.Value;

                try
                {

                    ServicioUniversidad.actualizarEstudiante(nombre, cedula, pCodigo, correo, celular, fecha, genero);

                    MessageBox.Show("Estudiante Actualizado");

                    txtBuscar.Text = "";
                    txtNombre.Text = "";
                    txtCedula.Text = "";
                    txtCorreo.Text = "";
                    txtCelularEstu.Text = "";
                    rbtMasculinoEstu.Checked = false;
                    rbtFemeninoEstu.Checked = false;
                    timePickerFechaEstu.Value = DateTime.Today;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al momento de actualizar estudiante" + ex);
                }
            }
        }
    }
}
