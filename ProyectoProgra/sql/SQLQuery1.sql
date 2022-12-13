create database ProyectoFinalUH


create table Clientes
(
codigo_cliente int identity (1,1) PRIMARY KEY,
nombre_cliente varchar(50),
apellido_cliente varchar(50),
telefono_cliente varchar(50)


)

create procedure SelectCli

   @email_cliente varchar(50)
  

   as
   begin
   select * from Clientes where email_cliente=@email_cliente
   end
   exec SelectCli 'araya@uh.com'

exec IngresarCliente'hola','araya','213'
exec IngresarCliente'miguel','sosa','4545','miguelsosa@uh.com'
exec IngresarCliente'osito','sosa','4545','osisosa@uh.com','3'
exec Consultar
create procedure Modificar_clientes    
@codigo_cliente int,
@nombre_cliente varchar(30)='',
@apellido_cliente varchar(50)='',
@telefono_cliente varchar(50)='',
@email_cliente varchar(50)='',
@rutina_cliente varchar(50)=''


as
begin
	update clientes set nombre_cliente=@nombre_cliente,apellido_cliente=@apellido_cliente,telefono_cliente=@telefono_cliente,email_cliente=@email_cliente,rutina_cliente=@rutina_cliente  where codigo_cliente = @codigo_cliente
end

exec Modificar_clientes 'ositos','araya','333' ,'osi@uh.com','3'
exec Consultar
------consultar----
create procedure Consultar
as

begin

select * from clientes

end

---para llamarlo---
exec Consultar
insert 

----borrar----
create procedure BorrarCliente
@nombre_cliente varchar(30)
as
begin

delete clientes where nombre_cliente=@nombre_cliente
end

exec BorrarCliente 'osito'

exec Consultar
------------------------------------------------------------------------------------------------------------------
create table Provincia

(
codigo_pro int identity (1) PRIMARY KEY,
nombre_pro varchar (50)
)


-------------------------------------------------------------------------------------------------------------------------

create table Canton
(
Codigo_Canton int identity (1,1) PRIMARY KEY,
Nombre_Can varchar (50),
Codigo_provincia int
CONSTRAINT FK_Codigo_provincia FOREIGN KEY REFERENCES Provincia(codigo_pro)
)

--------------------------------------------------------------------------------------------------------------------

create table Districto
(
Codigo_Districto int identity (1,1) PRIMARY KEY,
Nombre_Dis varchar (50),
Codigo_can int
CONSTRAINT FK_Codigo_can FOREIGN KEY REFERENCES Canton(codigo_canton)

)

---------------------------------------------------------------------------------------------------------------------
create table Direcciones
(
comentarios varchar(50),
Codigo_Direccion int identity (1,1) PRIMARY KEY,
codigo_cliente int FOREIGN KEY REFERENCES Clientes(codigo_cliente),
codigo_provincia int FOREIGN KEY REFERENCES Provincia(codigo_pro),
codigo_canton int FOREIGN KEY REFERENCES Canton(Codigo_Canton),
codigo_districto int FOREIGN KEY REFERENCES Districto(codigo_districto),


)

create procedure AgregarDirecciones


@comentarios varchar(50),
@codigo_cliente   int,
@codigo_provincia  int,
@codigo_canton  int,
@codigo_districto int



as
begin
insert into Direcciones(codigo_cliente,codigo_provincia,codigo_canton,codigo_districto,comentarios)values(@codigo_cliente,@codigo_provincia,@codigo_canton,@codigo_districto,@comentarios)
end

exec AgregarDirecciones 'aserri',3,1,1,1

create procedure ConsultarDirecciones

as

begin

select * from Direcciones

end
exec ConsultarDirecciones



create procedure BorrarDirecciones
@Codigo_Direccion int
as
begin

delete Direcciones where Codigo_Direccion=@Codigo_Direccion
end

exec BorrarDirecciones 2
exec ConsultarDirecciones


create procedure ModificarDirecciones    
@Codigo_Direccion int,
@comentarios varchar(50),
@codigo_cliente   int,
@codigo_provincia  int,
@codigo_canton  int,
@codigo_districto int


as
begin
	update Direcciones set codigo_cliente=@codigo_cliente,codigo_provincia=@codigo_provincia,codigo_canton=@codigo_canton,codigo_districto=@codigo_districto,comentarios=@comentarios where Codigo_Direccion = @Codigo_Direccion
end

exec ModificarDirecciones 3,'desampa',3,1,1,1
exec ConsultarDirecciones

--------------------------------------------------------------------------------------------------------------------
create table Usuarios
(
correo varchar(50),
clave int,
CONSTRAINT PK_correo PRIMARY KEY (correo),
tipo varchar(10)

)


create procedure ConsultarUsuarios
as

begin

select * from Usuarios

end

---para llamarlo---
exec ConsultarUsuarios


----borrar----
create procedure BorrarUsuarios
@correo varchar(30)
as
begin

delete Usuarios where correo=@correo
end

exec BorrarUsuarios 'daniela@uh.com'
exec ConsultarUsuarios


----agregar----
---si quiero update le pongo alter procedure---
create procedure IngresarUsuarios     
@correo varchar(30),
@clave varchar(30)='',

@tipo varchar(50)=''
as
begin
insert into Usuarios (correo,clave,tipo)values(@correo,@clave,@tipo)
end

exec IngresarUsuarios 'dani@uh.com','123','admin'
exec ConsultarUsuarios


-----modificar----

create procedure ActualizaUsuarios      
@correo varchar(30),
@clave varchar(30),
@tipo varchar(50)
as
begin
	update Usuarios set clave=@clave,tipo=@tipo where correo=@correo
end


exec ActualizaUsuarios	'dani@uh.com','123','admin'
exec ConsultarUsuarios

create procedure ValidarUsuario
@correo varchar (30),
@clave varchar(30)
as

begin
select * from Usuarios where correo=@correo and clave=@clave
end



exec ValidarUsuario 'dani@uh.com','456'


--------------------------------------------------------------------------------------------------------------------
create table Producto
(
codigo_producto int identity primary key,
nombre_producto varchar(100),
precio_producto float


)

insert into Producto (nombre_producto,precio_producto)values ('proteina','3000')
insert into Producto (nombre_producto,precio_producto)values ('Creatina','9500')
insert into Producto (nombre_producto,precio_producto)values ('Blusa','5800')
select * from Producto 


------consultar----
create procedure ConsultarProducto
as

begin

select * from Producto

end

---para llamarlo---
exec ConsultarProducto


----borrar----
create procedure BorrarProducto
@nombre_producto varchar(30)
as
begin

delete Producto where nombre_producto=@nombre_producto
end

exec BorrarProducto'Blusa'
exec ConsultarProducto


----agregar----
---si quiero update le pongo alter procedure---
create procedure IngresarProductos    

@nombre_producto varchar(50)='',
@precio_producto float
as
begin
insert into Producto (nombre_producto,precio_producto)values(@nombre_producto,@precio_producto)
end

exec IngresarProductos'sueta','8500'
exec ConsultarProducto

-----modificar----

create procedure ActualizaProducto
@nombre_producto varchar(50),
@precio_producto float
as
begin
	update Producto set nombre_producto=@nombre_producto,precio_producto=@precio_producto where nombre_producto=@nombre_producto
end


exec ActualizaProducto 'blusa','7550'
exec ConsultarProducto



------------------------------------------------------------------------------------------------------------------

create table Mae_Facturas
(
nfactura int identity(1,1)primary key,
fecha datetime default GetDate(),
codigo_cliente int,
total int,
IV_total int

CONSTRAINT fk_codigo_cliente FOREIGN KEY REFERENCES Clientes(Codigo_cliente)

)
---------------------------------------------------------------------------------------------------------------------------------
create table det_factura
(
	codigo_DetFactura int identity(1,1)PRIMARY KEY,
	nfact int,
	linea int
	 CONSTRAINT FK_nfact FOREIGN KEY REFERENCES Mae_Facturas (nfactura),
	fecha datetime default GetDate(),
	cantidad int,
	total int,
	IV_total int,
	codCliente int
	CONSTRAINT FK_codCliente FOREIGN KEY REFERENCES Clientes(codigo_cliente)
	
	)
-----------------------------------------------------------------------------------------------------------------

create table rutinas 
 (
 id_rutina int identity(1,1) primary key,
 rutina1 varchar(50),
 
 
 )

 create procedure SelectRuti

   @email_cliente varchar(50)
  

   as
   begin
   select Clientes.rutina_cliente , rutinas.rutina1 from Clientes inner join rutinas on clientes.rutina_cliente =rutinas.id_rutina  where email_cliente=@email_cliente
   end

   exec SelectRuti 'jholy@uh.com'
 create procedure ConsultarRutina
 @correo_cliente varchar(50)
 
as

begin

select Clientes.rutina_cliente,rutinas.rutina1 from Clientes inner join rutinas on Clientes.rutina_cliente=rutinas.id_rutina where Clientes.email_cliente=@correo_cliente

end

---para llamarlo---
exec ConsultarRutina 'araya@uh.com'
exec con


----borrar----
create procedure BorrarRutina
@rutina varchar(30)
as
begin

delete rutinas where rutina1=@rutina
end

exec BorrarRutina 'Brazos'
exec ConsultarRutina


----agregar----
---si quiero update le pongo alter procedure---
create procedure IngresarRutina 

@rutina varchar(50)=''

as
begin
insert into rutinas (rutina1)values(@rutina)
end

exec IngresarRutina 'abdomen'
exec ConsultarRutina

-----modificar----

create procedure ActualizaRutina

@rutina varchar(50),
@id_rutina int
as
begin
	update rutinas set rutina1=@rutina where id_rutina=@id_rutina
end


exec ActualizaRutina 'piernas', '1'
exec ConsultarRutina

create procedure CambiarRutina

@email_cliente nvarchar(50),
@id_rutina int
as
begin
update Clientes set rutina_cliente=@id_rutina where Clientes.email_cliente=@email_cliente
end



------------------------------------------------------------------------------------------------------------


create procedure selecproducto
@codigo_producto int
as 
 begin 
 select codigo_producto, nombre_producto, precio_producto from producto where codigo_producto = @codigo_producto
 end

 exec selecproducto  2


exec MaeFactura 'miguel',2300

----------------------------------------------------------------------------------------------------------------
create procedure MaeFactura
 
  @codigo_cliente int,
  @total money
  as 

  begin
  DECLARE @FECHA datetime
  SET @fecha = GETDATE()
    insert into mae_factura (fecha,codigo_cliente,total) values (@FECHA,@codigo_cliente,@total)
  
  end
  exec MaeFactura  1, 6000
    exec MaeFactura  2, 9000
   select * from mae_factura

   create procedure SelectUsu

   @correo varchar(50)
  

   as
   begin
   select * from Usuarios where correo=@correo
   end

   exec SelectUsu 'dani@uh.com'

