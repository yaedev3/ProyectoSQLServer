CREATE DATABASE databasecar;
USE databasecar;

/* TABLES */
CREATE TABLE Proveedor (
    idProveedor BIGINT NOT NULL IDENTITY(1,1),
    Nombre VARCHAR(25) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    Domicilio VARCHAR(25) NOT NULL,
    RazonSocial VARCHAR(25) NOT NULL,
    Email VARCHAR(25) NOT NULL,
    CONSTRAINT PK_Proveedor PRIMARY KEY(idProveedor)
);

CREATE TABLE Auto(
	IdAuto BIGINT IDENTITY(1,1) NOT NULL,
	Modelo VARCHAR(25) NOT NULL,
	Marca VARCHAR(25) NOT NULL,
	Nombre VARCHAR(25) NOT NULL,	
    PrecioFabrica FLOAT NOT NULL,
	Cantidad INT NOT NULL,
	CONSTRAINT PK_Auto PRIMARY KEY(IdAuto)
);

CREATE TABLE Instancia_Auto(
    NoSerie VARCHAR(17) NOT NULL,
	IdAuto BIGINT NOT NULL,
    PrecioVenta FLOAT,
	Bandera BIT,
    CONSTRAINT PK_NoSerie PRIMARY KEY(NoSerie),
	CONSTRAINT FK_Instancia_Auto_Auto FOREIGN KEY(IdAuto) REFERENCES Auto (IdAuto)
);

CREATE TABLE Agente (
    idAgente BIGINT NOT NULL IDENTITY(1,1),
    Nombre VARCHAR(25) NOT NULL, 
    RFC VARCHAR(12) NOT NULL,
    Salario FLOAT NOT NULL,
    Domicilio VARCHAR(25) NOT NULL,
    Celular VARCHAR(15) NOT NULL,
    Email VARCHAR(25) NOT NULL,
    CONSTRAINT PK_Agente PRIMARY KEY(idAgente)
);

CREATE TABLE Credito (
    idCredito BIGINT NOT NULL IDENTITY(1,1),
    NoSerie VARCHAR(17) NOT NULL,
    MontoInicial FLOAT NOT NULL,
    FechaApartado DATE NOT NULL,
    CONSTRAINT PK_Credito PRIMARY KEY(idCredito),
    CONSTRAINT FK_Credito_Auto FOREIGN KEY(NoSerie) REFERENCES Instancia_Auto (NoSerie) 
);

CREATE TABLE Cliente (
    idCliente BIGINT NOT NULL IDENTITY(1,1),
    Nombre VARCHAR(30) NOT NULL,
    Domicilio VARCHAR(30) NOT NULL,
    Telefono VARCHAR(30) NOT NULL,
    Ocupacion VARCHAR(30) NOT NULL,
    CONSTRAINT PK_Cliente PRIMARY KEY(idCliente)
);

CREATE TABLE Venta (
    idVenta BIGINT NOT NULL IDENTITY(1,1),
    idCliente BIGINT NOT NULL,
    idAgente BIGINT NOT NULL,
    NoSerie VARCHAR(17) NOT NULL,
    idCredito BIGINT NULL,
    FechaVenta DATE,
    MontoTotal FLOAT,
    NoExhibiciones INT NOT NULL,
    Adeudo FLOAT NOT NULL,
    TipoVenta VARCHAR(15) NOT NULL,
    CONSTRAINT PK_Venta PRIMARY KEY(idVenta),
    CONSTRAINT FK_Venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente (idCliente),
    CONSTRAINT FK_Venta_Agente FOREIGN KEY(idAgente) REFERENCES Agente (idAgente),
    CONSTRAINT FK_Venta_Auto FOREIGN KEY(NoSerie) REFERENCES Instancia_Auto (NoSerie),
    CONSTRAINT FK_Venta_Credito FOREIGN KEY(idCredito) REFERENCES Credito (idCredito)
);

CREATE TABLE Compra (
    idCompra BIGINT NOT NULL IDENTITY(1,1),
    idProveedor BIGINT NOT NULL,
    idAgente BIGINT NOT NULL,
    NoSerie VARCHAR(17) NOT NULL,
    FechaCompra DATE,
    CONSTRAINT PK_Compra PRIMARY KEY(idCompra),
    CONSTRAINT FK_Compra_Cliente FOREIGN KEY(idProveedor) REFERENCES Proveedor (idProveedor),
    CONSTRAINT FK_Compra_Agente FOREIGN KEY(idAgente) REFERENCES Agente (idAgente),
    CONSTRAINT FK_Compra_Auto FOREIGN KEY(NoSerie) REFERENCES Instancia_Auto(NoSerie)
);

CREATE TABLE Pago (
    idPago BIGINT NOT NULL IDENTITY(1,1),
    idVenta BIGINT,
    NoPago INT,
    CantidadPagar FLOAT,
    CONSTRAINT PK_Pago PRIMARY KEY(idPago),
    CONSTRAINT FK_Pago_Venta FOREIGN KEY(idVenta) REFERENCES Venta (idVenta),
);

/* RULES */
/* Regla para los tipos de pago, solo pueden ser de "Contado" o a "Credito"*/
CREATE RULE nombre_pagos As @pagos IN ('Credito', 'Contado');
EXEC sp_bindrule 'nombre_pagos', 'Venta.TipoVenta'; 

/* Regla para el numero de pagos, debe ser mayor o igual a 1 y menor o igual a 24*/
CREATE RULE numero_pagos  AS @range>= 1 AND @range < 24;  
EXEC sp_bindrule 'numero_pagos', 'Venta.NoExhibiciones'; 

/* TRIGGERS */
/* Cuando se inserta una compra cambia la bandera de activo del auto a positivo*/
CREATE TRIGGER T_BanderaCompra ON Compra
AFTER INSERT
AS 
	UPDATE Instancia_Auto
	SET Bandera = 1 
	FROM Instancia_Auto IA INNER JOIN INSERTED I ON 
	IA.NoSerie = I.NoSerie

/* Cuando se inserta una compra cambia la bandera de activo del auto a negativo*/
CREATE TRIGGER T_BanderaVenta ON Venta
AFTER INSERT
AS 
	UPDATE Instancia_Auto 
	SET Bandera = 0 
	FROM Instancia_Auto IA INNER JOIN INSERTED I ON 
	IA.NoSerie = I.NoSerie

/* Cuando se inserta una compra aumenta el numero de autos*/
CREATE TRIGGER T_Compra ON Compra
AFTER INSERT
AS 
	UPDATE Auto 
	SET Cantidad = Cantidad + 1 
	FROM Instancia_Auto IA INNER JOIN Auto ON IA.IdAuto = Auto.IdAuto
	INNER JOIN INSERTED I ON 
	IA.NoSerie = I.NoSerie;

/* Cuando se inserta una venta disminuye el numero de autos*/
CREATE TRIGGER T_Venta ON Venta
AFTER INSERT
AS 
	UPDATE Auto 
	SET Cantidad = Cantidad - 1 
	FROM Instancia_Auto IA INNER JOIN Auto ON IA.IdAuto = Auto.IdAuto
	INNER JOIN INSERTED I ON 
	IA.NoSerie = I.NoSerie;

/* Cuando se inserta un auto le añade el precio de venta*/
CREATE TRIGGER T_PrecioVenta ON Instancia_Auto
AFTER INSERT
AS 
	UPDATE Instancia_Auto 
	SET PrecioVenta = PrecioFabrica * 1.25 
	FROM Instancia_Auto IA INNER JOIN Auto ON IA.IdAuto = Auto.IdAuto
	INNER JOIN INSERTED I ON 
	IA.NoSerie = I.NoSerie;

/* Cuando se inserta una venta le añade la fecha*/
CREATE TRIGGER T_Fecha_Venta ON Venta
AFTER INSERT
AS 
	UPDATE Venta 
	SET FechaVenta = GETDATE() 
	FROM Venta v INNER JOIN INSERTED I ON 
	v.idVenta = I.idVenta

/* Cuando se inserta una compra le añade la fecha*/
CREATE TRIGGER T_Fecha_Compra ON Compra
AFTER INSERT
AS 
	UPDATE Compra 
	SET FechaCompra = GETDATE() 
	FROM Compra c INNER JOIN INSERTED I ON 
	c.idCompra = I.idCompra

/* Cuando se inserta un pago reduce el adeudo de la venta*/
CREATE TRIGGER T_Pago ON Pago
AFTER INSERT
AS 
	UPDATE Venta 
	SET Adeudo = A.Adeudo - (A.Adeudo / A.NoExhibiciones) 
	FROM Adeudo A INNER JOIN INSERTED I ON 
	A.idVenta = I.idVenta