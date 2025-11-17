using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gentefit.db;
using Gentefit.Modelo;

namespace Gentefit.Controlador
{
    internal class LogicaEntrenadores
    {
        //Obtener todos los entrenadores
        public List<Entrenador> ListarEntrenadores()
        {
            using var contexto = new GentefitContext();
            return contexto.Entrenadores.ToList();
        }

        //Buscar entrenador por ID
        public List<Entrenador> BuscarPorId(int id)
        {
            using var contexto = new GentefitContext();
            return contexto.Entrenadores
                .Where(c => c.idEntrenador == id).ToList();
        }

        //Añadir un nuevo entrenador
        public void AnadirEntrenador(Entrenador nuevoEntrenador)
        {
            using var contexto = new GentefitContext();
            contexto.Entrenadores.Add(nuevoEntrenador);
            contexto.SaveChanges();
        }

        //Modificar entrenador
        public bool ModificarEntrenador(Entrenador entrenador)
        {
            using var contexto = new GentefitContext();
            var c = contexto.Entrenadores.
                FirstOrDefault(
                x => x.idEntrenador == entrenador.idEntrenador);
            if (c == null) return false;

            c.nombre = entrenador.nombre;
            c.apellidos = entrenador.apellidos;
            c.dni = entrenador.dni;
            contexto.SaveChanges();
            return true;
        }

        //Eliminar entrenador por ID
        public bool EliminarEntrenador(int id)
        {
            using var contexto = new GentefitContext();
            var entrenador = contexto.Entrenadores.Find(id);
            if(entrenador != null)
            {
                contexto.Entrenadores.Remove(entrenador);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
