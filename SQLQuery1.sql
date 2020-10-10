select nombre, email from Proveedores where nombre like '%Flores%'

insert into Proveedores (codigo,nombre,nombreEmpresa,pais,telefono,email) values ('003','Kevin Ortega','La curacao','El Salvador','2428-3033','Kevin@gmail.com')

delete from Proveedores where idProveedores=23

update Proveedores set codigo='003', nombre='Anthony Ortega', nombreEmpresa='Omnisport', pais='Noruega', telefono='8228-2828', email='Anthony@hotmail.com' where idProveedores=11

update Proveedores set codigo='003', nombre='Kevin Ortiz', nombreEmpresa='OLX', pais='Italia', telefono='2628-8281', email='Ortiz@gmail.com' where idProveedores=12