using ModeloParcial1_2;
namespace FrmTorneo
{
    public partial class FrmTorneo : Form
    {
        Competencia competencia;
        public FrmTorneo()
        {
            InitializeComponent();
        }

        private void FrmTorneo_Load(object sender, EventArgs e)
        {
            this.competencia = new Competencia("Torneos el Foquito", 10);
            Equipo e1 = new EquipoFutbol("Independiente", true);
            Equipo e2 = new EquipoFutbol("Boca", true);
            Equipo e3 = new EquipoBasket("Spurs");
            Equipo e4 = new EquipoBasket("Chicago Bulls");
            Equipo e5 = new EquipoFutbol("Racing");
            this.competencia += e1;
            this.competencia += e1;//pruebo de agregar el mismo equipo
            this.competencia += e2;
            this.competencia += e3;
            this.competencia += e4;
            this.competencia += e5;
            this.cmbEquipoUno.DataSource = this.competencia.Equipos;
            this.rchtDatosTorneo.Text += Competencia.MostrarTorneo(this.competencia);
        }

        private void cmbEquipoUno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbEquipoDos.DataSource = competencia.Equipos.FindAll(element => element != (Equipo)this.cmbEquipoUno.SelectedItem);
        }

        private void btnDesafiar_Click(object sender, EventArgs e)
        {
            if (Equipo.JugarPartido((Equipo)this.cmbEquipoUno.SelectedItem,(Equipo)cmbEquipoDos.SelectedItem))
            {
                MessageBox.Show("Se Jugo el partido");
                this.dgvResultados.DataSource = null;
                this.dgvResultados.DataSource = this.competencia.Equipos;
            }
            else
            {

                MessageBox.Show("No se puede jugar el partido entre estos 2 equipos");
            }
        }
    }
}