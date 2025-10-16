-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3312
-- Tiempo de generación: 16-10-2025 a las 17:13:53
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `puntajes_megaware`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puntajesglobales`
--

CREATE TABLE `puntajesglobales` (
  `Nombre` text NOT NULL,
  `puntaje_total` int(11) NOT NULL,
  `rockmaruga` int(11) NOT NULL,
  `coin_collector` int(11) NOT NULL,
  `MegaRun` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `puntajesglobales`
--

INSERT INTO `puntajesglobales` (`Nombre`, `puntaje_total`, `rockmaruga`, `coin_collector`, `MegaRun`) VALUES
('juan', 7777, 7000, 777, 0),
('ramon', 40, 0, 0, 0),
('uvuvuevuevue', 0, 0, 0, 0),
('', 40, 0, 0, 0),
('jorge', 40, 0, 0, 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
