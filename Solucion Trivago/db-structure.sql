-- Table: public.aeropuerto

-- DROP TABLE public.aeropuerto;

CREATE TABLE public.aeropuerto
(
    identificador_aeropuerto integer NOT NULL,
    nombre_aeropuerto character varying(30) COLLATE pg_catalog."default" NOT NULL,
    lugar_aeropuerto character varying(30) COLLATE pg_catalog."default" NOT NULL,
    codigo_aeropuerto integer NOT NULL,
    CONSTRAINT aeropuerto_pkey PRIMARY KEY (identificador_aeropuerto),
    CONSTRAINT lugares_pkey FOREIGN KEY (identificador_aeropuerto)
        REFERENCES public.lugares (identificador_lugar) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.aeropuerto
    OWNER to postgres;
---------------------------------------------
-- Table: public.hotel

-- DROP TABLE public.hotel;

CREATE TABLE public.hotel
(
    identificador integer NOT NULL,
    nombre character varying(100) COLLATE pg_catalog."default" NOT NULL,
    foto character varying(100) COLLATE pg_catalog."default" NOT NULL,
    pais character varying(100) COLLATE pg_catalog."default" NOT NULL,
    lugar character varying(100) COLLATE pg_catalog."default" NOT NULL,
    habitaciones integer NOT NULL,
    tarifa_hotel double precision NOT NULL,
    CONSTRAINT hotel_pkey PRIMARY KEY (identificador)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.hotel
    OWNER to postgres;
---------------------------------------------

-- Table: public.informacion_prereservaciones_hoteles

-- DROP TABLE public.informacion_prereservaciones_hoteles;

CREATE TABLE public.informacion_prereservaciones_hoteles
(
    id_hotel integer NOT NULL,
    fecha_llegada date NOT NULL,
    fecha_salida date NOT NULL,
    cantidad_habitaciones integer NOT NULL,
    cantidad_personas integer NOT NULL,
    id_cliente integer NOT NULL,
    personas_menores integer NOT NULL,
    personas_mayores integer NOT NULL,
    precio_total_prereservacion double precision NOT NULL,
    CONSTRAINT fk_prereservaciones_clientes FOREIGN KEY (id_cliente)
        REFERENCES public.usuarios (cedula) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_preservaciones_hotel FOREIGN KEY (id_hotel)
        REFERENCES public.hotel (identificador) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.informacion_prereservaciones_hoteles
    OWNER to postgres;

-- Index: fki_fk_prereservaciones_clientes

-- DROP INDEX public.fki_fk_prereservaciones_clientes;

CREATE INDEX fki_fk_prereservaciones_clientes
    ON public.informacion_prereservaciones_hoteles USING btree
    (id_cliente)
    TABLESPACE pg_default;

-- Index: fki_fk_preservaciones_hotel

-- DROP INDEX public.fki_fk_preservaciones_hotel;

CREATE INDEX fki_fk_preservaciones_hotel
    ON public.informacion_prereservaciones_hoteles USING btree
    (id_hotel)
    TABLESPACE pg_default;

---------------------------------
-- Table: public.informacion_reservaciones_hoteles

-- DROP TABLE public.informacion_reservaciones_hoteles;

CREATE TABLE public.informacion_reservaciones_hoteles
(
    id_hotel integer NOT NULL,
    fecha_llegada date NOT NULL,
    fecha_salida date NOT NULL,
    cantidad_habitaciones integer NOT NULL,
    cantidad_personas integer NOT NULL,
    id_cliente integer,
    personas_menores integer NOT NULL,
    personas_mayores integer NOT NULL,
    precio_total_reservacion double precision NOT NULL,
    CONSTRAINT fk_reservaciones_clientes FOREIGN KEY (id_cliente)
        REFERENCES public.usuarios (cedula) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_reservaciones_hotel FOREIGN KEY (id_hotel)
        REFERENCES public.hotel (identificador) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.informacion_reservaciones_hoteles
    OWNER to postgres;

-- Index: fki_info_cliente

-- DROP INDEX public.fki_info_cliente;

CREATE INDEX fki_info_cliente
    ON public.informacion_reservaciones_hoteles USING btree
    (id_cliente)
    TABLESPACE pg_default;

-- Index: fki_informacion_hotel

-- DROP INDEX public.fki_informacion_hotel;

CREATE INDEX fki_informacion_hotel
    ON public.informacion_reservaciones_hoteles USING btree
    (id_hotel)
    TABLESPACE pg_default;

---------------------------------------

-- Table: public.lugares

-- DROP TABLE public.lugares;

CREATE TABLE public.lugares
(
    identificador_lugar integer NOT NULL,
    nombre_lugar character varying(25) COLLATE pg_catalog."default" NOT NULL,
    id_pais integer,
    CONSTRAINT lugares_pkey PRIMARY KEY (identificador_lugar),
    CONSTRAINT fk_lugar_pais FOREIGN KEY (id_pais)
        REFERENCES public.paises (identificador) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.lugares
    OWNER to postgres;

-- Index: fki_fk_lugar_pais

-- DROP INDEX public.fki_fk_lugar_pais;

CREATE INDEX fki_fk_lugar_pais
    ON public.lugares USING btree
    (id_pais)
    TABLESPACE pg_default;

--------------------------

-- Table: public.paises

-- DROP TABLE public.paises;

CREATE TABLE public.paises
(
    identificador integer NOT NULL,
    nombre character varying(100) COLLATE pg_catalog."default" NOT NULL,
    direccion character varying(100) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT paises_pkey PRIMARY KEY (identificador)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.paises
    OWNER to postgres;

----------------------------------

-- Table: public.ranking_hoteles

-- DROP TABLE public.ranking_hoteles;

CREATE TABLE public.ranking_hoteles
(
    id_hotel integer NOT NULL,
    calificacion_actual integer NOT NULL,
    CONSTRAINT fk_ranking_id_hotel FOREIGN KEY (id_hotel)
        REFERENCES public.hotel (identificador) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.ranking_hoteles
    OWNER to postgres;

-- Index: fki_fk_ranking_hotel

-- DROP INDEX public.fki_fk_ranking_hotel;

CREATE INDEX fki_fk_ranking_hotel
    ON public.ranking_hoteles USING btree
    (id_hotel)
    TABLESPACE pg_default;

------------------------------

-- Table: public.rutas

-- DROP TABLE public.rutas;

CREATE TABLE public.rutas
(
    identificador_ruta integer NOT NULL,
    pais_origen character varying(30) COLLATE pg_catalog."default" NOT NULL,
    pais_destino character varying(30) COLLATE pg_catalog."default" NOT NULL,
    duracion integer NOT NULL,
    CONSTRAINT rutas_pkey PRIMARY KEY (identificador_ruta)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.rutas
    OWNER to postgres;

------------------------

-- Table: public.tarifas_hoteles

-- DROP TABLE public.tarifas_hoteles;

CREATE TABLE public.tarifas_hoteles
(
    identificador_tarifa integer NOT NULL,
    precio_tarifa double precision NOT NULL,
    CONSTRAINT tarifas_hoteles_pkey PRIMARY KEY (identificador_tarifa)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.tarifas_hoteles
    OWNER to postgres;

------------------------

-- Table: public.tarifas_vuelos

-- DROP TABLE public.tarifas_vuelos;

CREATE TABLE public.tarifas_vuelos
(
    identificador_tarifa integer NOT NULL,
    ruta integer NOT NULL,
    precio double precision NOT NULL,
    CONSTRAINT tarifas_vuelos_pkey PRIMARY KEY (identificador_tarifa),
    CONSTRAINT fk_tarifa_ruta FOREIGN KEY (ruta)
        REFERENCES public.rutas (identificador_ruta) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.tarifas_vuelos
    OWNER to postgres;

-- Index: fki_fk_tarifa_ruta

-- DROP INDEX public.fki_fk_tarifa_ruta;

CREATE INDEX fki_fk_tarifa_ruta
    ON public.tarifas_vuelos USING btree
    (ruta)
    TABLESPACE pg_default;


------------------
-- Table: public.usuarios

-- DROP TABLE public.usuarios;

CREATE TABLE public.usuarios
(
    cedula integer NOT NULL,
    nombre character varying(30) COLLATE pg_catalog."default" NOT NULL,
    "contraseña" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    tipo_usuario character varying(30) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT usuarios_pkey PRIMARY KEY (cedula)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.usuarios
    OWNER to postgres;

------------------------
-- Table: public.vehiculos

-- DROP TABLE public.vehiculos;

CREATE TABLE public.vehiculos
(
    placa integer NOT NULL,
    marca character varying(30) COLLATE pg_catalog."default" NOT NULL,
    modelo character varying(30) COLLATE pg_catalog."default" NOT NULL,
    tipo_vehiculo character varying(30) COLLATE pg_catalog."default" NOT NULL,
    precio double precision NOT NULL,
    cantidad_personas integer NOT NULL,
    CONSTRAINT vehiculos_pkey PRIMARY KEY (placa)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.vehiculos
    OWNER to postgres;
---------------------


-----------------------------------

-- Table: public.informacion_reservaciones_vuelos

-- DROP TABLE public.informacion_reservaciones_vuelos;

CREATE TABLE public.informacion_reservaciones_vuelos
(
    id_vuelo integer,
    id_hotel integer,
    placa_vehiculo integer,
    pasajeros_adultos integer,
    "pasajeros_niños" integer,
    habitaciones_hotel integer,
    fecha_inicio date,
    fecha_fin date,
    pais_origen character varying(100) COLLATE pg_catalog."default",
    pais_destino character varying(100) COLLATE pg_catalog."default",
    duracion_total integer,
    precio_total double precision,
    vuelo_escala character varying(100) COLLATE pg_catalog."default",
    id_cliente integer,
    CONSTRAINT fk_cliente FOREIGN KEY (id_cliente)
        REFERENCES public.usuarios (cedula) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_hotel FOREIGN KEY (id_hotel)
        REFERENCES public.hotel (identificador) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_vehiculo FOREIGN KEY (placa_vehiculo)
        REFERENCES public.vehiculos (placa) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_vuelo FOREIGN KEY (id_vuelo)
        REFERENCES public.rutas (identificador_ruta) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.informacion_reservaciones_vuelos
    OWNER to postgres;

-- Index: fki_fk_cliente

-- DROP INDEX public.fki_fk_cliente;

CREATE INDEX fki_fk_cliente
    ON public.informacion_reservaciones_vuelos USING btree
    (id_cliente)
    TABLESPACE pg_default;

-- Index: fki_fk_hotel

-- DROP INDEX public.fki_fk_hotel;

CREATE INDEX fki_fk_hotel
    ON public.informacion_reservaciones_vuelos USING btree
    (id_hotel)
    TABLESPACE pg_default;

-- Index: fki_fk_vehiculo

-- DROP INDEX public.fki_fk_vehiculo;

CREATE INDEX fki_fk_vehiculo
    ON public.informacion_reservaciones_vuelos USING btree
    (placa_vehiculo)
    TABLESPACE pg_default;

-- Index: fki_fk_vuelo

-- DROP INDEX public.fki_fk_vuelo;

CREATE INDEX fki_fk_vuelo
    ON public.informacion_reservaciones_vuelos USING btree
    (id_vuelo)
    TABLESPACE pg_default;

-----------------------------------

-- Table: public.informacion_prereservaciones_vuelos

-- DROP TABLE public.informacion_prereservaciones_vuelos;

CREATE TABLE public.informacion_prereservaciones_vuelos
(
    id_vuelo integer,
    id_hotel integer,
    placa_vehiculo integer,
    pasajeros_adultos integer,
    "pasajeros_niños" integer,
    habitaciones_hotel integer,
    fecha_inicio date,
    fecha_fin date,
    pais_origen character varying(100) COLLATE pg_catalog."default",
    pais_destino character varying(100) COLLATE pg_catalog."default",
    duracion_total integer,
    precio_total double precision,
    vuelo_escala character varying(100) COLLATE pg_catalog."default",
    id_cliente integer,
    CONSTRAINT fk_cliente FOREIGN KEY (id_cliente)
        REFERENCES public.usuarios (cedula) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_hotel FOREIGN KEY (id_hotel)
        REFERENCES public.hotel (identificador) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_vehiculo FOREIGN KEY (placa_vehiculo)
        REFERENCES public.vehiculos (placa) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_vuelo FOREIGN KEY (id_vuelo)
        REFERENCES public.rutas (identificador_ruta) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.informacion_prereservaciones_vuelos
    OWNER to postgres;