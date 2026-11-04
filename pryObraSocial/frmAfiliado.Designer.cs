namespace pryObraSocial
{
    partial class frmAfiliado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAfiliado));
            lblTitulo = new Label();
            grpDatosPersonales = new GroupBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNroAfiliado = new TextBox();
            lblNroAfiliado = new Label();
            grpPlan = new GroupBox();
            txtCosto = new TextBox();
            lblCosto = new Label();
            cmbPlan = new ComboBox();
            lblPlan = new Label();
            cmdGuardar = new Button();
            cmdCancelar = new Button();
            grpDatosPersonales.SuspendLayout();
            grpPlan.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(301, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CARGA DE DATOS DEL AFILIADO";
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.BackColor = SystemColors.ButtonHighlight;
            grpDatosPersonales.Controls.Add(txtTelefono);
            grpDatosPersonales.Controls.Add(lblTelefono);
            grpDatosPersonales.Controls.Add(dtpFechaNacimiento);
            grpDatosPersonales.Controls.Add(lblFechaNacimiento);
            grpDatosPersonales.Controls.Add(txtDni);
            grpDatosPersonales.Controls.Add(lblDni);
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Controls.Add(txtApellido);
            grpDatosPersonales.Controls.Add(lblApellido);
            grpDatosPersonales.Controls.Add(txtNroAfiliado);
            grpDatosPersonales.Controls.Add(lblNroAfiliado);
            grpDatosPersonales.Location = new Point(20, 55);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(470, 235);
            grpDatosPersonales.TabIndex = 1;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos personales";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(170, 195);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(140, 23);
            txtTelefono.TabIndex = 11;
            txtTelefono.KeyPress += solonumeros_KeyPress;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(20, 198);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Teléfono:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(170, 162);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(140, 23);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(20, 165);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(120, 15);
            lblFechaNacimiento.TabIndex = 8;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(170, 129);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(140, 23);
            txtDni.TabIndex = 7;
            txtDni.KeyPress += solonumeros_KeyPress;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(20, 132);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 96);
            txtNombre.MaxLength = 40;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Location = new Point(170, 63);
            txtApellido.MaxLength = 40;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(275, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(20, 66);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtNroAfiliado
            // 
            txtNroAfiliado.Location = new Point(170, 30);
            txtNroAfiliado.MaxLength = 10;
            txtNroAfiliado.Name = "txtNroAfiliado";
            txtNroAfiliado.Size = new Size(140, 23);
            txtNroAfiliado.TabIndex = 1;
            txtNroAfiliado.KeyPress += solonumeros_KeyPress;
            // 
            // lblNroAfiliado
            // 
            lblNroAfiliado.AutoSize = true;
            lblNroAfiliado.Location = new Point(20, 33);
            lblNroAfiliado.Name = "lblNroAfiliado";
            lblNroAfiliado.Size = new Size(82, 15);
            lblNroAfiliado.TabIndex = 0;
            lblNroAfiliado.Text = "N° de afiliado:";
            // 
            // grpPlan
            // 
            grpPlan.BackColor = SystemColors.ControlLightLight;
            grpPlan.Controls.Add(txtCosto);
            grpPlan.Controls.Add(lblCosto);
            grpPlan.Controls.Add(cmbPlan);
            grpPlan.Controls.Add(lblPlan);
            grpPlan.Location = new Point(20, 300);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(470, 105);
            grpPlan.TabIndex = 2;
            grpPlan.TabStop = false;
            grpPlan.Text = "Plan de cobertura";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(170, 63);
            txtCosto.Multiline = true;
            txtCosto.Name = "txtCosto";
            txtCosto.ReadOnly = true;
            txtCosto.Size = new Size(140, 23);
            txtCosto.TabIndex = 3;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(20, 66);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(106, 15);
            lblCosto.TabIndex = 2;
            lblCosto.Text = "Costo mensual ($):";
            // 
            // cmbPlan
            // 
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "Plan Básico", "Plan Joven", "Plan Familiar", "Plan Integral", "Plan Premium" });
            cmbPlan.Location = new Point(170, 30);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(200, 23);
            cmbPlan.TabIndex = 1;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(20, 33);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(33, 15);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan:";
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(290, 420);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(95, 32);
            cmdGuardar.TabIndex = 3;
            cmdGuardar.Text = "&Guardar";
            cmdGuardar.UseVisualStyleBackColor = true;
            cmdGuardar.Click += cmdGuardar_Click;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(395, 420);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(95, 32);
            cmdCancelar.TabIndex = 4;
            cmdCancelar.Text = "&Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAfiliado
            // 
            AcceptButton = cmdGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            CancelButton = cmdCancelar;
            ClientSize = new Size(510, 470);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdGuardar);
            Controls.Add(grpPlan);
            Controls.Add(grpDatosPersonales);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAfiliado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Obra Social - Afiliados";
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpDatosPersonales;
        private Label lblNroAfiliado;
        private TextBox txtNroAfiliado;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private GroupBox grpPlan;
        private Label lblPlan;
        private ComboBox cmbPlan;
        private Label lblCosto;
        private TextBox txtCosto;
        private Button cmdGuardar;
        private Button cmdCancelar;
    }
}
