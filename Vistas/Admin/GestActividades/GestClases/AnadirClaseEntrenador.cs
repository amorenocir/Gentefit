using Gentefit.Controlador;
using Gentefit.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    public partial class AnadirClaseEntrenador : Form
    {
        private Clase clase;
        private int idActividad;
        LogicaEntrenadores logicaEntre = new LogicaEntrenadores();
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaAct = new LogicaActividades();
        public AnadirClaseEntrenador(Clase clase, int idActividad)
        {
            InitializeComponent();
            this.clase = clase;
            this.idActividad = idActividad;
        }

        private void AnadirClaseEntrenador_Load(object sender, EventArgs e)
        {
            CargarDatos();

            foreach (DataGridViewRow fila in PanelEntrenadores.Rows)
            {
                if (fila.IsNewRow) continue;

                int idEntrenador = (int)fila.Cells["idEntrenador"].Value;
                //List<Entrenador> posiblesEntre = logicaEntre.BuscarPorId(idEntrenador);
                //Entrenador entrenador = posiblesEntre[0];

                List<Clase> todasClases = logicaClases.ListarClases();
                for (int i = 0; i < todasClases.Count; i++)
                {
                    List<Actividad> posiblesAct = logicaAct.BuscarPorID(todasClases[i].idActividad);
                    Actividad actividad = posiblesAct[0];
                    if (todasClases[i].idEntrenador == idEntrenador)
                    {
                        if (todasClases[i].dia == clase.dia)
                        {
                            TimeOnly horaIni1;
                            TimeOnly horaIni2;
                            TimeOnly horaFin1;
                            TimeOnly horaFin2;
                            if (todasClases[i].hora <= clase.hora)
                            {
                                horaIni1 = todasClases[i].hora;
                                horaIni2 = clase.hora;
                                horaFin1 = todasClases[i].hora.AddMinutes(actividad.duracion);
                                horaFin2 = clase.hora.AddMinutes(actividad.duracion);
                            }
                            else
                            {
                                horaIni1 = clase.hora;
                                horaIni2 = todasClases[i].hora;
                                horaFin1 = clase.hora.AddMinutes(actividad.duracion);
                                horaFin2 = todasClases[i].hora.AddMinutes(actividad.duracion);
                            }
                            if (horaIni1 < horaFin2 && horaIni2 < horaFin1)
                            {
                                fila.DefaultCellStyle.BackColor = Color.Salmon;
                                fila.DefaultCellStyle.ForeColor = Color.Maroon;
                            }
                        }
                    }
                }
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(CajaTextoBuscar.Text, out int idEntrenador))
            {
                MessageBox.Show("Por introduce un ID válido.");
            }
            PanelEntrenadores.DataSource = logicaEntre.BuscarPorId(idEntrenador);
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BotonSeleccionar_Click(object sender, EventArgs e)
        {
            if (PanelEntrenadores.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un entrenador para la clase.");
                return;
            }else if(PanelEntrenadores.CurrentRow.DefaultCellStyle.BackColor == Color.Salmon)
            {
                return;
            }
            int idEntrenador = (int)PanelEntrenadores.CurrentRow.Cells["idEntrenador"].Value;
            clase.idEntrenador = idEntrenador;
            new AnadirClaseSala(idActividad, clase).Show();
            this.Close();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            new MenuAdClases(idActividad).Show();
            this.Close();
        }

        public void CargarDatos()
        {
            PanelEntrenadores.DataSource = logicaEntre.ListarEntrenadores();
        }
    }
}
