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
    public partial class GUIListarMatriculas : Form
    {
        public GUIListarMatriculas()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ServicioProyectoUniversidadSW.matricula[] matriculas;

            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Numero"));
            dt.Columns.Add(new DataColumn("Estu. Cedula"));
            dt.Columns.Add(new DataColumn("Estu. Codigo"));
            dt.Columns.Add(new DataColumn("Programa"));
            dt.Columns.Add(new DataColumn("Num. Creditos"));
            dt.Columns.Add(new DataColumn("PPA"));
            dt.Columns.Add(new DataColumn("Valor"));

            try
            {
                matriculas = ServicioUniversidad.listarMatriculas();
                if (matriculas == null)
                {
                    MessageBox.Show("No existen matriculas");

                }
                else
                {
                    for (int i = 0; i < matriculas.Length; i++)
                    {
                        dr = dt.NewRow();
                        dr["Numero"] = Convert.ToString(matriculas[i].numeroMatricula);
                        dr["Estu. Cedula"] = Convert.ToString(matriculas[i].cedulaEstudiante);
                        dr["Estu. Codigo"] = matriculas[i].codigoEstudiante;
                        dr["Programa"] = matriculas[i].programa;
                        dr["Num. Creditos"] = matriculas[i].numCreditos;
                        dr["PPA"] = matriculas[i].ppa;
                        dr["Valor"] = matriculas[i].valor;






                        dt.Rows.Add(dr);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar estudiantes ! " + ex);
            }

            grilla.DataSource = dt;
        }

       private void button1_Click_1(object sender, EventArgs e)
        {
            ServicioProyectoUniversidadSW.matricula[] matriculas;

            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Numero"));
            dt.Columns.Add(new DataColumn("Estu. Cedula"));
            dt.Columns.Add(new DataColumn("Estu. Codigo"));
            dt.Columns.Add(new DataColumn("Programa"));
            dt.Columns.Add(new DataColumn("Num. Creditos"));
            dt.Columns.Add(new DataColumn("PPA"));
            dt.Columns.Add(new DataColumn("Valor"));

            try
            {
                matriculas = ServicioUniversidad.listarMatriculas();
                if (matriculas == null)
                {
                    MessageBox.Show("No existen matriculas");

                }
                else
                {
                    for (int i = 0; i < matriculas.Length; i++)
                    {
                        if (matriculas[i].valor >= Convert.ToInt32(txtValorFilt.Text))
                        {
                            dr = dt.NewRow();
                            dr["Numero"] = Convert.ToString(matriculas[i].numeroMatricula);
                            dr["Estu. Cedula"] = Convert.ToString(matriculas[i].cedulaEstudiante);
                            dr["Estu. Codigo"] = matriculas[i].codigoEstudiante;
                            dr["Programa"] = matriculas[i].programa;
                            dr["Num. Creditos"] = matriculas[i].numCreditos;
                            dr["PPA"] = matriculas[i].ppa;
                            dr["Valor"] = matriculas[i].valor;


                            dt.Rows.Add(dr);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar estudiantes ! " + ex);
            }

            grilla.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServicioProyectoUniversidadSW.matricula[] matriculas;

            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Numero"));
            dt.Columns.Add(new DataColumn("Estu. Cedula"));
            dt.Columns.Add(new DataColumn("Estu. Codigo"));
            dt.Columns.Add(new DataColumn("Programa"));
            dt.Columns.Add(new DataColumn("Num. Creditos"));
            dt.Columns.Add(new DataColumn("PPA"));
            dt.Columns.Add(new DataColumn("Valor"));

            try
            {
                matriculas = ServicioUniversidad.listarMatriculas();
                if (matriculas == null)
                {
                    MessageBox.Show("No existen matriculas");

                }
                else
                {
                    for (int i = 0; i < matriculas.Length; i++)
                    {
                        if (matriculas[i].numCreditos >= Convert.ToInt32(txtCreditosFilt.Text))
                        {
                            dr = dt.NewRow();
                            dr["Numero"] = Convert.ToString(matriculas[i].numeroMatricula);
                            dr["Estu. Cedula"] = Convert.ToString(matriculas[i].cedulaEstudiante);
                            dr["Estu. Codigo"] = matriculas[i].codigoEstudiante;
                            dr["Programa"] = matriculas[i].programa;
                            dr["Num. Creditos"] = matriculas[i].numCreditos;
                            dr["PPA"] = matriculas[i].ppa;
                            dr["Valor"] = matriculas[i].valor;


                            dt.Rows.Add(dr);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar estudiantes ! " + ex);
            }

            grilla.DataSource = dt;
        }
    }
}
