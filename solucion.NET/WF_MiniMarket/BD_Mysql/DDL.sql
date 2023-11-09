-- Active: 1683890773572@@127.0.0.1@3306@minimarket
USE minimarket;

create table minimarket(
    idMinimarket int AUTO_INCREMENT,
    nit varchar(15) not NULL,
    razonSocial varchar(50) not NULL,
    telefono varchar(10) not NULL,
    nomenclatura varchar(50) not NULL,
    ciudad varchar(50) not NULL,
    departamento varchar (50) not NULL,
    correo varchar(50) not NULL,
    sitioWeb varchar(50) not NULL,
    facebook varchar(50) not NULL,
    whatsapp varchar(50) not NULL,
    CONSTRAINT pk_minimarket PRIMARY KEY (idMinimarket),
    CONSTRAINT unico_nit UNIQUE (nit),
    CONSTRAINT razonSocial UNIQUE (razonSocial));

    create table proveedor(
        idProveedor int AUTO_INCREMENT,
        nit varchar(15) not NULL,
        razonSocial varchar(50) not NULL,
        telefono varchar(10) not NULL,
        correo varchar(50) not NULL,
        nomenclatura varchar(50) not NULL,
        ciudad varchar(50) not NULL,
        departamento varchar (50) not NULL,
        CONSTRAINT pk_proveedor PRIMARY KEY (idProveedor),
        CONSTRAINT unico_nit_proveedor UNIQUE (nit),
        CONSTRAINT unico_razonSocial_proveedor UNIQUE (razonSocial));

    create table categoria(
        idCategoria int AUTO_INCREMENT,
        nombre varchar(50) not NULL,
        descripcion varchar(200) not NULL,
        CONSTRAINT pk_categoria PRIMARY KEY (idCategoria),
        CONSTRAINT unico_nombre UNIQUE (nombre));

    create table cliente(
        idCliente int AUTO_INCREMENT,
        tipoDocumento ENUM ('CC','TI','PAS','PEP','PPT','CE','Otro'),
        identificacion varchar(11) not NULL, 
        nombres varchar(10) not NULL,
        apellidos varchar(50) not NULL,
        correo varchar(50) not NULL,
        celular varchar(11) not NULL,
        CONSTRAINT pk_cliente PRIMARY KEY (idCliente),
        CONSTRAINT unico_identificacion UNIQUE (identificacion));

    create table producto(
        idProducto int AUTO_INCREMENT,
        nombre varchar(50) not NULL, 
        marca varchar(50) not NULL,
        stock int default 0,
        pvp int not NULL default 0,
        descripcion varchar(200) NULL,
        unidadMedida ENUM ('UND','gr'),
        idCategoria int not NULL,
        CONSTRAINT pk_producto PRIMARY KEY (idProducto),
        CONSTRAINT unico_nombre UNIQUE (nombre),
        CONSTRAINT fk_categoria FOREIGN KEY (idCategoria) REFERENCES Categoria (idCategoria));

    create table empleado(
        idEmpleado int AUTO_INCREMENT,
        tipoDocumento ENUM ('CC','TI','PAS','PEP','PPT','CE','Otro'),
        identificacion varchar(11) not NULL, 
        nombres varchar(50) not NULL,
        apellidos varchar(50) not NULL,
        celular varchar(11) not NULL,
        correo varchar(50) not NULL,
        contraseña varchar(10) not NULL,
        idMinimarket int not NULL,
        CONSTRAINT pk_empleado PRIMARY KEY (idEmpleado),
        CONSTRAINT unico_identificacion_empleado UNIQUE (identificacion),
        CONSTRAINT unico_correo_empleado UNIQUE (correo),
        CONSTRAINT fk_minimarket FOREIGN KEY (idMinimarket) REFERENCES Minimarket (idMinimarket));

        drop table producto;
        drop table empleado;

    create table factura(
        idFactura int AUTO_INCREMENT,
        codigoFactura varchar(8) not NULL, 
        fechaGeneracion DATETIME not NULL,
        iva int not NULL,
        sinIva int not NULL,
        total int not NULL,
        idEmpleado int not NULL,
        idCliente int not NULL,
        CONSTRAINT pk_factura PRIMARY KEY (idFactura),
        CONSTRAINT unico_factura UNIQUE (codigoFactura),
        CONSTRAINT fk_empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado (idEmpleado),
        CONSTRAINT fk_cliente FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente));

    create table detalleFactura(
        idDetalleFactura int AUTO_INCREMENT,
        cantidadProductos int not NULL, 
        precioVenta int not NULL,
        idEmpleado int not NULL,
        idCliente int not NULL,
        CONSTRAINT pk_detalleFactura PRIMARY KEY (idDetalleFactura),
        CONSTRAINT unico_factura UNIQUE (codigoFactura),
        CONSTRAINT fk_empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado (idEmpleado),
        CONSTRAINT fk_cliente FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente));   





        




    
    

