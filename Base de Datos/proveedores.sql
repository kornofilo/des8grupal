-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-11-2017 a las 05:31:14
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
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `idproveedor` int(6) NOT NULL,
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

INSERT INTO `proveedores` (`idproveedor`, `RUC`, `DV`, `nombre`, `telefono`, `fax`, `direccion`, `email`, `tipoProveedor`) VALUES
(2, '23', '23', 'KEVIN', '12', '123', '13212', '3123', 'MANTENIMIENTO'),
(3, '123', '3E2', 'DE', 'DE', 'DEDE', 'DE', 'DE', 'LABORATORIO'),
(4, 'de', 'ded', '324', '234', '4234', '234', '234', 'LABORATORIO'),
(5, '234', '23', '3f', 'fv', 'f', 'vf', 'vf', 'MANTENIMIENTO'),
(6, '12', '12', 'wew', 'we', 'wew', 'w', 'w', 'LABORATORIO');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`idproveedor`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `idproveedor` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
