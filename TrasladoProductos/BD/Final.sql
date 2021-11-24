USE hotelSanCarlos;

create table productoTraslado(
	idProducto varchar(10) primary key not null,
    nombre varchar(35) not null,
    precio float not null,
    descripcion varchar(80),
    estado char(1) not null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table bodegaTraslado(
	idBodega varchar(10) primary key not null,
	nombre varchar(35) not null,
    direccion varchar(80) not null,
    estado char(1) not null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table inventarioTraslado(
	idInventario varchar(10) primary key not null,
    idSucursal varchar(10) not null,
    idBodega varchar(10) not null,
    idProducto varchar(10) not null,
    stockActual int not null,
    stockMinimo int not null,
    stockMaximo int not null,
    estado char(1) not null,
    
    /*Foráneas*/
    foreign key (idSucursal) references sucursal(idSucursal),
    foreign key (idBodega) references bodegaTraslado(idBodega),
    foreign key (idProducto) references productoTraslado(idProducto)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table trasladoProductoE(
	idTrasladoE varchar(10) primary key not null,
    bodegaOrigen varchar(10) not null,
    bodegaDestino varchar(10) not null,
    documento varchar(10) not null,
    fecha date not null,
    estado char(1) not null,
    
    /*Foráneas*/
    foreign key (bodegaOrigen) references bodegaTraslado(idBodega),
    foreign key (bodegaDestino) references bodegaTraslado(idBodega)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table trasladoProductoD(
	idTrasladoE varchar(10) primary key not null,
    idInventario varchar(10) not null,
    idProducto varchar(10) not null,
    cantidad int not null,
    
    /*Foráneas*/
    foreign key (idTrasladoE) references trasladoProductoE(idTrasladoE),
    foreign key (idInventario) references inventarioTraslado(idInventario),
    foreign key (idProducto) references productoTraslado(idProducto)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------
-- Inserts 
-- ----------
select * from modulo;
select * from aplicacion;
select * from usuarioAplicacion;

INSERT INTO `hotelsancarlos`.`empresa` (`idEmpresa`, `nit`, `nombre`, `direccion`, `telefono`, `estatus`) VALUES ('1', '6565-l', 'Hotel San Carlos', 'Zona 5 de Mixco', '45656412', 'A');
INSERT INTO `hotelsancarlos`.`sucursal` (`idSucursal`, `idEmpresa`, `nombre`, `direccion`, `telefono`, `codigoPostal`, `estatus`) VALUES ('1', '1', 'Central', 'Ciudad de Guatemala', '45655', '502', 'A');

INSERT INTO `hotelsancarlos`.`modulo` (`pkId`, `nombre`, `descripcion`, `estado`) VALUES ('4000', 'Traslado', 'Modulo dedicado al traslado de Productos', 'A');
INSERT INTO `hotelsancarlos`.`aplicacion` (`pkId`, `fkIdModulo`, `nombre`, `estado`, `rutaChm`, `rutaHtml`) VALUES ('4000', '4000', 'Traslado prod bodega', '1', '0', '0');
INSERT INTO `hotelsancarlos`.`aplicacion` (`pkId`, `fkIdModulo`, `nombre`, `estado`, `rutaChm`, `rutaHtml`) VALUES ('4002', '4001', 'Bodegas', '1', '0', '0');
select * from aplicacion;

insert into usuarioaplicacion values ("1","4000","1","1","1","1","1");
select * from usuarioAplicacion;
select * from bitacoraUsuario;
select * from inventarioTraslado;

select * from empresa;

select * from inventarioTraslado;

INSERT INTO `hotelsancarlos`.`inventarioTraslado` (`idInventario`, `idSucursal`, `idBodega`, `idProducto`, `stockActual`, `stockMinimo`, `stockMaximo`, `estado`) VALUES ('001', '1', '1', '1', '100', '30', '200', 'A');

select * from productoTraslado;
select * from reporte;

INSERT INTO `hotelsancarlos`.`reporte` (`idReporte`, `nombre`, `ruta`, `idAplicacion`, `estado`) VALUES ('1', 'Reporte Productos ', 'D:\\Proyectos_Git_Analisis\\ExamenFinal\\TrasladoProductos\\CapaVistaTraslado\\Productos.rpt', '4001', 'A');
INSERT INTO `hotelsancarlos`.`reporte` (`idReporte`, `nombre`, `ruta`, `idAplicacion`, `estado`) VALUES ('2', 'Reporte Bodegas', 'D:\\Proyectos_Git_Analisis\\ExamenFinal\\TrasladoProductos\\CapaVistaTraslado\\Bodegas.rpt', '4002', 'A');

UPDATE `hotelsancarlos`.`aplicacion` SET `nombre` = 'Productos', `rutaChm` = 'D:\\Proyectos_Git_Analisis\\ExamenFinal\\Ayudas\\Ayudas.chm', `rutaHtml` = 'Ayuda-Mantenimiento-Productos.html' WHERE (`pkId` = '4001');
UPDATE `hotelsancarlos`.`aplicacion` SET `rutaChm` = 'D:\\Proyectos_Git_Analisis\\ExamenFinal\\Ayudas\\Ayudas.chm', `rutaHtml` = 'Ayuda-Mantenimiento-Bodega.html' WHERE (`pkId` = '4002');

select * from aplicacion;
INSERT INTO `hotelsancarlos`.`aplicacion` (`pkId`, `fkIdModulo`, `nombre`, `estado`, `rutaChm`, `rutaHtml`) VALUES ('4003', '4001', 'Traslado encabezado', '1', '0', '0');
INSERT INTO `hotelsancarlos`.`aplicacion` (`pkId`, `fkIdModulo`, `nombre`, `estado`, `rutaChm`, `rutaHtml`) VALUES ('4004', '4001', 'Traslado Detalle', '1', '0', '0');

select * from trasladoProductoE;
select * from trasladoProductoD;