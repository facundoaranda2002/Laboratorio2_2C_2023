namespace FrmView
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cancellationTokenSource;
        Task tarea;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            this.tarea = Task.Run(() => this.IniciarReloj(this.cancellationTokenSource), token);

        }

        public delegate void Callback(DateTime hora, string saludo);

        private void ActualizarHora(DateTime hora, string saludo)
        {
            if (this.InvokeRequired)
            {
                Callback callback = new Callback(this.ActualizarHora);
                object[] args = { hora, saludo };
                this.BeginInvoke(callback, args);
                //Es lo mismo que lo de arriba
                //this.BeginInvoke(()=>this.ActualizarHora(hora, saludo));
                //this.BeginInvoke(this.ActualizarHora);//voy a invocar al hilo principal a traves del secundario para poder modificar el form, estoy volviendo a llamar a la funcion asi entra por el else una vez que llame al hilo principal
            }
            else
            {
                this.lblHora.Text = $"{hora}";
                this.txtIngresar.Text = saludo;
            }
        }

        private void IniciarReloj(CancellationTokenSource cancellationTokenSource)
        {
            int i = 0;
            do
            { 
                this.ActualizarHora(DateTime.Now, i.ToString());
                Thread.Sleep(1000);
                i++;
            }
            while (true && !cancellationTokenSource.IsCancellationRequested);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }
    }
}