-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Фев 19 2020 г., 13:02
-- Версия сервера: 5.6.41
-- Версия PHP: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `mishqa`
--

-- --------------------------------------------------------

--
-- Структура таблицы `table1`
--

CREATE TABLE `table1` (
  `codegos` varchar(30) NOT NULL,
  `numberdoc` varchar(30) NOT NULL,
  `surname` varchar(30) NOT NULL,
  `givennames` varchar(30) NOT NULL,
  `nationality` varchar(30) NOT NULL,
  `dateofbirth` varchar(30) NOT NULL,
  `placeofbir` varchar(30) NOT NULL,
  `sexx` varchar(30) NOT NULL,
  `dateofissue` varchar(30) NOT NULL,
  `OfPosNameSign` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `table2`
--

CREATE TABLE `table2` (
  `positRUS` varchar(30) NOT NULL,
  `NameVesselRUS` varchar(30) NOT NULL,
  `ShipOwnerRUS` varchar(30) NOT NULL,
  `TypeVersselRUS` varchar(30) NOT NULL,
  `PortRegistryRUS` varchar(30) NOT NULL,
  `GrossTonnageRUS` varchar(30) NOT NULL,
  `TypeKWRUS` varchar(30) NOT NULL,
  `SealRUS` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
