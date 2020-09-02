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
    public partial class GUIListarEstudiantesMatricula : Form
    {
        GUIAgregarMatricula agregar;
        public GUIListarEstudiantesMatricula(GUIAgregarMatricula gui)
        {
            agregar = gui;
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ServicioProyectoUniversidadSW.estudiante[] estudiantes;

            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Cédula"));
            dt.Columns.Add(new DataColumn("Correo"));
            dt.Columns.Add(new DataColumn("Célular"));
            dt.Columns.Add(new DataColumn("Fecha de Nacimiento"));
            dt.Columns.Add(new DataColumn("Genero"));

            try
            {
                estudiantes = ServicioUniversidad.listarEstudiantes();

                for (int i = 0; i < estudiantes.Length; i++)
                {
                    dr = dt.NewRow();
                    dr["Nombre"] = estudiantes[i].nombre;
                    dr["Código"] = estudiantes[i].codigo;
                    dr["Cédula"] = Convert.ToInt32(estudiantes[i].cedula);
                    dr["Correo"] = estudiantes[i].correo;
                    dr["Célular"] = Convert.ToInt32(estudiantes[i].celular);

                    String fecha = Convert.ToString(estudiantes[i].fechaNacimiento);
                    int start = 0;
                    int lenght = 10;
                    dr["Fecha de Nacimiento"] = fecha.Substring(start, lenght);

                    dr["Genero"] = estudiantes[i].genero;

                    dt.Rows.Add(dr);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar estudiantes ! " + ex);
            }

            grilla.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String y = grilla.CurrentRow.Cells[2].Value.ToString();
            agregar.setCedulaEst(y);

        }

        private void grilla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String y = grilla.CurrentRow.Cells[1].Value.ToString();
            agregar.setCodigoEst(y);
        }
    }
}
