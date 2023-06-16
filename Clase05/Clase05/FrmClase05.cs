namespace Clase05
{
    public partial class FrmClase05 : Form
    {
        public FrmClase05()
        {
            InitializeComponent();

            //this.btnAceptar.Text = "El boton ahora cambio el nombre";

            this.lstNombres.Items.Add("Alejandro");
            this.lstNombres.Items.Add("Pepe");
            this.lstNombres.Items.Add("Luis");
            this.lstNombres.Items.Add("Jose");
        }

        private void FrmClase05_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*
            DialogResult resultado = MessageBox.Show("Hola Mundo", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("La operacion fue OK");
            }
            //MessageBox.Show(resultado.ToString());
            */
            MessageBox.Show($"{this.txtNombre.Text} , {this.txtApellido.Text}", "Caja de texto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SegundoForm frmSegundo = new SegundoForm();
            DialogResult result = frmSegundo.ShowDialog();//si usara el frmSegundo.Show() me permitiria abrir los forms que quiera porque me permite tocar fuera del form aunque este siga abierto



            if (result == DialogResult.OK)
            {
                MessageBox.Show(frmSegundo.GetPalabra());//MessageBox.Show("Todo OK");
            }

            foreach (Control item in this.grpDatos.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name == "txtNombre")
                    {
                        item.Text = "lalal";
                    }
                }
            }

        }

        private void FrmClase05_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Desea cerrar la ventana?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}