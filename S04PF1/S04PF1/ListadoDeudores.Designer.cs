namespace S04PF1
{
    partial class ListadoDeudores
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
            lblDeudores = new Label();
            dtgvDeudores = new DataGridView();
            idSocio = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvDeudores).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.deudores;
            pictureBox1.Location = new Point(207, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblDeudores
            // 
            lblDeudores.AutoSize = true;
            lblDeudores.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeudores.Location = new Point(338, 56);
            lblDeudores.Name = "lblDeudores";
            lblDeudores.Size = new Size(211, 25);
            lblDeudores.TabIndex = 19;
            lblDeudores.Text = "Listado de Deudores";
            lblDeudores.Click += lblCarnet_Click;
            // 
            // dtgvDeudores
            // 
            dtgvDeudores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDeudores.Columns.AddRange(new DataGridViewColumn[] { idSocio, nombre, apellido });
            dtgvDeudores.Location = new Point(225, 145);
            dtgvDeudores.Name = "dtgvDeudores";
            dtgvDeudores.RowTemplate.Height = 25;
            dtgvDeudores.Size = new Size(345, 258);
            dtgvDeudores.TabIndex = 20;
            // 
            // idSocio
            // 
            idSocio.HeaderText = "Numero Socio";
            idSocio.Name = "idSocio";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // ListadoDeudores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvDeudores);
            Controls.Add(lblDeudores);
            Controls.Add(pictureBox1);
            Name = "ListadoDeudores";
            Text = "ListadoDeudores";
            Load += ListadoDeudores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvDeudores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDeudores;
        private DataGridView dtgvDeudores;
        private DataGridViewTextBoxColumn idSocio;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
    }
}