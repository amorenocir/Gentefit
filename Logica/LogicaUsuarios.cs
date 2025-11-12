using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Gentefit.ModeloXml;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

public class LogicaUsuarios
{

    // Obtener todos los usuarios
    public List<Usuario> ObtenerTodos()
    {
        using var contexto = new GentefitContext();
        return contexto.Usuarios.ToList();
    }

    // Buscar usuario por ID
    public List<Usuario> BuscarPorId(int id)
    {
        using var contexto = new GentefitContext();
        var resultado = contexto.Usuarios
            .Where(u => u.idUsuario == id)
            .ToList();
        return resultado;
    }
    

    // Añadir un nuevo usuario
    public void AnadirUsuario(Usuario nuevoUsuario)
    {
        using var contexto = new GentefitContext();
        contexto.Usuarios.Add(nuevoUsuario);
        contexto.SaveChanges();
    }

    // Modificar un usuario
    public bool Modificar(Usuario usuario)
    {
        using var contexto = new GentefitContext();
        var c = contexto.Usuarios.FirstOrDefault(x => x.idUsuario == usuario.idUsuario);
        if (c == null) return false;

        c.idUsuario = usuario.idUsuario;
        c.nombre = usuario.nombre;
        c.apellidos = usuario.apellidos;
        c.email = usuario.email;
        c.contrasena = usuario.contrasena;
        c.rol = usuario.rol;

        contexto.SaveChanges();
        return true;
    }


    // Eliminar usuario por ID
    public bool EliminarUsuario(int id)
    {
        using var contexto = new GentefitContext();
        var usuario = contexto.Usuarios.Find(id);
        if (usuario != null)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
            return true;
        }
        return false;
    }

    // Exportar usuarios a XML
    public void ExportarXml(string rutaArchivo)
    {
        var usuarios = ObtenerTodos();
        var usuariosXml = usuarios.Select(c => ConvertirAXml(c)).ToList();

        XmlSerializer serializer = new XmlSerializer(typeof(List<UsuarioXml>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
        {
            serializer.Serialize(fs, usuariosXml);
        }
    }

    // Importar usuarios desde XML
    public void ImportarXml(string rutaArchivo)
    {
        using var contexto = new GentefitContext();
        XmlSerializer serializer = new XmlSerializer(typeof(List<UsuarioXml>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
        {
            List<UsuarioXml> usuariosXml = (List<UsuarioXml>)serializer.Deserialize(fs);
            List<Usuario> usuarios = usuariosXml.Select(x =>
            {
                var c = ConvertirAEntidad(x);
                c.idUsuario = 0; // Ignorar el ID del XML
                return c;
            }).ToList();

            contexto.Usuarios.AddRange(usuarios);
            contexto.SaveChanges();
        }
    }

    // Conversión Usuario -> UsuarioXml
    public static UsuarioXml ConvertirAXml(Usuario usuario)
    {
        return new UsuarioXml
        {
            Id = usuario.idUsuario,
            Nombre = usuario.nombre,
            Apellidos = usuario.apellidos,
            Email = usuario.email,
            Contrasena = usuario.contrasena,
            Rol = usuario.rol.ToString(),
        };
    }

    // Conversión ClienteXml -> Cliente
    public static Usuario ConvertirAEntidad(UsuarioXml usuarioXml)
    {
        return new Usuario
        {
            idUsuario = usuarioXml.Id,
            nombre = usuarioXml.Nombre,
            apellidos = usuarioXml.Apellidos,
            email = usuarioXml.Email,
            contrasena = usuarioXml.Contrasena,
            rol = Enum.Parse<TipoRol>(usuarioXml.Rol),
        };
    }
}
