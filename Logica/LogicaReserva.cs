// Importamos las dependencias necesarias
using Gentefit.db;                     // Acceso al contexto de la base de datos (GentefitContext)
using Gentefit.Modelo;                 // Modelos de entidades (Reserva, Clase, Cliente, etc.)
using Gentefit.Modelo.Enums;           // Enum con el estado de la reserva (Confirmada, Pendiente, Cancelada)
using Microsoft.EntityFrameworkCore;   // Permite usar Include() para cargar relaciones entre tablas
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gentefit.Logica
{
    public class LogicaReservas
    {
        // 🟩 MÉTODO 1: ObtenerTodas()
        // Devuelve una lista con todas las reservas registradas en la base de datos.
        // Incluye también la información relacionada de la clase y del cliente.
        public List<Reserva> ObtenerTodas()
        {
            // Se crea un nuevo contexto de base de datos.
            // 'using var' asegura que se cierre automáticamente al finalizar el bloque.
            using var contexto = new GentefitContext();

            // Consulta todas las reservas, incluyendo (JOIN) los datos de la clase y el cliente asociados.
            return contexto.Reservas
                           .Include(r => r.clase)   // Carga también los datos de la clase (JOIN con tabla Clase)
                           .Include(r => r.cliente) // Carga también los datos del cliente (JOIN con tabla Cliente)
                           .ToList();               // Convierte el resultado a una lista en memoria
        }

        // 🟦 MÉTODO 2: BuscarPorCliente()
        // Devuelve todas las reservas que pertenecen a un cliente concreto (por su idCliente).
        public List<Reserva> BuscarPorCliente(int idCliente)
        {
            // Crea el contexto para consultar la base de datos.
            using var contexto = new GentefitContext();

            // Consulta la tabla de reservas, incluyendo los datos de la clase,
            // pero solo aquellas reservas cuyo idCliente coincida con el parámetro recibido.
            return contexto.Reservas
                           .Include(r => r.clase)              // Incluye los datos de la clase asociada
                           .Where(r => r.idCliente == idCliente) // Filtra las reservas del cliente específico
                           .ToList();                          // Convierte el resultado en lista
        }

        // 🟧 MÉTODO 3: ReservarClase()
        // Permite a un cliente apuntarse a una clase.
        // Si hay plazas libres → reserva confirmada.
        // Si no hay plazas libres → pasa a lista de espera (Pendiente).
        public void ReservarClase(int idCliente, int idClase)
        {
            // Crea un nuevo contexto de base de datos (EF Core).
            // 'using var' asegura que se libere automáticamente cuando el método termine.
            using var contexto = new GentefitContext();

            // Busca en la tabla 'Clases' la clase con el ID indicado.
            // 'Include(c => c.reservas)' indica que además cargue las reservas asociadas a esa clase (JOIN).
            var clase = contexto.Clases
                .Include(c => c.reservas)
                .FirstOrDefault(c => c.idClase == idClase);

            // Si no encuentra ninguna clase con ese ID, lanza un error controlado.
            // Esto evita intentar crear una reserva sobre una clase inexistente.
            if (clase == null)
                throw new Exception("Clase no encontrada.");

            // Guarda el número máximo de plazas disponibles para esa clase (aforo).
            // Este valor viene de la propiedad 'plazasLibres' de la clase.
            int aforoMaximo = clase.plazasLibres;

            // Cuenta cuántas reservas CONFIRMADAS tiene actualmente la clase.
            // Solo se consideran aquellas reservas cuyo estado sea 'Confirmada'.
            int reservasConfirmadas = clase.reservas.Count(r => r.estado == EstadoReserva.Confirmada);

            // Crea un nuevo objeto 'Reserva' en memoria.
            // Todavía no está guardado en la base de datos hasta que se ejecute 'SaveChanges()'.
            var nuevaReserva = new Reserva
            {
                // Asigna el ID del cliente que hace la reserva.
                idCliente = idCliente,

                // Asigna el ID de la clase a la que se apunta el cliente.
                idClase = idClase,

                // Guarda la fecha actual del sistema en la que se realiza la reserva.
                fecha = DateTime.Now
            };

            // Comprueba si la clase aún tiene plazas libres.
            if (reservasConfirmadas < aforoMaximo)
            {
                // Si hay plazas disponibles, la reserva se marca como CONFIRMADA.
                nuevaReserva.estado = EstadoReserva.Confirmada;
            }
            else
            {
                // Si el aforo ya está completo, el cliente pasa a la lista de espera.
                // No necesitamos posición de cola, simplemente el orden temporal (fecha).
                nuevaReserva.estado = EstadoReserva.Pendiente;
            }

            // Añade la nueva reserva al conjunto de reservas del contexto.
            // Esto le indica a Entity Framework que debe insertarla en la base de datos.
            contexto.Reservas.Add(nuevaReserva);

            // Ejecuta todos los cambios pendientes en la base de datos.
            // Aquí es donde EF genera y ejecuta el comando SQL 'INSERT INTO Reserva (...)'.
            contexto.SaveChanges();
            // 📨 Enviar notificación al cliente
            var cliente = contexto.Clientes.FirstOrDefault(c => c.idCliente == idCliente);
            if (cliente != null)
            {
                string estadoTexto = nuevaReserva.estado == EstadoReserva.Confirmada ? "Confirmada ✅" : "En espera ⏳";

                string asunto = "📋 Confirmación de tu reserva en Gentefit";
                string cuerpo = $"<h3>Hola {cliente.nombre},</h3>" +
                    $"<p>Tu reserva para la clase <b>{idClase}</b> se ha registrado correctamente.</p>" +
                    $"<p><b>Estado actual:</b> {estadoTexto}</p>" +
                    $"<p>Fecha de la reserva: {nuevaReserva.fecha}</p>" +
                    $"<hr><p>Gracias por confiar en Gentefit 💪</p>";

                EnviarCorreo.Notificar(cliente.email, asunto, cuerpo);
            }


        }

        // 🟥 MÉTODO 4: CancelarReserva()
        // Cancela una reserva existente. 
        // Si era confirmada → libera una plaza y mueve al primer cliente en espera.
        // Si era en espera → simplemente se cancela (no hace falta reordenar nada).
        public bool CancelarReserva(int idReserva)
        {
            // Crea un nuevo contexto de base de datos (EF Core).
            using var contexto = new GentefitContext();

            // Busca la reserva por su ID e incluye la información de la clase asociada.
            var reserva = contexto.Reservas
                                  .Include(r => r.clase)
                                  .FirstOrDefault(r => r.idReserva == idReserva);

            // Si no existe ninguna reserva con ese ID, no se hace nada.
            if (reserva == null)
                return false;

            // Guardamos el ID de la clase para usarlo más adelante.
            int idClase = reserva.idClase;

            // Comprobamos si la reserva estaba confirmada antes de cancelarla.
            bool eraConfirmada = (reserva.estado == EstadoReserva.Confirmada);

            // Cambia el estado de la reserva a "Cancelada".
            reserva.estado = EstadoReserva.Cancelada;

            // Guarda este cambio en la base de datos.
            contexto.SaveChanges();

            // Si la reserva era CONFIRMADA (tenía plaza),
            // hay que liberar una plaza y subir al primer cliente en lista de espera.
            if (eraConfirmada)
            {
                // Llamamos al método privado que gestiona la promoción.
                PromoverSiguienteEnEspera(contexto, idClase);
            }

            // Devuelve true si la cancelación se realizó correctamente.
            return true;
        }

        // 🔁 MÉTODO PRIVADO: PromoverSiguienteEnEspera()
        // Se ejecuta automáticamente al cancelar una reserva CONFIRMADA.
        // Su función es buscar al primer cliente en lista de espera (Pendiente)
        // y cambiar su estado a Confirmada.
        private void PromoverSiguienteEnEspera(GentefitContext contexto, int idClase)
        {
            // Carga la clase con todas sus reservas (Confirmadas y Pendientes).
            var clase = contexto.Clases
                .Include(c => c.reservas)
                .FirstOrDefault(c => c.idClase == idClase);

            // Si no encuentra la clase, no hace nada.
            if (clase == null)
                return;

            // Busca la primera reserva en lista de espera.
            // El orden se determina por la fecha de creación de la reserva (más antigua primero).
            var siguiente = clase.reservas
                .Where(r => r.estado == EstadoReserva.Pendiente)
                .OrderBy(r => r.fecha)
                .FirstOrDefault();

            // Si existe alguien en espera...
            if (siguiente != null)
            {
                // Cambia su estado a CONFIRMADA.
                siguiente.estado = EstadoReserva.Confirmada;

                // Guarda el cambio en la base de datos.
                contexto.SaveChanges();
                // 📨 Notificar al cliente promovido
                var clientePromovido = contexto.Clientes.FirstOrDefault(c => c.idCliente == siguiente.idCliente);
                if (clientePromovido != null)
                {
                    string asunto = "🎉 ¡Tu reserva ha sido confirmada!";
                    string cuerpo = $"<h3>Hola {clientePromovido.nombre},</h3>" +
                        $"<p>Buenas noticias: tu reserva en Gentefit ha pasado de <b>espera</b> a <b>confirmada</b>.</p>" +
                        $"<p>Clase ID: {idClase}</p>" +
                        $"<p>Fecha de confirmación: {DateTime.Now}</p>" +
                        $"<hr><p>¡Nos vemos en el gimnasio 🏋️‍♀️!</p>";

                    EnviarCorreo.Notificar(clientePromovido.email, asunto, cuerpo);
                }

            }
        }
    }
}
