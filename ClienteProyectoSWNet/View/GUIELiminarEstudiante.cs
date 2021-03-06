﻿using ClienteProyectoSWNet.model;
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
    public partial class GUIELiminarEstudiante : Form
    {
        public GUIELiminarEstudiante()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioUniversidad.eliminarEstudiante(txtBuscar.Text);
                MessageBox.Show("Estudiante Eliminado");

                txtBuscar.Text = "";
                txtNombre.Text = "";
                txtCedula.Text = "";
                txtCorreo.Text = "";
                txtCelular.Text = "";
                txtFechaNacimiento.Text = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el estudiante" + ex);
            }
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
                       
                        txtBuscar.Text = estu.codigo;

                        txtNombre.Text = estu.nombre;
                        txtCedula.Text = Convert.ToString(estu.codigo);
                        txtCorreo.Text = estu.correo;
                        txtCelular.Text = Convert.ToString(estu.celular);

                        if (estu.genero.Equals("M"))
                        {
                            txtGenero.Text = "Masculino";
                        }
                        else if (estu.genero.Equals("F"))
                        {
                            txtGenero.Text = "Femenino";
                        }

                        String fecha = Convert.ToString(estu.fechaNacimiento);
                        int start = 0;
                        int lenght = 10;
                        txtFechaNacimiento.Text = fecha.Substring(start, lenght);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al momento de buscar el estudiante" + ex);
                    }
                }
            }

        }
    }
}
