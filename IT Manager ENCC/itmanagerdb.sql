-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 30, 2019 at 12:57 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `itmanagerdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `user` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `password` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `fullname` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `role` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `creationdate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `user`, `password`, `fullname`, `role`, `creationdate`) VALUES
(1, 'wegwegwegwegwe', 'gwegwegweg', 'gregwegwe', 'Admin', '2019-04-02 14:16:41'),
(2, 'FullName', 'UserName', 'SupperSecretPassword', 'Super Admin', '2019-04-02 14:17:13');

-- --------------------------------------------------------

--
-- Table structure for table `hardware`
--

CREATE TABLE `hardware` (
  `ID` int(11) NOT NULL,
  `Type` int(1) NOT NULL,
  `State` int(1) NOT NULL,
  `Office` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `inventorycode` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `serialcode` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `Manufacturer` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `Model` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `description` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `creationdate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hardware`
--

INSERT INTO `hardware` (`ID`, `Type`, `State`, `Office`, `inventorycode`, `serialcode`, `Manufacturer`, `Model`, `description`, `creationdate`) VALUES
(2, 2, 3, 'asfasf', 'fasfasf', 'fas', 'asfas', 'fsafas', 'fasfsa', '2019-04-07 12:07:27'),
(7, 4, 4, 'asdasdasd', 'sad', 'asd', '15-Apr-19 14:24:16', '15-Apr-19 14:24:16', '15-Apr-19 14:24:16', '2019-04-15 14:24:16'),
(9, 0, 0, 'asd', 'asd', 'olaaa', 'asdasd', 'das', 'aasda', '2019-04-15 14:27:26'),
(10, 2, 0, 'asdas', 'dasdsad', 'asdas', 'asdas', 'asdasd', '17-Apr-19 09:49:30', '2019-04-17 09:49:30'),
(11, 3, 3, 'office', 'code', 'number', 'samsung', 'xbox', 'description', '2019-04-17 09:50:24'),
(12, 2, 2, 'zxczxc', 'zxczx', 'zxczxc', 'zxczx', 'zxc', 'zxczxc', '2019-04-17 09:53:11'),
(14, 1, 1, 'off new', 'iii', 'ssss', 'mmm', 'mmmm', 'dddd', '2019-04-17 14:55:25'),
(15, 1, 5, 'asdasda', 'sdas', 'dasdasdasd', 'dasd', 'asdas', 'dasddas', '2019-04-21 14:03:22'),
(16, 0, 0, 'aaaaaaaaa', 'aaaaaaaaa', 'aaaaaaaaa', 'aaaaaaaaa', 'aaaaaaaaa', 'aaaaaaaaa', '2019-04-22 11:49:38'),
(17, 0, 0, 'oooooooo', 'iiiiiiiii', 'nnnnnnnnnn', 'mmmmmmmmm', 'mmmmmmmmm', 'ddddddddddd', '2019-04-23 09:21:15'),
(18, 0, 0, 'dfsdf', 'sdf', 'sd', 'dsfsd', 'sd', 'sdfs', '2019-04-23 09:23:43');

-- --------------------------------------------------------

--
-- Table structure for table `hardwaremovement`
--

CREATE TABLE `hardwaremovement` (
  `id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `id_hardware` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `assignment_date` datetime NOT NULL,
  `return_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hardwaremovement`
--

INSERT INTO `hardwaremovement` (`id`, `id_user`, `id_hardware`, `status`, `assignment_date`, `return_date`) VALUES
(1, 15, 11, 1, '2019-04-12 00:00:00', '2019-04-29 09:11:01'),
(2, 31, 14, 1, '2019-04-12 00:00:00', '2019-04-29 11:10:31'),
(3, 15, 11, 1, '2019-04-28 11:39:31', NULL),
(4, 30, 11, 1, '2019-04-28 14:45:39', NULL),
(5, 28, 10, 3, '2019-04-28 14:53:27', NULL),
(6, 32, 1, 5, '2019-04-28 15:00:10', '2019-04-29 09:15:01'),
(7, 28, 1, 1, '2019-04-29 09:26:25', NULL),
(8, 15, 1, 2, '2019-04-29 09:26:38', NULL),
(9, 15, 10, 1, '2019-04-29 09:29:26', NULL),
(10, 15, 111, 2, '2019-04-29 09:29:42', NULL),
(11, 15, 14, 5, '2019-04-29 09:30:03', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `hardwarestates`
--

CREATE TABLE `hardwarestates` (
  `id` int(11) NOT NULL,
  `name` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hardwarestates`
--

INSERT INTO `hardwarestates` (`id`, `name`) VALUES
(1, 'New'),
(2, 'Good'),
(3, 'Average'),
(4, 'Bad'),
(5, 'Obsolete');

-- --------------------------------------------------------

--
-- Table structure for table `hardwaretypes`
--

CREATE TABLE `hardwaretypes` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hardwaretypes`
--

INSERT INTO `hardwaretypes` (`id`, `name`) VALUES
(1, 'Laptop'),
(2, 'Desktop'),
(3, 'All In One Pc'),
(4, 'Printer'),
(5, 'Monitor');

-- --------------------------------------------------------

--
-- Table structure for table `manager`
--

CREATE TABLE `manager` (
  `ID` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `ID` int(11) NOT NULL,
  `ID_Hardware` int(11) NOT NULL,
  `Problem_State` int(1) NOT NULL,
  `ProblemPriority` int(1) NOT NULL,
  `ProblemCategory` int(1) NOT NULL,
  `ProblemDescription` varchar(100) NOT NULL,
  `ProblemDescriptionAdmin` varchar(100) NOT NULL,
  `SolutionDescriptionAdmin` varchar(100) NOT NULL,
  `SentDate` int(8) NOT NULL,
  `SourceIpAdress` int(11) NOT NULL,
  `SourceMacAdress` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ticketrelations`
--

CREATE TABLE `ticketrelations` (
  `ID` int(11) NOT NULL,
  `ID_Ticket` int(11) NOT NULL,
  `ID_User` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `username` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `password` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `fullname` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `email` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  `localemail` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `direction` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `job` varchar(50) DEFAULT NULL,
  `entrydate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `username`, `password`, `fullname`, `email`, `localemail`, `phone`, `direction`, `job`, `entrydate`) VALUES
(15, 'sdfsdsdfsdf', 'sdfsdfsd', 'FULL NAME 333', 'sdfsdfsdf', 'sdfsdsdfsdf@encc.local', 'sdfsdf', 'dfsdf', 'dfsdfsdf', '2019-04-02 11:26:24'),
(28, 'sdfsdfsdfsdf', 'fsdfsdf', 'fsdf', 'sdfsdf', 'sdfsdfsdfsdf@encc.local', 'sdfsd', 'sdfsdf', 'sdfsdfs', '2019-04-01 15:51:58'),
(29, 'dsadsadasd', 'asdasdas', 'asdasdsadasd', 'dasdasd', 'dsadsadasd@encc.local', 'asda', 'dsadasdas', 'asdasd', '2019-04-02 09:18:46'),
(30, 'sdfsdsdfsdf', 'sdfsdfsd', 'FULL NAME2', 'sdfsdfsdf', 'sdfsdsdfsdf@encc.local', 'sdfsdf', 'dfsdf', 'dfsdfsdf', '2019-04-02 11:26:31'),
(31, 'sdfsdf', 'sdfsdfsdfsd', 'sdfsd', 'dfsdfsdfsdf', 'sdfsdf@encc.local', 'sdfdsf', 'sdfsdfsd', 'sdfsdf', '2019-04-02 11:45:00'),
(32, 'sdsfsdf', 'sdfsdfsdf', 'sdfsdf', 'sdfsdfsdffds', 'sdsfsdf@encc.local', 'sdfsdfds', 'sdfs', 'sdfsd', '2019-04-02 11:45:48');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `hardware`
--
ALTER TABLE `hardware`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `hardwaremovement`
--
ALTER TABLE `hardwaremovement`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `hardwarestates`
--
ALTER TABLE `hardwarestates`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `hardwaretypes`
--
ALTER TABLE `hardwaretypes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manager`
--
ALTER TABLE `manager`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `ticketrelations`
--
ALTER TABLE `ticketrelations`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `hardware`
--
ALTER TABLE `hardware`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `hardwaremovement`
--
ALTER TABLE `hardwaremovement`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `hardwarestates`
--
ALTER TABLE `hardwarestates`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `hardwaretypes`
--
ALTER TABLE `hardwaretypes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `manager`
--
ALTER TABLE `manager`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `ticketrelations`
--
ALTER TABLE `ticketrelations`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
