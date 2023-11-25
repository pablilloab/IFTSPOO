drop procedure AltaActividad;

delimiter //

create procedure `AltaActividad`(in IdAct int, in IdSoc int,in Tiempo int, in Dia int, in Monto decimal, out rta int)
begin
     declare existe int default 0;
     declare siguienteC int default 0;
     declare siguienteT int default 0;
     declare itero int default 1;
     declare dias int default 30;
     
     #busco si el socio ya existe cargado en esa actividad
     select count(idInscripcion) into existe from inscripcion where idSocio = IdSoc and idActividad = IdAct;  
	 

	 if existe = 0 then	 
		if Dia = 1 then
			#hago el insert de la cuota        
			insert into cuota values (null, curdate(), Monto, "contado",0);       
        
			#busco el ultimo id de cuota creado
			select max(idCuota) into siguienteC from cuota;         
			
            #busco el ultimo carnet creado
			select max(idCarnet) into siguienteT from carnet;
            if siguienteT is null then
				set siguienteT = 1;
			else
				set siguienteT = siguienteT + 1;
			end if;
            
            #hago el insert en carnet
			insert into carnet values (null, siguienteT);
			
        
			#hago el insert en la tabla de socios.
			insert into inscripcion values(null,IdSoc, IdAct, siguienteT, siguienteC);	
			set rta  = 1;        
        else
			#hago el insert de la cuota (1) del mes
			insert into cuota values (null, curdate(), Monto, "contado",0);             
                    
            #busco el ultimo id de cuota creado anteriormente
			select max(idCuota) into siguienteC from cuota;              
            set itero = itero + 1;
                        
			while(itero <= Tiempo) do
				#hago el insert de la cuota        
				insert into cuota (idCuota, fechaPago, monto, medioPago,pagoRealizado) values (siguienteC, date_add(curdate(), interval dias day), Monto,  "contado",0); 
                set dias = dias + 30;
                set itero = itero + 1;
			end while;            
            
			#busco el ultimo carnet creado
			select max(idCarnet) into siguienteT from carnet;
            if siguienteT is null then
				set siguienteT = 1;
			else
				set siguienteT = siguienteT + 1;
			end if;
            
            #hago el insert en carnet
			insert into carnet values (null, siguienteT);			
        
			#hago el insert en la tabla de socios.
			insert into inscripcion values(null,IdSoc, IdAct, siguienteT, siguienteC);	
			set rta  = 1;    
            
        end if;
        
	 else
		set rta = 0;
	 end if;		 
end