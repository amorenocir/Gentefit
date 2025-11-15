using Gentefit.Controlador;
using Gentefit.db;
using Gentefit.Modelo;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    public partial class AnadirClaseSala : Form
    {
        private Clase clase;
        private int idActividad;
        LogicaSala logicaSala = new LogicaSala();
        LogicaActividades logicaActiv = new LogicaActividades();
        LogicaClases logicaClase = new LogicaClases();
        public AnadirClaseSala(int idActividad, Clase clase)
        {
            InitializeComponent();
            this.idActividad = idActividad;
            this.clase = clase;
        }

        private void AnadirClaseSala_Load(object sender, EventArgs e)
        {
            PanelSalas.DataSource = logicaSala.ListarSalas();

            foreach (DataGridViewRow fila in PanelSalas.Rows)
            {
                if (fila.IsNewRow) continue;

                int idSala = (int)fila.Cells["idSala"].Value;
                List<Sala> posiblesSalas = logicaSala.BuscarPorId(idSala);
                Sala sala = posiblesSalas[0]; //Ja tenim l'objecte Sala de la fila

                List<Clase> todasClases = logicaClase.ListarClases(); //Comparem cada clase existent amb les clases de la sala de cada fila
                for (int i = 0; i < todasClases.Count; i++)
                {
                    List<Actividad> posibleAct = logicaActiv.BuscarPorID(todasClases[i].idActividad);
                    Actividad actividad = posibleAct[0];
                    if (todasClases[i].idSala == idSala)
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

        private void BotonSeleccionar_Click(object sender, EventArgs e)
        {
            if (PanelSalas.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una sala para la clase.");
                return;
            }
            else if (PanelSalas.CurrentRow.DefaultCellStyle.BackColor == Color.Salmon)
            {
                return;
            }
            int idSala = (int)PanelSalas.CurrentRow.Cells["idSala"].Value;
            clase.idSala = idSala;
            logicaClase.AddClase(clase);

            MessageBox.Show("Clase añadida correctamente.");
            this.Close();
            new MenuAdClases(idActividad).Show();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            new MenuAdClases(idActividad).Show();
            this.Close();
        }

        private void PanelSalas_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in PanelSalas.Rows)
            {
                if(fila.DefaultCellStyle.BackColor == Color.Salmon)
                {
                    fila.Selected = false;
                }
            }
        }
    }
}
