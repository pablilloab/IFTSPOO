using S04PF1.Data;

namespace S04PF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUSER_Enter(object sender, EventArgs e)
        {
            //este evento se ejecuta cuando llega el foco

            if (txtUSER.Text == "USUARIO")
            {
                txtUSER.Text = "";
            }
        }

        private void txtUSER_Leave(object sender, EventArgs e)
        {
            if (txtUSER.Text == "")
            {
                txtUSER.Text = "USUARIO";
            }
        }

        private void textPASS_Enter(object sender, EventArgs e)
        {
            if (txtPASS.Text == "PASS")
            {
                txtPASS.Text = "";
                txtPASS.UseSystemPasswordChar = true;
            }
        }

        private void txtPASS_Leave(object sender, EventArgs e)
        {
            if (txtPASS.Text == "")
            {
                txtPASS.Text = "PASS";
                txtPASS.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtUSER.Text == "pablo" &&  txtPASS.Text == "123456")
            //{
            //    Form formulario = new Form2();
            //    formulario.ShowDialog();                
            //}
            //else
            //{
            //    MessageBox.Show("Login Incorrecto", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (!Users.validarUsuario(txtUSER.Text, txtPASS.Text))
            {
                MessageBox.Show("Login Incorrecto");
            }
            else
            {
                Form formulario = new Form3();
                formulario.ShowDialog(); 
            };
        }
    }
}