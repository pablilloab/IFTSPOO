namespace PrimerProyecto
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EN MANTENIMIENTO!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingresa tu nombre", "NOMBRE", "Ingrese aqui");
            MessageBox.Show(nombre);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombreIngresado = text_nombre.Text;
            MessageBox.Show(nombreIngresado);
        }
    }
}