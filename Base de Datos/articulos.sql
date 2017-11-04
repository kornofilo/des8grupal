-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 04, 2017 at 10:00 PM
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
-- Table structure for table `articulos`
--

CREATE TABLE `articulos` (
  `id_articulo` int(11) NOT NULL,
  `nombre_art` varchar(50) NOT NULL,
  `existencia` int(5) NOT NULL,
  `precio` decimal(15,2) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `departamento` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `articulos`
--

INSERT INTO `articulos` (`id_articulo`, `nombre_art`, `existencia`, `precio`, `tipo`, `marca`, `modelo`, `departamento`) VALUES
(2, 'PlayStation 4 Slim 1TB ', 100, '299.00', 'Consolas de Videojuegos', 'Sony', 'Slim 1TB ', 'Tecnología'),
(3, 'Xbox One S 500GB Console', 50, '247.99', 'Consolas de Videojuegos', 'Microsoft', 'S 500GB Console', 'Tecnología'),
(4, 'Grand Theft Auto V - Xbox One', 25, '37.00', 'Videojuegos', 'Rockstar Games ', 'Normal Edition', 'Tecnología'),
(5, 'inFAMOUS: Second Son', 10, '18.86', 'Videojuegos', 'Sony', 'Standard Edition', 'Tecnología'),
(6, 'Steam Gift Card - $50', 75, '50.00', 'Gift Cards', 'Valve', '50 dolares giftcard', 'Tecnología');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `articulos`
--
ALTER TABLE `articulos`
  ADD PRIMARY KEY (`id_articulo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `articulos`
--
ALTER TABLE `articulos`
  MODIFY `id_articulo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
