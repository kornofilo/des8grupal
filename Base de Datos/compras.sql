-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 11, 2017 at 09:49 PM
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
  `idproveedor` int(7) NOT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  `totalCompra` decimal(15,2) NOT NULL,
  `tipoCompra` varchar(20) NOT NULL,
  `cxp` int(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `compras`
--

INSERT INTO `compras` (`idCompra`, `idproveedor`, `nombre`, `fecha`, `totalCompra`, `tipoCompra`, `cxp`) VALUES
(83, 10, 'MULTIMAX', '2017-11-11 15:45:12', '905.21', 'Contado', 0),
(84, 2, 'Super 99', '2017-11-11 15:45:56', '265.35', 'Contado', 0),
(85, 2, 'Super 99', '2017-11-11 15:46:12', '79.18', 'Contado', 0),
(86, 10, 'MULTIMAX', '2017-11-11 15:47:31', '265.35', 'Contado', 0);

--
-- Triggers `compras`
--
DELIMITER $$
CREATE TRIGGER `INSERT_COMPRA_EN_PAGOS` AFTER INSERT ON `compras` FOR EACH ROW BEGIN 
	IF NEW.tipoCompra = 'Crédito' THEN
		INSERT INTO pagos VALUES (NULL,NEW.idproveedor,NEW.totalCompra, NEW.fecha, NEW.idCompra, NEW.totalCompra);
INSERT INTO saldos VALUES (NULL,NEW.idCompra,NEW.idproveedor, NEW.totalCompra);     
    ELSE
    INSERT INTO pagos VALUES (NULL,NEW.idproveedor,NEW.totalCompra, NEW.fecha, NEW.idCompra, 0);
	END IF;
END
$$
DELIMITER ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `compras`
--
ALTER TABLE `compras`
  ADD PRIMARY KEY (`idCompra`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `compras`
--
ALTER TABLE `compras`
  MODIFY `idCompra` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
