namespace ClienteProyectoSWNet.View
{
    partial class GUIActualizarEstudiante
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labFechaNacimiento = new System.Windows.Forms.Label();
            this.labGenero = new System.Windows.Forms.Label();
            this.labCorreo = new System.Windows.Forms.Label();
            this.labCedula = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.labCodigoEstu = new System.Windows.Forms.Label();
            this.timePickerFechaEstu = new System.Windows.Forms.DateTimePicker();
            this.rbtFemeninoEstu = new System.Windows.Forms.RadioButton();
            this.rbtMasculinoEstu = new System.Windows.Forms.RadioButton();
            this.txtCelularEstu = new System.Windows.Forms.TextBox();
            this.labCelularEstu = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBuscar.Controls.Add(this.btnActualizar);
            this.panelBuscar.Controls.Add(this.txtCelularEstu);
            this.panelBuscar.Controls.Add(this.labCelularEstu);
            this.panelBuscar.Controls.Add(this.rbtFemeninoEstu);
            this.panelBuscar.Controls.Add(this.rbtMasculinoEstu);
            this.panelBuscar.Controls.Add(this.timePickerFechaEstu);
            this.panelBuscar.Controls.Add(this.txtCorreo);
            this.panelBuscar.Controls.Add(this.txtCedula);
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.txtNombre);
            this.panelBuscar.Controls.Add(this.labFechaNacimiento);
            this.panelBuscar.Controls.Add(this.labGenero);
            this.panelBuscar.Controls.Add(this.labCorreo);
            this.panelBuscar.Controls.Add(this.labCedula);
            this.panelBuscar.Controls.Add(this.labNombre);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.labCodigoEstu);
            this.panelBuscar.Location = new System.Drawing.Point(12, 12);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(373, 306);
            this.panelBuscar.TabIndex = 1;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(150, 130);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(124, 20);
            this.txtCorreo.TabIndex = 17;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(150, 97);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(124, 20);
            this.txtCedula.TabIndex = 15;
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // labFechaNacimiento
            // 
            this.labFechaNacimiento.AutoSize = true;
            this.labFechaNacimiento.Location = new System.Drawing.Point(36, 234);
            this.labFechaNacimiento.Name = "labFechaNacimiento";
            this.labFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.labFechaNacimiento.TabIndex = 7;
            this.labFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // labGenero
            // 
            this.labGenero.AutoSize = true;
            this.labGenero.Location = new System.Drawing.Point(36, 194);
            this.labGenero.Name = "labGenero";
            this.labGenero.Size = new System.Drawing.Size(42, 13);
            this.labGenero.TabIndex = 6;
            this.labGenero.Text = "Genero";
            // 
            // labCorreo
            // 
            this.labCorreo.AutoSize = true;
            this.labCorreo.Location = new System.Drawing.Point(36, 133);
            this.labCorreo.Name = "labCorreo";
            this.labCorreo.Size = new System.Drawing.Size(38, 13);
            this.labCorreo.TabIndex = 5;
            this.labCorreo.Text = "Correo";
            // 
            // labCedula
            // 
            this.labCedula.AutoSize = true;
            this.labCedula.Location = new System.Drawing.Point(36, 100);
            this.labCedula.Name = "labCedula";
            this.labCedula.Size = new System.Drawing.Size(40, 13);
            this.labCedula.TabIndex = 3;
            this.labCedula.Text = "Cédula";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(36, 68);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(44, 13);
            this.labNombre.TabIndex = 2;
            this.labNombre.Text = "Nombre";
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
            this.labCodigoEstu.Size = new System.Drawing.Size(40, 13);
            this.labCodigoEstu.TabIndex = 0;
            this.labCodigoEstu.Text = "Código";
            // 
            // timePickerFechaEstu
            // 
            this.timePickerFechaEstu.Location = new System.Drawing.Point(150, 234);
            this.timePickerFechaEstu.Name = "timePickerFechaEstu";
            this.timePickerFechaEstu.Size = new System.Drawing.Size(200, 20);
            this.timePickerFechaEstu.TabIndex = 21;
            // 
            // rbtFemeninoEstu
            // 
            this.rbtFemeninoEstu.AutoSize = true;
            this.rbtFemeninoEstu.Location = new System.Drawing.Point(180, 211);
            this.rbtFemeninoEstu.Name = "rbtFemeninoEstu";
            this.rbtFemeninoEstu.Size = new System.Drawing.Size(71, 17);
            this.rbtFemeninoEstu.TabIndex = 23;
            this.rbtFemeninoEstu.TabStop = true;
            this.rbtFemeninoEstu.Text = "Femenino";
            this.rbtFemeninoEstu.UseVisualStyleBackColor = true;
            // 
            // rbtMasculinoEstu
            // 
            this.rbtMasculinoEstu.AutoSize = true;
            this.rbtMasculinoEstu.Location = new System.Drawing.Point(180, 188);
            this.rbtMasculinoEstu.Name = "rbtMasculinoEstu";
            this.rbtMasculinoEstu.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculinoEstu.TabIndex = 22;
            this.rbtMasculinoEstu.TabStop = true;
            this.rbtMasculinoEstu.Text = "Masculino";
            this.rbtMasculinoEstu.UseVisualStyleBackColor = true;
            // 
            // txtCelularEstu
            // 
            this.txtCelularEstu.Location = new System.Drawing.Point(150, 162);
            this.txtCelularEstu.Name = "txtCelularEstu";
            this.txtCelularEstu.Size = new System.Drawing.Size(124, 20);
            this.txtCelularEstu.TabIndex = 25;
            // 
            // labCelularEstu
            // 
            this.labCelularEstu.AutoSize = true;
            this.labCelularEstu.Location = new System.Drawing.Point(35, 165);
            this.labCelularEstu.Name = "labCelularEstu";
            this.labCelularEstu.Size = new System.Drawing.Size(39, 13);
            this.labCelularEstu.TabIndex = 24;
            this.labCelularEstu.Text = "Celular";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(209, 269);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // GUIActualizarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 330);
            this.Controls.Add(this.panelBuscar);
            this.Name = "GUIActualizarEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Estudiante";
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labFechaNacimiento;
        private System.Windows.Forms.Label labGenero;
        private System.Windows.Forms.Label labCorreo;
        private System.Windows.Forms.Label labCedula;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label labCodigoEstu;
        private System.Windows.Forms.DateTimePicker timePickerFechaEstu;
        private System.Windows.Forms.RadioButton rbtFemeninoEstu;
        private System.Windows.Forms.RadioButton rbtMasculinoEstu;
        private System.Windows.Forms.TextBox txtCelularEstu;
        private System.Windows.Forms.Label labCelularEstu;
        private System.Windows.Forms.Button btnActualizar;
    }
}