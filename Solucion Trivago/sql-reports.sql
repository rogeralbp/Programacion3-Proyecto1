-----Report 1-------

SELECT COUNT(r.id_hotel) AS reservaciones, h.nombre FROM informacion_reservaciones_hoteles AS r JOIN 
hotel AS h on r.id_hotel =h.identificador  WHERE r.id_hotel = h.identificador GROUP BY h.nombre ORDER BY reservaciones DESC
----- Report 2-------


SELECT COUNT(r.cantidad_personas) AS personas,h.nombre FROM informacion_reservaciones_hoteles AS r JOIN 
hotel AS h on r.id_hotel =h.identificador  WHERE r.id_hotel = h.identificador GROUP BY h.nombre  ORDER BY personas DESC

----- Report 3-------
SELECT COUNT(*) as porcentaje_visitas,pais_destino FROM informacion_reservaciones_vuelos GROUP BY pais_destino

---Report 4 ----

SELECT v.marca  as marca FROM informacion_reservaciones_vuelos AS r JOIN vehiculos AS v
ON r.placa_vehiculo=v.placa GROUP BY marca ORDER BY marca DESC

---Report 5----

SELECT vuelo_escala pais_escla FROM informacion_reservaciones_vuelos WHERE vuelo_escala !='Vuelo Directo'