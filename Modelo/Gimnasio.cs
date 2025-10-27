using System;
using System.Collections.Generic;

namespace Gentefit.Modelo;

public partial class Gimnasio
{
    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public virtual ICollection<Actividad> Actividades { get; set; } = new List<Actividad>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Monitor> Monitores { get; set; } = new List<Monitor>();

    public virtual ICollection<Sala> Salas { get; set; } = new List<Sala>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public void AñadirCliente(Cliente cliente)
    {
        using (var contexto = new GentefitContext())
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }
    }
    public List<Cliente> ListarClientes()
    {
        using (var contexto = new GentefitContext())
        {
            return contexto.Clientes.ToList();
        }
    }
    public void ActualizarCliente(Cliente cliente)
    {
        using (var contexto = new GentefitContext())
        {
            contexto.Clientes.Update(cliente);
            contexto.SaveChanges();
        }

    }
    public void EliminarCliente(int id)
    {
        using (var contexto = new GentefitContext())
        {
            var cliente = contexto.Clientes.Find(id);
            if (cliente != null)
            {
                contexto.Clientes.Remove(cliente);
                contexto.SaveChanges();
            }
        }
    }


}
