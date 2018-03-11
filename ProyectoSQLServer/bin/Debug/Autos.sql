CREATE DATABASE databasecar;
USE databasecar;

CREATE TABLE Proveedor (
    idProveedor BIGINT NOT NULL IDENTITY(1,1),
    Nombre VARCHAR(25) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    Domicilio VARCHAR(25) NOT NULL,
    RazonSocial VARCHAR(25) NOT NULL,
    Email VARCHAR(25) NOT NULL,
    CONSTRAINT PK_Proveedor PRIMARY KEY(idProveedor)
);
CREATE TABLE Auto (
    NoSerie VARCHAR(17) NOT NULL,
    Nombre VARCHAR(25) NOT NULL,
    Marca VARCHAR(25) NOT NULL,
    Modelo VARCHAR(25) NOT NULL,
    PrecioFabrica FLOAT NOT NULL,
    PrecioVenta FLOAT NOT NULL,
    CONSTRAINT PK_NoSerie PRIMARY KEY(NoSerie)
);

INSERT INTO Auto (NoSerie,Nombre,Marca,Modelo,PrecioFabrica,PrecioVenta) VALUES ('1575skdjrn75asdwr','Tsuru','Nissan','2017', 105500.00, 135000.00)

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
    CONSTRAINT FK_Credito_Auto FOREIGN KEY(NoSerie) REFERENCES Auto (NoSerie) 
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
    FechaVenta DATE NOT NULL,
    MontoTotal FLOAT NOT NULL,
    NoExhibiciones INT NOT NULL,
    Adeudo FLOAT NOT NULL,
    TipoVenta VARCHAR(15) NOT NULL,
    CONSTRAINT PK_Venta PRIMARY KEY(idVenta),
    CONSTRAINT FK_Venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente (idCliente),
    CONSTRAINT FK_Venta_Agente FOREIGN KEY(idAgente) REFERENCES Agente (idAgente),
    CONSTRAINT FK_Venta_Auto FOREIGN KEY(NoSerie) REFERENCES Auto (NoSerie),
    CONSTRAINT FK_Venta_Credito FOREIGN KEY(idCredito) REFERENCES Credito (idCredito)
);
CREATE TABLE Compra (
    idCompra BIGINT NOT NULL IDENTITY(1,1),
    idProveedor BIGINT NOT NULL,
    idAgente BIGINT NOT NULL,
    NoSerie VARCHAR(17) NOT NULL,
    FechaCompra DATE NOT NULL,
    CONSTRAINT PK_Compra PRIMARY KEY(idCompra),
    CONSTRAINT FK_Compra_Cliente FOREIGN KEY(idProveedor) REFERENCES Proveedor (idProveedor),
    CONSTRAINT FK_Compra_Agente FOREIGN KEY(idAgente) REFERENCES Agente (idAgente),
    CONSTRAINT FK_Compra_Auto FOREIGN KEY(NoSerie) REFERENCES Auto (NoSerie)
);
CREATE TABLE Pago (
    idPago BIGINT NOT NULL IDENTITY(1,1),
    idVenta BIGINT,
    NoPago INT,
    CantidadPagar FLOAT,
    CONSTRAINT PK_Pago PRIMARY KEY(idPago),
    CONSTRAINT FK_Pago_Venta FOREIGN KEY(idVenta) REFERENCES Venta (idVenta),
);
CREATE RULE nombre_pagos As @pagos IN ('Credito', 'Contado');
EXEC sp_bindrule 'nombre_pagos', 'Venta.TipoVenta'; 

