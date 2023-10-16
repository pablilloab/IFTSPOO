namespace S04PF1
{
    partial class Form3
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
            btnAltaSocio = new Button();
            lblMenuPrincipal = new Label();
            btnAltaNoSocio = new Button();
            btnCobroCuota = new Button();
            btnEntregaCarnet = new Button();
            btnListadoVencimiento = new Button();
            lblAltaSocio = new Label();
            lblCargaNoSocio = new Label();
            lblCobroCuota = new Label();
            lblEntregaCarnet = new Label();
            lblListadoVencimientos = new Label();
            SuspendLayout();
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAltaSocio.Location = new Point(81, 93);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new Size(142, 48);
            btnAltaSocio.TabIndex = 0;
            btnAltaSocio.Text = "Alta Socio";
            btnAltaSocio.UseVisualStyleBackColor = true;
            btnAltaSocio.Click += btnAltaSocio_Click;
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenuPrincipal.Location = new Point(303, 19);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new Size(202, 29);
            lblMenuPrincipal.TabIndex = 5;
            lblMenuPrincipal.Text = "MENU PRINCIPAL";
            lblMenuPrincipal.Click += label1_Click;
            // 
            // btnAltaNoSocio
            // 
            btnAltaNoSocio.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAltaNoSocio.Location = new Point(81, 147);
            btnAltaNoSocio.Name = "btnAltaNoSocio";
            btnAltaNoSocio.Size = new Size(142, 48);
            btnAltaNoSocio.TabIndex = 6;
            btnAltaNoSocio.Text = "Alta No Socio";
            btnAltaNoSocio.UseVisualStyleBackColor = true;
            // 
            // btnCobroCuota
            // 
            btnCobroCuota.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnCobroCuota.Location = new Point(81, 201);
            btnCobroCuota.Name = "btnCobroCuota";
            btnCobroCuota.Size = new Size(142, 48);
            btnCobroCuota.TabIndex = 7;
            btnCobroCuota.Text = "Cobro de Cuota";
            btnCobroCuota.UseVisualStyleBackColor = true;
            // 
            // btnEntregaCarnet
            // 
            btnEntregaCarnet.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntregaCarnet.Location = new Point(81, 255);
            btnEntregaCarnet.Name = "btnEntregaCarnet";
            btnEntregaCarnet.Size = new Size(142, 48);
            btnEntregaCarnet.TabIndex = 8;
            btnEntregaCarnet.Text = "Entrega de Carnet";
            btnEntregaCarnet.UseVisualStyleBackColor = true;
            // 
            // btnListadoVencimiento
            // 
            btnListadoVencimiento.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnListadoVencimiento.Location = new Point(81, 309);
            btnListadoVencimiento.Name = "btnListadoVencimiento";
            btnListadoVencimiento.Size = new Size(142, 48);
            btnListadoVencimiento.TabIndex = 9;
            btnListadoVencimiento.Text = "Listado Vencimientos";
            btnListadoVencimiento.UseVisualStyleBackColor = true;
            // 
            // lblAltaSocio
            // 
            lblAltaSocio.AutoSize = true;
            lblAltaSocio.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblAltaSocio.Location = new Point(239, 110);
            lblAltaSocio.Name = "lblAltaSocio";
            lblAltaSocio.Size = new Size(215, 16);
            lblAltaSocio.TabIndex = 10;
            lblAltaSocio.Text = "Carga de datos para alta de socios.";
            // 
            // lblCargaNoSocio
            // 
            lblCargaNoSocio.AutoSize = true;
            lblCargaNoSocio.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblCargaNoSocio.Location = new Point(239, 163);
            lblCargaNoSocio.Name = "lblCargaNoSocio";
            lblCargaNoSocio.Size = new Size(238, 16);
            lblCargaNoSocio.TabIndex = 11;
            lblCargaNoSocio.Text = "Carga de datos para alta de NO socios.";
            // 
            // lblCobroCuota
            // 
            lblCobroCuota.AutoSize = true;
            lblCobroCuota.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblCobroCuota.Location = new Point(239, 217);
            lblCobroCuota.Name = "lblCobroCuota";
            lblCobroCuota.Size = new Size(186, 16);
            lblCobroCuota.TabIndex = 12;
            lblCobroCuota.Text = "Cobro de cuota por actividad.";
            // 
            // lblEntregaCarnet
            // 
            lblEntregaCarnet.AutoSize = true;
            lblEntregaCarnet.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblEntregaCarnet.Location = new Point(239, 271);
            lblEntregaCarnet.Name = "lblEntregaCarnet";
            lblEntregaCarnet.Size = new Size(163, 16);
            lblEntregaCarnet.TabIndex = 13;
            lblEntregaCarnet.Text = "Entrea de carnet de socio.";
            // 
            // lblListadoVencimientos
            // 
            lblListadoVencimientos.AutoSize = true;
            lblListadoVencimientos.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblListadoVencimientos.Location = new Point(239, 325);
            lblListadoVencimientos.Name = "lblListadoVencimientos";
            lblListadoVencimientos.Size = new Size(334, 16);
            lblListadoVencimientos.TabIndex = 14;
            lblListadoVencimientos.Text = "Listado de socios que al dia de la fecha vence su cuota.";
            lblListadoVencimientos.Click += label1_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblListadoVencimientos);
            Controls.Add(lblEntregaCarnet);
            Controls.Add(lblCobroCuota);
            Controls.Add(lblCargaNoSocio);
            Controls.Add(lblAltaSocio);
            Controls.Add(btnListadoVencimiento);
            Controls.Add(btnEntregaCarnet);
            Controls.Add(btnCobroCuota);
            Controls.Add(btnAltaNoSocio);
            Controls.Add(lblMenuPrincipal);
            Controls.Add(btnAltaSocio);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAltaSocio;
        private Label lblMenuPrincipal;
        private Button btnAltaNoSocio;
        private Button btnCobroCuota;
        private Button btnEntregaCarnet;
        private Button btnListadoVencimiento;
        private Label lblAltaSocio;
        private Label lblCargaNoSocio;
        private Label lblCobroCuota;
        private Label lblEntregaCarnet;
        private Label lblListadoVencimientos;
    }
}