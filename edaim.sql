-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Апр 17 2020 г., 10:29
-- Версия сервера: 10.3.13-MariaDB-log
-- Версия PHP: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `edaim`
--

-- --------------------------------------------------------

--
-- Структура таблицы `log`
--

CREATE TABLE `log` (
  `ID` int(100) NOT NULL,
  `login` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Data` varchar(70) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `log`
--

INSERT INTO `log` (`ID`, `login`, `Data`) VALUES
(1, 'artur', '15:03:11 11 апреля 2020'),
(2, 'artur', '15:03:17 11 апреля 2020'),
(3, 'artur', '15:04:10 11 апреля 2020'),
(4, 'admin', '13:49:48 15 апреля 2020'),
(5, 'artur', '13:50:07 15 апреля 2020'),
(6, 'artur', '14:00:32 15 апреля 2020'),
(7, 'admin', '14:28:46 15 апреля 2020'),
(8, 'admin', '14:45:09 15 апреля 2020'),
(9, 'admin', '14:51:02 15 апреля 2020'),
(10, 'admin', '14:51:38 15 апреля 2020'),
(11, 'admin', '14:52:12 15 апреля 2020'),
(12, 'admin', '14:52:48 15 апреля 2020'),
(13, 'admin', '14:58:02 15 апреля 2020'),
(14, 'admin', '14:58:27 15 апреля 2020'),
(15, 'admin', '15:09:20 15 апреля 2020'),
(16, 'admin', '15:32:22 15 апреля 2020'),
(17, 'admin', '15:33:29 15 апреля 2020'),
(18, 'admin', '15:33:59 15 апреля 2020'),
(19, 'admin', '15:35:19 15 апреля 2020'),
(20, 'artur', '15:36:16 15 апреля 2020'),
(21, 'admin', '15:39:21 15 апреля 2020'),
(22, 'admin', '15:49:57 15 апреля 2020'),
(23, 'admin', '15:56:00 15 апреля 2020'),
(24, 'admin', '15:56:53 15 апреля 2020'),
(25, 'admin', '15:59:14 15 апреля 2020'),
(26, 'admin', '16:33:22 15 апреля 2020'),
(27, 'admin', '16:34:07 15 апреля 2020'),
(28, 'admin', '16:34:42 15 апреля 2020'),
(29, 'admin', '18:32:34 15 апреля 2020'),
(30, 'admin', '18:34:39 15 апреля 2020'),
(31, 'admin', '18:35:14 15 апреля 2020'),
(32, 'admin', '18:38:42 15 апреля 2020'),
(33, 'admin', '18:39:27 15 апреля 2020'),
(34, 'admin', '18:39:58 15 апреля 2020'),
(35, 'admin', '18:40:45 15 апреля 2020'),
(36, 'admin', '18:41:54 15 апреля 2020'),
(37, 'admin', '18:42:25 15 апреля 2020'),
(38, 'admin', '19:05:00 15 апреля 2020'),
(39, 'admin', '19:06:22 15 апреля 2020'),
(40, 'admin', '19:10:44 15 апреля 2020'),
(41, 'admin', '19:11:28 15 апреля 2020'),
(42, 'admin', '19:12:09 15 апреля 2020'),
(43, 'admin', '19:13:08 15 апреля 2020'),
(44, 'admin', '19:16:09 15 апреля 2020'),
(45, 'admin', '19:16:38 15 апреля 2020'),
(46, 'admin', '19:17:18 15 апреля 2020'),
(47, 'admin', '19:18:14 15 апреля 2020'),
(48, 'admin', '19:19:57 15 апреля 2020'),
(49, 'admin', '19:20:24 15 апреля 2020'),
(50, 'admin', '19:20:53 15 апреля 2020'),
(51, 'admin', '19:21:30 15 апреля 2020'),
(52, 'admin', '19:23:58 15 апреля 2020'),
(53, 'admin', '19:30:24 15 апреля 2020'),
(54, 'admin', '19:31:12 15 апреля 2020'),
(55, 'admin', '19:32:14 15 апреля 2020'),
(56, 'admin', '19:33:01 15 апреля 2020'),
(57, 'admin', '19:33:26 15 апреля 2020'),
(58, 'admin', '19:35:06 15 апреля 2020'),
(59, 'admin', '19:37:08 15 апреля 2020'),
(60, 'admin', '19:49:31 15 апреля 2020'),
(61, 'admin', '19:50:48 15 апреля 2020'),
(62, 'admin', '19:51:14 15 апреля 2020'),
(63, 'admin', '19:52:08 15 апреля 2020'),
(64, 'admin', '19:53:08 15 апреля 2020'),
(65, 'admin', '19:53:30 15 апреля 2020'),
(66, 'admin', '19:55:21 15 апреля 2020'),
(67, 'admin', '19:59:18 15 апреля 2020'),
(68, 'admin', '20:01:06 15 апреля 2020'),
(69, 'admin', '20:02:18 15 апреля 2020'),
(70, 'admin', '20:06:00 15 апреля 2020'),
(71, 'admin', '20:07:34 15 апреля 2020'),
(72, 'admin', '20:08:53 15 апреля 2020'),
(73, 'admin', '20:11:46 15 апреля 2020'),
(74, 'admin', '20:12:33 15 апреля 2020'),
(75, 'admin', '20:13:44 15 апреля 2020'),
(76, 'admin', '20:23:28 15 апреля 2020'),
(77, 'admin', '14:06:12 17 апреля 2020'),
(78, 'admin', '14:06:33 17 апреля 2020'),
(79, 'admin', '14:07:36 17 апреля 2020'),
(80, 'admin', '14:10:14 17 апреля 2020'),
(81, 'admin', '14:13:04 17 апреля 2020'),
(82, 'admin', '14:15:42 17 апреля 2020'),
(83, 'gg', '14:17:10 17 апреля 2020'),
(84, 'gg', '14:18:19 17 апреля 2020'),
(85, 'gg', '14:20:50 17 апреля 2020'),
(86, 'gg', '14:24:06 17 апреля 2020');

-- --------------------------------------------------------

--
-- Структура таблицы `table1`
--

CREATE TABLE `table1` (
  `ID` int(100) NOT NULL,
  `codegos` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `numberdoc` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `surname` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `givennames` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nationality` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dateofbirth` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `placeofbir` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `sexx` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dateofissue` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `OfPosNameSign` varchar(400) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `table1`
--

INSERT INTO `table1` (`ID`, `codegos`, `numberdoc`, `surname`, `givennames`, `nationality`, `dateofbirth`, `placeofbir`, `sexx`, `dateofissue`, `OfPosNameSign`) VALUES
(2, 'RUS', 'МК 0038952', 'Имя/name', 'Андрей Юрьевич', 'Россия/Russia', '11 апреля 2020 г.', 'Новосибирск/USSR', '', '11 апреля 2020 г.', 'Руководитель ФБУ\n\"Администрация Обского БВП\"\nС.В. Павлушкин /\nHead S.Pavlushkin\n\"Administration of the Ob BWW\" FSFI'),
(3, 'RUS', 'МК 0038952', 'Имя/name', 'Андрей Юрьевич', 'Россия/Russia', '19 апреля 2020 г.', 'Новосибирск/USSR', '', '17 апреля 2020 г.', 'Руководитель ФБУ\n\"Администрация Обского БВП\"\nС.В. Павлушкин /\nHead S.Pavlushkin\n\"Administration of the Ob BWW\" FSFI'),
(4, 'RUS', 'МК 0038952', 'Имя/name', 'Андрей Юрьевич', 'Россия/Russia', '4 апреля 2020 г.', 'Новосибирск/USSR', '', '25 апреля 2020 г.', 'Руководитель ФБУ\n\"Администрация Обского БВП\"\nС.В. Павлушкин /\nHead S.Pavlushkin\n\"Administration of the Ob BWW\" FSFI'),
(5, 'RUS', 'МК 0038952', 'Имя/name', 'Андрей Юрьевич', 'Россия/Russia', '26 апреля 2020 г.', 'Новосибирск/USSR', '', '14 апреля 2020 г.', 'Руководитель ФБУ\n\"Администрация Обского БВП\"\nС.В. Павлушкин /\nHead S.Pavlushkin\n\"Administration of the Ob BWW\" FSFI'),
(6, 'RUS', 'МК 0038952', 'Имя/name', 'Андрей Юрьевич', 'Россия/Russia', '26 апреля 2020 г.', 'Новосибирск/USSR', '', '23 декабря 2022 г.', 'Руководитель ФБУ\n\"Администрация Обского БВП\"\nС.В. Павлушкин /\nHead S.Pavlushkin\n\"Administration of the Ob BWW\" FSFI');

-- --------------------------------------------------------

--
-- Структура таблицы `table2`
--

CREATE TABLE `table2` (
  `ID` int(10) NOT NULL,
  `positRUS` varchar(30) NOT NULL,
  `NameVesselRUS` varchar(30) NOT NULL,
  `ShipOwnerRUS` varchar(30) NOT NULL,
  `TypeVersselRUS` varchar(30) NOT NULL,
  `PortRegistryRUS` varchar(30) NOT NULL,
  `GrossTonnageRUS` varchar(30) NOT NULL,
  `TypeKWRUS` varchar(30) NOT NULL,
  `SealRUS` varchar(400) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `ID` int(50) NOT NULL,
  `login` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`ID`, `login`, `password`) VALUES
(1, 'gg', 'gg'),
(5, 'admin', 'admin'),
(7, '4', '4'),
(8, '5', '5'),
(9, '6', '6'),
(10, '8', '8'),
(14, '2221', '1112');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `log`
--
ALTER TABLE `log`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `table1`
--
ALTER TABLE `table1`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `table2`
--
ALTER TABLE `table2`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `log`
--
ALTER TABLE `log`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87;

--
-- AUTO_INCREMENT для таблицы `table1`
--
ALTER TABLE `table1`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `table2`
--
ALTER TABLE `table2`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
