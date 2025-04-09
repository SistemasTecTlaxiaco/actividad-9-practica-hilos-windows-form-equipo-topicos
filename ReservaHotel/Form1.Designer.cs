namespace ReservaHotel
{
    partial class Reserva
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcularPreciototal = new System.Windows.Forms.Button();
            this.btnCancelarreserva = new System.Windows.Forms.Button();
            this.btnModificarreserva = new System.Windows.Forms.Button();
            this.btnCrear_reserva = new System.Windows.Forms.Button();
            this.lblPrecioTotal = new System.Windows.Forms.TextBox();
            this.LbprecioTotal = new System.Windows.Forms.Label();
            this.txtPrecioNoche = new System.Windows.Forms.TextBox();
            this.LbPnoche = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.LbEstado = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Lbfechafin = new System.Windows.Forms.Label();
            this.Lbfechainicio = new System.Windows.Forms.Label();
            this.txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.Lbhabitacion = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.Lbusuario = new System.Windows.Forms.Label();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.labelReserva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularPreciototal
            // 
            this.btnCalcularPreciototal.Location = new System.Drawing.Point(562, 329);
            this.btnCalcularPreciototal.Name = "btnCalcularPreciototal";
            this.btnCalcularPreciototal.Size = new System.Drawing.Size(123, 34);
            this.btnCalcularPreciototal.TabIndex = 99;
            this.btnCalcularPreciototal.Text = "Calcular Precio Total";
            this.btnCalcularPreciototal.UseVisualStyleBackColor = true;
            this.btnCalcularPreciototal.Click += new System.EventHandler(this.btnCalcularPreciototal_Click);
            // 
            // btnCancelarreserva
            // 
            this.btnCancelarreserva.Location = new System.Drawing.Point(397, 329);
            this.btnCancelarreserva.Name = "btnCancelarreserva";
            this.btnCancelarreserva.Size = new System.Drawing.Size(123, 34);
            this.btnCancelarreserva.TabIndex = 98;
            this.btnCancelarreserva.Text = "Cancelar Reserva";
            this.btnCancelarreserva.UseVisualStyleBackColor = true;
            this.btnCancelarreserva.Click += new System.EventHandler(this.btnCancelarreserva_Click);
            // 
            // btnModificarreserva
            // 
            this.btnModificarreserva.Location = new System.Drawing.Point(241, 329);
            this.btnModificarreserva.Name = "btnModificarreserva";
            this.btnModificarreserva.Size = new System.Drawing.Size(123, 34);
            this.btnModificarreserva.TabIndex = 97;
            this.btnModificarreserva.Text = "Modificar Reserva";
            this.btnModificarreserva.UseVisualStyleBackColor = true;
            this.btnModificarreserva.Click += new System.EventHandler(this.btnModificarreserva_Click);
            // 
            // btnCrear_reserva
            // 
            this.btnCrear_reserva.Location = new System.Drawing.Point(79, 329);
            this.btnCrear_reserva.Name = "btnCrear_reserva";
            this.btnCrear_reserva.Size = new System.Drawing.Size(123, 34);
            this.btnCrear_reserva.TabIndex = 96;
            this.btnCrear_reserva.Text = "Crear Reserva";
            this.btnCrear_reserva.UseVisualStyleBackColor = true;
            this.btnCrear_reserva.Click += new System.EventHandler(this.btnCrear_reserva_Click);
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Location = new System.Drawing.Point(534, 180);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(160, 20);
            this.lblPrecioTotal.TabIndex = 95;
            this.lblPrecioTotal.TextChanged += new System.EventHandler(this.lblPrecioTotal_TextChanged);
            // 
            // LbprecioTotal
            // 
            this.LbprecioTotal.AutoSize = true;
            this.LbprecioTotal.Location = new System.Drawing.Point(432, 189);
            this.LbprecioTotal.Name = "LbprecioTotal";
            this.LbprecioTotal.Size = new System.Drawing.Size(60, 13);
            this.LbprecioTotal.TabIndex = 94;
            this.LbprecioTotal.Text = "Precio total";
            this.LbprecioTotal.Click += new System.EventHandler(this.LbprecioTotal_Click);
            // 
            // txtPrecioNoche
            // 
            this.txtPrecioNoche.Location = new System.Drawing.Point(534, 139);
            this.txtPrecioNoche.Name = "txtPrecioNoche";
            this.txtPrecioNoche.Size = new System.Drawing.Size(160, 20);
            this.txtPrecioNoche.TabIndex = 93;
            this.txtPrecioNoche.TextChanged += new System.EventHandler(this.txtPrecioNoche_TextChanged);
            // 
            // LbPnoche
            // 
            this.LbPnoche.AutoSize = true;
            this.LbPnoche.Location = new System.Drawing.Point(432, 146);
            this.LbPnoche.Name = "LbPnoche";
            this.LbPnoche.Size = new System.Drawing.Size(88, 13);
            this.LbPnoche.TabIndex = 92;
            this.LbPnoche.Text = "Precio por noche";
            this.LbPnoche.Click += new System.EventHandler(this.LbPnoche_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(534, 88);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(188, 21);
            this.cmbEstado.TabIndex = 91;
            this.cmbEstado.Text = "Pendiente";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // LbEstado
            // 
            this.LbEstado.AutoSize = true;
            this.LbEstado.Location = new System.Drawing.Point(429, 92);
            this.LbEstado.Name = "LbEstado";
            this.LbEstado.Size = new System.Drawing.Size(40, 13);
            this.LbEstado.TabIndex = 90;
            this.LbEstado.Text = "Estado";
            this.LbEstado.Click += new System.EventHandler(this.LbEstado_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(204, 264);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 89;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(204, 222);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 88;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // Lbfechafin
            // 
            this.Lbfechafin.AutoSize = true;
            this.Lbfechafin.Location = new System.Drawing.Point(102, 271);
            this.Lbfechafin.Name = "Lbfechafin";
            this.Lbfechafin.Size = new System.Drawing.Size(69, 13);
            this.Lbfechafin.TabIndex = 87;
            this.Lbfechafin.Text = "Fecha de Fin";
            this.Lbfechafin.Click += new System.EventHandler(this.Lbfechafin_Click);
            // 
            // Lbfechainicio
            // 
            this.Lbfechainicio.AutoSize = true;
            this.Lbfechainicio.Location = new System.Drawing.Point(102, 222);
            this.Lbfechainicio.Name = "Lbfechainicio";
            this.Lbfechainicio.Size = new System.Drawing.Size(79, 13);
            this.Lbfechainicio.TabIndex = 86;
            this.Lbfechainicio.Text = "Fecha de inicio";
            this.Lbfechainicio.Click += new System.EventHandler(this.Lbfechainicio_Click);
            // 
            // txtIdHabitacion
            // 
            this.txtIdHabitacion.Location = new System.Drawing.Point(204, 180);
            this.txtIdHabitacion.Name = "txtIdHabitacion";
            this.txtIdHabitacion.Size = new System.Drawing.Size(160, 20);
            this.txtIdHabitacion.TabIndex = 85;
            this.txtIdHabitacion.Text = "INGRESAR HABITACION";
            this.txtIdHabitacion.TextChanged += new System.EventHandler(this.txtIdHabitacion_TextChanged);
            // 
            // Lbhabitacion
            // 
            this.Lbhabitacion.AutoSize = true;
            this.Lbhabitacion.Location = new System.Drawing.Point(102, 180);
            this.Lbhabitacion.Name = "Lbhabitacion";
            this.Lbhabitacion.Size = new System.Drawing.Size(58, 13);
            this.Lbhabitacion.TabIndex = 84;
            this.Lbhabitacion.Text = "Habitacion";
            this.Lbhabitacion.Click += new System.EventHandler(this.Lbhabitacion_Click);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(204, 132);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtIdUsuario.TabIndex = 83;
            this.txtIdUsuario.Text = "USUARIO";
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // Lbusuario
            // 
            this.Lbusuario.AutoSize = true;
            this.Lbusuario.Location = new System.Drawing.Point(102, 132);
            this.Lbusuario.Name = "Lbusuario";
            this.Lbusuario.Size = new System.Drawing.Size(43, 13);
            this.Lbusuario.TabIndex = 82;
            this.Lbusuario.Text = "Usuario";
            this.Lbusuario.Click += new System.EventHandler(this.Lbusuario_Click);
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(204, 89);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(160, 20);
            this.txtIdReserva.TabIndex = 81;
            this.txtIdReserva.Text = "INGRESAR RESERVA";
            this.txtIdReserva.TextChanged += new System.EventHandler(this.txtIdReserva_TextChanged);
            // 
            // labelReserva
            // 
            this.labelReserva.AutoSize = true;
            this.labelReserva.Location = new System.Drawing.Point(102, 89);
            this.labelReserva.Name = "labelReserva";
            this.labelReserva.Size = new System.Drawing.Size(47, 13);
            this.labelReserva.TabIndex = 80;
            this.labelReserva.Text = "Reserva";
            this.labelReserva.Click += new System.EventHandler(this.labelReserva_Click);
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularPreciototal);
            this.Controls.Add(this.btnCancelarreserva);
            this.Controls.Add(this.btnModificarreserva);
            this.Controls.Add(this.btnCrear_reserva);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.LbprecioTotal);
            this.Controls.Add(this.txtPrecioNoche);
            this.Controls.Add(this.LbPnoche);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.LbEstado);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.Lbfechafin);
            this.Controls.Add(this.Lbfechainicio);
            this.Controls.Add(this.txtIdHabitacion);
            this.Controls.Add(this.Lbhabitacion);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.Lbusuario);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.labelReserva);
            this.Name = "Reserva";
            this.Text = "Reserva ";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularPreciototal;
        private System.Windows.Forms.Button btnCancelarreserva;
        private System.Windows.Forms.Button btnModificarreserva;
        private System.Windows.Forms.Button btnCrear_reserva;
        private System.Windows.Forms.TextBox lblPrecioTotal;
        private System.Windows.Forms.Label LbprecioTotal;
        private System.Windows.Forms.TextBox txtPrecioNoche;
        private System.Windows.Forms.Label LbPnoche;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label LbEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label Lbfechafin;
        private System.Windows.Forms.Label Lbfechainicio;
        private System.Windows.Forms.TextBox txtIdHabitacion;
        private System.Windows.Forms.Label Lbhabitacion;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label Lbusuario;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Label labelReserva;
    }
}

