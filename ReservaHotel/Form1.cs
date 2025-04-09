using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservalibreria;

namespace ReservaHotel
{
    public partial class Reserva: Form
    {
        private Reservalibreria.Reserva reservaActual;


        public Reserva()
        {
            InitializeComponent();
            cmbEstado.Items.AddRange(new string[] { "Pendiente", "Confirmada", "Cancelada" });
            cmbEstado.SelectedIndex = 0;


        }

        private void btnCrear_reserva_Click(object sender, EventArgs e)
        {
            try
            {
                reservaActual = new Reservalibreria.Reserva(
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

    

        private void btnCalcularPreciototal_Click(object sender, EventArgs e)
        {
            if (reservaActual != null && float.TryParse(txtPrecioNoche.Text, out float precioNoche))
            {
                float total = reservaActual.CalcularPrecioTotal(precioNoche);
                lblPrecioTotal.Text = total.ToString("C");
            }
            else
            {
                MessageBox.Show("Ingrese un precio por noche válido", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblPrecioTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbprecioTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioNoche_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbPnoche_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LbEstado_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Lbfechafin_Click(object sender, EventArgs e)
        {

        }

        private void Lbfechainicio_Click(object sender, EventArgs e)
        {

        }

        private void txtIdHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbhabitacion_Click(object sender, EventArgs e)
        {

        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbusuario_Click(object sender, EventArgs e)
        {

        }

        private void txtIdReserva_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelReserva_Click(object sender, EventArgs e)
        {

        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }
    }
}
