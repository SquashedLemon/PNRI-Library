-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 30, 2018 at 12:55 PM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_library_pnri`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_access`
--

CREATE TABLE `tbl_access` (
  `u_id` int(11) DEFAULT NULL,
  `access_add_material` tinyint(1) DEFAULT NULL,
  `access_add_staff` tinyint(1) DEFAULT NULL,
  `access_borrow_material` tinyint(1) DEFAULT NULL,
  `access_catalog` tinyint(1) DEFAULT NULL,
  `access_config` tinyint(1) DEFAULT NULL,
  `access_dashboard` tinyint(1) DEFAULT NULL,
  `access_records` tinyint(1) DEFAULT NULL,
  `access_return_material` tinyint(1) DEFAULT NULL,
  `access_view` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_borrower`
--

CREATE TABLE `tbl_borrower` (
  `b_id` int(11) NOT NULL,
  `b_fname` varchar(50) DEFAULT NULL,
  `b_lname` varchar(50) DEFAULT NULL,
  `b_div` varchar(50) DEFAULT NULL,
  `b_sec` varchar(50) DEFAULT NULL,
  `b_username` varchar(50) DEFAULT NULL,
  `b_password` varchar(50) DEFAULT NULL,
  `b_contact` varchar(50) DEFAULT NULL,
  `b_address` varchar(150) DEFAULT NULL,
  `b_barangay` varchar(50) DEFAULT NULL,
  `b_city` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_catalog`
--

CREATE TABLE `tbl_catalog` (
  `c_id` int(11) NOT NULL,
  `c_status` varchar(50) DEFAULT NULL,
  `c_access` int(11) DEFAULT NULL,
  `c_call` varchar(50) DEFAULT NULL,
  `c_title` varchar(255) DEFAULT NULL,
  `c_author` varchar(200) DEFAULT NULL,
  `c_publisher` varchar(250) DEFAULT NULL,
  `c_copyright` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_division`
--

CREATE TABLE `tbl_division` (
  `d_id` int(11) DEFAULT NULL,
  `d_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_section`
--

CREATE TABLE `tbl_section` (
  `s_id` int(11) DEFAULT NULL,
  `s_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaction`
--

CREATE TABLE `tbl_transaction` (
  `t_id` int(11) NOT NULL,
  `b_id` int(11) DEFAULT NULL,
  `c_id` int(11) DEFAULT NULL,
  `t_borrowdate` date DEFAULT NULL,
  `t_returneddate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `u_id` int(11) NOT NULL,
  `u_type` varchar(50) DEFAULT NULL,
  `u_fname` varchar(50) DEFAULT NULL,
  `u_lname` varchar(50) DEFAULT NULL,
  `u_username` varchar(50) DEFAULT NULL,
  `u_password` varchar(50) DEFAULT NULL,
  `u_picture` blob
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`u_id`, `u_type`, `u_fname`, `u_lname`, `u_username`, `u_password`, `u_picture`) VALUES
(1, 'Admin', 'Kenneth', 'Gremio', 'Admin', 'Admin', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_access`
--
ALTER TABLE `tbl_access`
  ADD KEY `u_id` (`u_id`);

--
-- Indexes for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  ADD PRIMARY KEY (`b_id`);

--
-- Indexes for table `tbl_catalog`
--
ALTER TABLE `tbl_catalog`
  ADD PRIMARY KEY (`c_id`);

--
-- Indexes for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  ADD PRIMARY KEY (`t_id`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`u_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `t_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_access`
--
ALTER TABLE `tbl_access`
  ADD CONSTRAINT `tbl_access_ibfk_1` FOREIGN KEY (`u_id`) REFERENCES `tbl_user` (`u_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
