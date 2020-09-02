using ClienteProyectoSWNet.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteProyectoSWNet
{
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por:" + "\n" + "Cristian Daniel Devia Bonilla 2220161013" + "\n" + "Juan Esteban Rubio Bahamon 2220161020");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIBuscarEstudiante guiBuscar = new GUIBuscarEstudiante();
            guiBuscar.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIActualizarEstudiante guiActualizar = new GUIActualizarEstudiante();
            guiActualizar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIELiminarEstudiante guiEliminar = new GUIELiminarEstudiante();
            guiEliminar.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListar guiListar = new GUIListar();
            guiListar.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAgregarEstudiante guiAgregar = new GUIAgregarEstudiante();
            guiAgregar.Show();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIAgregarMatricula guiMatAgregar = new GUIAgregarMatricula();
            guiMatAgregar.Show();
        }

        private void modiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIModificarMatricula gui = new GUIModificarMatricula();
            gui.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIBuscarMatricula gui = new GUIBuscarMatricula();
            gui.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIEliminarMatricula gui = new GUIEliminarMatricula();
            gui.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIListarMatriculas gui = new GUIListarMatriculas();
            gui.Show();
        }
    }
}
