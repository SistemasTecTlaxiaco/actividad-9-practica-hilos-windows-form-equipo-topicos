namespace ReservaLibreria
{
   using System;
using System.Collections.Generic;

namespace ReservaLibrary
{
    public class Reserva
    {
        // Atributos
        public int IdReserva { get; set; }
        public int IdUsuario { get; set; }
        public int IdHabitacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public float PrecioTotal { get; set; }

        // Constructor
        public Reserva(int idReserva, int idUsuario, int idHabitacion, 
                      DateTime fechaInicio, DateTime fechaFin, 
                      string estado, float precioTotal)
        {
            IdReserva = idReserva;
            IdUsuario = idUsuario;
            IdHabitacion = idHabitacion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Estado = estado;
            PrecioTotal = precioTotal;
        }

        // Métodos
        public void CrearReserva()
        {
            Estado = "Confirmada";
            Console.WriteLine("Reserva creada con éxito.");
        }

        public void CancelarReserva()
        {
            if (Estado != "Cancelada")
            {
                Estado = "Cancelada";
                Console.WriteLine("Reserva cancelada con éxito.");
            }
            else
            {
                Console.WriteLine("La reserva ya está cancelada.");
            }
        }

        public void ModificarReserva(DateTime nuevaFechaInicio, DateTime nuevaFechaFin)
        {
            if (Estado != "Cancelada")
            {
                FechaInicio = nuevaFechaInicio;
                FechaFin = nuevaFechaFin;
                Console.WriteLine("Reserva modificada con éxito.");
            }
            else
            {
                Console.WriteLine("No se puede modificar una reserva cancelada.");
            }
        }

        public float CalcularPrecioTotal(float precioPorNoche)
        {
            if (Estado != "Cancelada")
            {
                TimeSpan duracion = FechaFin - FechaInicio;
                int dias = duracion.Days;
                PrecioTotal = dias * precioPorNoche;
                return PrecioTotal;
            }
            return 0;
        }
    }
}
}
