-- MariaDB dump 10.19  Distrib 10.4.22-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: minimarket
-- ------------------------------------------------------
-- Server version	10.4.22-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `idCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idCategoria`),
  UNIQUE KEY `unico_nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Carnes','Carne de res, de cerdo y más'),(2,'Bebidas','Refrescos, jugos y bebidas diversas'),(4,'POroductos de Limpieza','Detergentes, jabones, y productos para limpieza de'),(5,'Granos','Arroz, fríjol, lenteja y mas');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `tipoDoc` enum('CC','TI','PAS','PEP','PPT','CE','Otro') DEFAULT NULL,
  `identificacion` varchar(11) NOT NULL,
  `nombres` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `celular` varchar(11) NOT NULL,
  PRIMARY KEY (`idCliente`),
  UNIQUE KEY `unico_identificacion` (`identificacion`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'CC','1111111111','Carlos Alberto','Torres Lozada','lozada@gmail.com','3204405060');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallefactura`
--

DROP TABLE IF EXISTS `detallefactura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallefactura` (
  `idDetalleFactura` int(11) NOT NULL AUTO_INCREMENT,
  `cantidadProductos` int(11) NOT NULL,
  `precioUnitario` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL,
  `idFactura` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL,
  PRIMARY KEY (`idDetalleFactura`),
  KEY `fk_factura` (`idFactura`),
  KEY `fk_producto` (`idProducto`),
  CONSTRAINT `fk_factura` FOREIGN KEY (`idFactura`) REFERENCES `factura` (`idFactura`),
  CONSTRAINT `fk_producto` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallefactura`
--

LOCK TABLES `detallefactura` WRITE;
/*!40000 ALTER TABLE `detallefactura` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallefactura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleordencompra`
--

DROP TABLE IF EXISTS `detalleordencompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalleordencompra` (
  `idDetalleOrden` int(11) NOT NULL AUTO_INCREMENT,
  `codigoDetalleOrden` int(11) NOT NULL,
  `cantidadProductos` int(11) NOT NULL,
  `precioCompra` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL,
  `idOrdenCompra` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL,
  PRIMARY KEY (`idDetalleOrden`),
  UNIQUE KEY `unico_detalleOrdenCompra` (`codigoDetalleOrden`),
  KEY `fk_ordenCompra` (`idOrdenCompra`),
  KEY `fk_producto1` (`idProducto`),
  CONSTRAINT `fk_ordenCompra` FOREIGN KEY (`idOrdenCompra`) REFERENCES `ordencompra` (`idOrdenCompra`),
  CONSTRAINT `fk_producto1` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleordencompra`
--

LOCK TABLES `detalleordencompra` WRITE;
/*!40000 ALTER TABLE `detalleordencompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleordencompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `idEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `tipoDoc` enum('CC','TI','PAS','PEP','PPT','CE','Otro') DEFAULT NULL,
  `identificacion` varchar(11) NOT NULL,
  `nombres` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `celular` varchar(11) NOT NULL,
  `clave` varchar(8) NOT NULL,
  `idMinimarket` int(11) NOT NULL,
  PRIMARY KEY (`idEmpleado`),
  UNIQUE KEY `unico_identificacion_empleado` (`identificacion`),
  UNIQUE KEY `unico_correo_empleado` (`correo`),
  KEY `fk_minimarket` (`idMinimarket`),
  CONSTRAINT `fk_minimarket` FOREIGN KEY (`idMinimarket`) REFERENCES `minimarket` (`idMinimarket`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
  `idFactura` int(11) NOT NULL AUTO_INCREMENT,
  `codigoFactura` varchar(8) NOT NULL,
  `fechaGeneracion` datetime NOT NULL,
  `iva` int(11) NOT NULL,
  `sinIva` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `idEmpleado` int(11) NOT NULL,
  `idCliente` int(11) NOT NULL,
  PRIMARY KEY (`idFactura`),
  UNIQUE KEY `unico_factura` (`codigoFactura`),
  KEY `fk_empleado` (`idEmpleado`),
  KEY `fk_cliente` (`idCliente`),
  CONSTRAINT `fk_cliente` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`),
  CONSTRAINT `fk_empleado` FOREIGN KEY (`idEmpleado`) REFERENCES `empleado` (`idEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `minimarket`
--

DROP TABLE IF EXISTS `minimarket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `minimarket` (
  `idMinimarket` int(11) NOT NULL AUTO_INCREMENT,
  `nit` varchar(15) NOT NULL,
  `razonSocial` varchar(50) NOT NULL,
  `telefono` varchar(10) NOT NULL,
  `nomenclatura` varchar(50) NOT NULL,
  `ciudad` varchar(50) NOT NULL,
  `departamento` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `sitioWeb` varchar(50) NOT NULL,
  `facebook` varchar(50) NOT NULL,
  `whatsapp` varchar(10) NOT NULL,
  PRIMARY KEY (`idMinimarket`),
  UNIQUE KEY `unico_nit` (`nit`),
  UNIQUE KEY `unico_razonSocial` (`razonSocial`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `minimarket`
--

LOCK TABLES `minimarket` WRITE;
/*!40000 ALTER TABLE `minimarket` DISABLE KEYS */;
INSERT INTO `minimarket` VALUES (1,'1010101010','LaTienditaCali','3106601010','Carrera 15 # 8 C 12','Cali','Valle del Cauca','latiendita@gmail.com','latiendamaspro.com','latienditacali','3106602020');
/*!40000 ALTER TABLE `minimarket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordencompra`
--

DROP TABLE IF EXISTS `ordencompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ordencompra` (
  `idOrdenCompra` int(11) NOT NULL AUTO_INCREMENT,
  `codigoOrden` int(11) NOT NULL,
  `iva` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `fechaPedido` datetime NOT NULL,
  `fechaEntrega` datetime NOT NULL,
  `sinIva` int(11) NOT NULL,
  `idEmpleado` int(11) NOT NULL,
  `idProveedor` int(11) NOT NULL,
  PRIMARY KEY (`idOrdenCompra`),
  UNIQUE KEY `unico_ordenCompra` (`codigoOrden`),
  KEY `fk_empleado1` (`idEmpleado`),
  KEY `fk_proveedor` (`idProveedor`),
  CONSTRAINT `fk_empleado1` FOREIGN KEY (`idEmpleado`) REFERENCES `empleado` (`idEmpleado`),
  CONSTRAINT `fk_proveedor` FOREIGN KEY (`idProveedor`) REFERENCES `proveedor` (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordencompra`
--

LOCK TABLES `ordencompra` WRITE;
/*!40000 ALTER TABLE `ordencompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordencompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `idProducto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `stock` int(11) DEFAULT 0,
  `pvp` int(11) NOT NULL DEFAULT 0,
  `descripcion` varchar(200) DEFAULT NULL,
  `unidadMedida` enum('UND','gr') DEFAULT NULL,
  `idCategoria` int(11) NOT NULL,
  PRIMARY KEY (`idProducto`),
  UNIQUE KEY `unico_nombre` (`nombre`),
  KEY `fk_categoria` (`idCategoria`),
  CONSTRAINT `fk_categoria` FOREIGN KEY (`idCategoria`) REFERENCES `categoria` (`idCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (2,'Escoba','Limpimax',40,12000,'Escoba de buena calidad','UND',1);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `idProveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nit` varchar(15) NOT NULL,
  `razonSocial` varchar(50) NOT NULL,
  `telefono` varchar(10) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `nomenclatura` varchar(50) NOT NULL,
  `ciudad` varchar(50) NOT NULL,
  `departamento` varchar(50) NOT NULL,
  PRIMARY KEY (`idProveedor`),
  UNIQUE KEY `unico_nit_proveedor` (`nit`),
  UNIQUE KEY `unico_razonSocial_proveedor` (`razonSocial`),
  UNIQUE KEY `unico_correo_proveedor` (`correo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'100004444','SurtiLocuras','3136661122','surtilocuras@gmail.com','Carrera 60 # 15 C 12','Cali','Valle del Cauca'),(2,'122304444','LoMejor','3208889977','lomejorcali@gmail.com','Carrera 70 # 44 C 12','Cali','Valle del Cauca'),(3,'100000088','Casa Limpia','3104453030','proveemax@gmail.com','Diagonal 70 # 52 - 60','Cali','Valle del Cauca'),(5,'162541625','DeTodoYMas','3208889977','detodo@gmail.com','Carrera 50 # 66 C 12','Cali','Valle del Cauca'),(6,'1004525601','Distripro','6651414','distri@gmail.com','Calle 70 - 55 N 70','Cali','Valle del Cauca');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-09 11:03:14
