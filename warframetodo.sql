-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Sep 24, 2020 at 03:00 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `warframetodo`
--

-- --------------------------------------------------------

--
-- Table structure for table `commonitem`
--

DROP TABLE IF EXISTS `commonitem`;
CREATE TABLE IF NOT EXISTS `commonitem` (
  `Id` int(50) NOT NULL AUTO_INCREMENT,
  `ItemTypeId` int(50) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `WikiString` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ItemTypeId` (`ItemTypeId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `itemtype`
--

DROP TABLE IF EXISTS `itemtype`;
CREATE TABLE IF NOT EXISTS `itemtype` (
  `Id` int(50) NOT NULL AUTO_INCREMENT,
  `ItemType` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `Id` int(50) NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `PasswordSalt` varchar(50) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `CreationDate` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `commonitem`
--
ALTER TABLE `commonitem`
  ADD CONSTRAINT `commonitem_ibfk_1` FOREIGN KEY (`ItemTypeId`) REFERENCES `itemtype` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
