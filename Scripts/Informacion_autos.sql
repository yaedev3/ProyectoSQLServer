INSERT INTO Proveedor (Nombre,Telefono,Domicilio,RazonSocial,Email) VALUES ('Juan Perez', '8182858','Himno Nacional','Deportivos SA de CV','Deportivos@gmail.com');
INSERT INTO Proveedor (Nombre,Telefono,Domicilio,RazonSocial,Email) VALUES ('Rodolfo Rodriguez', '3231563','Salvador Nava','Empresariales SA de CV','Empresariales@gmail.com');
INSERT INTO Proveedor (Nombre,Telefono,Domicilio,RazonSocial,Email) VALUES ('Silvia Torres', '8152452','Manuel Nava','Electricos SA de CV','Electricos@gmail.com');
INSERT INTO Proveedor (Nombre,Telefono,Domicilio,RazonSocial,Email) VALUES ('Pedro Gonzalez', '8201000','Himalaya','Antiguos SA de CV','Antiguos@gmail.com');

INSERT INTO Agente (Nombre,RFC,Salario,Domicilio,Celular,Email) VALUES ('Jose Perez','JOSPE12354',18500.00,'Prados','4444851254','jope@hotmail.com');

INSERT INTO Cliente (Nombre,Domicilio,Telefono,Ocupacion) VALUES ('Miguel Sanchez','Los lirios','8456213','Estudiante');
INSERT INTO Cliente (Nombre,Domicilio,Telefono,Ocupacion) VALUES ('Ramon Salinas','Las flores','44954512','Chef');
INSERT INTO Cliente (Nombre,Domicilio,Telefono,Ocupacion) VALUES ('Jose Rosas','Los arboles','44984512','Maestro');

INSERT INTO Auto (Modelo, Marca, Nombre, PrecioFabrica, Cantidad) VALUES ('1995','Ford','Tsuru',12000,0);

INSERT INTO Instancia_Auto (NoSerie,IdAuto,Bandera) VALUES ('1E2AA1S2D59E8W54S',1,1);
INSERT INTO Instancia_Auto (NoSerie,IdAuto,Bandera) VALUES ('1E2AEAS2D59E8W54S',1,1);

SELECT * FROM Instancia_Auto;
DROP DATABASE databasecar;
