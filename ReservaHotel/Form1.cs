using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaHotel
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbEstado.Items.AddRange(new string[] { "Pendiente", "Confirmada", "Cancelada" });
            cmbEstado.SelectedIndex = 0;
        }

        private void btnCrear_reserva_Click(object sender, EventArgs e)
        {
            try
            {
                reservaActual = new Reserva(
                    int.Parse(txtIdReserva.Text),
                    int.Parse(txtIdUsuario.Text),
                    int.Parse(txtIdHabitacion.Text),
                    dtpFechaInicio.Value,
                    dtpFechaFin.Value,
                    cmbEstado.SelectedItem.ToString(),
                    0
                );

                reservaActual.CrearReserva();
                cmbEstado.SelectedItem = reservaActual.Estado;

                MessageBox.Show("Reserva creada exitosamente", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear reserva: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarreserva_Click(object sender, EventArgs e)
        {
            if (reservaActual != null)
            {
                reservaActual.ModificarReserva(dtpFechaInicio.Value, dtpFechaFin.Value);
                MessageBox.Show("Fechas de reserva actualizadas", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay reserva para modificar", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarreserva_Click(object sender, EventArgs e)
        {
            if (reservaActual != null)
            {
                reservaActual.CancelarReserva();
                cmbEstado.SelectedItem = reservaActual.Estado;
                MessageBox.Show("Reserva cancelada", "Información",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay reserva para cancelar", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalcularPreciototal_Click(object sender, EventArgs e)
        {
            if (reservaActual != null && float.TryParse(txtPrecioNoche.Text, out float precioNoche))
            {
                float total = reservaActual.CalcularPrecioTotal(precioNoche);
                txtPrecioTotal.Text = total.ToString("C");
            }
            else
            {
                MessageBox.Show("Ingrese un precio por noche válido", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
