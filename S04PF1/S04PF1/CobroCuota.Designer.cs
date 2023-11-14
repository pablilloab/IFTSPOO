namespace S04PF1
{
    partial class CobroCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CobroCuota));
            pictureBox1 = new PictureBox();
            lblCobroCuota = new Label();
            txtCodSocio = new TextBox();
            lblCodSocio = new Label();
            btnBuscar = new Button();
            dtgvCuota = new DataGridView();
            fechaCobro = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            medioPago = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCuota).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(239, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblCobroCuota
            // 
            lblCobroCuota.AutoSize = true;
            lblCobroCuota.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCobroCuota.Location = new Point(363, 42);
            lblCobroCuota.Name = "lblCobroCuota";
            lblCobroCuota.Size = new Size(163, 25);
            lblCobroCuota.TabIndex = 17;
            lblCobroCuota.Text = "Cobro de Cuota";
            lblCobroCuota.Click += lblAltaActividad_Click;
            // 
            // txtCodSocio
            // 
            txtCodSocio.Location = new Point(314, 121);
            txtCodSocio.Name = "txtCodSocio";
            txtCodSocio.Size = new Size(100, 23);
            txtCodSocio.TabIndex = 21;
            // 
            // lblCodSocio
            // 
            lblCodSocio.AutoSize = true;
            lblCodSocio.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodSocio.Location = new Point(211, 129);
            lblCodSocio.Name = "lblCodSocio";
            lblCodSocio.Size = new Size(97, 15);
            lblCodSocio.TabIndex = 20;
            lblCodSocio.Text = "Código de Socio";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(467, 98);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 46);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnGuardar_Click;
            // 
            // dtgvCuota
            // 
            dtgvCuota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCuota.Columns.AddRange(new DataGridViewColumn[] { fechaCobro, monto, medioPago, estado });
            dtgvCuota.Location = new Point(176, 177);
            dtgvCuota.Name = "dtgvCuota";
            dtgvCuota.RowTemplate.Height = 25;
            dtgvCuota.Size = new Size(443, 174);
            dtgvCuota.TabIndex = 24;
            dtgvCuota.CellContentClick += dtgvCuota_CellContentClick;
            // 
            // fechaCobro
            // 
            fechaCobro.HeaderText = "Fecha Cobro";
            fechaCobro.Name = "fechaCobro";
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            // 
            // medioPago
            // 
            medioPago.HeaderText = "Medio Pago";
            medioPago.Name = "medioPago";
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            // 
            // CobroCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvCuota);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodSocio);
            Controls.Add(lblCodSocio);
            Controls.Add(lblCobroCuota);
            Controls.Add(pictureBox1);
            Name = "CobroCuota";
            Text = "CobroCuota";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCuota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCobroCuota;
        private TextBox txtCodSocio;
        private Label lblCodSocio;
        private Button btnBuscar;
        private DataGridView dtgvCuota;
        private DataGridViewTextBoxColumn fechaCobro;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn medioPago;
        private DataGridViewTextBoxColumn estado;
    }
}