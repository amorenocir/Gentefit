// Importamos las dependencias necesarias
using Gentefit.Logica;                // Acceso a la lógica de negocio de reservas
using Gentefit.db;                    // Acceso al contexto de base de datos
using Gentefit.Modelo.Enums;          // Enum que define los estados de la reserva
using System.Linq;                    // Permite realizar consultas LINQ sobre colecciones
using System;

namespace Gentefit.Test
{
    public class TestReservasInterno
    {
        // 🧩 MÉTODO: ProbarReservas()
        // Este método simula el proceso completo de una reserva:
        // 1. Crea una nueva reserva (cliente + clase).
        // 2. Consulta el resultado en la base de datos.
        // 3. Devuelve un texto con el estado final (Confirmada o En Espera).
        public static string ProbarReservas()
        {
            try
            {
                // Instancia la clase de lógica de reservas.
                // Esta clase se encarga de aplicar las reglas de negocio (aforo, lista de espera, etc.).
                var logica = new LogicaReservas();

                // IDs de ejemplo para la prueba.
                // Puedes cambiar estos valores para probar distintos clientes y clases.
                int idCliente = 1;
                int idClase = 2;

                // 1️⃣ Intentar realizar la reserva llamando al método principal de la lógica.
                // Si la clase tiene plazas → se confirmará.
                // Si no tiene → quedará como Pendiente (en espera).
                logica.ReservarClase(idCliente, idClase);

                // 2️⃣ Consultar en la base de datos la reserva recién creada.
                // Esto nos permite verificar si el registro se creó correctamente y cuál fue su estado.
                using var contexto = new GentefitContext();

                // Busca la última reserva del cliente en esa clase (por fecha más reciente).
                var reserva = contexto.Reservas
                    .Where(r => r.idCliente == idCliente && r.idClase == idClase)
                    .OrderByDescending(r => r.fecha)
                    .FirstOrDefault();

                // Si no se encuentra ninguna reserva, algo falló en la inserción.
                if (reserva == null)
                    return "❌ Error: no se encontró la reserva después de intentar crearla.";

                // 3️⃣ Determinar el estado final de la reserva.
                // Se convierte el valor del enum a texto legible.
                string estadoTexto = reserva.estado switch
                {
                    EstadoReserva.Confirmada => "Confirmada ✅ (plaza asignada)",
                    EstadoReserva.Pendiente => "En espera ⏳ (lista de espera)",
                    EstadoReserva.Cancelada => "Cancelada ❌",
                    _ => "Desconocido ⚠️"
                };

                // 4️⃣ Construir el mensaje final para mostrar en pantalla o en el MessageBox.
                // Incluye todos los datos relevantes para el test.
                return $"Reserva creada correctamente:\n" +
                       $"➡ Cliente: {idCliente}\n" +
                       $"➡ Clase: {idClase}\n" +
                       $"➡ Estado final: {estadoTexto}\n" +
                       $"🕓 Fecha: {reserva.fecha}";
            }
            catch (Exception ex)
            {
                // Si ocurre cualquier error durante el proceso, se captura y se devuelve un mensaje claro.
                return $"❌ Error al probar la reserva: {ex.Message}";
            }
        }
        public static string TestCancelarReserva()
        {
            try
            {
                using var contexto = new GentefitContext();

                // 1️⃣ Seleccionamos una reserva confirmada existente
                var reservaConfirmada = contexto.Reservas
                    .Where(r => r.estado == EstadoReserva.Confirmada && r.idClase == 2)
                    .FirstOrDefault();

                if (reservaConfirmada == null)
                    return "❌ No hay reservas confirmadas para cancelar.";

                int idReserva = reservaConfirmada.idReserva;
                int idClase = reservaConfirmada.idClase;

                // Guardamos el nombre del cliente para mostrarlo después
                var cliente = contexto.Clientes.Find(reservaConfirmada.idCliente);
                string nombreCliente = cliente != null ? $"{cliente.nombre} {cliente.apellidos}" : $"Cliente {reservaConfirmada.idCliente}";

                // 2️⃣ Cancelamos la reserva usando la lógica
                var logica = new LogicaReservas();
                bool exito = logica.CancelarReserva(idReserva);

                if (!exito)
                    return "❌ No se pudo cancelar la reserva (no encontrada o error interno).";

                // 3️⃣ Verificamos si ahora hay alguien en espera que haya pasado a confirmada
                var nuevaConfirmada = contexto.Reservas
                    .Where(r => r.idClase == idClase && r.estado == EstadoReserva.Confirmada)
                    .OrderByDescending(r => r.fecha)
                    .FirstOrDefault();

                string mensajeResultado =
                    $"🟧 Reserva cancelada correctamente:\n" +
                    $"➡ Cliente cancelado: {nombreCliente}\n" +
                    $"➡ Clase: {idClase}\n" +
                    $"🕓 Fecha cancelación: {DateTime.Now}\n\n";

                if (nuevaConfirmada != null)
                {
                    var nuevoCliente = contexto.Clientes.Find(nuevaConfirmada.idCliente);
                    mensajeResultado +=
                        $"✅ El siguiente en lista de espera ha sido promovido:\n" +
                        $"➡ Cliente: {nuevoCliente?.nombre} {nuevoCliente?.apellidos}\n" +
                        $"➡ Nueva reserva confirmada a las {nuevaConfirmada.fecha}";
                }
                else
                {
                    mensajeResultado += "⚠️ No había nadie en la lista de espera.";
                }

                return mensajeResultado;
            }
            catch (Exception ex)
            {
                return $"❌ Error al cancelar la reserva: {ex.Message}";
            }
        }

    }
}
