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
    public partial class GUIAgregarEstudiante : Form
    {
        public GUIAgregarEstudiante()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
         
            if((txtNombreEstu.Text.Equals("") || txtCodigoEstu.Text.Equals("") 
                || txtCedulaEstu.Text.Equals("") || txtCorreoEstu.Text.Equals("") 
                || txtCelularEstu.Text.Equals("") ) || (rbtMasculinoEstu.Checked == false && rbtFemeninoEstu.Checked == false))
            {
                MessageBox.Show("No pueden existir campos vacios");
            }
            else
            {
                ServicioProyectoUniversidadSW.estudiante estu;
                estu = new ServicioProyectoUniversidadSW.estudiante();

                String nombre, codigo, correo;
                String genero = "";
                int cedula, celular;
                DateTime fechaNacimiento;

                nombre = txtNombreEstu.Text;
                cedula = Convert.ToInt32(txtCedulaEstu.Text);
                codigo = txtCodigoEstu.Text;
                correo = txtCorreoEstu.Text;
                celular = Convert.ToInt32(txtCelularEstu.Text);

                if (rbtMasculinoEstu.Checked == true)
                {
                    genero = "M";
                }
                else if (rbtFemeninoEstu.Checked == true)
                {
                    genero = "F";
                }

                fechaNacimiento = timePickerFechaEstu.Value;

                estu.nombre = nombre;
                estu.cedula = cedula;
                estu.codigo = codigo;
                estu.correo = correo;
                estu.celular = celular;
                estu.genero = genero;

                estu.fechaNacimiento = fechaNacimiento;
                estu.fechaNacimientoSpecified = true;

                try
                {
                    ServicioUniversidad.agregarEstudiante(estu);

                    MessageBox.Show("Estudiante agregado");

                    txtNombreEstu.Text = "";
                    txtCedulaEstu.Text = "";
                    txtCodigoEstu.Text = "";
                    txtCorreoEstu.Text = "";
                    txtCelularEstu.Text = "";

                    rbtMasculinoEstu.Checked = false;
                    rbtFemeninoEstu.Checked = false;

                    timePickerFechaEstu.Value = DateTime.Today;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar estudiante" + ex);
                }
            }

        }
    }
}
