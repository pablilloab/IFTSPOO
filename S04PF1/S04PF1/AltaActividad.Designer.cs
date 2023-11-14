namespace S04PF1
{
    partial class AltaActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaActividad));
            picAltaActividad = new PictureBox();
            lblAltaActividad = new Label();
            lblCodSocio = new Label();
            txtCodSocio = new TextBox();
            dtgvActividad = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            horario = new DataGridViewTextBoxColumn();
            costoMensual = new DataGridViewTextBoxColumn();
            costoDiario = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            chkDia = new CheckBox();
            lblTiempo = new Label();
            txtTiempo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picAltaActividad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            SuspendLayout();
            // 
            // picAltaActividad
            // 
            picAltaActividad.Image = (Image)resources.GetObject("picAltaActividad.Image");
            picAltaActividad.Location = new Point(259, 12);
            picAltaActividad.Name = "picAltaActividad";
            picAltaActividad.Size = new Size(96, 73);
            picAltaActividad.SizeMode = PictureBoxSizeMode.Zoom;
            picAltaActividad.TabIndex = 17;
            picAltaActividad.TabStop = false;
            // 
            // lblAltaActividad
            // 
            lblAltaActividad.AutoSize = true;
            lblAltaActividad.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAltaActividad.Location = new Point(371, 34);
            lblAltaActividad.Name = "lblAltaActividad";
            lblAltaActividad.Size = new Size(196, 25);
            lblAltaActividad.TabIndex = 16;
            lblAltaActividad.Text = "Alta de Actividades";
            lblAltaActividad.Click += lblAltaSocios_Click;
            // 
            // lblCodSocio
            // 
            lblCodSocio.AutoSize = true;
            lblCodSocio.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodSocio.Location = new Point(137, 126);
            lblCodSocio.Name = "lblCodSocio";
            lblCodSocio.Size = new Size(97, 15);
            lblCodSocio.TabIndex = 18;
            lblCodSocio.Text = "Código de Socio";
            lblCodSocio.Click += lblNombre_Click;
            // 
            // txtCodSocio
            // 
            txtCodSocio.Location = new Point(240, 118);
            txtCodSocio.Name = "txtCodSocio";
            txtCodSocio.Size = new Size(100, 23);
            txtCodSocio.TabIndex = 19;
            // 
            // dtgvActividad
            // 
            dtgvActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividad.Columns.AddRange(new DataGridViewColumn[] { codigo, descripcion, horario, costoMensual, costoDiario });
            dtgvActividad.Location = new Point(137, 169);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.RowTemplate.Height = 25;
            dtgvActividad.Size = new Size(544, 150);
            dtgvActividad.TabIndex = 20;
            dtgvActividad.CellContentClick += dataGridView1_CellContentClick;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            // 
            // horario
            // 
            horario.HeaderText = "Horario";
            horario.Name = "horario";
            // 
            // costoMensual
            // 
            costoMensual.HeaderText = "Costo/Mes";
            costoMensual.Name = "costoMensual";
            // 
            // costoDiario
            // 
            costoDiario.HeaderText = "Costo/Dia";
            costoDiario.Name = "costoDiario";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(572, 367);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 46);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkDia
            // 
            chkDia.AutoSize = true;
            chkDia.Location = new Point(591, 120);
            chkDia.Name = "chkDia";
            chkDia.Size = new Size(90, 19);
            chkDia.TabIndex = 23;
            chkDia.Text = "es por el Día";
            chkDia.UseVisualStyleBackColor = true;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblTiempo.Location = new Point(389, 126);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(49, 15);
            lblTiempo.TabIndex = 24;
            lblTiempo.Text = "Tiempo";
            lblTiempo.Click += label1_Click_1;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(444, 118);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 23);
            txtTiempo.TabIndex = 25;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTiempo);
            Controls.Add(lblTiempo);
            Controls.Add(chkDia);
            Controls.Add(btnGuardar);
            Controls.Add(dtgvActividad);
            Controls.Add(txtCodSocio);
            Controls.Add(lblCodSocio);
            Controls.Add(picAltaActividad);
            Controls.Add(lblAltaActividad);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)picAltaActividad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAltaActividad;
        private Label lblAltaActividad;
        private Label lblCodSocio;
        private TextBox txtCodSocio;
        private DataGridView dtgvActividad;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn horario;
        private DataGridViewTextBoxColumn costoMensual;
        private DataGridViewTextBoxColumn costoDiario;
        private CheckBox chkDia;
        private Label lblTiempo;
        private TextBox txtTiempo;
    }
}