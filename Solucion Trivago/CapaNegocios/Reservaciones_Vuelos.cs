using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Reservaciones_Vuelos
    {
        public string fecha_inicio;
        public string fecha_fin;
        public string pais_origen;
        public string pais_destino;
        public string vuelo_escala;
        public int id_vuelo;
        public int id_hotel;
        public int placa_vehiculo;
        public int pasajeros_adultos;
        public int pasajeros_niños;
        public int habitaciones_hotel;
        public int duracion_total;
        public int id_cliente;
        public double precio_total;

        public Reservaciones_Vuelos() {
            this.id_vuelo = 0;
            this.id_hotel = 0;
            this.placa_vehiculo =0;
            this.pasajeros_adultos = 0;
            this.pasajeros_niños = 0;
            this.habitaciones_hotel =0;
            this.fecha_inicio = String.Empty;
            this.fecha_fin = String.Empty;
            this.pais_origen = String.Empty;
            this.pais_destino = String.Empty;
            this.duracion_total = 0;
            this.precio_total = 0;
            this.vuelo_escala = String.Empty;
            this.id_cliente = 0;
        }

        public Reservaciones_Vuelos(int pid_Vuelo, int pid_Hotel, int pplaca_vehiculo, int ppasajeros_adultos, int ppasajeros_niños, int phabitaciones_hotel, string pfecha_Inicio, string pfecha_Fin, string ppais_Origen, string ppais_Destino, int pduracion_Total, double pprecio_Total, string pvuelo_escala, int pid_Cliente)
        {
            this.id_vuelo = pid_Vuelo;
            this.id_hotel = pid_Hotel;
            this.placa_vehiculo = pplaca_vehiculo;
            this.pasajeros_adultos = ppasajeros_adultos;
            this.pasajeros_niños = ppasajeros_niños;
            this.habitaciones_hotel = phabitaciones_hotel;
            this.fecha_inicio = pfecha_Inicio;
            this.fecha_fin = pfecha_Fin;
            this.pais_origen = ppais_Origen;
            this.pais_destino = ppais_Destino;
            this.duracion_total = pduracion_Total;
            this.precio_total = pprecio_Total;
            this.vuelo_escala = pvuelo_escala;
            this.id_cliente = pid_Cliente;
        }
    }
}
