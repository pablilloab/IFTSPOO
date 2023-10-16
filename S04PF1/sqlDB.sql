#Creacion de tabla para socios.

CREATE TABLE `instituto`.`socio` (
  `idSocio` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `apellido` VARCHAR(45) NULL,
  `dni` VARCHAR(45) NULL,
  `telefono` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  PRIMARY KEY (`idSocio`),
  UNIQUE INDEX `idSocio_UNIQUE` (`idSocio` ASC) VISIBLE);