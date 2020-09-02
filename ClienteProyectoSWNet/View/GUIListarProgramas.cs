using ClienteProyectoSWNet.model;
using ClienteProyectoSWNet.ServicioProyectoUniversidadSW;
using System;
using System.Collections;
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
    public partial class GUIListarProgramas : Form
    {
        GUIAgregarMatricula gui;
        public GUIListarProgramas(GUIAgregarMatricula pGui)
        {
            gui = pGui;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioProyectoUniversidadSW.programaAcademico[] programas;

            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Codigo"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Registro"));
            dt.Columns.Add(new DataColumn("Duración"));
            dt.Columns.Add(new DataColumn("Modalidad"));
            

            try
            {
                programas = ServicioUniversidad.listarProgramas();

                for (int i = 0; i<programas.Length; i++)
                {
                    dr = dt.NewRow();
                    dr["Codigo"] = Convert.ToString(programas[i].codigo);
                    dr["Nombre"] = programas[i].nombre;                  
                    dr["Registro"] = programas[i].registroCalificado;
                    dr["Duración"] = Convert.ToString(programas[i].duracionMeses);
                    dr["Modalidad"] = programas[i].modalidad;
     


                    dt.Rows.Add(dr);
                }

}
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar estudiantes ! " + ex);
            }

            grilla.DataSource = dt;

        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String y = grilla.CurrentRow.Cells[0].Value.ToString();
            gui.setPrograma(y);
            
        }
    }
}
