namespace S04PF1
{
    partial class Login
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
            picUSER = new PictureBox();
            lblUser = new Label();
            lblPASS = new Label();
            txtUSER = new TextBox();
            txtPASS = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)picUSER).BeginInit();
            SuspendLayout();
            // 
            // picUSER
            // 
            picUSER.Image = Properties.Resources.login;
            picUSER.Location = new Point(319, 31);
            picUSER.Name = "picUSER";
            picUSER.Size = new Size(153, 119);
            picUSER.SizeMode = PictureBoxSizeMode.Zoom;
            picUSER.TabIndex = 0;
            picUSER.TabStop = false;
            picUSER.Click += pictureBox1_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(211, 207);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(90, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "USUARIO";
            // 
            // lblPASS
            // 
            lblPASS.AutoSize = true;
            lblPASS.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPASS.Location = new Point(247, 260);
            lblPASS.Name = "lblPASS";
            lblPASS.Size = new Size(54, 25);
            lblPASS.TabIndex = 2;
            lblPASS.Text = "PASS";
            // 
            // txtUSER
            // 
            txtUSER.Location = new Point(326, 212);
            txtUSER.Name = "txtUSER";
            txtUSER.Size = new Size(146, 23);
            txtUSER.TabIndex = 3;
            txtUSER.Text = "USUARIO";
            txtUSER.Enter += txtUSER_Enter;
            txtUSER.Leave += txtUSER_Leave;
            // 
            // txtPASS
            // 
            txtPASS.Location = new Point(326, 262);
            txtPASS.Name = "txtPASS";
            txtPASS.Size = new Size(146, 23);
            txtPASS.TabIndex = 4;
            txtPASS.Text = "PASS";
            txtPASS.Enter += textPASS_Enter;
            txtPASS.Leave += txtPASS_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(326, 350);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPASS);
            Controls.Add(txtUSER);
            Controls.Add(lblPASS);
            Controls.Add(lblUser);
            Controls.Add(picUSER);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picUSER).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUSER;
        private Label lblUser;
        private Label lblPASS;
        private TextBox txtUSER;
        private TextBox txtPASS;
        private Button btnLogin;
    }
}