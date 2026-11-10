CREATE DATABASE DB_FincaManager;
GO

USE DB_FincaManager;
GO

CREATE TABLE Tbl_Roles (
    IdRol INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Tbl_Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    IdRol INT NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Usuario_Rol FOREIGN KEY (IdRol) REFERENCES Tbl_Roles(IdRol)
);
GO

CREATE TABLE Tbl_Fincas (
    IdFinca INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Ubicacion VARCHAR(250),
    AreaTotalManzanas DECIMAL(18,2) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Tbl_LotesSectores (
    IdLoteSector INT PRIMARY KEY IDENTITY(1,1),
    IdFinca INT NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    AreaTrabajableMetros DECIMAL(18,2) NOT NULL,
    TotalPlantas INT NOT NULL,
    VariedadCultivo VARCHAR(100) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Lote_Finca FOREIGN KEY (IdFinca) REFERENCES Tbl_Fincas(IdFinca)
);
GO

CREATE TABLE Tbl_PeriodosCosecha (
    IdPeriodo INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    FechaInicio DATETIME NOT NULL,
    FechaFin DATETIME NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Tbl_Categorias (
    IdCategoria INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Tbl_Marcas (
    IdMarca INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Tbl_UnidadesMedida (
    IdUnidadesMedida INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Abreviatura VARCHAR(10) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Tbl_Productos (
    IdProducto INT PRIMARY KEY IDENTITY(1,1),
    IdCategoria INT NOT NULL,
    IdMarca INT NOT NULL,
    IdUnidadMedida INT NOT NULL,
    Nombre VARCHAR(150) NOT NULL,
    PesoProducto DECIMAL(18,2) NOT NULL,
    CantidadMedidas DECIMAL(18,2) NOT NULL,
    StockMinimo DECIMAL(18,2) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Producto_Categoria FOREIGN KEY (IdCategoria) REFERENCES Tbl_Categorias(IdCategoria),
    CONSTRAINT FK_Producto_Marca FOREIGN KEY (IdMarca) REFERENCES Tbl_Marcas(IdMarca),
    CONSTRAINT FK_Producto_Unidad FOREIGN KEY (IdUnidadMedida) REFERENCES Tbl_UnidadesMedida(IdUnidadesMedida)
);
GO

CREATE TABLE Tbl_Kardex (
    IdKardex INT PRIMARY KEY IDENTITY(1,1),
    IdProducto INT NOT NULL,
    TipoMovimiento VARCHAR(20) NOT NULL,
    CantidadUnidades DECIMAL(18,2) NOT NULL,
    PesoAparente DECIMAL(18,2) NOT NULL,
    PesoReal DECIMAL(18,2) NOT NULL,
    CostoUnitarioQuetzales DECIMAL(18,2) NOT NULL,
    Fecha DATETIME NOT NULL,
    CONSTRAINT FK_Kardex_Producto FOREIGN KEY (IdProducto) REFERENCES Tbl_Productos(IdProducto)
);
GO

CREATE TABLE Tbl_Empleados (
    IdEmpleado INT PRIMARY KEY IDENTITY(1,1),
    Nombres VARCHAR(100) NOT NULL,
    Apellidos VARCHAR(100) NOT NULL,
    DPI VARCHAR(13) NOT NULL,
    Telefono VARCHAR(15),
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Tbl_TiposLabor (
    IdTipoLabor INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    TipoPago VARCHAR(30) NOT NULL,
    TarifaBaseQuetzales DECIMAL(18,2) NOT NULL,
    HorarioSugerido VARCHAR(50),
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Tbl_RegistrosJornada (
    IdRegistoJornada INT PRIMARY KEY IDENTITY(1,1),
    IdEmpleado INT NOT NULL,
    IdLotesSector INT NOT NULL,
    IdTipoLabor INT NOT NULL,
    IdPeriodoCosecha INT NOT NULL,
    Fecha DATETIME NOT NULL,
    CantidadRealizada DECIMAL(18,2) NOT NULL,
    TotalPagadoQuetzales DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Jornada_Empleado FOREIGN KEY (IdEmpleado) REFERENCES Tbl_Empleados(IdEmpleado),
    CONSTRAINT FK_Jornada_Lote FOREIGN KEY (IdLotesSector) REFERENCES Tbl_LotesSectores(IdLoteSector),
    CONSTRAINT FK_Jornada_Labor FOREIGN KEY (IdTipoLabor) REFERENCES Tbl_TiposLabor(IdTipoLabor),
    CONSTRAINT FK_Jornada_Periodo FOREIGN KEY (IdPeriodoCosecha) REFERENCES Tbl_PeriodosCosecha(IdPeriodo)
);
GO

CREATE TABLE Tbl_AplicacionesFoliares (
    IdAplicacionFoliar INT PRIMARY KEY IDENTITY(1,1),
    IdLoteSector INT NOT NULL,
    CapacidadBombaLitros DECIMAL(18,2) NOT NULL,
    TotalBombasAplicadas INT NOT NULL,
    Fecha DATETIME NOT NULL,
    CONSTRAINT FK_Aplicacion_Lote FOREIGN KEY (IdLoteSector) REFERENCES Tbl_LotesSectores(IdLoteSector)
);
GO

CREATE TABLE Tbl_DetalleAplicacionesFoliares (
    IdDetalleAplicacion INT PRIMARY KEY IDENTITY(1,1),
    IdAplicacionFoliar INT NOT NULL,
    IdProducto INT NOT NULL,
    DosisPorBomba DECIMAL(18,2) NOT NULL,
    TotalInsumoConsumido DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_DetalleApp_App FOREIGN KEY (IdAplicacionFoliar) REFERENCES Tbl_AplicacionesFoliares(IdAplicacionFoliar),
    CONSTRAINT FK_DetalleApp_Producto FOREIGN KEY (IdProducto) REFERENCES Tbl_Productos(IdProducto)
);
GO

CREATE TABLE Tbl_Proveedores (
    IdProveedor INT PRIMARY KEY IDENTITY(1,1),
    Nit VARCHAR(15) NOT NULL,
    NombreRazonSocial VARCHAR(150) NOT NULL,
    Direccion VARCHAR(200) NOT NULL,
    Telefono VARCHAR(15),
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Tbl_Compras (
    IdCompra INT PRIMARY KEY IDENTITY(1,1),
    IdProveedor INT NOT NULL,
    Fecha DATETIME NOT NULL,
    SerieDocumento VARCHAR(20),
    NumeroDocumento VARCHAR(50),
    TotalQuetzales DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Compra_Proveedor FOREIGN KEY (IdProveedor) REFERENCES Tbl_Proveedores(IdProveedor)
);
GO

CREATE TABLE Tbl_DetalleCompra (
    IdDetalleCompra INT PRIMARY KEY IDENTITY(1,1),
    IdCompra INT NOT NULL,
    IdProducto INT NOT NULL,
    CantidadUnidades DECIMAL(18,2) NOT NULL,
    PesoAparente DECIMAL(18,2) NOT NULL,
    PesoReal DECIMAL(18,2) NOT NULL,
    SubtotalQuetzales DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_DetalleCompra_Compra FOREIGN KEY (IdCompra) REFERENCES Tbl_Compras(IdCompra),
    CONSTRAINT FK_DetalleCompra_Producto FOREIGN KEY (IdProducto) REFERENCES Tbl_Productos(IdProducto)
);
GO

CREATE TABLE Tbl_Ventas (
    IdVenta INT PRIMARY KEY IDENTITY(1,1),
    IdPeriodoCosecha INT NOT NULL,
    NitCliente VARCHAR(15) NOT NULL,
    NombreCliente VARCHAR(150) NOT NULL,
    Fecha DATETIME NOT NULL,
    TotalQuetzales DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Venta_Periodo FOREIGN KEY (IdPeriodoCosecha) REFERENCES Tbl_PeriodosCosecha(IdPeriodo)
);
GO

CREATE TABLE Tbl_DetalleVenta (
    IdDetalleVenta INT PRIMARY KEY IDENTITY(1,1),
    IdVenta INT NOT NULL,
    IdProducto INT NOT NULL,
    CantidadUnidades DECIMAL(18,2) NOT NULL,
    PrecioUnitarioQuetzales DECIMAL(18,2) NOT NULL,
    SubtotalQuetzales DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_DetalleVenta_Venta FOREIGN KEY (IdVenta) REFERENCES Tbl_Ventas(IdVenta),
    CONSTRAINT FK_DetalleVenta_Producto FOREIGN KEY (IdProducto) REFERENCES Tbl_Productos(IdProducto)
);
GO

CREATE TABLE Tbl_Facturas (
    IdFactura INT PRIMARY KEY IDENTITY(1,1),
    IdVenta INT NULL,
    IdCompra INT NULL,
    UuidFel VARCHAR(100) NOT NULL,
    Serie VARCHAR(20) NOT NULL,
    Numero VARCHAR(50) NOT NULL,
    FechaEmision DATETIME NOT NULL,
    MontoTotal DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Factura_Venta FOREIGN KEY (IdVenta) REFERENCES Tbl_Ventas(IdVenta),
    CONSTRAINT FK_Factura_Compra FOREIGN KEY (IdCompra) REFERENCES Tbl_Compras(IdCompra)
);
GO

CREATE TABLE Tbl_Recibos (
    IdRecibo INT PRIMARY KEY IDENTITY(1,1),
    IdEmpleado INT NULL,
    IdProveedor INT NULL,
    CorrelativoInterno VARCHAR(50) NOT NULL,
    Fecha DATETIME NOT NULL,
    MontoTotalQuetzales DECIMAL(18,2) NOT NULL,
    Concepto VARCHAR(250) NOT NULL,
    CONSTRAINT FK_Recibo_Empleado FOREIGN KEY (IdEmpleado) REFERENCES Tbl_Empleados(IdEmpleado),
    CONSTRAINT FK_Recibo_Proveedor FOREIGN KEY (IdProveedor) REFERENCES Tbl_Proveedores(IdProveedor)
);
GO

CREATE TABLE Tbl_CuentasFinancieras (
    IdCuentaFinanciera INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL, 
    Tipo VARCHAR(20) NOT NULL,     
    NumeroCuenta VARCHAR(50),
    NombreBanco VARCHAR(100),
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0,
    SaldoActualQuetzales DECIMAL(18,2) NOT NULL DEFAULT 0.00
);
GO

CREATE TABLE Tbl_MovimientosFinancieros (
    IdMovimientoFinanciero INT PRIMARY KEY IDENTITY(1,1),
    IdCuentaFinanciera INT NOT NULL,
    TipoMovimiento VARCHAR(20) NOT NULL, 
    MetodoPago VARCHAR(30) NOT NULL,     
    NumeroBoletaReferencia VARCHAR(50),
    MontoQuetzales DECIMAL(18,2) NOT NULL,
    Fecha DATETIME NOT NULL,
    Concepto VARCHAR(250) NOT NULL,
    CONSTRAINT FK_Movimiento_Cuenta FOREIGN KEY (IdCuentaFinanciera) REFERENCES Tbl_CuentasFinancieras(IdCuentaFinanciera)
);
GO

CREATE TABLE Tbl_ParametrosSistema (
    IdParametro INT PRIMARY KEY IDENTITY(1,1),
    Clave VARCHAR(50) NOT NULL UNIQUE,
    Valor VARCHAR(255) NOT NULL,
    Descripcion VARCHAR(200),
    Activo BIT NOT NULL DEFAULT 1,
    Eliminado BIT NOT NULL DEFAULT 0
);
GO