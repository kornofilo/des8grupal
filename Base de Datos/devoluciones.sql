-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 07, 2017 at 12:28 AM
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
-- Table structure for table `devoluciones`
--

CREATE TABLE `devoluciones` (
  `IDDevolucion` int(5) NOT NULL,
  `IDproveedor` varchar(25) NOT NULL,
  `IDproducto` varchar(25) NOT NULL,
  `fechaDevolucion` datetime NOT NULL,
  `cantProductos` int(11) NOT NULL,
  `idCompra` int(11) NOT NULL,
  `costoUnitario` decimal(15,2) NOT NULL,
  `montoDev` decimal(15,2) NOT NULL,
  `saldo` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Triggers `devoluciones`
--
DELIMITER $$
CREATE TRIGGER `UPDATE_SALDO_DEVOLUCION` AFTER INSERT ON `devoluciones` FOR EACH ROW UPDATE `saldos` SET `saldoActual`=NEW.saldo WHERE saldos.idCompra = NEW.idCompra
$$
DELIMITER ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `devoluciones`
--
ALTER TABLE `devoluciones`
  ADD PRIMARY KEY (`IDDevolucion`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `devoluciones`
--
ALTER TABLE `devoluciones`
  MODIFY `IDDevolucion` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
