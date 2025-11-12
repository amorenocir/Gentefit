using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.ModeloXml;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

public class LogicaClientes
{

    // Obtener todos los clientes
    public List<Cliente> ObtenerTodos()
    {
        using var contexto = new GentefitContext();
        return contexto.Clientes.ToList();
    }

    // Buscar cliente por ID
    public List<Cliente> BuscarPorId(int id)
    {
        using var contexto = new GentefitContext();
        var resultado = contexto.Clientes
            .Where(u => u.idCliente == id)
            .ToList();
        return resultado;
    }

    // Añadir un nuevo cliente
    public void AnadirCliente(Cliente nuevoCliente)
    {
        using var contexto = new GentefitContext();
        contexto.Clientes.Add(nuevoCliente);
        contexto.SaveChanges();
    }

    // Modificar un cliente
    public bool Modificar(Cliente cliente)
    {
        using var contexto = new GentefitContext();
        var c = contexto.Clientes.FirstOrDefault(x => x.idCliente == cliente.idCliente);
        if (c == null) return false;

        c.nombre = cliente.nombre;
        c.apellidos = cliente.apellidos;
        c.dni = cliente.dni;
        c.telefono = cliente.telefono;
        c.email = cliente.email;
        c.contrasena = cliente.contrasena;

        contexto.SaveChanges();
        return true;
    }


    // Eliminar cliente por ID
    public bool EliminarCliente(int id)
    {
        using var contexto = new GentefitContext();
        var cliente = contexto.Clientes.Find(id);
        if (cliente != null)
        {
            contexto.Clientes.Remove(cliente);
            contexto.SaveChanges();
            return true;
        }
        return false;
    }

    // Exportar clientes a XML
    public void ExportarXml(string rutaArchivo)
    {
        var clientes = ObtenerTodos();
        var clientesXml = clientes.Select(c => ConvertirAXml(c)).ToList();

        XmlSerializer serializer = new XmlSerializer(typeof(List<ClienteXml>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
        {
            serializer.Serialize(fs, clientesXml);
        }
    }

    // Importar clientes desde XML
    public void ImportarXml(string rutaArchivo)
    {
        using var contexto = new GentefitContext();
        XmlSerializer serializer = new XmlSerializer(typeof(List<ClienteXml>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
        {
            List<ClienteXml> clientesXml = (List<ClienteXml>)serializer.Deserialize(fs);
            List<Cliente> clientes = clientesXml.Select(x =>
            {
                var c = ConvertirAEntidad(x);
                c.idCliente = 0; // Ignorar el ID del XML
                return c;
            }).ToList();

            contexto.Clientes.AddRange(clientes);
            contexto.SaveChanges();
        }
    }

    // Conversión Cliente -> ClienteXml
    public static ClienteXml ConvertirAXml(Cliente cliente)
    {
        return new ClienteXml
        {
            Id = cliente.idCliente,
            Nombre = cliente.nombre,
            Apellidos = cliente.apellidos,
            Dni = cliente.dni,
            Telefono = cliente.telefono,
            Email = cliente.email,
            Contrasena = cliente.contrasena,
        };
    }

    // Conversión ClienteXml -> Cliente
    public static Cliente ConvertirAEntidad(ClienteXml clienteXml)
    {
        return new Cliente
        {
            idCliente = clienteXml.Id,
            nombre = clienteXml.Nombre,
            apellidos = clienteXml.Apellidos,
            dni = clienteXml.Dni,
            telefono = clienteXml.Telefono,
            email = clienteXml.Email,
            contrasena = clienteXml.Contrasena,
        };
    }
}


