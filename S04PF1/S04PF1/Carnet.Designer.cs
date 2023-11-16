namespace S04PF1
{
    partial class Carnet
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
            lblCarnet = new Label();
            pictureBox1 = new PictureBox();
            lblInfo = new Label();
            dtgvInscripcion = new DataGridView();
            idInscripcion = new DataGridViewTextBoxColumn();
            idSocio = new DataGridViewTextBoxColumn();
            nombreSocio = new DataGridViewTextBoxColumn();
            apellidoSocio = new DataGridViewTextBoxColumn();
            nombreActividad = new DataGridViewTextBoxColumn();
            idCarnet = new DataGridViewTextBoxColumn();
            IdCuota = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvInscripcion).BeginInit();
            SuspendLayout();
            // 
            // lblCarnet
            // 
            lblCarnet.AutoSize = true;
            lblCarnet.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarnet.Location = new Point(366, 62);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.Size = new Size(205, 25);
            lblCarnet.TabIndex = 18;
            lblCarnet.Text = "Impresión de Carnet";
            lblCarnet.Click += lblCobroCuota_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carnet;
            pictureBox1.Location = new Point(249, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(269, 145);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(262, 15);
            lblInfo.TabIndex = 26;
            lblInfo.Text = "Seleccione la inscripción para imprimir el carnet.";
            // 
            // dtgvInscripcion
            // 
            dtgvInscripcion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvInscripcion.Columns.AddRange(new DataGridViewColumn[] { idInscripcion, idSocio, nombreSocio, apellidoSocio, nombreActividad, idCarnet, IdCuota });
            dtgvInscripcion.Location = new Point(35, 197);
            dtgvInscripcion.Name = "dtgvInscripcion";
            dtgvInscripcion.RowTemplate.Height = 25;
            dtgvInscripcion.Size = new Size(743, 172);
            dtgvInscripcion.TabIndex = 27;
            dtgvInscripcion.CellContentClick += dtgvInscripcion_CellContentClick;
            // 
            // idInscripcion
            // 
            idInscripcion.HeaderText = "Id Inscripcion";
            idInscripcion.Name = "idInscripcion";
            // 
            // idSocio
            // 
            idSocio.HeaderText = "Id Socio";
            idSocio.Name = "idSocio";
            // 
            // nombreSocio
            // 
            nombreSocio.HeaderText = "Nombre";
            nombreSocio.Name = "nombreSocio";
            // 
            // apellidoSocio
            // 
            apellidoSocio.HeaderText = "Apellido";
            apellidoSocio.Name = "apellidoSocio";
            // 
            // nombreActividad
            // 
            nombreActividad.HeaderText = "Actividad";
            nombreActividad.Name = "nombreActividad";
            // 
            // idCarnet
            // 
            idCarnet.HeaderText = "Id Carnet";
            idCarnet.Name = "idCarnet";
            // 
            // IdCuota
            // 
            IdCuota.HeaderText = "Id Cuota";
            IdCuota.Name = "IdCuota";
            // 
            // Carnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvInscripcion);
            Controls.Add(lblInfo);
            Controls.Add(pictureBox1);
            Controls.Add(lblCarnet);
            Name = "Carnet";
            Text = "Carnet";
            Load += Carnet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvInscripcion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarnet;
        private PictureBox pictureBox1;
        private Label lblInfo;
        private DataGridView dtgvInscripcion;
        private DataGridViewTextBoxColumn idInscripcion;
        private DataGridViewTextBoxColumn idSocio;
        private DataGridViewTextBoxColumn nombreSocio;
        private DataGridViewTextBoxColumn apellidoSocio;
        private DataGridViewTextBoxColumn nombreActividad;
        private DataGridViewTextBoxColumn idCarnet;
        private DataGridViewTextBoxColumn IdCuota;
    }
}