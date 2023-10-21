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
  `costo` DECIMAL(10,0) NOT NULL,
  PRIMARY KEY (`idActividad`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `club_deportivo`.`socios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`socios` (
  `idSocio` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `dni` VARCHAR(45) NOT NULL,
  `telefono` VARCHAR(45) NULL DEFAULT NULL,
  `email` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idSocio`))
ENGINE = InnoDB
AUTO_INCREMENT = 5
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
AUTO_INCREMENT = 3
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
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `club_deportivo`.`cuota`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `club_deportivo`.`cuota` (
  `idCuota` INT NOT NULL AUTO_INCREMENT,
  `monto` DECIMAL(10,0) NOT NULL,
  `fechaPago` DATE NOT NULL,
  `medioPago` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idCuota`))
ENGINE = InnoDB
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
-- procedure NuevoSocio
-- -----------------------------------------------------

DELIMITER $$
USE `club_deportivo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoSocio`(in Nom varchar(45),in Ape varchar(45),in Dni varchar(45),in Tel varchar(45), in Email varchar(45), in historiaM varchar(150),
			                 in fecha varchar(10), in alto decimal, in peso decimal, out rta int)
begin
     declare existe int default 0;
     declare siguiente int default 0;
     
     set existe = (select count(idSocio) from socios where dni = Dni);     
	 
	 if existe = 0 then	 
         #hago el insert en la tabla de socios.
		 insert into socios values(null,Nom,Ape,Dni,Tel,Email);
         
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
