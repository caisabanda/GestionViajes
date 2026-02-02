-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-02-2026 a las 20:38:12
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `db_viajes_geison`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `destinos`
--

CREATE TABLE `destinos` (
  `destino_id` int(11) NOT NULL,
  `nombre` longtext NOT NULL,
  `pais` longtext NOT NULL,
  `descripcion` longtext NOT NULL,
  `costo` decimal(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `destinos`
--

INSERT INTO `destinos` (`destino_id`, `nombre`, `pais`, `descripcion`, `costo`) VALUES
(1, 'Dubai', 'Emiratos Arabes', 'Lujo', 12000.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `turistas`
--

CREATE TABLE `turistas` (
  `turista_id` int(11) NOT NULL,
  `nombre` longtext NOT NULL,
  `apellido` longtext NOT NULL,
  `email` longtext NOT NULL,
  `telefono` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `turistas`
--

INSERT INTO `turistas` (`turista_id`, `nombre`, `apellido`, `email`, `telefono`) VALUES
(1, 'Geison', 'Caisabanda', 'geisoncg92@uniandes.edu.ec', '1800-Geison');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20260202183451_PrimeraMigracionViajes', '8.0.0');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `destinos`
--
ALTER TABLE `destinos`
  ADD PRIMARY KEY (`destino_id`);

--
-- Indices de la tabla `turistas`
--
ALTER TABLE `turistas`
  ADD PRIMARY KEY (`turista_id`);

--
-- Indices de la tabla `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `destinos`
--
ALTER TABLE `destinos`
  MODIFY `destino_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `turistas`
--
ALTER TABLE `turistas`
  MODIFY `turista_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
