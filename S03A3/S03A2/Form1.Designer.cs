namespace S03A3
{
    partial class Form1
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
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblTipo = new Label();
            cboTipo = new ComboBox();
            lblDocumento = new Label();
            txtNumeroDoc = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblErrorNombre = new Label();
            lblErrorApellido = new Label();
            lblErrorTipo = new Label();
            lblErrorNumero = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(47, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(47, 102);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "APELLIDO";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(199, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(135, 102);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(199, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(47, 187);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(32, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "TIPO";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.Location = new Point(135, 187);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 5;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(367, 187);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(80, 15);
            lblDocumento.TabIndex = 6;
            lblDocumento.Text = "DOCUMENTO";
            // 
            // txtNumeroDoc
            // 
            txtNumeroDoc.Location = new Point(463, 187);
            txtNumeroDoc.Name = "txtNumeroDoc";
            txtNumeroDoc.Size = new Size(199, 23);
            txtNumeroDoc.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(229, 335);
            button1.Name = "button1";
            button1.Size = new Size(105, 38);
            button1.TabIndex = 8;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(449, 335);
            button2.Name = "button2";
            button2.Size = new Size(105, 38);
            button2.TabIndex = 9;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.Location = new Point(349, 61);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(0, 15);
            lblErrorNombre.TabIndex = 10;
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.Location = new Point(349, 105);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(0, 15);
            lblErrorApellido.TabIndex = 11;
            // 
            // lblErrorTipo
            // 
            lblErrorTipo.AutoSize = true;
            lblErrorTipo.Location = new Point(266, 192);
            lblErrorTipo.Name = "lblErrorTipo";
            lblErrorTipo.Size = new Size(0, 15);
            lblErrorTipo.TabIndex = 12;
            // 
            // lblErrorNumero
            // 
            lblErrorNumero.AutoSize = true;
            lblErrorNumero.Location = new Point(668, 192);
            lblErrorNumero.Name = "lblErrorNumero";
            lblErrorNumero.Size = new Size(0, 15);
            lblErrorNumero.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrorNumero);
            Controls.Add(lblErrorTipo);
            Controls.Add(lblErrorApellido);
            Controls.Add(lblErrorNombre);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNumeroDoc);
            Controls.Add(lblDocumento);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblTipo;
        private ComboBox cboTipo;
        private Label lblDocumento;
        private TextBox txtNumeroDoc;
        private Button button1;
        private Button button2;
        private Label lblErrorNombre;
        private Label lblErrorApellido;
        private Label lblErrorTipo;
        private Label lblErrorNumero;
    }
}