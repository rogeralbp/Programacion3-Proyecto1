using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Reservaciones_Guardadas
    {
        String idPais, idLugar, idHotel, fechaLlegada, fechaSalida, cantidadPersonas, cantidadHabitaciones, precioTotal;

        public Reservaciones_Guardadas() {
            idPais = String.Empty;
            idLugar = String.Empty;
            idHotel = String.Empty;
            fechaLlegada = String.Empty;
            fechaSalida = String.Empty;
            cantidadPersonas = String.Empty;
            cantidadHabitaciones = String.Empty;
            precioTotal = String.Empty;
        }

        public Reservaciones_Guardadas(string pidPais,string pidLugar,string pidHotel,string pfechaLlegada,string pfechaSalida,string pcantidadPersonas, string pcantidadHabitaciones,string pprecioTotal)
        {
            idPais = pidPais;
            idLugar = pidLugar;
            idHotel = pidHotel;
            fechaLlegada = pfechaLlegada;
            fechaSalida = pfechaSalida;
            cantidadPersonas = pcantidadPersonas;
            cantidadHabitaciones = pcantidadHabitaciones;
            precioTotal = pprecioTotal;
        }
    }
}
