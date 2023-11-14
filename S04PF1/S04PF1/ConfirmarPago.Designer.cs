namespace S04PF1
{
    partial class ConfirmarPago
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
            lblConfirmarPago = new Label();
            lblFechaPago = new Label();
            lblMonto = new Label();
            lblMedioPago = new Label();
            lblFecha = new Label();
            lblMontoT = new Label();
            lblMP = new Label();
            lblPromo = new Label();
            chk3Cuotas = new CheckBox();
            chk6Cuotas = new CheckBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // lblConfirmarPago
            // 
            lblConfirmarPago.AutoSize = true;
            lblConfirmarPago.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmarPago.Location = new Point(194, 21);
            lblConfirmarPago.Name = "lblConfirmarPago";
            lblConfirmarPago.Size = new Size(161, 25);
            lblConfirmarPago.TabIndex = 18;
            lblConfirmarPago.Text = "Confirmar Pago";
            lblConfirmarPago.Click += lblCobroCuota_Click;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaPago.Location = new Point(101, 87);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(0, 15);
            lblFechaPago.TabIndex = 21;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.Location = new Point(268, 87);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(0, 15);
            lblMonto.TabIndex = 22;
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedioPago.Location = new Point(422, 87);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(0, 15);
            lblMedioPago.TabIndex = 23;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(93, 52);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 24;
            lblFecha.Text = "Fecha";
            lblFecha.Click += label1_Click;
            // 
            // lblMontoT
            // 
            lblMontoT.AutoSize = true;
            lblMontoT.Location = new Point(253, 52);
            lblMontoT.Name = "lblMontoT";
            lblMontoT.Size = new Size(52, 15);
            lblMontoT.TabIndex = 25;
            lblMontoT.Text = "Monto $";
            // 
            // lblMP
            // 
            lblMP.AutoSize = true;
            lblMP.Location = new Point(402, 52);
            lblMP.Name = "lblMP";
            lblMP.Size = new Size(87, 15);
            lblMP.TabIndex = 26;
            lblMP.Text = "Medio de Pago";
            // 
            // lblPromo
            // 
            lblPromo.AutoSize = true;
            lblPromo.Location = new Point(40, 171);
            lblPromo.Name = "lblPromo";
            lblPromo.Size = new Size(117, 15);
            lblPromo.TabIndex = 27;
            lblPromo.Text = "Aplicar Promociones";
            // 
            // chk3Cuotas
            // 
            chk3Cuotas.AutoSize = true;
            chk3Cuotas.Location = new Point(42, 200);
            chk3Cuotas.Name = "chk3Cuotas";
            chk3Cuotas.Size = new Size(95, 19);
            chk3Cuotas.TabIndex = 28;
            chk3Cuotas.Text = "3 cuotas 15%";
            chk3Cuotas.UseVisualStyleBackColor = true;
            chk3Cuotas.CheckedChanged += chk3Cuotas_CheckedChanged;
            // 
            // chk6Cuotas
            // 
            chk6Cuotas.AutoSize = true;
            chk6Cuotas.Location = new Point(42, 234);
            chk6Cuotas.Name = "chk6Cuotas";
            chk6Cuotas.Size = new Size(89, 19);
            chk6Cuotas.TabIndex = 29;
            chk6Cuotas.Text = "6 cuotas 5%";
            chk6Cuotas.UseVisualStyleBackColor = true;
            chk6Cuotas.CheckedChanged += chk6Cuotas_CheckedChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(390, 207);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(109, 46);
            btnConfirmar.TabIndex = 30;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // ConfirmarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 295);
            Controls.Add(btnConfirmar);
            Controls.Add(chk6Cuotas);
            Controls.Add(chk3Cuotas);
            Controls.Add(lblPromo);
            Controls.Add(lblMP);
            Controls.Add(lblMontoT);
            Controls.Add(lblFecha);
            Controls.Add(lblMedioPago);
            Controls.Add(lblMonto);
            Controls.Add(lblFechaPago);
            Controls.Add(lblConfirmarPago);
            Name = "ConfirmarPago";
            Text = "ConfirmarPago";
            Load += ConfirmarPago_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfirmarPago;
        private Label lblFechaPago;
        private Label lblMonto;
        private Label lblMedioPago;
        private Label lblFecha;
        private Label lblMontoT;
        private Label lblMP;
        private Label lblPromo;
        private CheckBox chk3Cuotas;
        private CheckBox chk6Cuotas;
        private Button btnConfirmar;
    }
}