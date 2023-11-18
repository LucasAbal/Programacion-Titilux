CREATE TABLE Personas (
    Ci INT PRIMARY KEY,
    Nombre VARCHAR(255),
    Apellido VARCHAR(255),
    Telefono VARCHAR(15)
);

CREATE TABLE Domicilio (
    Num_Puerta INT PRIMARY KEY,
    Departamento VARCHAR(50),
    Calle VARCHAR(255),
    Ciudad_Destino VARCHAR(255),
    Esquina VARCHAR(255)
);

CREATE TABLE Camion (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Matricula VARCHAR(15),
    Seguro VARCHAR(3),
    Capacidad INT
);

CREATE TABLE ActividadCamiones (
    Id_ActividadCamion INT PRIMARY KEY,
    Id_Camion INT,
    Tarea VARCHAR(255),
    Fecha_Hora DATETIME,
    UbicacionAlmacen VARCHAR(100),
    FOREIGN KEY (Id_Camion) REFERENCES Camion(Id)
);

CREATE TABLE Almacen (
    Id VARCHAR(15) PRIMARY KEY,
    Capacidad INT,
    Ubicacion VARCHAR(255)
);

CREATE TABLE Cliente (
    Ci INT PRIMARY KEY,
    Num_Puerta INT,
    FOREIGN KEY (Ci) REFERENCES Personas(Ci),
    FOREIGN KEY (Num_Puerta) REFERENCES Domicilio(Num_Puerta)
);

CREATE TABLE Paquete (
    Id INT AUTO_INCREMENT PRIMARY KEY ,
	fecha_entrega varchar(50),
    fecha_recepcion varchar(50),
    Peso DECIMAL(10, 2),
    Tamano VARCHAR(50),
    Ci INT,
    Envio_Num_Puerta INT,
    Estado VARCHAR(50),
    FOREIGN KEY (Ci) REFERENCES Cliente(Ci),
    FOREIGN KEY (Envio_Num_Puerta) REFERENCES Domicilio(Num_Puerta)
);

CREATE TABLE Lote (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Capacidad INT,
    Alm_Envio VARCHAR(15),
    FOREIGN KEY (Alm_Envio) REFERENCES Almacen(Id)
);

CREATE TABLE lote_paquete (
    LoteID INT,
    PaqueteID INT,
    PRIMARY KEY (PaqueteID), -- Cambiado de paqueteID a PaqueteID
    FOREIGN KEY (LoteID) REFERENCES Lote(Id),
    FOREIGN KEY (PaqueteID) REFERENCES Paquete(Id)
);

CREATE TABLE lote_almacen (
    LoteID INT,
    AlmacenID VARCHAR(15),
    PRIMARY KEY (LoteID),
    FOREIGN KEY (LoteID) REFERENCES Lote(Id),
    FOREIGN KEY (AlmacenID) REFERENCES Almacen(Id)
);


CREATE TABLE roles (
    ID TINYINT NOT NULL,
    NombreRol VARCHAR(30) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE Rol_Usuario (
    Usuario VARCHAR(30) NOT NULL,
    Rol TINYINT NOT NULL,
    PRIMARY KEY (Usuario),
    FOREIGN KEY (Rol) REFERENCES roles(ID)
);

CREATE TABLE Chofer (
    Ci INT PRIMARY KEY,
    Nombre VARCHAR(255),
    Apellido VARCHAR(255),
    Telefono VARCHAR(15),
    Licencia VARCHAR(50)
);

