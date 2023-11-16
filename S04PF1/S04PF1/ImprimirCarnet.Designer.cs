namespace S04PF1
{
    partial class ImprimirCarnet
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblNumCarnet = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblActividad = new Label();
            lblFecha = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtActividad = new TextBox();
            txtFecha = new TextBox();
            txtNumCarnet = new TextBox();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_gym_carnet;
            pictureBox1.Location = new Point(-43, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(176, 31);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 1;
            label1.Text = "CARNET DE SOCIO";
            label1.Click += label1_Click;
            // 
            // lblNumCarnet
            // 
            lblNumCarnet.AutoSize = true;
            lblNumCarnet.Location = new Point(161, 73);
            lblNumCarnet.Name = "lblNumCarnet";
            lblNumCarnet.Size = new Size(108, 15);
            lblNumCarnet.TabIndex = 2;
            lblNumCarnet.Text = "Numero de Carnet:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 131);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(203, 131);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(28, 174);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(60, 15);
            lblActividad.TabIndex = 5;
            lblActividad.Text = "Actividad:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(203, 174);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(86, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha Emisión:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(263, 123);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(90, 166);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(100, 23);
            txtActividad.TabIndex = 9;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(295, 166);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 10;
            // 
            // txtNumCarnet
            // 
            txtNumCarnet.Location = new Point(279, 70);
            txtNumCarnet.Name = "txtNumCarnet";
            txtNumCarnet.Size = new Size(100, 23);
            txtNumCarnet.TabIndex = 11;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(174, 212);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 12;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // ImprimirCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 242);
            Controls.Add(btnImprimir);
            Controls.Add(txtNumCarnet);
            Controls.Add(txtFecha);
            Controls.Add(txtActividad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblFecha);
            Controls.Add(lblActividad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblNumCarnet);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ImprimirCarnet";
            Text = "ImprimirCarnet";
            Load += ImprimirCarnet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblNumCarnet;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblActividad;
        private Label lblFecha;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtActividad;
        private TextBox txtFecha;
        private TextBox txtNumCarnet;
        private Button btnImprimir;
    }
}