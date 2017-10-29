-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-10-2017 a las 00:29:30
-- Versión del servidor: 10.1.26-MariaDB
-- Versión de PHP: 7.1.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cuentasxpagar`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `INSERT_PROVEE` (IN `_codigo` INT(6), IN `_ruc` VARCHAR(15), IN `_dv` VARCHAR(6), IN `_nombre` VARCHAR(25), IN `_telefono` VARCHAR(25), IN `_fax` VARCHAR(25), IN `_direccion` VARCHAR(30), IN `_email` VARCHAR(25), IN `_tipoproveedor` VARCHAR(25))  INSERT INTO `proveedores`(`codigo`, `RUC`, `DV`, `nombre`, `telefono`, `fax`, `direccion`, `email`, `tipoProveedor`) VALUES (_codigo,_ruc,_dv,_nombre,_telefono,_fax,_direccion,_email,_tipoproveedor)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDAT_PROVEE` (IN `_codigo` INT(6), IN `_ruc` VARCHAR(15), IN `_dv` VARCHAR(6), IN `_nombre` VARCHAR(25), IN `_telefono` VARCHAR(25), IN `_fax` VARCHAR(25), IN `_direccion` VARCHAR(30), IN `_email` VARCHAR(25), IN `_tipoproveedor` VARCHAR(25))  UPDATE `proveedores` SET `RUC`=_ruc,`DV`=_dv,`nombre`=_nombre,`telefono`=_telefono,`fax`=_fax,`direccion`=_direccion,`email`=_email,`tipoProveedor`=_tipoproveedor WHERE `codigo`=_codigo$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras`
--

CREATE TABLE `compras` (
  `id` int(5) NOT NULL,
  `documento` int(5) NOT NULL,
  `proveedor` varchar(25) NOT NULL,
  `fechaRegistro` date NOT NULL,
  `fechaVencimiento` date NOT NULL,
  `factura` int(5) NOT NULL,
  `fechaFiscal` date NOT NULL,
  `tipoPago` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `codigo` int(6) NOT NULL,
  `RUC` varchar(15) NOT NULL,
  `DV` varchar(6) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `telefono` varchar(25) NOT NULL,
  `fax` varchar(25) NOT NULL,
  `direccion` varchar(30) NOT NULL,
  `email` varchar(25) NOT NULL,
  `tipoProveedor` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`codigo`, `RUC`, `DV`, `nombre`, `telefono`, `fax`, `direccion`, `email`, `tipoProveedor`) VALUES
(1, '431124', '14', 'Compu Zone', '775-3213', '775-9834', 'Zona Libre', 'compuzone@gmail.com', 'Tecnologia'),
(4, 'we', '1', 'we', 'ew', 'ew', 'ew', 'ew', 'ew'),
(5, '23', '23', 'r', 'r', 'r', 'r', 'r', 'r'),
(6, '12', '12', 'med', '12', '12', 'de', 'de', 'MANTENIMIENTO'),
(7, 'de', '0', 'ded', 't', 'r', 'j', 't', 'MANTENIMIENTO'),
(8, 'rR', 'HY', 'Y', 'Y', 'Y', 'Y', 'Y', 'LABORATORIO');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `compras`
--
ALTER TABLE `compras`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`codigo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `compras`
--
ALTER TABLE `compras`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `codigo` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
