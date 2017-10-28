-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 28, 2017 at 04:09 AM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cuentasxpagar`
--

-- --------------------------------------------------------

--
-- Table structure for table `compras`
--

CREATE TABLE `compras` (
  `idCompra` int(7) NOT NULL,
  `idProveedor` int(7) NOT NULL,
  `fecha` date NOT NULL,
  `idProducto` int(7) NOT NULL,
  `cantidad` int(4) NOT NULL,
  `cantidadDescuento` decimal(15,2) NOT NULL,
  `descuento` decimal(15,2) NOT NULL,
  `itbms` decimal(15,2) NOT NULL,
  `subtotal` decimal(15,2) NOT NULL,
  `total` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `proveedores`
--

CREATE TABLE `proveedores` (
  `codigo` int(6) NOT NULL,
  `RUC` varchar(15) NOT NULL,
  `DV` int(6) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `telefono` varchar(25) NOT NULL,
  `fax` varchar(25) NOT NULL,
  `direccion` varchar(30) NOT NULL,
  `email` varchar(25) NOT NULL,
  `tipoProveedor` int(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `proveedores`
--

INSERT INTO `proveedores` (`codigo`, `RUC`, `DV`, `nombre`, `telefono`, `fax`, `direccion`, `email`, `tipoProveedor`) VALUES
(1, '1', 1, 'MULTIMAX', '0', '0', 'TERRONAL', 'MULTIMAX@MULTIMAX', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `compras`
--
ALTER TABLE `compras`
  ADD PRIMARY KEY (`idCompra`);

--
-- Indexes for table `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`codigo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `compras`
--
ALTER TABLE `compras`
  MODIFY `idCompra` int(7) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `codigo` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
