namespace S04PF1
{
    partial class Form4
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
            lblAltaSocios = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            picAltaSocio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAltaSocio).BeginInit();
            SuspendLayout();
            // 
            // lblAltaSocios
            // 
            lblAltaSocios.AutoSize = true;
            lblAltaSocios.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAltaSocios.Location = new Point(318, 32);
            lblAltaSocios.Name = "lblAltaSocios";
            lblAltaSocios.Size = new Size(161, 29);
            lblAltaSocios.TabIndex = 0;
            lblAltaSocios.Text = "Alta de Socios";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(94, 113);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 16);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(167, 106);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 22);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(167, 155);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(222, 22);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(94, 162);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(56, 16);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(167, 205);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(222, 22);
            txtDni.TabIndex = 6;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(94, 212);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(31, 16);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(167, 252);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(222, 22);
            txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(94, 259);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(58, 16);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(167, 296);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 22);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(94, 303);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 16);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(290, 351);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 46);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(424, 351);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 46);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // picAltaSocio
            // 
            picAltaSocio.Image = Properties.Resources.alta_usuario;
            picAltaSocio.Location = new Point(511, 113);
            picAltaSocio.Name = "picAltaSocio";
            picAltaSocio.Size = new Size(211, 168);
            picAltaSocio.SizeMode = PictureBoxSizeMode.Zoom;
            picAltaSocio.TabIndex = 15;
            picAltaSocio.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picAltaSocio);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblAltaSocios);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)picAltaSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltaSocios;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnGuardar;
        private Button btnLimpiar;
        private PictureBox picAltaSocio;
    }
}