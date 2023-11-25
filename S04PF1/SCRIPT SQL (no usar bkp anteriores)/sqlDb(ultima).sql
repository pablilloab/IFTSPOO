drop database club_deportivo;

-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema club_deportivo
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema club_deportivo
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `club_deportivo` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `club_deportivo` ;

-- -----------------------------------------------------
-- Table `club_deportivo`.`actividad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`actividad` (
  `idActividad` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(45) NOT NULL,
  `horario` VARCHAR(45) NOT NULL,
  `costo_mensual` DECIMAL(10,0) NOT NULL,
  `costo_diario` DECIMAL(10,0) NOT NULL,
  PRIMARY KEY (`idActividad`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `club_deportivo`.`socios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`socios` (
  `idSocio` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `dni` INT NOT NULL,
  `telefono` VARCHAR(45) NULL DEFAULT NULL,
  `email` VARCHAR(45) NULL DEFAULT NULL,
  `carnet` TINYINT NULL DEFAULT '0',
  PRIMARY KEY (`idSocio`))
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `club_deportivo`.`aptos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`aptos` (
  `idApto` INT NOT NULL AUTO_INCREMENT,
  `idSocio` INT NOT NULL,
  `historiaM` VARCHAR(150) NOT NULL,
  `fecha` VARCHAR(10) NOT NULL,
  `alto` DECIMAL(10,0) NOT NULL,
  `peso` DECIMAL(10,0) NOT NULL,
  PRIMARY KEY (`idApto`),
  INDEX `idsocio_idx` (`idSocio` ASC) VISIBLE,
  CONSTRAINT `idSocioApto`
    FOREIGN KEY (`idSocio`)
    REFERENCES `club_deportivo`.`socios` (`idSocio`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `club_deportivo`.`carnet`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`carnet` (
  `idCarnet` INT NOT NULL AUTO_INCREMENT,
  `nroCarnet` INT NOT NULL,
  PRIMARY KEY (`idCarnet`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `club_deportivo`.`cuota`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`cuota` (
  `idCuota` INT NOT NULL AUTO_INCREMENT,
  `fechaPago` DATE NOT NULL,
  `monto` DECIMAL(10,0) NOT NULL,
  `medioPago` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idCuota`, `fechaPago`))
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `club_deportivo`.`inscripcion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`inscripcion` (
  `idInscripcion` INT NOT NULL AUTO_INCREMENT,
  `idSocio` INT NOT NULL,
  `idActividad` INT NOT NULL,
  `idCarnet` INT NOT NULL,
  `idCuota` INT NOT NULL,
  PRIMARY KEY (`idInscripcion`),
  INDEX `idSocio_idx` (`idSocio` ASC) VISIBLE,
  INDEX `idActividad_idx` (`idActividad` ASC) VISIBLE,
  INDEX `idCarnet_idx` (`idCarnet` ASC) VISIBLE,
  INDEX `idCouta_idx` (`idCuota` ASC) VISIBLE,
  CONSTRAINT `idActividad`
    FOREIGN KEY (`idActividad`)
    REFERENCES `club_deportivo`.`actividad` (`idActividad`),
  CONSTRAINT `idCarnet`
    FOREIGN KEY (`idCarnet`)
    REFERENCES `club_deportivo`.`carnet` (`idCarnet`),
  CONSTRAINT `idCouta`
    FOREIGN KEY (`idCuota`)
    REFERENCES `club_deportivo`.`cuota` (`idCuota`),
  CONSTRAINT `idSocio`
    FOREIGN KEY (`idSocio`)
    REFERENCES `club_deportivo`.`socios` (`idSocio`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `club_deportivo`.`roles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`roles` (
  `RolUsu` INT NOT NULL,
  `NomRol` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`RolUsu`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `club_deportivo`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`usuario` (
  `CodUsu` INT NOT NULL,
  `NombreUsu` VARCHAR(20) NULL DEFAULT NULL,
  `PassUsu` VARCHAR(15) NULL DEFAULT NULL,
  `RolUsu` INT NULL DEFAULT NULL,
  `Activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`CodUsu`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `club_deportivo` ;

-- -----------------------------------------------------
-- procedure AltaActividad
-- -----------------------------------------------------

DELIMITER $$
USE `club_deportivo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AltaActividad`(in IdAct int, in IdSoc int,in Tiempo int, in Dia int, in Monto decimal, out rta int)
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
			insert into cuota values (null, curdate(), Monto, "contado");       
        
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
			insert into cuota values (null, curdate(), Monto, "contado");             
                    
            #busco el ultimo id de cuota creado anteriormente
			select max(idCuota) into siguienteC from cuota;              
            set itero = itero + 1;
                        
			while(itero < Tiempo) do
				#hago el insert de la cuota        
				insert into cuota (idCuota, fechaPago, monto, medioPago) values (siguienteC, date_add(curdate(), interval dias day), Monto,  "contado"); 
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
			insert into carnet values (null, siguienteT);
            
			#hago el insert en la tabla de inscripcion.
			insert into inscripcion values(null,IdSoc, IdAct, siguienteT, siguienteC);	
			set rta  = 1; 
            
        end if;
        
	 else
		set rta = 0;
	 end if;		 
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure NuevoSocio
-- -----------------------------------------------------

DELIMITER $$
USE `club_deportivo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoSocio`(in Nom varchar(45),in Ape varchar(45),in inDni int,in Tel varchar(45), in Email varchar(45), in historiaM varchar(150),
			                 in fecha varchar(10), in alto decimal, in peso decimal, out rta int)
begin
     declare existe int default 0;
     declare siguiente int default 0;
     
     #set existe = (select count(idSocio) from socios where dni = Dni);
     select count(dni) into existe from socios where dni = inDni;  
	 #set existe = (select case when count(idSocio) > 0 then 1 else 0 end from socios where dni = Dni);

	 if existe = 0 then	 
         #hago el insert en la tabla de socios.
		 insert into socios values(null,Nom,Ape,inDni,Tel,Email,1);
         
         #busco el id de socio insertado para dar de alta en la tabla de aptos fisicos.
         select max(idSocio) into siguiente from socios;
         
         #hago el insert en la tabla de apto fisico.
         insert into aptos values(null,siguiente,historiaM,fecha,alto,peso);
                  
		 set rta  = 1;
	 else
		 set rta = 0;
	 end if;		 
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure checkLogin
-- -----------------------------------------------------

DELIMITER $$
USE `club_deportivo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkLogin`(in Usu varchar(20),in Pass varchar(15), out resultado int)
begin    
  
  select count(NomRol) into resultado
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass and Activo = 1;       

end$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
