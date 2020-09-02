namespace ClienteProyectoSWNet.View
{
    partial class GUIModificarMatricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.timePickerFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.labFechaNacimiento = new System.Windows.Forms.Label();
            this.labCorreo = new System.Windows.Forms.Label();
            this.labCedula = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.labCodigoEstu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumCreditos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPPA = new System.Windows.Forms.TextBox();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBuscar.Controls.Add(this.txtPPA);
            this.panelBuscar.Controls.Add(this.label3);
            this.panelBuscar.Controls.Add(this.txtNumCreditos);
            this.panelBuscar.Controls.Add(this.label2);
            this.panelBuscar.Controls.Add(this.txtValor);
            this.panelBuscar.Controls.Add(this.label1);
            this.panelBuscar.Controls.Add(this.btnActualizar);
            this.panelBuscar.Controls.Add(this.timePickerFechaMatricula);
            this.panelBuscar.Controls.Add(this.txtPrograma);
            this.panelBuscar.Controls.Add(this.txtCodigo);
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.txtCedula);
            this.panelBuscar.Controls.Add(this.labFechaNacimiento);
            this.panelBuscar.Controls.Add(this.labCorreo);
            this.panelBuscar.Controls.Add(this.labCedula);
            this.panelBuscar.Controls.Add(this.labNombre);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.labCodigoEstu);
            this.panelBuscar.Location = new System.Drawing.Point(29, 12);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(373, 364);
            this.panelBuscar.TabIndex = 2;
            this.panelBuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBuscar_Paint);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(199, 316);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // timePickerFechaMatricula
            // 
            this.timePickerFechaMatricula.Location = new System.Drawing.Point(150, 277);
            this.timePickerFechaMatricula.Name = "timePickerFechaMatricula";
            this.timePickerFechaMatricula.Size = new System.Drawing.Size(200, 20);
            this.timePickerFechaMatricula.TabIndex = 21;
            // 
            // txtPrograma
            // 
            this.txtPrograma.Location = new System.Drawing.Point(150, 130);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.ReadOnly = true;
            this.txtPrograma.Size = new System.Drawing.Size(124, 20);
            this.txtPrograma.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(150, 97);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(124, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(280, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(150, 61);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(124, 20);
            this.txtCedula.TabIndex = 8;
            // 
            // labFechaNacimiento
            // 
            this.labFechaNacimiento.AutoSize = true;
            this.labFechaNacimiento.Location = new System.Drawing.Point(36, 283);
            this.labFechaNacimiento.Name = "labFechaNacimiento";
            this.labFechaNacimiento.Size = new System.Drawing.Size(97, 13);
            this.labFechaNacimiento.TabIndex = 7;
            this.labFechaNacimiento.Text = "Fecha de matricula";
            // 
            // labCorreo
            // 
            this.labCorreo.AutoSize = true;
            this.labCorreo.Location = new System.Drawing.Point(36, 133);
            this.labCorreo.Name = "labCorreo";
            this.labCorreo.Size = new System.Drawing.Size(108, 13);
            this.labCorreo.TabIndex = 5;
            this.labCorreo.Text = "Programa Académico";
            this.labCorreo.Click += new System.EventHandler(this.labCorreo_Click);
            // 
            // labCedula
            // 
            this.labCedula.AutoSize = true;
            this.labCedula.Location = new System.Drawing.Point(36, 100);
            this.labCedula.Name = "labCedula";
            this.labCedula.Size = new System.Drawing.Size(93, 13);
            this.labCedula.TabIndex = 3;
            this.labCedula.Text = "Código Estudiante";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(36, 68);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(93, 13);
            this.labNombre.TabIndex = 2;
            this.labNombre.Text = "Cedula Estudiante";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(124, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // labCodigoEstu
            // 
            this.labCodigoEstu.AutoSize = true;
            this.labCodigoEstu.Location = new System.Drawing.Point(36, 20);
            this.labCodigoEstu.Name = "labCodigoEstu";
            this.labCodigoEstu.Size = new System.Drawing.Size(92, 13);
            this.labCodigoEstu.TabIndex = 0;
            this.labCodigoEstu.Text = "Número Matrícula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(150, 158);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(124, 20);
            this.txtValor.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Numero Creditos";
            // 
            // txtNumCreditos
            // 
            this.txtNumCreditos.Location = new System.Drawing.Point(150, 189);
            this.txtNumCreditos.Name = "txtNumCreditos";
            this.txtNumCreditos.Size = new System.Drawing.Size(124, 20);
            this.txtNumCreditos.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "PPA";
            // 
            // txtPPA
            // 
            this.txtPPA.Location = new System.Drawing.Point(150, 221);
            this.txtPPA.Name = "txtPPA";
            this.txtPPA.Size = new System.Drawing.Size(124, 20);
            this.txtPPA.TabIndex = 32;
            // 
            // GUIModificarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 388);
            this.Controls.Add(this.panelBuscar);
            this.Name = "GUIModificarMatricula";
            this.Text = "Modificar Matricula";
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DateTimePicker timePickerFechaMatricula;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label labFechaNacimiento;
        private System.Windows.Forms.Label labCorreo;
        private System.Windows.Forms.Label labCedula;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label labCodigoEstu;
        private System.Windows.Forms.TextBox txtPPA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumCreditos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
    }
}