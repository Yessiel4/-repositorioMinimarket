use minimarket;
CREATE table minimarket
(
    idMinimarket INT AUTO_INCREMENT,
    nit VARCHAR (15) NOT null, 
    razonSocial varchar (50) not null,
    telefono varchar (10) not null,
    nomenclatura varchar (50) not null,
    ciudad varchar (50) not null, 
    departamento varchar (50) not null,
    correo varchar (50) not null,
    sitioWeb varchar (50) not null,
    facebook varchar (50) not null,
    whatsapp varchar (50) not null,
    CONSTRAINT pk_minimarket PRIMARY KEY (idMinimarket),
    CONSTRAINT unico_nit UNIQUE (nit),
    CONSTRAINT unico_razonSocial UNIQUE (razonSocial));



CREATE table proveedor
(
    idProveedor int AUTO_INCREMENT,
    nit VARCHAR(15) not null,
    razonSocial varchar (50) not null,
    telefono varchar (10) not null,
    nomenclatura varchar (50) not null,
    ciudad varchar (50) not null, 
    departamento varchar (50) not null,
    CONSTRAINT pk_proveedor PRIMARY KEY (idProveedor),
    CONSTRAINT unico_nit_proveedor UNIQUE (nit),
    CONSTRAINT unico_razonSoacial_proveedor UNIQUE (razonSocial));


CREATE table categoria
(
    idCategoria int AUTO_INCREMENT,
    nombre VARCHAR(50) not null,
    decripcion varchar (200) null,
    constraint pk_categoria primary key (idCategoria),
    constraint unico_nombre UNIQUE (nombre));

CREATE table cliente
(
    idCliente int auto_increment,
    tipo_Documento ENUM ('CC','TI','CE','PAS','PEP','PPT','OTROS') not null,
    identificacion VARCHAR (50) not null,
    nombre VARCHAR(50) not null,
    apellido VARCHAR(50)not null,
    correo_Electronico VARCHAR (50) not null,
    celular VARCHAR(50) not null,
    constraint pk_cliente PRIMARY KEY(idCliente),
    CONSTRAINT unico_identificacion UNIQUE(identificacion));
    ;
CREATE table producto 
(
    Idproducto int AUTO_INCREMENT,
    nombre  varchar (50) not null,  
    marca varchar (50) null,
    stock int default 0,
    pvp int not null default 0,
    descripcion varchar (200) NULL,
    unidadMedida ENUM ('UND','GR'),
    idCategoria int not null,
    CONSTRAINT pk_producto primary key (idproducto),
    constraint unico_nombre UNIQUE (nombre),
    constraint foreign key (idCategoria) references categoria (idCategoria)
);

create table empleado(
    idEmpleado int auto_increment,
    tipo_Documento ENUM ('CC','TI','CE','PAS','PEP','PPT','OTROS') not null,
    identificacion VARCHAR (11) not null,
    nombres varchar(50) not null,
    apellidos varchar(50) not null,
    correo varchar(50) not null,
    celular VARCHAR(11) not null,
    clave varchar (8) not null,
    Idminimarket int not null,
    CONSTRAINT pk_empleado PRIMARY KEY (idEmpleado),
    CONSTRAINT unico_identificacion_empleado UNIQUE(identificacion),
    constraint unico_correo_empleado UNIQUE (correo),
    constraint fk_minimarket FOREIGN key (idMinimarket) REFERENCES Minimarket (idMinimarket));

create table factura
(
    idFactura int AUTO_INCREMENT,
    codigoFactura VARCHAR(8) not null,
    FechaGeneracion DATETIME not null,
    SinIva int not null,
    iva int not null,
    total int not null,
    idEmpleado int not null,
    idCliente int not null,
    CONSTRAINT pk_factura PRIMARY KEY (idFactura),
    CONSTRAINT unico_factura UNIQUE(codigoFactura),
    constraint fk_empleado FOREIGN key (idEmpleado) REFERENCES empleado (idEmpleado),
    constraint fk_cliente foreign key (idCliente) REFERENCES cliente (idCliente));

create table detalleFactura
(
    idDetalleFactura int AUTO_INCREMENT,
    cantidadProductos int not null,
    precioVenta int not null,
    idProducto int not null,
    idFactura int not null,
    constraint pk_detalleFactura primary key (idDetalleFactura),
    constraint fk_producto foreign key (idProducto) references producto (idProducto),
    constraint fk_factura foreign key (idFactura) references factura (idFactura));