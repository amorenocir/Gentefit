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
    public partial class ModificarClases2 : Form
    {
        private int idActividad;
        private Clase clase;
        LogicaEntrenadores logicaEntre = new LogicaEntrenadores();
        LogicaSala logicaSalas = new LogicaSala();
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaAct = new LogicaActividades();
        public ModificarClases2(int idActividad, Clase clase)
        {
            InitializeComponent();
            this.idActividad = idActividad;
            this.clase = clase;
        }

        private void ModificarClases2_Load(object sender, EventArgs e)
        {
            PanelEntrenadores.DataSource = logicaEntre.ListarEntrenadores();
            PanelSalas.DataSource = logicaSalas.ListarSalas();
            EditarPanel(PanelEntrenadores, true);
            EditarPanel(PanelSalas, false);

            List<Actividad> posiblesAct = logicaAct.BuscarPorID(idActividad);
            Actividad actividad = posiblesAct[0];
            string tituloMin = "Modificar clases de " + actividad.nombre;
            Titulo.Text = tituloMin.ToUpper();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            int idEntrenador = (int)PanelEntrenadores.CurrentRow.Cells["idEntrenador"].Value;
            int idSala = (int)PanelSalas.CurrentRow.Cells["idSala"].Value;
            clase.idEntrenador = idEntrenador;
            clase.idSala = idSala;

            bool exito = logicaClases.Modificar(clase);
            if (exito)
            {
                MessageBox.Show("Clase modificada correctamente.");
                new MenuAdClases(idActividad).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la clase.");
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ModificarClases(idActividad).Show();
            this.Close();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            new MenuAdClases(idActividad).Show();
            this.Close();
        }

        private void EditarPanel(DataGridView panel, bool opcionPanel)
        {
            foreach (DataGridViewRow fila in panel.Rows)
            {
                if (fila.IsNewRow) continue;
                string x;
                if (opcionPanel)
                {
                    x = "idEntrenador";
                }
                else
                {
                    x = "idSala";
                }
                int idObjeto = (int)fila.Cells[x].Value;
                List<Clase> todasClases = logicaClases.ListarClases();
                for (int i = 0; i < todasClases.Count; i++)
                {
                    List<Actividad> posiblesAct = logicaAct.BuscarPorID(todasClases[i].idActividad);
                    Actividad actividad = posiblesAct[0];
                    bool correcto;
                    if (opcionPanel)
                    {
                        if (todasClases[i].idEntrenador == idObjeto)
                        {
                            correcto = true;
                        }
                        else
                        {
                            correcto = false;
                        }
                    }
                    else
                    {
                        if (todasClases[i].idSala == idObjeto)
                        {
                            correcto = true;
                        }
                        else
                        {
                            correcto = false;
                        }
                    }
                    if (correcto)
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

        private void PanelEntrenadores_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in PanelEntrenadores.Rows)
            {
                if(fila.DefaultCellStyle.BackColor == Color.Salmon)
                {
                    fila.Selected = false;
                }
            }
        }

        private void PanelSalas_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in PanelSalas.Rows)
            {
                if (fila.DefaultCellStyle.BackColor == Color.Salmon)
                {
                    fila.Selected = false;
                }
            }
        }
    }
}
