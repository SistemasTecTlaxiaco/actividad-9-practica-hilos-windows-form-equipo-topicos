using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioLibreria;
namespace UsuarioHotel
{
    public partial class Form1 : Form
    {
        private Usuario usuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBox1.Text, out int idUsuario))
                {
                    MessageBox.Show("El ID de usuario debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = textBox2.Text;
                string apellido = textBox3.Text;
                string email = textBox4.Text;
                string contraseña = textBox5.Text;

                usuario = new Usuario(idUsuario, nombre, apellido, email, contraseña, "Cliente");

                

                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnsesion_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                string email = textBox4.Text;
                string contraseña = textBox5.Text;

                bool sesionIniciada = usuario.IniciarSesion(email, contraseña);
                MessageBox.Show(sesionIniciada ? "Sesión iniciada con éxito." : "Email o contraseña incorrectos.",
                                "Iniciar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay un usuario registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } }
        

        private void btnCerarsesion_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
               
                MessageBox.Show("Sesión cerrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay una sesión activa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnModificraperfil_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                try
                {
                    string nombre = textBox2.Text;
                    string apellido = textBox3.Text;
                    string email = textBox4.Text;
                    string contraseña = textBox5.Text;

                  
                    MessageBox.Show("Perfil modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el perfil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay un usuario registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void idusuario_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                MessageBox.Show($"ID de Usuario: {usuario.IdUsuario}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay un usuario registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nombreusuario_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                MessageBox.Show($"Nombre del Usuario: {usuario.Nombre} {usuario.Apellido}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay un usuario registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

