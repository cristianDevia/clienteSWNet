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
using System.Windows.Forms.VisualStyles;

namespace ClienteProyectoSWNet.View
{
    public partial class GUIAgregarMatricula : Form
    {
        public GUIAgregarMatricula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((txtCedulaEstudiante.Text.Equals("") || txtCodigoEstudiante.Text.Equals("")
                || txtNumCreditos.Text.Equals("") || txtNumMat.Text.Equals("")
                || txtPPA.Text.Equals("")) || txtProgramaAcademico.Equals("") || txtValor.Equals(""))
            {
                MessageBox.Show("No pueden existir campos vacios");
            }

            else
            {
                ServicioProyectoUniversidadSW.matricula mat;
                mat = new ServicioProyectoUniversidadSW.matricula();

                int numeroMatricula, numeroCreditos;
                double valor, ppa;
                DateTime fechaMatricula;

                String programa = txtProgramaAcademico.Text;
                int cedula = Convert.ToInt32(txtCedulaEstudiante.Text);
                String codigo = txtCodigoEstudiante.Text;
                numeroCreditos = Convert.ToInt32(txtNumCreditos.Text);
                numeroMatricula = Convert.ToInt32(txtNumMat.Text);
                valor = Convert.ToDouble(txtValor.Text);
                ppa = Convert.ToDouble(txtPPA.Text);

                fechaMatricula = timePickerFechaEstu.Value;

                mat.cedulaEstudiante = cedula;
                mat.programa = programa;
                mat.codigoEstudiante = codigo;
                mat.numCreditos = numeroCreditos;
                mat.numeroMatricula = numeroMatricula;
                mat.valor = valor;
                mat.ppa = ppa;
                mat.fechaMatricula = fechaMatricula;
                mat.fechaMatriculaSpecified = true;

                try
                {
                    ServicioUniversidad.agregarMatricula(mat);

                    MessageBox.Show("Matricula agregado");

                    txtCedulaEstudiante.Text = "";
                    txtCodigoEstudiante.Text = "";
                    txtNumCreditos.Text = "";
                    txtNumMat.Text = "";
                    txtPPA.Text = "";
                    txtProgramaAcademico.Text = "";
                    txtValor.Text = "";

                    timePickerFechaEstu.Value = DateTime.Today;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar estudiante" + ex);
                }
            }

        }

        private void btnListarEstudiantesMat_Click(object sender, EventArgs e)
        {
            GUIListarEstudiantesMatricula listar = new GUIListarEstudiantesMatricula(this);
            listar.Show();
        }

        private void btnListarProgramas_Click(object sender, EventArgs e)
        {
            GUIListarProgramas list = new GUIListarProgramas(this);
            list.Show();
        }

        public void setCedulaEst(String cedula)
        {
            txtCedulaEstudiante.Text = Convert.ToString(cedula);
     
        }

        public void setCodigoEst(String codigo)
        {
            txtCodigoEstudiante.Text = codigo;
        }

       public void setPrograma(String codigo)
        {
            txtProgramaAcademico.Text = codigo;
        }
    }

    }


