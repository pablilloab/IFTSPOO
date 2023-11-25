-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: club_deportivo
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `actividad`
--

DROP TABLE IF EXISTS `actividad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actividad` (
  `idActividad` int NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) NOT NULL,
  `horario` varchar(45) NOT NULL,
  `costo_mensual` decimal(10,0) NOT NULL,
  `costo_diario` decimal(10,0) NOT NULL,
  PRIMARY KEY (`idActividad`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actividad`
--

LOCK TABLES `actividad` WRITE;
/*!40000 ALTER TABLE `actividad` DISABLE KEYS */;
INSERT INTO `actividad` VALUES (1,'Musculacion','12:30',500,250);
/*!40000 ALTER TABLE `actividad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aptos`
--

DROP TABLE IF EXISTS `aptos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aptos` (
  `idApto` int NOT NULL AUTO_INCREMENT,
  `idSocio` int NOT NULL,
  `historiaM` varchar(150) NOT NULL,
  `fecha` varchar(10) NOT NULL,
  `alto` decimal(10,0) NOT NULL,
  `peso` decimal(10,0) NOT NULL,
  PRIMARY KEY (`idApto`),
  KEY `idsocio_idx` (`idSocio`),
  CONSTRAINT `idSocioApto` FOREIGN KEY (`idSocio`) REFERENCES `socios` (`idSocio`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aptos`
--

LOCK TABLES `aptos` WRITE;
/*!40000 ALTER TABLE `aptos` DISABLE KEYS */;
INSERT INTO `aptos` VALUES (6,8,'Todo normal','13/11/2023',163,68),(7,9,'asd','11/11/23',165,55),(8,10,'todo ok','11/11/23',165,56),(9,11,'asdas','14/11/2023',180,68),(10,12,'Ok','17/11/2023',163,68),(11,13,'Ok','17/11/2023',163,68),(12,14,'asd','17/11/2023',163,68);
/*!40000 ALTER TABLE `aptos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carnet`
--

DROP TABLE IF EXISTS `carnet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carnet` (
  `idCarnet` int NOT NULL AUTO_INCREMENT,
  `nroCarnet` int NOT NULL,
  PRIMARY KEY (`idCarnet`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carnet`
--

LOCK TABLES `carnet` WRITE;
/*!40000 ALTER TABLE `carnet` DISABLE KEYS */;
INSERT INTO `carnet` VALUES (9,1),(10,10),(11,11),(12,12),(13,13),(14,14),(15,15);
/*!40000 ALTER TABLE `carnet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuota`
--

DROP TABLE IF EXISTS `cuota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuota` (
  `idCuota` int NOT NULL AUTO_INCREMENT,
  `fechaPago` date NOT NULL,
  `monto` decimal(10,0) NOT NULL,
  `medioPago` varchar(45) NOT NULL,
  `pagoRealizado` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`idCuota`,`fechaPago`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuota`
--

LOCK TABLES `cuota` WRITE;
/*!40000 ALTER TABLE `cuota` DISABLE KEYS */;
INSERT INTO `cuota` VALUES (14,'2023-11-13',500,'contado',0),(14,'2023-12-13',500,'contado',0),(14,'2024-01-12',500,'contado',0),(15,'2023-11-14',100,'cuotas',1),(15,'2023-12-14',500,'contado',0),(15,'2024-01-13',500,'contado',0),(16,'2023-11-14',425,'contado',1),(16,'2023-12-14',425,'contado',1),(17,'2023-11-16',475,'contado',1),(17,'2023-12-16',500,'contado',0),(17,'2024-01-15',500,'contado',0),(18,'2023-11-17',475,'contado',1),(18,'2023-12-17',500,'contado',0),(18,'2024-01-16',500,'contado',0),(19,'2023-11-17',0,'contado',1),(19,'2023-12-17',500,'contado',0),(19,'2024-01-16',500,'contado',0);
/*!40000 ALTER TABLE `cuota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inscripcion`
--

DROP TABLE IF EXISTS `inscripcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inscripcion` (
  `idInscripcion` int NOT NULL AUTO_INCREMENT,
  `idSocio` int NOT NULL,
  `idActividad` int NOT NULL,
  `idCarnet` int NOT NULL,
  `idCuota` int NOT NULL,
  PRIMARY KEY (`idInscripcion`),
  KEY `idSocio_idx` (`idSocio`),
  KEY `idActividad_idx` (`idActividad`),
  KEY `idCarnet_idx` (`idCarnet`),
  KEY `idCouta_idx` (`idCuota`),
  CONSTRAINT `idActividad` FOREIGN KEY (`idActividad`) REFERENCES `actividad` (`idActividad`),
  CONSTRAINT `idCarnet` FOREIGN KEY (`idCarnet`) REFERENCES `carnet` (`idCarnet`),
  CONSTRAINT `idCouta` FOREIGN KEY (`idCuota`) REFERENCES `cuota` (`idCuota`),
  CONSTRAINT `idSocio` FOREIGN KEY (`idSocio`) REFERENCES `socios` (`idSocio`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inscripcion`
--

LOCK TABLES `inscripcion` WRITE;
/*!40000 ALTER TABLE `inscripcion` DISABLE KEYS */;
INSERT INTO `inscripcion` VALUES (10,9,1,10,14),(11,10,1,11,15),(12,11,1,12,16),(13,8,1,13,17),(14,13,1,14,18),(15,14,1,15,19);
/*!40000 ALTER TABLE `inscripcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `RolUsu` int NOT NULL,
  `NomRol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`RolUsu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'admin');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `socios`
--

DROP TABLE IF EXISTS `socios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `socios` (
  `idSocio` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `dni` int NOT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `carnet` tinyint DEFAULT '0',
  PRIMARY KEY (`idSocio`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `socios`
--

LOCK TABLES `socios` WRITE;
/*!40000 ALTER TABLE `socios` DISABLE KEYS */;
INSERT INTO `socios` VALUES (8,'Pablo ','Bari',29832537,'2477344273','pab.a.bari@gmail.com',1),(9,'asd','asd',9,'9','asd',1),(10,'Pimpi','Iriberri',32659565,'2125','pasd',1),(11,'Mateo','asd',213246584,'654654','asdasd',1),(12,'Harry','Potter',1234569,'123456','asd@asd.com',1),(13,'Bruce','Wayne',123456,'123456','asd@asd.com',1),(14,'asd','asd',123,'123','asd@asd.com',1);
/*!40000 ALTER TABLE `socios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `CodUsu` int NOT NULL,
  `NombreUsu` varchar(20) DEFAULT NULL,
  `PassUsu` varchar(15) DEFAULT NULL,
  `RolUsu` int DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`CodUsu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'asd','asd',1,1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-25  9:48:11
