CREATE DATABASE  IF NOT EXISTS `bloodcoding` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bloodcoding`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: bloodcoding
-- ------------------------------------------------------
-- Server version	5.7.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cajas`
--

DROP TABLE IF EXISTS `cajas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cajas` (
  `idCajas` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` double DEFAULT NULL,
  `estado` int(11) DEFAULT NULL,
  `apertura` datetime DEFAULT NULL,
  `cierre` datetime DEFAULT NULL,
  PRIMARY KEY (`idCajas`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cajas`
--

LOCK TABLES `cajas` WRITE;
/*!40000 ALTER TABLE `cajas` DISABLE KEYS */;
INSERT INTO `cajas` VALUES (1,50,1,'2018-10-11 13:37:37','2018-10-11 13:37:37'),(2,900,1,'2018-10-10 21:48:12','2018-10-10 21:48:12'),(3,900,1,'2018-10-10 21:48:13','2018-10-10 21:48:13');
/*!40000 ALTER TABLE `cajas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalles_venta`
--

DROP TABLE IF EXISTS `detalles_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalles_venta` (
  `id` int(11) NOT NULL,
  `precio` double DEFAULT NULL,
  `id_producto` int(11) DEFAULT NULL,
  `id_venta` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalles_venta`
--

LOCK TABLES `detalles_venta` WRITE;
/*!40000 ALTER TABLE `detalles_venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalles_venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimientos_caja`
--

DROP TABLE IF EXISTS `movimientos_caja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimientos_caja` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` double DEFAULT NULL,
  `descripcion` text,
  `fecha` datetime DEFAULT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `id_caja` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimientos_caja`
--

LOCK TABLES `movimientos_caja` WRITE;
/*!40000 ALTER TABLE `movimientos_caja` DISABLE KEYS */;
INSERT INTO `movimientos_caja` VALUES (1,1999,'Salida','2018-10-11 12:58:13',1,1),(2,900,'Salida','2018-10-11 13:30:12',1,1);
/*!40000 ALTER TABLE `movimientos_caja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `idproductos` int(11) NOT NULL AUTO_INCREMENT,
  `codigobarras` varchar(90) DEFAULT NULL,
  `precio` double NOT NULL,
  `ultimaentrada` datetime NOT NULL,
  `stock` int(11) NOT NULL,
  `categoria` varchar(20) NOT NULL,
  PRIMARY KEY (`idproductos`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Editado',3140,'2018-10-10 22:36:20',340,'Editado'),(2,'XXXX',13.9,'2018-10-10 21:14:13',40,'DULCERIA'),(4,'Editado',3140,'2018-10-11 13:24:54',340,'Editado');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `idusuarios` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(10) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `password` blob NOT NULL,
  `rol` int(11) NOT NULL DEFAULT '2' COMMENT '1 - Administrador\n2 - Empleado',
  PRIMARY KEY (`idusuarios`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'prro','Pa QuÃ© o QuÃ©','#­v+al¥;(@5ð~\">',1),(2,'Aveda','Armando Churros','¨Á›\ÓP¡\åYü¡;º',2),(4,'FrankLamar','Francisco Lamas','vQbUñ;ónAI¶N\nO\Ú\\vE†Á¿F\Ö6\Ü\ë',1),(5,'oraora','Peyuso Caluso','\ÖnjVm¹`@‘±HˆH\Ët¹g\ß\ïk8\áúBº>›z',2),(6,'Editado','Editadisimo','Franklin2017',2),(8,'FrankLamar','Francisco Lamas','\áÀú__e^8U×¾¨)H',1);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ventas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cliente` varchar(45) DEFAULT NULL,
  `id_movimiento` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-10-17 11:28:31
