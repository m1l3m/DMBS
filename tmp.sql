-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 05, 2022 at 10:40 AM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tmp`
--

-- --------------------------------------------------------

--
-- Table structure for table `artikli`
--

CREATE TABLE `artikli` (
  `id` int(11) NOT NULL,
  `id_korisnika` int(11) NOT NULL,
  `naziv` varchar(30) NOT NULL,
  `opis` varchar(300) NOT NULL,
  `kolicina` int(11) NOT NULL,
  `jedinicna_cijena` double NOT NULL,
  `slika` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `artikli`
--

INSERT INTO `artikli` (`id`, `id_korisnika`, `naziv`, `opis`, `kolicina`, `jedinicna_cijena`, `slika`) VALUES
(1, 1, 'CocaCola', 'Piće', 11, 1, 'cola.jpg'),
(2, 1, 'Fanta', 'Piće', 5, 1, 'fanta.jpg'),
(3, 1, 'Hljeb', 'Bijeli, rezani', 2, 1.5, 'hljeb.jpg'),
(4, 2, 'Sladoled - kornet', 'Ledo', 5, 1.2, 'kornet.jpg'),
(5, 2, 'Maramice', 'pakovanje 10kom', 1, 1.8, 'maramice.jpg'),
(9, 1, 'Kifla', 'Mala kifla', 10, 0.1, '');

-- --------------------------------------------------------

--
-- Table structure for table `korisnici`
--

CREATE TABLE `korisnici` (
  `id` int(11) NOT NULL,
  `username` varchar(32) NOT NULL,
  `password` varchar(128) NOT NULL,
  `ime` varchar(32) DEFAULT NULL,
  `prezime` varchar(32) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `korisnici`
--

INSERT INTO `korisnici` (`id`, `username`, `password`, `ime`, `prezime`) VALUES
(1, 'tmp1', '*23AE809DDACAF96AF0FD78ED04B6A265E05AA257', 'Petar', 'Petrović'),
(2, 'tmp2', '*531E182E2F72080AB0740FE2F2D689DBE0146E04', 'Ivana', 'Ivanović'),
(3, 'tmp3', '*846AEC788124A4D732D51692E35E9DE488607F86', 'Marko', 'Marković');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `artikli`
--
ALTER TABLE `artikli`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_korisnik_artkal` (`id_korisnika`);

--
-- Indexes for table `korisnici`
--
ALTER TABLE `korisnici`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `artikli`
--
ALTER TABLE `artikli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `korisnici`
--
ALTER TABLE `korisnici`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
