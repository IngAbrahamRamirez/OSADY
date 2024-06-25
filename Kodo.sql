create database OSADY 
go
use OSADY
go
--TABLAS DE LA BD
create table usuario
(id int primary key identity (1,1),
usuario varchar (70) unique,
cc_usuario bigint unique,
correo varchar (70) unique,
contrasena varchar (100)not null,
cargo_empleado varchar (70) not null,
estado char (1),
num_ingreso char (1)
)
go
create table empleado 
(id int primary key identity (1,1),
id_usuario int foreign key references usuario,
nombre_completo varchar (100) not null,
cc bigint unique,
fecha_nacimiento date not null,
lugar_nacimiento varchar (100) not null,
direccion varchar (100) not null,
telefono int not null,
celular bigint not null,
correo_e varchar (100),
antecedentes char (2),
profesion varchar (100),
estado_civil varchar (50) not null,
anos_experiencia int not null,
area varchar (50) not null,
libreta_militar varchar (50),
vehiculo char (2),
numero_licencia varchar (50),
categoria_licencia char (2),
tipo_vivienda varchar (20) not null,
numero_dependientes int,
perfil_laboral varchar (500)
)
go
create table contrato 
(id int primary key identity (1,1),
id_empleado int foreign key references empleado,
id_usuario int foreign key references usuario,
nombre_empleado varchar (100) not null,
CC_Empleado bigint unique,
Tipo_contrato varchar (50) not null,
duracion_estimada varchar (50),
fecha_inicio date not null,
cargo_empleado varchar (100)not null,
salario bigint not null,
condiciones varchar (1000)
)
go 
create table liquidacion_contrato
(id int primary key identity(0,1),
id_usuario int foreign key references usuario,
id_contrato int foreign key references contrato,
causa varchar (100) not null,
salario bigint not null,
dias_liquidar int not null,
prima_servicios bigint not null,
vacaciones bigint not null,
cesantias bigint not null,
intereses_cesantias bigint not null,
caja_compensacion real not null,
Impuesto_Caja_compensacion real,
impuesto_ICBF real not null,
Im_ICBF real,
impuesto_SENA real not null,
Im_SENA real,
pension real not null,
Impuesto_pension real ,
salud real,
Impuesto_salud real,
indemnizacion bigint,
observaciones varchar (1000),
total_liquidacion bigint,
identificador char(1),
id_empleado int foreign key references empleado
)
go
create table dotacion 
(id int primary key identity (1,1),
id_usuario int foreign key references usuario,
id_empleado int foreign key references empleado,
fecha_entrega date not null,
tiempo_renovacion date,
observaciones varchar (1000))
go 
create table articulo 
(id int primary key identity (1,1),
id_usuario int foreign key references usuario,
cantidad int not null,
nombre_articulo varchar (100) unique,
tipo varchar (50) not null,
estado varchar (100) not null,
descripcion varchar (500))
go 
create table detalles_dotacion
(id_articulo int foreign key references articulo,
id_dotacion int foreign key references dotacion,
Nombre_articulo varchar (100)not null,
Cantidad int not null
)
go
create table informacion_academica
(id_empleado int foreign key references empleado,
institucion varchar (50) not null,
tipo_titulacion varchar (50) not null,
titulo varchar (50) not null,
fecha_titulacion date not null)
go
create table referencias
(id_empleado int foreign key references empleado,
tipo varchar (50) not null,
nombre varchar (100) not null,
parentesco varchar (50),
telefono bigint not null,
correo varchar (50)
)
--PROCEDIMIENTOS ALMACENADOS
go
create procedure Acceso_Usuario
@Usuario varchar (70),
@contrasena varchar (100),
@cargo_empleado varchar (70)
as
select usuario,contrasena,cargo_empleado from usuario 
where usuario=@Usuario and contrasena=@contrasena and cargo_empleado=@cargo_empleado and estado='A'
go
create procedure Insertar_usuario
@usuario varchar (70),
@cc_usuario bigint,
@correo varchar (70),
@contrasena varchar (100),
@cargo_empleado varchar (70),
@estado char (1),
@num_ingreso char(1)
as
insert into usuario (usuario,cc_usuario,correo,contrasena,cargo_empleado,estado,num_ingreso)values (@usuario,@cc_usuario,@correo,@contrasena,@cargo_empleado,@estado,@num_ingreso)
go
create procedure Consulta_N_Ingreso
@usuario varchar (70)
as
select num_ingreso,id from usuario where usuario=@usuario
go
create procedure Actualizacion_Contrasena
@usuario varchar (70),
@clave varchar (20),
@num_ingreso char (1)
as
update usuario set contrasena=@clave, num_ingreso=@num_ingreso where usuario = @usuario
go
create procedure Actualizar_Usuario
@cc_usuario bigint,
@correo varchar (70),
@cargo varchar (70)
as
update usuario set correo=@correo, cargo_empleado=@cargo where cc_usuario=@cc_usuario
go
create proc Eliminar_U
@usuario varchar (70)
as
update usuario set estado='I' where usuario=@usuario
go
create procedure consultaG_U
as
select cc_usuario,'Correo'=usuario,cargo_empleado from usuario where estado='a'
go
create procedure consultaG_U_Activar
as
select cc_usuario,usuario,cargo_empleado from usuario where estado='i'
go
create procedure consultaE_U
@dato varchar (70)
as
select cc_usuario,'Correo'=usuario,cargo_empleado from usuario where cargo_empleado like @dato+'%' or correo like @dato+'%' or cc_usuario like @dato+'%'
go
create procedure Activar_U
@usuario varchar (70)
as
update usuario set estado='a' where usuario=@usuario
go
create procedure Insertar_empleado 
@id_usuario int,
@nombre_completo varchar (100),
@cc bigint,
@area varchar (50),
@fecha_nacimiento date ,
@lugar_nacimiento varchar (100),
@direccion varchar (100),
@telefono int,
@celular bigint,
@correo varchar (100),
@antecedentes char (2),
@profesion varchar (100),
@estado_civil varchar (50),
@anos_experiencia int,
@libreta_militar varchar (50),
@vehiculo char (2),
@numero_licencia varchar (50),
@categoria_licencia char (2),
@tipo_vivienda varchar (20),
@numero_dependientes int,
@perfil_laboral varchar (500)
as
insert into empleado(id_usuario,nombre_completo,cc,area,fecha_nacimiento,lugar_nacimiento,direccion,telefono,celular,correo_e,antecedentes,profesion,estado_civil,anos_experiencia,libreta_militar,vehiculo,numero_licencia,categoria_licencia,tipo_vivienda,numero_dependientes,perfil_laboral)values (@id_usuario,@nombre_completo,@cc,@area,@fecha_nacimiento,@lugar_nacimiento,@direccion,@telefono,@celular,@correo,@antecedentes,@profesion,@estado_civil,@anos_experiencia,@libreta_militar,@vehiculo,@numero_licencia,@categoria_licencia,@tipo_vivienda,@numero_dependientes,@perfil_laboral)
go
create procedure actualizar_empleado
@cc_empleado bigint,
@area varchar (50),
@direccion varchar (100),
@telefono int,
@celular bigint,
@antecedentes char (2),
@correo varchar (100),
@profesion varchar (100),
@estado_civil varchar (50),
@anos_experiencia int,
@tipo_vivienda varchar (20),
@numero_dependientes int,
@perfil_laboral varchar (500)
as
update empleado set area=@area, direccion=@direccion,telefono=@telefono,celular=@celular,antecedentes=@antecedentes,correo_e=@correo,profesion=@profesion,estado_civil=@estado_civil,anos_experiencia=@anos_experiencia,tipo_vivienda=@tipo_vivienda,numero_dependientes=@numero_dependientes,perfil_laboral=@perfil_laboral where cc=@cc_empleado
go
create procedure Consulta_previa
@Cedula bigint
as
SELECT cc FROM Empleado WHERE cc = @Cedula
go
create procedure Consulta_previa_Liquidacion
@Id_Contrato bigint
as
SELECT id FROM Contrato WHERE id = @Id_Contrato
go
create procedure Consulta_previa_Empleado
@Id_Empleado int
as
SELECT id FROM empleado WHERE id = @Id_Empleado
go
create procedure consultaG_E
as
select* from empleado 
go
create procedure consultaE_E
@dato varchar (70)
as
select* from empleado inner join referencias on (empleado.id=referencias.id_empleado) inner join informacion_academica on (empleado.id=informacion_academica.id_empleado)
 where nombre_completo like @dato+'%' or cc like @dato+'%' or correo_e like @dato+'%' 
go
create procedure ConsultaID_Empleado
@cc bigint
as
select id from empleado where cc=@cc
go
create procedure consulta_Id_E
@cc bigint
as
select id from empleado where cc=@cc
go
create procedure Insertar_contrato 
@id_usuario int,
@id_empleado int,
@Tipo_contrato varchar (100),
@nombre_empleado varchar (100),
@cc bigint,
@duracion_contrato varchar (50),
@fecha_inicio date,
@cargo_empleado varchar (100),
@salario bigint,
@condiciones varchar (1000)
as
insert into contrato (id_usuario,id_empleado, Tipo_contrato,nombre_empleado, CC_Empleado,duracion_estimada,fecha_inicio,cargo_empleado,salario,condiciones) values (@id_usuario,@id_empleado,@Tipo_contrato,@nombre_empleado,@cc,@duracion_contrato,@fecha_inicio,@cargo_empleado,@salario,@condiciones)
go
create procedure consultaG_C
as
select* from contrato
go
create procedure consultaE_C
@dato varchar (100)
as
select* from contrato where nombre_empleado like @dato+'%' or CC_Empleado like @dato+'%'
go
create procedure Traer_Datos_E
@id_Empleado int
as
select nombre_completo,cc from empleado where id=@id_Empleado
go
create procedure Verificar_contrato
@id_empleado int
as
select id_empleado from contrato where id_empleado=@id_empleado
go
go
create procedure Verificar_contrato_Cedula
@Cedula bigint
as
select CC_Empleado from contrato where CC_Empleado=@Cedula
go
create procedure Traer_Fecha_Contrato
@cod_empleado int
as
select fecha_inicio from contrato where id_empleado=@cod_empleado
go
create procedure TraerID_Contrato 
@id_empleado int
as
select id from contrato where id_empleado=@id_empleado
go
create procedure TraerDatosEmpleado_Contrato
@Cedula bigint
as
select nombre_completo,cc from empleado where cc=@Cedula
go
create procedure insertar_Lcontrato
@id_usuario int,
@id_empleado int,
@id_contrato int,
@causa varchar (1000),
@salario bigint,
@dias_liquidar int,
@prima_servicios bigint,
@vacaciones bigint,
@cesantias bigint,
@intereses_cesantias bigint,
@caja_compensacion real,
@impuesto_ICBF real,
@impuesto_SENA real,
@pension real,
@salud real,
@indemnizacion bigint,
@total_liquidacion bigint,
@observaciones varchar (1000),
@identificador char(1)
as
insert into liquidacion_contrato (id_usuario,id_empleado,id_contrato,causa,salario,dias_liquidar,prima_servicios,vacaciones,cesantias,intereses_cesantias,caja_compensacion,impuesto_ICBF,impuesto_SENA,pension,salud,indemnizacion,total_liquidacion,observaciones,identificador) values (@id_usuario,@id_empleado,@id_contrato,@causa,@salario,@dias_liquidar,@prima_servicios,@vacaciones,@cesantias,@intereses_cesantias,@caja_compensacion,@impuesto_ICBF,@impuesto_SENA,@pension,@salud,@indemnizacion,@total_liquidacion,@observaciones,@identificador)
go
create procedure consultaG_Lcontrato
as
select id,id_usuario,id_empleado,id_contrato,causa,salario,dias_liquidar,prima_servicios,vacaciones,cesantias,intereses_cesantias,caja_compensacion,impuesto_ICBF,impuesto_SENA,pension,salud,indemnizacion,total_liquidacion,observaciones from liquidacion_contrato where identificador=0
go 
create procedure consultaE_Lcontrato
@id_empleado int
as
select id,id_usuario,id_empleado,id_contrato,causa,salario,dias_liquidar,prima_servicios,vacaciones,cesantias,intereses_cesantias,caja_compensacion,impuesto_ICBF,impuesto_SENA,pension,salud,indemnizacion,total_liquidacion,observaciones from liquidacion_contrato where identificador=0 and id_empleado=@id_empleado
go
create procedure Traer_datos_Liquidacion
@Cod_empleado int
as
select tipo_contrato,salario from contrato where id_empleado=@Cod_empleado
go
create procedure Actualizar_Impuestos
@identificador int,
@caja_compensacion real,
@impuesto_ICBF real,
@impuesto_SENA real,
@pension real,
@salud real
as
update liquidacion_contrato set Impuesto_Caja_compensacion=@caja_compensacion, Im_ICBF=@impuesto_ICBF,Im_SENA=@impuesto_SENA,Impuesto_pension=@pension,Impuesto_salud=@salud where @identificador =1
go
create procedure Consulta_Impuestos
as
select Impuesto_Caja_compensacion,Im_ICBF,Im_SENA,Impuesto_pension,Impuesto_salud from liquidacion_contrato where identificador=1
go
create procedure Consulta_Existencia_Liquidacion
@id_empleado int
as
select id_empleado from liquidacion_contrato where id_empleado=@id_empleado
go
create procedure insertar_dotacion
@id_usuario int,
@id_empleado int,
@fecha_entrega date,
@tiempo_renovacion date,
@observaciones varchar (1000)
as
insert into dotacion (id_usuario,id_empleado,fecha_entrega,tiempo_renovacion,observaciones) values (@id_usuario,@id_empleado,@fecha_entrega,@tiempo_renovacion,@observaciones)
go
create procedure consultaG_dotacion
as
select* from  dotacion inner join detalles_dotacion on (dotacion.id) = (detalles_dotacion.id_dotacion)
go
create procedure consultaE_dotacion
@dato varchar (100)
as
select* from  dotacion inner join detalles_dotacion on (dotacion.id) = (detalles_dotacion.id_dotacion) where id_empleado like @dato+'%' or tiempo_renovacion like @dato+'%' 
go
create procedure actualizar_dotacion
@id int,
@fecha_entrega date,
@observaciones varchar (1000)
as
update dotacion set observaciones=@observaciones,fecha_entrega=@fecha_entrega where id=@id
go
create procedure ConsultaID_Dotacion
@cod_empleado int
as
select id from dotacion where id_empleado=@cod_empleado
go
create procedure Consulta_Registros_Renovar
@Fecha_Hoy date
as
select*from dotacion where tiempo_renovacion<=@Fecha_Hoy
go
create procedure Ampliar_Fecha_Renovacion
@Cod_dotacion int,
@Nueva_Fecha date
as
update dotacion set tiempo_renovacion=@Nueva_Fecha where @Cod_dotacion=id
go
create procedure Consulta_ID_Dotacion
@id_empleado int
as
select id from dotacion where id_empleado=@id_empleado
go
create procedure Traer_Datos_DetallesDotacion
@id_dotacion int
as
select Nombre_articulo,Cantidad from detalles_dotacion where id_dotacion=@id_dotacion
go
create procedure verificar_existenciaContrato
@id_empleado int
as
select id_empleado from contrato where id_empleado=@id_empleado
go
create procedure insertar_articulo 
@id_usuario int,
@cantidad int,
@nombre varchar (100),
@tipo varchar (50),
@estado varchar (30),
@descripcion varchar (500)
as
insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (@id_usuario,@cantidad,@nombre,@tipo,@estado,@descripcion)
go
create procedure consultaG_articulo
as
select* from articulo
go
create procedure consultaE_articulo
@dato varchar (100)
as
select* from articulo where nombre_articulo like @dato+'%' or id like @dato+'%'
go
create procedure actualiza_articulo
@nombre varchar (100),
@estado varchar (30),
@descripcion varchar (500)
as
update articulo set estado=@estado,descripcion=@descripcion where nombre_articulo=@nombre
go
create procedure Actualizar_Cantidad_Art
@nombre_art varchar(100),
@cantidad int
as
update articulo set cantidad=@cantidad+cantidad where nombre_articulo=@nombre_art
go
create procedure Consulta_Cantidad_Articulos
@nombre_art varchar(50)
as
select cantidad from articulo where nombre_articulo=@nombre_art
go
create procedure Nueva_Cantidad_Art
@nombre_art varchar(50),
@cantidad_restar int
as
update articulo set cantidad = cantidad - @cantidad_restar where nombre_articulo=@nombre_art
go
create procedure consultaID_Articulo
@Nombre_art varchar (100)
as
select id from articulo where nombre_articulo=@Nombre_art
go
create procedure Consultar_Articulos
as
select nombre_articulo from articulo
go
create procedure Consulta_previa_Art
@Nombre_art varchar (50)
as
SELECT nombre_articulo FROM Articulo WHERE nombre_articulo = @Nombre_art
go
create procedure TrarDatos_Articulo
as
select nombre_articulo,cantidad from articulo
GO
create procedure Insercion_Detalles_Dotacion
@id_articulo int,
@id_dotacion int,
@Nombre_articulo varchar (100),
@Cantidad int
as
insert into detalles_dotacion (id_articulo,id_dotacion,Nombre_articulo,Cantidad) values (@id_articulo,@id_dotacion,@Nombre_articulo,@Cantidad)
go
create procedure insertar_Iacademica
@id_empleado int,
@institucion varchar (50),
@tipo_titulacion varchar (50),
@titulo varchar (50),
@fecha_titulacion date
as
insert into informacion_academica (id_empleado,institucion,tipo_titulacion,titulo,fecha_titulacion) values (@id_empleado,@institucion,@tipo_titulacion,@titulo,@fecha_titulacion)
go
create procedure actualizar_Iacademica
@institucion varchar (50),
@tipo_titulacion varchar (50),
@titulo varchar (50),
@fecha_titulacion date
as
update informacion_academica set institucion=@institucion,tipo_titulacion=@tipo_titulacion,titulo=@titulo,fecha_titulacion=@fecha_titulacion
go
create procedure consultaG_Iacademica
@cargo_u varchar (100),
@contrasena_u varchar (100)
as
select* from informacion_academica
go
create procedure consultaE_Iacademica
@cargo_u varchar (100),
@contrasena_u varchar (100),
@id int
as
select* from informacion_academica where id_empleado= @id
go
create procedure insertar_referencias
@id_empleado int,
@tipo char (2),
@nombre varchar (100),
@parentesco varchar (50),
@telefono bigint,
@correo varchar (50)
as
insert into referencias (id_empleado,tipo,nombre,parentesco,telefono,correo) values (@id_empleado,@tipo,@nombre,@parentesco,@telefono,@correo)
go
create procedure actualizar_referencias
@tipo char (11),
@nombre varchar (100),
@parentesco varchar (50),
@telefono bigint,
@correo varchar (50)
as
update referencias set tipo=@tipo,nombre=@nombre,parentesco=@parentesco,telefono=@telefono,correo=@correo
go
create procedure consultaG_referencias
@cargo_u varchar (100),
@contrasena_u varchar (100)
as
select* from referencias
go
create procedure consultaE_referencias
@cargo_u varchar (100),
@contrasena_u varchar (100),
@id int
as
select* from referencias where id_empleado=@id
go
Insert into usuario (usuario,cc_usuario, correo,contrasena, cargo_empleado,estado,num_ingreso) values ('Julian@hotmail.com','12345678','Julian@hotmail.com','1234','Gerente Administrativo','a','1')
go
Insert into usuario (usuario,cc_usuario, correo,contrasena, cargo_empleado,estado,num_ingreso) values ('Julian1@hotmail.com','12345670','Julian1@hotmail.com','9999','Gerente Administrativo','a','0')
go
Insert into usuario (usuario,cc_usuario,correo,contrasena, cargo_empleado,estado,num_ingreso) values ('Abraham@gmail.com','987654','Abraham@gmail.com','4321','Recursos Humanos','a','0')
go
Insert into usuario (usuario,cc_usuario,correo,contrasena, cargo_empleado,estado,num_ingreso) values ('Juana@hotmail.com','87654321','Juana@hotmail.com','1212','Secretaria','a','0')
go

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'10','Celular Samsung J5','Oficina','Bueno','Smartphone de alta tecnología')

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'100','Casco Protector CAT','Campo','Bueno','Casco para proteger contra accidentes')

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'40','Bisturí','Bodega','Regular','Bisturi empleado en bodega')

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'100','Botas BRAHMA','Campo','Bueno','Botas para salidas y caminatas')

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'30','Pad Mouse','Oficina','Bueno','Pad mouse para uso en las oficionas de la empresa')

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'100','Arnés','Campo','Bueno','Arnés para sugetarse')

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'30','Guantes en cuero','Campo','Regular','Guantes para proteger las manos contra accidentes')

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'35','Gafas protectoras','Campo','Bueno','Gafas protectoras de la vista')

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'40','Cinta pegante','Bodega','Bodega','Cinta pegante para bodega')

insert into articulo (id_usuario,cantidad,nombre_articulo,tipo,estado,descripcion) values (1,'10','Celular Blackberry','Oficina','Bueno','Telefono celular en buen estado')

--Inserción de tablas en la BD
--INSERCION EMPLEADO

--1
insert into empleado (id_usuario,nombre_completo,cc,area,fecha_nacimiento,lugar_nacimiento,direccion,telefono,celular,correo_e,antecedentes,profesion,estado_civil,anos_experiencia,libreta_militar,vehiculo,numero_licencia,categoria_licencia,tipo_vivienda,numero_dependientes,perfil_laboral)
values ('1','Julian Manosalva','7546554','Oficina','26/06/1998','Bogota DC','cl132 bis#156','5389938','3208161687','julian@hotmail.com','No','Gerente administrativo','Soltero','1','1547','No','No','No','Propia','4','Gerente administrativo')
insert into informacion_academica(id_empleado,institucion,tipo_titulacion,titulo,fecha_titulacion)values(1,'Colegio Fernando Molina','Bachiller','Bachiller con enfasis en finanzas','24/07/2008')
insert into referencias (id_empleado,tipo,nombre,parentesco,telefono,correo) values ('1','Laboral','Enterprice','NA','5346776','No')
--2
insert into empleado (id_usuario,nombre_completo,cc,area,fecha_nacimiento,lugar_nacimiento,direccion,telefono,celular,correo_e,antecedentes,profesion,estado_civil,anos_experiencia,libreta_militar,vehiculo,numero_licencia,categoria_licencia,tipo_vivienda,numero_dependientes,perfil_laboral)
values ('1','Austin Santos','54678098','Oficina','27/04/1999','Bogota DC','cll 132-24','6543232','3272345676','austin@gmail.com','No','Contador publico','Casado','3','102929','No','No','No','Propia','2','Hombre trabajador.')
insert into informacion_academica(id_empleado,institucion,tipo_titulacion,titulo,fecha_titulacion)values(2,'Universidad de la Salle','Título Profesional','Contador publico','29/04/2016')
insert into referencias (id_empleado,tipo,nombre,parentesco,telefono,correo) values (2,'Familiar','Pedro Santos','Padre','3456776','No')
--3
insert into empleado (id_usuario,nombre_completo,cc,area,fecha_nacimiento,lugar_nacimiento,direccion,telefono,celular,correo_e,antecedentes,profesion,estado_civil,anos_experiencia,libreta_militar,vehiculo,numero_licencia,categoria_licencia,tipo_vivienda,numero_dependientes,perfil_laboral)
values ('1','Edwin Rosa','519476543','Campo','07/12/1994','Risaralda','cra 200 #234','5437656','3208766565','EdwinRosa@hotmail.com','No','Administrador de empresas','Union libre','2','1534','No','No','No','Familiar','0','Administrador de empresas egresado de la U. Nacional')
insert into informacion_academica(id_empleado,institucion,tipo_titulacion,titulo,fecha_titulacion)values(3,'SENA','Técnico','Tecnico en administracion de empresas','24/07/2008')
insert into referencias (id_empleado,tipo,nombre,parentesco,telefono,correo) values (3,'Laboral','Panta Entertaintment','NA','5346776','Panda@hotmail.com')

--4
insert into empleado (id_usuario,nombre_completo,cc,area,fecha_nacimiento,lugar_nacimiento,direccion,telefono,celular,correo_e,antecedentes,profesion,estado_civil,anos_experiencia,libreta_militar,vehiculo,numero_licencia,categoria_licencia,tipo_vivienda,numero_dependientes,perfil_laboral)
values ('1','Andres Suarez Diaz','19654765','Bodega','13/01/1980','Quindío','Av cll 178- 34','7899000','3178909887','AndresSuarez@hotmail.com','No','Independiente','Casado','7','3456','No','No','No','Arrendada','4','Trabajador independiente')
insert into informacion_academica(id_empleado,institucion,tipo_titulacion,titulo,fecha_titulacion)values(4,'Colegio Antonio Nariño','Bachiller','Bachiller','27/07/2000')
insert into referencias (id_empleado,tipo,nombre,parentesco,telefono,correo) values (4,'Familiar','Camilo Suarez','Hijo(a)','5348900','CamSua@gmail.com')

--5
insert into empleado (id_usuario,nombre_completo,cc,area,fecha_nacimiento,lugar_nacimiento,direccion,telefono,celular,correo_e,antecedentes,profesion,estado_civil,anos_experiencia,libreta_militar,vehiculo,numero_licencia,categoria_licencia,tipo_vivienda,numero_dependientes,perfil_laboral)
values ('1','Andrea Gonzalez Fuentes','56789898','Campo','17/07/1989','Tolima','Calle 27 - 52 A','6743456','3166789032','AndreaGonzalez@hotmail.com','No','Secreatria','Union libre','7','No','No','No','No','Propia','1','Secretario Kodo trade and Commerce')
insert into informacion_academica(id_empleado,institucion,tipo_titulacion,titulo,fecha_titulacion)values(5,'Instituto Tecnico Bolivariano','Tecnico','Tecnico en gestion contable y administrativa','30/06/2011')
insert into referencias (id_empleado,tipo,nombre,parentesco,telefono,correo) values (5,'Laboral','M&A Company','NA','5346776','Manda@yahoo.com')

--6
insert into empleado (id_usuario,nombre_completo,cc,area,fecha_nacimiento,lugar_nacimiento,direccion,telefono,celular,correo_e,antecedentes,profesion,estado_civil,anos_experiencia,libreta_militar,vehiculo,numero_licencia,categoria_licencia,tipo_vivienda,numero_dependientes,perfil_laboral)
values ('1','Camila Romero Acosta','56789543','Campo','17/07/1989','Tolima','Calle 27 - 52 A','6743456','3166789032','AndreaGonzalez@hotmail.com','No','Secreatria','Union libre','7','No','No','No','No','Propia','1','Secretario Kodo trade and Commerce')
insert into informacion_academica(id_empleado,institucion,tipo_titulacion,titulo,fecha_titulacion)values(6,'Universidad Cooperativa','Título Profesional','Profesional en gestion administrativa','01/05/2013')
insert into referencias (id_empleado,tipo,nombre,parentesco,telefono,correo) values (6,'Familiar','Fernanda Gonzalez','Hermano(a)','3467654','Fernanda43@hotmail.com')

--7
insert into empleado (id_usuario,nombre_completo,cc,area,fecha_nacimiento,lugar_nacimiento,direccion,telefono,celular,correo_e,antecedentes,profesion,estado_civil,anos_experiencia,libreta_militar,vehiculo,numero_licencia,categoria_licencia,tipo_vivienda,numero_dependientes,perfil_laboral)
values ('1','Catalina Cifuentes','23456765','Oficina','28/11/1985','Putumayo','Av cll 68 #29-c','64679876','3166789032','CatalinaCifuentes@hotmail.com','No','Coordinadora marketing','Soltero','2','No','No','No','No','Propia','1','Coordinadora de marketing de Kodo')
insert into informacion_academica(id_empleado,institucion,tipo_titulacion,titulo,fecha_titulacion)values(7,'Instituto Gustavo Rojas','Bachiller','Bachiller','21/07/2015')
insert into referencias (id_empleado,tipo,nombre,parentesco,telefono,correo) values (7,'Laboral','DG Marketing','NA','3215677689','marketingDG@gmail.com')

--8
insert into empleado (id_usuario,nombre_completo,cc,area,fecha_nacimiento,lugar_nacimiento,direccion,telefono,celular,correo_e,antecedentes,profesion,estado_civil,anos_experiencia,libreta_militar,vehiculo,numero_licencia,categoria_licencia,tipo_vivienda,numero_dependientes,perfil_laboral)
values ('1','Jorge Arias Hernandez','6782121','Bodega','10/8/1981','Bolívar','Av circumbalar con cll 15','9876543','3093456765','JorgeArias@hotmail.com','No','Gerente Marketing','Casado','3','No','No','No','No','Propia','3','Empleado con altas capacidades')
insert into informacion_academica(id_empleado,institucion,tipo_titulacion,titulo,fecha_titulacion)values(8,'Colegio Fernando Molina','Bachiller','Bachiller con enfasis en finanzas','24/07/2008')
insert into referencias (id_empleado,tipo,nombre,parentesco,telefono,correo) values (8,'Familiar','Andres Arias','Padre','5467898','No')


--*****Insercion de registro del cual toma los porcentajes la liquidación*****
insert into liquidacion_contrato (causa,salario,dias_liquidar,prima_servicios,vacaciones,cesantias,intereses_cesantias,caja_compensacion,Impuesto_Caja_compensacion,impuesto_ICBF,IM_ICBF,impuesto_SENA,Im_SENA,pension,Impuesto_pension,salud,Impuesto_salud,indemnizacion,observaciones,identificador)
values ('Justificada','1200000','300','134','134','134','134','132','4','11111','3','111111','2','9999','12','9999','8.5','0','Liquidacion señuelo','1')

--Consultas de tablas
select* from usuario
select*from empleado
select* from articulo
select*from dotacion
select*from referencias
select*from informacion_academica
select*from contrato
select*from liquidacion_contrato
select*from detalles_dotacion
--drop database OSADY