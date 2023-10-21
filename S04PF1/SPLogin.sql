
delimiter //

create procedure checkLogin (in Usu varchar(20),in Pass varchar(15), out resultado int)
begin    
  
  select count(NomRol) into resultado
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass and Activo = 1;       

end //


