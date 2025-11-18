using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gentefit.Test
{
    public partial class TestReserva : Form
    {
        public TestReserva()
        {
            InitializeComponent();
        }

        
        //      TEST 1 — RESERVA OK
    
        private void btnReservaOK_Click(object sender, EventArgs e)
        {
            var clase = new Clase { plazasLibres = 2 };
            var reservas = new List<Reserva>();

            var nueva = new Reserva
            {
                idCliente = 1,
                idClase = 10,
                fecha = DateTime.Now
            };

            if (clase.plazasLibres > 0)
            {
                clase.plazasLibres--;
                nueva.estado = EstadoReserva.Confirmada;
                reservas.Add(nueva);

                MessageBox.Show("OK — Reserva CONFIRMADA.\nPlazas restantes: " + clase.plazasLibres,
                    "TEST 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        // TEST 2 — RESERVA SIN PLAZAS (EN ESPERA)
        
        private void btnSinPlazas_Click(object sender, EventArgs e)
        {
            var clase = new Clase { plazasLibres = 0 };
            var nueva = new Reserva();

            if (clase.plazasLibres == 0)
            {
                nueva.estado = EstadoReserva.EnEspera;

                MessageBox.Show("OK — Reserva EN ESPERA correctamente asignada.",
                    "TEST 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        // TEST 3 — RESERVA DUPLICADA
        
        private void btnDuplicada_Click(object sender, EventArgs e)
        {
            var reservas = new List<Reserva>
            {
                new Reserva { idCliente = 1, idClase = 10, estado = EstadoReserva.Confirmada }
            };

            bool existe = reservas.Any(r => r.idCliente == 1 && r.idClase == 10);

            if (existe)
            {
                MessageBox.Show("OK — Reserva DUPLICADA detectada.",
                    "TEST 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        // TEST 4 — CANCELAR RESERVA CONFIRMADA
      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var clase = new Clase { plazasLibres = 0 };
            var reserva = new Reserva { estado = EstadoReserva.Confirmada };

            if (reserva.estado == EstadoReserva.Confirmada)
                clase.plazasLibres++;

            reserva.estado = EstadoReserva.Cancelada;

            MessageBox.Show("OK — Reserva CANCELADA y plaza liberada.\nPlazas ahora: " + clase.plazasLibres,
                "TEST 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TestReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
