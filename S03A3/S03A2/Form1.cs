namespace S03A3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool esValido = true;

            if (txtApellido.Text == "")
            {
                lblErrorApellido.Text = "<-- Ingrese apellido";
                esValido = false;
            }
            else
            {
                lblErrorApellido.Text = "";
            }

            if (txtNombre.Text == "")
            {
                lblErrorNombre.Text = "<-- Ingrese nombre!";
                esValido = false;
            }
            else
            {
                lblErrorNombre.Text = "";
            }

            if (cboTipo.Text == "")
            {
                lblErrorTipo.Text = "<-- Seleccione!";
                esValido = false;
            }
            else
            {
                lblErrorTipo.Text = "";
            }

            if (txtNumeroDoc.Text == "")
            {
                lblErrorNumero.Text = "<-- Ingrese num Doc!";
                esValido = false;
            }
            else
            {
                lblErrorNumero.Text = "";
            }

            if (esValido)
            {
                Alumno alumno1 = new Alumno(txtNombre.Text, txtApellido.Text, cboTipo.Text, txtNumeroDoc.Text);
                MessageBox.Show(alumno1.ToString(), "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}