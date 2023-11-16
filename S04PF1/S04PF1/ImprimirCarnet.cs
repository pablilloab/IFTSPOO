using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S04PF1
{
    public partial class ImprimirCarnet : Form
    {
        public int IdCarnet { get; }
        public string Nombre { get; }
        public string Apellido { get; }
        public string Actividad { get; }
        public string FechaFormateada { get; }

        //public ImprimirCarnet(int idCarnet, string nombre, string apellido, string actividad, string fechaFormateada)
        //{
        //    IdCarnet = idCarnet;
        //    Nombre = nombre;
        //    Apellido = apellido;
        //    Actividad = actividad;
        //    FechaFormateada = fechaFormateada;
        //}

        public void SetDatos(int idCarnet, string nombre, string apellido, string actividad, string fecha)
        {
            // Asignar los datos a los controles en tu formulario
            // Por ejemplo:
            txtNumCarnet.Text = idCarnet.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtActividad.Text = actividad;
            txtFecha.Text = fecha;
        }
        public ImprimirCarnet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirCarnet_Load(object sender, EventArgs e)
        {
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            using (Bitmap bmp = new Bitmap(this.Width -10 , this.Height))
            {
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    // Ajusta las coordenadas y el tamaño para recortar desde arriba y abajo
                    int topOffset = 50; // offset superior
                    int bottomOffset = 40; // offset inferior
                    Rectangle srcRect = new Rectangle(this.Location.X, this.Location.Y + topOffset, this.Width, this.Height - topOffset - bottomOffset);
                    gr.CopyFromScreen(srcRect.Location, Point.Empty, srcRect.Size);
                }

                // Especifica la ruta del archivo en el disco local C:\
                string rutaGuardado = @"C:\Users\Public\carnet.jpg";

                try
                {
                    // Guarda la imagen en el disco local
                    bmp.Save(rutaGuardado, ImageFormat.Png);
                    MessageBox.Show("Formulario guardado como imagen en C:\\Users\\Public\\", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
