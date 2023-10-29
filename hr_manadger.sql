-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 29, 2023 at 11:05 AM
-- Server version: 5.7.24
-- PHP Version: 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hr_manadger`
--

-- --------------------------------------------------------

--
-- Table structure for table `hr_manadger`
--

CREATE TABLE `hr_manadger` (
  `Id` int(10) UNSIGNED NOT NULL,
  `Login` varchar(15) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `FIO` text NOT NULL,
  `NumberOfPhone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `stack_workers`
--

CREATE TABLE `stack_workers` (
  `ID` int(10) NOT NULL,
  `Login` int(11) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `FIO` varchar(15) NOT NULL,
  `Post` varchar(30) NOT NULL,
  `Departament` varchar(30) NOT NULL,
  `Division` varchar(30) NOT NULL,
  `NumberOfPhone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `hr_manadger`
--
ALTER TABLE `hr_manadger`
  ADD UNIQUE KEY `ID` (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `hr_manadger`
--
ALTER TABLE `hr_manadger`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
