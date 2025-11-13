using Gentefit.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gentefit.Modelo;

namespace Gentefit.Controlador
{
    internal class LogicaSala
    {
        //Mostrar todas las salas
        public List<Sala> ListarSalas()
        {
            using var contexto = new GentefitContext();
            return contexto.Salas.ToList();
        }

        //Añadir una sala
        public void AnadirSala(Sala nuevaSala)
        {
            using var contexto = new GentefitContext();
            contexto.Salas.Add(nuevaSala);
            contexto.SaveChanges();
        }

        //Modificar una sala
        public bool ModificarSala(Sala sala)
        {
            using var contexto = new GentefitContext();
            var s = contexto.Salas.FirstOrDefault(
                x => x.idSala == sala.idSala);
            if (s == null) return false;

            s.nombre = sala.nombre;
            contexto.SaveChanges();
            return true;
        }

        //Eliminar una sala
        public bool EliminarSala(int id)
        {
            using var contexto = new GentefitContext();
            var sala = contexto.Salas.Find(id);
            if (sala != null)
            {
                contexto.Salas.Remove(sala);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
