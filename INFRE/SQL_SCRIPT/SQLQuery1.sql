create table Producto(
	IdProducto int primary key identity(1,1),
	Nombre varchar(50) not null,
	Estado bit not null default(1)
)
go

insert into Producto(Nombre) values ('Nombre1'), ('Nom2'), ('Nom2')

create procedure ObtenerProductos
as
begin
	select * from Producto
end