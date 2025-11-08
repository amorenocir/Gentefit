using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gentefit.Vistas
{
    public partial class ReservasCliente : Form
    {
        private readonly LogicaReservas logicaRs = new LogicaReservas();

        public ReservasCliente()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelReservas.DataSource = logicaRs.ObtenerTodos();
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            new MenuCliente().Show();
            this.Hide();
        }
        private void BotonActividades_Click(object sender, EventArgs e)
        {
            new ActividadesCliente().Show();
            this.Hide();
        }
        private void BotonHorarios_Click(object sender, EventArgs e)
        {
            new HorariosCliente().Show();
            this.Hide();
        }

    }
}
