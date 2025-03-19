using System;

namespace Skills;

public class Members
{
    public string Nombre { get; set; }
    public string Rol { get; set; }
    public string CorreoElectronico { get; set; }

    // retorna un string con el nombre y el rol del miembro
    public override string ToString()
    {
        return $"{Nombre} - {Rol}";
    }

// añade la inicialización por defecto de las propiedades
    public Members()
    {
        Nombre = string.Empty;
        Rol = string.Empty;
        CorreoElectronico = string.Empty;
    }

    // constructor con parámetros
    public Members(string nombre, string rol, string correoElectronico)
    {
        Nombre = nombre;
        Rol = rol;
        CorreoElectronico = correoElectronico;
    }
}
