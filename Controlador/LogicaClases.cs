using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gentefit.db;
using Gentefit.Modelo;

namespace Gentefit.Controlador
{
    internal class LogicaClases
    {
        //Obtener todas las clases
        public List<Clase> ListarClases()
        {
            using var contexto = new GentefitContext();
            return contexto.Clases.ToList();
        }

        //Buscar clase por ID
        public List<Clase> BuscarPorId(int id)
        {
            using var contexto = new GentefitContext();
            return contexto.Clases.Where(c => c.idClase == id).ToList();
        }
        
        //Añadir una nueva clase
        public void AddClase(Clase clase)
        {
            using var contexto = new GentefitContext();
            contexto.Clases.Add(clase);
            contexto.SaveChanges();
        }

        //Modificar una clase
        public bool Modificar(Clase clase)
        {
            using var contexto = new GentefitContext();
            var c = contexto.Clases.FirstOrDefault(x => x.idClase == clase.idClase);
            if (c == null) return false;

            c.nombre
        }
    }
}
