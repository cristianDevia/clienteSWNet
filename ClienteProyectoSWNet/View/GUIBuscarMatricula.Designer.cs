namespace ClienteProyectoSWNet.View
{
    partial class GUIBuscarMatricula
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
            this.txtNumeroCreditos = new System.Windows.Forms.TextBox();
            this.labCelular = new System.Windows.Forms.Label();
            this.txtFechaMatricula = new System.Windows.Forms.TextBox();
            this.txtPPA = new System.Windows.Forms.TextBox();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labFechaNacimiento = new System.Windows.Forms.Label();
            this.labGenero = new System.Windows.Forms.Label();
            this.labCorreo = new System.Windows.Forms.Label();
            this.labCedula = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.labCodigoEstu = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBuscar.Controls.Add(this.label1);
            this.panelBuscar.Controls.Add(this.txtValor);
            this.panelBuscar.Controls.Add(this.txtNumeroCreditos);
            this.panelBuscar.Controls.Add(this.labCelular);
            this.panelBuscar.Controls.Add(this.txtFechaMatricula);
            this.panelBuscar.Controls.Add(this.txtPPA);
            this.panelBuscar.Controls.Add(this.txtPrograma);
            this.panelBuscar.Controls.Add(this.txtCedula);
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.txtCodigo);
            this.panelBuscar.Controls.Add(this.labFechaNacimiento);
            this.panelBuscar.Controls.Add(this.labGenero);
            this.panelBuscar.Controls.Add(this.labCorreo);
            this.panelBuscar.Controls.Add(this.labCedula);
            this.panelBuscar.Controls.Add(this.labNombre);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.labCodigoEstu);
            this.panelBuscar.Location = new System.Drawing.Point(15, 18);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(394, 317);
            this.panelBuscar.TabIndex = 1;
            // 
            // txtNumeroCreditos
            // 
            this.txtNumeroCreditos.Location = new System.Drawing.Point(150, 165);
            this.txtNumeroCreditos.Name = "txtNumeroCreditos";
            this.txtNumeroCreditos.ReadOnly = true;
            this.txtNumeroCreditos.Size = new System.Drawing.Size(124, 20);
            this.txtNumeroCreditos.TabIndex = 21;
            // 
            // labCelular
            // 
            this.labCelular.AutoSize = true;
            this.labCelular.Location = new System.Drawing.Point(36, 168);
            this.labCelular.Name = "labCelular";
            this.labCelular.Size = new System.Drawing.Size(85, 13);
            this.labCelular.TabIndex = 20;
            this.labCelular.Text = "Número Créditos";
            // 
            // txtFechaMatricula
            // 
            this.txtFechaMatricula.Location = new System.Drawing.Point(150, 269);
            this.txtFechaMatricula.Name = "txtFechaMatricula";
            this.txtFechaMatricula.ReadOnly = true;
            this.txtFechaMatricula.Size = new System.Drawing.Size(124, 20);
            this.txtFechaMatricula.TabIndex = 19;
            this.txtFechaMatricula.TextChanged += new System.EventHandler(this.txtFechaNacimiento_TextChanged);
            // 
            // txtPPA
            // 
            this.txtPPA.Location = new System.Drawing.Point(150, 203);
            this.txtPPA.Name = "txtPPA";
            this.txtPPA.ReadOnly = true;
            this.txtPPA.Size = new System.Drawing.Size(124, 20);
            this.txtPPA.TabIndex = 18;
            // 
            // txtPrograma
            // 
            this.txtPrograma.Location = new System.Drawing.Point(150, 130);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.ReadOnly = true;
            this.txtPrograma.Size = new System.Drawing.Size(124, 20);
            this.txtPrograma.TabIndex = 17;
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
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(150, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(124, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // labFechaNacimiento
            // 
            this.labFechaNacimiento.AutoSize = true;
            this.labFechaNacimiento.Location = new System.Drawing.Point(36, 276);
            this.labFechaNacimiento.Name = "labFechaNacimiento";
            this.labFechaNacimiento.Size = new System.Drawing.Size(100, 13);
            this.labFechaNacimiento.TabIndex = 7;
            this.labFechaNacimiento.Text = "Fecha de Matrícula";
            // 
            // labGenero
            // 
            this.labGenero.AutoSize = true;
            this.labGenero.Location = new System.Drawing.Point(36, 206);
            this.labGenero.Name = "labGenero";
            this.labGenero.Size = new System.Drawing.Size(28, 13);
            this.labGenero.TabIndex = 6;
            this.labGenero.Text = "PPA";
            // 
            // labCorreo
            // 
            this.labCorreo.AutoSize = true;
            this.labCorreo.Location = new System.Drawing.Point(36, 133);
            this.labCorreo.Name = "labCorreo";
            this.labCorreo.Size = new System.Drawing.Size(108, 13);
            this.labCorreo.TabIndex = 5;
            this.labCorreo.Text = "Programa Académico";
            // 
            // labCedula
            // 
            this.labCedula.AutoSize = true;
            this.labCedula.Location = new System.Drawing.Point(36, 100);
            this.labCedula.Name = "labCedula";
            this.labCedula.Size = new System.Drawing.Size(90, 13);
            this.labCedula.TabIndex = 3;
            this.labCedula.Text = "CédulaEstudiante";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(36, 68);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(93, 13);
            this.labNombre.TabIndex = 2;
            this.labNombre.Text = "Código Estudiante";
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
            this.labCodigoEstu.Size = new System.Drawing.Size(90, 13);
            this.labCodigoEstu.TabIndex = 0;
            this.labCodigoEstu.Text = "Número Matricula";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(150, 236);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(124, 20);
            this.txtValor.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Valor";
            // 
            // GUIBuscarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 352);
            this.Controls.Add(this.panelBuscar);
            this.Name = "GUIBuscarMatricula";
            this.Text = "Buscar Matricula";
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox txtNumeroCreditos;
        private System.Windows.Forms.Label labCelular;
        private System.Windows.Forms.TextBox txtFechaMatricula;
        private System.Windows.Forms.TextBox txtPPA;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labFechaNacimiento;
        private System.Windows.Forms.Label labGenero;
        private System.Windows.Forms.Label labCorreo;
        private System.Windows.Forms.Label labCedula;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label labCodigoEstu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
    }
}