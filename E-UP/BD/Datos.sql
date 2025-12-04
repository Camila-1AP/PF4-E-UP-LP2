create database Eup;
go

use Eup;
go

CREATE TABLE Departamento (
    DepartamentoID INT PRIMARY KEY IDENTITY(1,1),
    NombreDepartamento NVARCHAR(100) NOT NULL
);
go

CREATE TABLE Cargo (
    CargoID INT PRIMARY KEY IDENTITY(1,1),
    NombreCargo NVARCHAR(100) NOT NULL
);
go

ALTER TABLE Departamento
ADD Activo BIT NOT NULL DEFAULT (1);
go

ALTER TABLE Cargo
ADD Activo BIT NOT NULL DEFAULT (1);
go

-- empleado

CREATE TABLE Empleados (
    EmpleadoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    DepartamentoID INT NOT NULL,
    CargoID INT NOT NULL,
    FechaInicio DATE NOT NULL,
    FechaFin DATE NULL, -- solo se llena si el empleado está No vigente
    SueldoBruto DECIMAL(10,2) NOT NULL,
    Estado BIT NOT NULL,
    FotoEmpleado VARBINARY(MAX),
    ExtensionImagen NVARCHAR(10),
    FechaRegistro DATETIME DEFAULT GETDATE(),

    -- Campos calculados
    -- AFP con tope 433,496.00 a 2.87%
    AFP AS (
        ROUND(
            CASE 
                WHEN SueldoBruto > 433496.00 THEN 433496.00 * 0.0287
                ELSE SueldoBruto * 0.0287
            END, 2
        )
    ) PERSISTED,

    -- ARS con tope 216,748.00 a 3.04%
    ARS AS (
        ROUND(
            CASE 
                WHEN SueldoBruto > 216748.00 THEN 216748.00 * 0.0304
                ELSE SueldoBruto * 0.0304
            END, 2
        )
    ) PERSISTED,

    -- ISR anualizado
    ISR AS (
        ROUND(
            CASE 
                WHEN SueldoBruto * 12 <= 416220 THEN 0
                WHEN SueldoBruto * 12 <= 624329 
                    THEN ((SueldoBruto * 12 - 416220) * 0.15) / 12
                WHEN SueldoBruto * 12 <= 867123 
                    THEN (31216 + (SueldoBruto * 12 - 624329) * 0.20) / 12
                ELSE
                    (79776 + (SueldoBruto * 12 - 867123) * 0.25) / 12
            END, 2
        )
    ) PERSISTED,

    TotalDescuentos AS (
        ROUND(
            (
            -- AFP con tope
                CASE 
                    WHEN SueldoBruto > 433496.00 THEN 433496.00 * 0.0287
                    ELSE SueldoBruto * 0.0287
                END
                +
                -- ARS con tope
                CASE 
                    WHEN SueldoBruto > 216748.00 THEN 216748.00 * 0.0304
                    ELSE SueldoBruto * 0.0304
                END
                +
                -- ISR
                CASE 
                    WHEN SueldoBruto * 12 <= 416220 THEN 0
                    WHEN SueldoBruto * 12 <= 624329 
                        THEN ((SueldoBruto * 12 - 416220) * 0.15) / 12
                    WHEN SueldoBruto * 12 <= 867123 
                        THEN (31216 + (SueldoBruto * 12 - 624329) * 0.20) / 12
                    ELSE
                        (79776 + (SueldoBruto * 12 - 867123) * 0.25) / 12
                END
            ), 2
        )
    ) PERSISTED,

    SueldoNeto AS (
        ROUND(SueldoBruto - (
        -- AFP con tope
            CASE 
                WHEN SueldoBruto > 433496.00 THEN 433496.00 * 0.0287
                ELSE SueldoBruto * 0.0287
            END
            +
            -- ARS con tope
            CASE 
                WHEN SueldoBruto > 216748.00 THEN 216748.00 * 0.0304
                ELSE SueldoBruto * 0.0304
            END
            +
            -- ISR
            CASE 
                WHEN SueldoBruto * 12 <= 416220 THEN 0
                WHEN SueldoBruto * 12 <= 624329 
                    THEN ((SueldoBruto * 12 - 416220) * 0.15) / 12
                WHEN SueldoBruto * 12 <= 867123 
                    THEN (31216 + (SueldoBruto * 12 - 624329) * 0.20) / 12
                ELSE
                    (79776 + (SueldoBruto * 12 - 867123) * 0.25) / 12
            END
        ), 2)
    ) PERSISTED
);
-- Relaciones
ALTER TABLE Empleados
ADD CONSTRAINT FK_Empleados_Departamento
FOREIGN KEY (DepartamentoID) REFERENCES Departamento(DepartamentoID);

ALTER TABLE Empleados
ADD CONSTRAINT FK_Empleados_Cargo
FOREIGN KEY (CargoID) REFERENCES Cargo(CargoID);

--Tiempo en la empresa calculado
ALTER TABLE Empleados
ADD TiempoEnEmpresa AS 
(
    CASE 
        WHEN FechaFin IS NULL 
            THEN CAST(DATEDIFF(YEAR, FechaInicio, GETDATE()) AS VARCHAR(2)) + ' años ' + -- CAST; convierte de un tipo a otro
                 CAST(DATEDIFF(MONTH, FechaInicio, GETDATE()) % 12 AS VARCHAR(2)) + ' meses'
        ELSE CAST(DATEDIFF(YEAR, FechaInicio, FechaFin) AS VARCHAR(2)) + ' años ' +
             CAST(DATEDIFF(MONTH, FechaInicio, FechaFin) % 12 AS VARCHAR(2)) + ' meses'
    END
);

CREATE TABLE Auditoria (
    AuditoriaID INT PRIMARY KEY IDENTITY(1,1),
    Usuario NVARCHAR(50) NOT NULL,
    Accion NVARCHAR(100) NOT NULL, -- Ej: Insertar, Actualizar, Eliminar, Exportar
    Tabla NVARCHAR(50) NOT NULL,   -- Ej: Empleados
    RegistroID INT NULL,           -- ID del registro afectado
    FechaAccion DATETIME DEFAULT GETDATE()
);

go

CREATE TABLE Roles (
    RolID INT PRIMARY KEY IDENTITY(1,1),
    NombreRol NVARCHAR(50) NOT NULL -- "Administrador", "RRHH"
);

CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario NVARCHAR(50) NOT NULL,
    Clave NVARCHAR(100) NOT NULL, -- Contraseña
    RolID INT NOT NULL,
    FOREIGN KEY (RolID) REFERENCES Roles(RolID)
);
go

--carga inicial
INSERT INTO Roles (NombreRol) VALUES ('Administrador'), ('RRHH');

INSERT INTO Usuarios (NombreUsuario, Clave, RolID)
VALUES ('admin01', '123456', 1),
       ('rrhh01', '678900', 2);


insert into Departamento (NombreDepartamento, Activo)
values
('Tecnología', 1),
('Finanzas', 1),
('Marketing', 1),
('Ventas', 1);

insert into Cargo (NombreCargo, Activo)
values
('Desarrolladores', 1),
('Analista', 1),
('Coordinador', 1),
('Técnico', 1);


