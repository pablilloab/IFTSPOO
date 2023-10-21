 
 delimiter //
 create procedure NuevoSocio(in Nom varchar(45),in Ape varchar(45),in Dni varchar(45), in Tel varchar(45), in Email varchar(45), out rta int)
 begin
     declare existe int default 0;
     
     set existe = (select count(*) from socio where dni = Dni);     
	 
	 if existe = 0 then	 
		 insert into socio values(null,Nom,Ape,Dni,Tel,Email);
		 set rta  = 1;
	 else
		 set rta = 0;
	 end if;		 
    
     end //

drop procedure NuevoSocio;