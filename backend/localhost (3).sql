-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 29, 2023 at 01:07 PM
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
-- Database: `admin`
--
CREATE DATABASE IF NOT EXISTS `admin` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `admin`;

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `ID` int(10) UNSIGNED NOT NULL,
  `Login` varchar(15) NOT NULL,
  `Password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Database: `base_of_login`
--
CREATE DATABASE IF NOT EXISTS `base_of_login` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `base_of_login`;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(32) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `login`, `pass`) VALUES
(1, 'Admin', '123'),
(2, 'User', '123'),
(8, '123', 'abc'),
(7, 'Fack', '12'),
(9, '1234', '1234'),
(10, 'Данил', 'от1до8'),
(11, 'йц', 'йцйц'),
(12, '.ll', '.l.l'),
(13, 'sdfgh', 'dfghj'),
(14, 'dfgd', 'dfg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- Database: `company`
--
CREATE DATABASE IF NOT EXISTS `company` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `company`;

-- --------------------------------------------------------

--
-- Table structure for table `company`
--

CREATE TABLE `company` (
  `ID` int(10) UNSIGNED NOT NULL,
  `NameOfCompany` varchar(30) NOT NULL,
  `INN` int(10) NOT NULL,
  `Address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `company`
--

INSERT INTO `company` (`ID`, `NameOfCompany`, `INN`, `Address`) VALUES
(1, 'ddsf', 12356, 'ddsf');

-- --------------------------------------------------------

--
-- Table structure for table `stack_division`
--

CREATE TABLE `stack_division` (
  `Division` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `company`
--
ALTER TABLE `company`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `company`
--
ALTER TABLE `company`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Database: `hr_manadger`
--
CREATE DATABASE IF NOT EXISTS `hr_manadger` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `hr_manadger`;

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
--
-- Database: `wasdfghjkl;'`
--
CREATE DATABASE IF NOT EXISTS `wasdfghjkl;'` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `wasdfghjkl;'`;
--
-- Database: `worker`
--
CREATE DATABASE IF NOT EXISTS `worker` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `worker`;

-- --------------------------------------------------------

--
-- Table structure for table `worker`
--

CREATE TABLE `worker` (
  `Id` int(10) UNSIGNED NOT NULL,
  `Login` varchar(15) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `FIO` text NOT NULL,
  `Post` varchar(30) NOT NULL,
  `Department` varchar(30) NOT NULL,
  `Division` varchar(30) NOT NULL,
  `NumberOfPhone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `worker`
--
ALTER TABLE `worker`
  ADD UNIQUE KEY `  иап` (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `worker`
--
ALTER TABLE `worker`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
