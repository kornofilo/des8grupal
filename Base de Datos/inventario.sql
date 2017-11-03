-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-11-2017 a las 05:36:15
-- Versión del servidor: 10.1.22-MariaDB
-- Versión de PHP: 7.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyecto`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `articulo`
--

CREATE TABLE `articulo` (
  `id_articulo` int(11) NOT NULL,
  `nombre_art` varchar(50) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `existencia` varchar(50) NOT NULL,
  `fecha_exp` varchar(50) NOT NULL,
  `fecha_creacion` varchar(50) NOT NULL,
  `costo` varchar(50) NOT NULL,
  `minimo` varchar(50) NOT NULL,
  `maximo` varchar(50) NOT NULL,
  `precio` varchar(50) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `departamento` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `id_dep` int(11) NOT NULL,
  `departamento` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`id_dep`, `departamento`) VALUES
(1, 'gg'),
(2, 'gg'),
(3, 'jgcthfc');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `descuento`
--

CREATE TABLE `descuento` (
  `id_descuento` int(11) NOT NULL,
  `descuento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `descuento`
--

INSERT INTO `descuento` (`id_descuento`, `descuento`) VALUES
(1, 5),
(2, 7),
(3, 15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `id_marca` int(11) NOT NULL,
  `marca` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`id_marca`, `marca`) VALUES
(1, 'hhh'),
(2, 'ggg'),
(3, 'd'),
(4, 'Quarlee'),
(5, 'Eliah');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modelo`
--

CREATE TABLE `modelo` (
  `id_modelo` int(11) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `idmarca` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `modelo`
--

INSERT INTO `modelo` (`id_modelo`, `modelo`, `idmarca`) VALUES
(1, 'haha', 'hoho'),
(2, 'kerly', 'samaniego'),
(3, 'h', 'h'),
(4, 'g', 'f'),
(5, 'hola', 'hahaha'),
(6, 'gordi', 'puto'),
(7, 'gggg', 'jjjjj'),
(8, 'lexus', 'ha'),
(9, 'huawei', 'haha'),
(10, 's3 mini', 'samsum'),
(11, 'p9litw', 'huawei'),
(12, 'f', 'f'),
(13, 'g', 'g'),
(14, 'putito', 'putito'),
(15, 'no se', 'no seque'),
(16, 'noi s', 'ckjsbskD'),
(17, 'GGGG', 'HHH'),
(18, 'FFFFFFFFFF', 'FFFFFF'),
(19, 'AAA', 'AAAA'),
(20, 'BBBBBB', 'bbbbb'),
(21, 'GGgGgG', 'ggggg'),
(22, 'coño', 'de la madre'),
(23, 'puta', 'mdre'),
(24, 'g', 'g'),
(25, 'h', 'f'),
(26, 'hhhh', 'jjjjjjj'),
(27, 'fgfgfgf', 'gfgfgf'),
(28, 'cccc', 'cccc'),
(29, 'ss', 'ssss'),
(30, 'fdfdf', 'gdgdgd'),
(31, 'g', 'f'),
(32, 'g', 'f'),
(33, 'kkkkk', 'kkkkk'),
(34, 'kkkkk', 'kkkkk'),
(35, 'vvvv', 'vvv'),
(36, 'f', 'f'),
(37, 'hjabsd', 'ggg'),
(38, 'Quarlee', 'Quarlee'),
(39, '100', '7'),
(40, '100', '5'),
(41, '100', '5'),
(42, '100', '5'),
(43, '100', '5'),
(44, '100', '5'),
(45, '100', '5'),
(46, '100', '5'),
(47, '100', '5'),
(48, '100', '5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `precio`
--

CREATE TABLE `precio` (
  `id_precio` int(11) NOT NULL,
  `precio` varchar(50) NOT NULL,
  `descuento` varchar(50) NOT NULL,
  `tot_des` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `precio`
--

INSERT INTO `precio` (`id_precio`, `precio`, `descuento`, `tot_des`) VALUES
(2, '1000', '7', '70');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `articulo`
--
ALTER TABLE `articulo`
  ADD PRIMARY KEY (`id_articulo`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`id_dep`);

--
-- Indices de la tabla `descuento`
--
ALTER TABLE `descuento`
  ADD PRIMARY KEY (`id_descuento`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_marca`);

--
-- Indices de la tabla `modelo`
--
ALTER TABLE `modelo`
  ADD PRIMARY KEY (`id_modelo`);

--
-- Indices de la tabla `precio`
--
ALTER TABLE `precio`
  ADD PRIMARY KEY (`id_precio`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `articulo`
--
ALTER TABLE `articulo`
  MODIFY `id_articulo` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `id_dep` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `modelo`
--
ALTER TABLE `modelo`
  MODIFY `id_modelo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;
--
-- AUTO_INCREMENT de la tabla `precio`
--
ALTER TABLE `precio`
  MODIFY `id_precio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
