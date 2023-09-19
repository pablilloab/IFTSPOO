namespace S04PF1
{
    public partial class Form2 : Form
    {
        int nro = 0; //variable global para tomar la fial con el producto a borrar
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            //crea un nuevo renglon en mi grilla y guardo su numero de fila
            int fila = dtgvDatos.Rows.Add();

            //asigno los valores cargados como datos - HAY Q VALIDAR !!!
            dtgvDatos.Rows[fila].Cells[0].Value = txtCodProd.Text;
            dtgvDatos.Rows[fila].Cells[1].Value = txtNomProd.Text;
            dtgvDatos.Rows[fila].Cells[2].Value = txtCantidad.Text;

            //muevo vacio a todos los campos para permitir otro ingreso
            txtCodProd.Text = "";
            txtNomProd.Text = "";
            txtCantidad.Text = "";

            //vuelvo el foco a la linea de codigo
            txtCodProd.Focus();
        }

        private void dtgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nro = e.RowIndex;
            if (nro != -1)
            {
                MessageBox.Show((string)dtgvDatos.Rows[nro].Cells[1].Value);
            }
            else
            {
                MessageBox.Show("Selecciono el encabezado");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dtgvDatos.Rows.RemoveAt(nro);
        }
    }
}
