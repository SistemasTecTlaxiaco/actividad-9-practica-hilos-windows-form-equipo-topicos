using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioLibreria
{
    public class Usuario
    {
        public int IdUsuario { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Email { get; private set; }
        private string Contraseña;
        public string TipoUsuario { get; private set; }
        private bool SesionActiva;

        public Usuario(int idUsuario, string nombre, string apellido, string email, string contraseña, string tipoUsuario)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contraseña = contraseña;
            TipoUsuario = tipoUsuario;
            SesionActiva = false;
        }

        public void Registrar()
        {
            // Aquí podrías agregar lógica para almacenar el usuario en una base de datos
            Console.WriteLine("Usuario registrado con éxito.");
        }

        public bool IniciarSesion(string email, string contraseña)
        {
            if (Email == email && Contraseña == contraseña)
            {
                SesionActiva = true;
                return true;
            }
            return false;
        }

        public void CerrarSesion()
        {
            SesionActiva = false;
        }

        public void ModificarPerfil(string nombre, string apellido, string email, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contraseña = contraseña;
        }
    }
}


