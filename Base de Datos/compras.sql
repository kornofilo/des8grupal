-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-11-2017 a las 04:22:41
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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras`
--

CREATE TABLE `compras` (
  `idCompra` int(7) NOT NULL,
  `idproveedor` int(7) NOT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  `idProducto` int(7) NOT NULL,
  `producto` varchar(25) DEFAULT NULL,
  `cantidad` int(4) NOT NULL,
  `costoUnitario` decimal(15,2) NOT NULL,
  `totalCompra` decimal(15,2) NOT NULL,
  `tipoCompra` varchar(20) NOT NULL,
  `cxp` int(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `compras`
--

INSERT INTO `compras` (`idCompra`, `idproveedor`, `nombre`, `fecha`, `idProducto`, `producto`, `cantidad`, `costoUnitario`, `totalCompra`, `tipoCompra`, `cxp`) VALUES
(1, 1, 'Multimax', '2017-11-02 22:07:09', 234, 'lapto', 5, '24.00', '120.00', 'True', 0),
(2, 1, 'Multimax', '2017-11-02 22:10:24', 245, 'cd', 50, '0.35', '17.50', 'Contado', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `compras`
--
ALTER TABLE `compras`
  ADD PRIMARY KEY (`idCompra`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `compras`
--
ALTER TABLE `compras`
  MODIFY `idCompra` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
