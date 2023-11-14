namespace S04PF1
{
    partial class AltaProducto
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
            lblTitulo = new Label();
            lblCodProd = new Label();
            lblNomProd = new Label();
            lblCantidad = new Label();
            txtCodProd = new TextBox();
            txtNomProd = new TextBox();
            txtCantidad = new TextBox();
            btnCargar = new Button();
            btnBorrar = new Button();
            dtgvDatos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(26, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(204, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ALTA DE PRODUCTOS";
            // 
            // lblCodProd
            // 
            lblCodProd.AutoSize = true;
            lblCodProd.Location = new Point(26, 77);
            lblCodProd.Name = "lblCodProd";
            lblCodProd.Size = new Size(114, 15);
            lblCodProd.TabIndex = 1;
            lblCodProd.Text = "Codigo de producto";
            // 
            // lblNomProd
            // 
            lblNomProd.AutoSize = true;
            lblNomProd.Location = new Point(26, 116);
            lblNomProd.Name = "lblNomProd";
            lblNomProd.Size = new Size(119, 15);
            lblNomProd.TabIndex = 2;
            lblNomProd.Text = "Nombre de producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(26, 157);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCodProd
            // 
            txtCodProd.Location = new Point(198, 77);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(100, 23);
            txtCodProd.TabIndex = 4;
            // 
            // txtNomProd
            // 
            txtNomProd.Location = new Point(198, 113);
            txtNomProd.Name = "txtNomProd";
            txtNomProd.Size = new Size(255, 23);
            txtNomProd.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(198, 157);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 6;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(546, 138);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(95, 42);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(665, 139);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(95, 41);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dtgvDatos
            // 
            dtgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatos.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre, cantidad });
            dtgvDatos.Location = new Point(140, 221);
            dtgvDatos.Name = "dtgvDatos";
            dtgvDatos.RowTemplate.Height = 25;
            dtgvDatos.Size = new Size(543, 202);
            dtgvDatos.TabIndex = 9;
            dtgvDatos.CellClick += dtgvDatos_CellClick;
            // 
            // codigo
            // 
            codigo.HeaderText = "Codigo";
            codigo.Name = "codigo";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.Width = 300;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvDatos);
            Controls.Add(btnBorrar);
            Controls.Add(btnCargar);
            Controls.Add(txtCantidad);
            Controls.Add(txtNomProd);
            Controls.Add(txtCodProd);
            Controls.Add(lblCantidad);
            Controls.Add(lblNomProd);
            Controls.Add(lblCodProd);
            Controls.Add(lblTitulo);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCodProd;
        private Label lblNomProd;
        private Label lblCantidad;
        private TextBox txtCodProd;
        private TextBox txtNomProd;
        private TextBox txtCantidad;
        private Button btnCargar;
        private Button btnBorrar;
        private DataGridView dtgvDatos;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn cantidad;
    }
}