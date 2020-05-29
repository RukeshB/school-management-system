-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 29, 2020 at 04:20 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `school_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `account_fee_structure`
--

CREATE TABLE `account_fee_structure` (
  `class` varchar(5) NOT NULL,
  `fee_description` varchar(150) NOT NULL,
  `amount` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `bus_info`
--

CREATE TABLE `bus_info` (
  `route` varchar(50) NOT NULL,
  `bus_number` varchar(10) NOT NULL,
  `route_fee` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `exam_marks`
--

CREATE TABLE `exam_marks` (
  `id` int(11) NOT NULL,
  `class_id` varchar(10) NOT NULL,
  `subject_code` varchar(10) NOT NULL,
  `terminal_id` varchar(10) NOT NULL,
  `student_id` varchar(10) NOT NULL,
  `student_name` varchar(50) NOT NULL,
  `marks` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `exam_terminals`
--

CREATE TABLE `exam_terminals` (
  `id` int(11) NOT NULL,
  `terminal_id` varchar(10) NOT NULL,
  `terminal_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `libary_book_menu`
--

CREATE TABLE `libary_book_menu` (
  `book_code` varchar(10) NOT NULL,
  `title` varchar(50) NOT NULL,
  `number_of_book` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `libary_issue_book`
--

CREATE TABLE `libary_issue_book` (
  `class` varchar(5) NOT NULL,
  `student_id` varchar(10) NOT NULL,
  `book_code` varchar(10) NOT NULL,
  `title` varchar(50) NOT NULL,
  `date_of_issue` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `libary_member`
--

CREATE TABLE `libary_member` (
  `class` varchar(5) NOT NULL,
  `student_id` varchar(10) NOT NULL,
  `student_name` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `libary_return_book`
--

CREATE TABLE `libary_return_book` (
  `class` varchar(5) NOT NULL,
  `student_id` varchar(10) NOT NULL,
  `book_code` varchar(10) NOT NULL,
  `title` varchar(50) NOT NULL,
  `date_of_return` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `user_name` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `account_type` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `user_name`, `pass`, `account_type`) VALUES
(1, 'Rukesh', '123456789', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `manage_class`
--

CREATE TABLE `manage_class` (
  `id` int(11) NOT NULL,
  `class_id` varchar(10) NOT NULL,
  `class_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `manage_subject`
--

CREATE TABLE `manage_subject` (
  `id` int(11) NOT NULL,
  `subject_code` varchar(10) NOT NULL,
  `subject_name` varchar(50) NOT NULL,
  `full_marks` int(11) NOT NULL,
  `pass_marks` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `manage_subject_teacher`
--

CREATE TABLE `manage_subject_teacher` (
  `id` int(11) NOT NULL,
  `sub_teacher_id` varchar(10) NOT NULL,
  `subject_id` varchar(10) NOT NULL,
  `teacher_id` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `result_marks`
--

CREATE TABLE `result_marks` (
  `class` varchar(5) NOT NULL,
  `subject_code` varchar(10) NOT NULL,
  `terminal` varchar(30) NOT NULL,
  `student_id` varchar(10) NOT NULL,
  `student_name` varchar(40) NOT NULL,
  `marks` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `result_subject`
--

CREATE TABLE `result_subject` (
  `class` varchar(5) NOT NULL,
  `subject_code` varchar(10) NOT NULL,
  `subject_name` varchar(15) NOT NULL,
  `full_marks` int(11) NOT NULL,
  `pass_marks` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `staff_info`
--

CREATE TABLE `staff_info` (
  `name` varchar(50) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `address` varchar(30) NOT NULL,
  `phone` varchar(15) NOT NULL,
  `email` varchar(30) NOT NULL,
  `subject_name` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student_info`
--

CREATE TABLE `student_info` (
  `admission_date` date NOT NULL,
  `student_id` varchar(10) NOT NULL,
  `class` varchar(5) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `date_of_birth` date NOT NULL,
  `birth_place` varchar(30) NOT NULL,
  `city` varchar(25) NOT NULL,
  `address` varchar(30) NOT NULL,
  `phone_no.` varchar(15) NOT NULL,
  `Email` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `exam_marks`
--
ALTER TABLE `exam_marks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `exam_terminals`
--
ALTER TABLE `exam_terminals`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manage_class`
--
ALTER TABLE `manage_class`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manage_subject`
--
ALTER TABLE `manage_subject`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manage_subject_teacher`
--
ALTER TABLE `manage_subject_teacher`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student_info`
--
ALTER TABLE `student_info`
  ADD PRIMARY KEY (`student_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `exam_marks`
--
ALTER TABLE `exam_marks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `exam_terminals`
--
ALTER TABLE `exam_terminals`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `manage_class`
--
ALTER TABLE `manage_class`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `manage_subject`
--
ALTER TABLE `manage_subject`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `manage_subject_teacher`
--
ALTER TABLE `manage_subject_teacher`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
