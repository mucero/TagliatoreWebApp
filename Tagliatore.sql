-- Base de datos: Tagliatore

CREATE DATABASE Tagliatore;
GO
USE Tagliatore;
GO

-- Tabla: Platillos
CREATE TABLE Platillos (
    id_platillo INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    ingredientes TEXT NOT NULL,
    precio DECIMAL(10, 2) NOT NULL,
    imagen_url VARCHAR(255),
    fecha_creacion DATETIME DEFAULT GETDATE(),
    fecha_actualizacion DATETIME DEFAULT GETDATE()
);

-- Tabla: Clientes
CREATE TABLE Clientes (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    correo VARCHAR(100) NOT NULL UNIQUE,
    telefono VARCHAR(15),
    dni VARCHAR(20) NOT NULL UNIQUE,
    fecha_registro DATETIME DEFAULT GETDATE(),
    fecha_actualizacion DATETIME DEFAULT GETDATE()
);

-- Tabla: Meseros (Usuarios)
CREATE TABLE Meseros (
    id_mesero INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    correo VARCHAR(100) NOT NULL UNIQUE,
    telefono VARCHAR(15),
    estado BIT DEFAULT 1, -- Eliminación lógica
    fecha_registro DATETIME DEFAULT GETDATE(),
    fecha_actualizacion DATETIME DEFAULT GETDATE()
);

-- Tabla: Órdenes
CREATE TABLE Ordenes (
    id_orden INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente INT,
    id_mesero INT,
    id_mesa INT NOT NULL,
    estado NVARCHAR(20) DEFAULT 'pendiente',
    fecha_orden DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente) ON DELETE SET NULL,
    FOREIGN KEY (id_mesero) REFERENCES Meseros(id_mesero) ON DELETE SET NULL
);

-- Tabla intermedia: Detalle de Ordenes
CREATE TABLE DetalleOrdenes (
    id_detalle INT IDENTITY(1,1) PRIMARY KEY,
    id_orden INT NOT NULL,
    id_platillo INT NOT NULL,
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (id_orden) REFERENCES Ordenes(id_orden) ON DELETE CASCADE,
    FOREIGN KEY (id_platillo) REFERENCES Platillos(id_platillo) ON DELETE CASCADE
);
