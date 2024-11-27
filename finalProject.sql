-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 144.76.227.84
-- Generation Time: Nov 24, 2024 at 12:44 AM
-- Server version: 10.11.9-MariaDB-log
-- PHP Version: 8.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db10444`
--

-- --------------------------------------------------------

--
-- Table structure for table `ai requirements_compulsory`
--

CREATE TABLE `ai requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ai requirements_compulsory`
--

INSERT INTO `ai requirements_compulsory` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('AI 310', 'Artificial Intelligence', '3', 'Algorithms '),
('AI 320', 'Convex Optimization Theory', '3', 'Mathematics -2 '),
('AI 330 ', 'Machine Learning ', '3', 'Probability and Statistics - 2'),
('AI 335', 'Neural Networks & deeplearning', '3', 'Machine Learning '),
('AI 360', 'Natural Language Processing', '3', 'Artificial Intelligence'),
('AI 370', 'Advanced Machine Learning ', '3', 'Machine Learning '),
('AI 420', 'Evolutionary Algorithm', '3', 'Convex Optimization Theory'),
('AI 430', 'Computational Intelligence', '3', 'Artificial Intelligence'),
('AI 460', 'Natural Language Understanding', '3', 'Natural Language Processing'),
('AI 498', 'Project', '6', 'Software Engineering - 1\nAnd according to Article 8'),
('IS 365', 'Big Data Technologies', '3', 'Database Systems -1'),
('IT 441', 'Image processing -1 ', '3', 'Signals and Systems');

-- --------------------------------------------------------

--
-- Table structure for table `ai requirements_electives`
--

CREATE TABLE `ai requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ai requirements_electives`
--

INSERT INTO `ai requirements_electives` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('AI 350', 'Data Visualization', '3', 'Probability and Statistics -2'),
('AI 380', 'Human Computer Interaction', '3', 'Artificial Intelligence'),
('AI 435', 'Spoken language Processing ', '3', 'Natural Language Processing '),
('AI 457', 'Knowledge representation', '3', 'Artificial Intelligence'),
('AI 490', 'Bioinformatics', '3', 'Artificial Intelligence'),
('AI 496', 'Selected Topics in Artificial Intelligence', '3', 'Level 4'),
('CS 416', 'Advanced Algorithms ', '3', 'Algorithms '),
('CS 460', 'Distributed systems and Cloud Computing', '3', 'Computers Network -1'),
('CS 471', 'Parallel Processing and high Performance Computing', '3', 'Operating Systems -1'),
('CS 480', 'Cryptography', '3', 'Probability and Statistics - 1'),
('IS 312', 'Database Systems -2', '3', 'Database Systems -1'),
('IS 360', 'Intorduction to Data Science ', '3', 'Database Systems -2'),
('IT 312', 'Microprocessors', '3', 'Logic Design'),
('IT 341\r\n', 'Digital Signal Processing', '3', 'Discrete Mathematics'),
('IT 414', 'Embedded Systems', '3', 'Microprocessors'),
('IT 415', 'Robotics', '3', 'Discrete Mathematics'),
('IT 425', 'Embedded Internet of things System', '3', 'Embedded Systems'),
('IT 443', 'Speech Processing', '3', 'Signals and Systems'),
('IT 444', 'Computer Vision', '3', 'Algorithms');

-- --------------------------------------------------------

--
-- Table structure for table `cs requirements_compulsory`
--

CREATE TABLE `cs requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cs requirements_compulsory`
--

INSERT INTO `cs requirements_compulsory` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('342CS', 'Operating Systems-2', '3', 'Operating Systems-1'),
('AI 310', 'Artificial Intelligence', '3', 'Algorithms'),
('AI 330', 'Machine Learning', '3', 'Probability and Statistics-2'),
('CS 322', 'Computer Organization', '3', 'Logic Design'),
('CS 352', 'Software Engineering-2', '3', 'Software Engineering-1'),
('CS 405', 'Theory of Computation', '3', 'Discrete Mathematics'),
('CS 419', 'Compilers', '3', 'Data Structures'),
('CS 460', 'Distributed systems and Cloud Computing', '3', 'Computer Networks-1'),
('CS 471', 'Parallel Processing and high Performance Computing', '3', 'Operating Systems-1'),
('CS 498', 'Project', '6', 'SoftwareEngineering-1 \r\nAnd according to Article 8'),
('IT 331', 'Computer Graphics-1', '3', 'Programming-1'),
('IT 423', 'Information and Computer Networks Security', '3', 'Computer Networks-1');

-- --------------------------------------------------------

--
-- Table structure for table `cs requirements_electives`
--

CREATE TABLE `cs requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cs requirements_electives`
--

INSERT INTO `cs requirements_electives` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('AI 335', 'Neural Networks & deep learning', '3', 'Machine Learning'),
('AI 350', 'Data Visualization', '3', 'Probability and Statistics-2'),
('AI 360', 'Natural Language Processing', '3', 'Artificial Intelligence'),
('AI 380', 'Human Computer Interaction', '3', 'Artificial Intelligence'),
('CS 410', 'Concepts of Programming Languages', '3', 'Programming-1'),
('CS 416', 'Advanced Algorithms', '3', 'Algorithms'),
('CS 480', 'Cryptography', '3', 'Probability and Statistics-1'),
('CS 496', 'Selected Topics in Computer Science', '3', 'Level 4'),
('IS 312', 'Database Systems-2', '3', 'Database Systems-1'),
('IS 434', 'Quality Assurance of Information Systems and Programming', '3', 'System Analysis and Design-2'),
('IT 312', 'Microprocessors', '3', 'Logic Design'),
('IT 342', 'Pattern Recognitions ', '3', '-'),
('IT 414', 'Embedded Systems', '3', 'Microprocessors'),
('IT 433 ', 'Multimedia', '3', 'Programming-1'),
('IT 441', 'Image processing-1', '3', 'Signals and Systems '),
('IT 444', 'Computer Vision', '3', 'Algorithms');

-- --------------------------------------------------------

--
-- Table structure for table `faculty requirements_compulsory`
--

CREATE TABLE `faculty requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faculty requirements_compulsory`
--

INSERT INTO `faculty requirements_compulsory` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('CS 111', 'Introduction to Computers', '3', '-'),
('CS 112', 'Programming-1', '3', 'Introduction to Computers'),
('CS 213', 'Programming-2', '3', 'Programming-1'),
('CS 214', 'Data Structures', '3', 'Programming-1'),
('CS 221', 'Logic Design', '3', '-'),
('CS 241', 'Operating Systems-1', '3', 'Programming-1'),
('CS 251', 'Software Engineering-1', '3', 'Programming-1'),
('CS 316', 'Algorithms', '3', 'Data Structures'),
('IS 211', 'Database System-1', '3', '-'),
('IS 231', 'Fundamentals of Information Systems', '3', '-'),
('IS 240', 'Operations Research', '3', '-'),
('IS 351 ', 'System Analysis and Design-1', '3', 'Fundamentals of Information Systems'),
('IT 111', 'Electronics-1', '3', '-'),
('IT 221 ', 'Data Communication', '3', 'Probability and Statistics1'),
('IT 222', 'Computer Networks-1', '3', 'Database System-1'),
('IT 223', 'Internet Technology', '3', '-'),
('MA 111', 'Mathematics-1', '3', '-'),
('MA 112', 'Discrete Mathematics', '3', '-'),
('MA 113', 'Mathematics–3', '3', 'Mathematics-1'),
('PH 111', 'Physics', '3', '-'),
('ST 121', 'Probability and Statistics1', '3', '-');

-- --------------------------------------------------------

--
-- Table structure for table `faculty requirements_electives`
--

CREATE TABLE `faculty requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faculty requirements_electives`
--

INSERT INTO `faculty requirements_electives` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('342 IS', 'Simulation Languages', '3', 'Modeling and Simulation'),
('CS 313 ', 'Programming-3‬', '3', 'Programming-2'),
('HU 122', 'Fundamentals of Management', '3', '-'),
('IS 241', 'Modeling and Simulation', '3', '-'),
('IS 321', 'Projects Management', '3', 'Operations Research'),
('IT 211', 'Computer Maintenance', '3', '-'),
('IT 241', 'Signals and Systems', '3', 'Mathematics-2'),
('ST 122 ', 'Probability and Statistics-2 ', '3', 'Probability and Statistics1');

-- --------------------------------------------------------

--
-- Table structure for table `general requirements_compulsory`
--

CREATE TABLE `general requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `general requirements_compulsory`
--

INSERT INTO `general requirements_compulsory` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('HU 111', 'English-1', '2', '-'),
('HU 112', 'English-2', '2', '-'),
('HU 313', 'Human Rights', '2', '-');

-- --------------------------------------------------------

--
-- Table structure for table `general requirements_electives`
--

CREATE TABLE `general requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `general requirements_electives`
--

INSERT INTO `general requirements_electives` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('323 H', 'Fundamentals of Accounting ', '3', '-'),
('HU 121', 'Fundamentals of Economics', '3', '-'),
('HU 213', 'English-3', '3', 'English-1,2'),
('HU 331', 'Communication & Negotiation Skills ', '3', '-'),
('HU 332', 'Creative Thinking', '3', '-'),
('HU 333', 'Mass Communication', '3', '-'),
('HU 334', 'Professional Ethics ', '3', '-');

-- --------------------------------------------------------

--
-- Table structure for table `is requirements_compulsory`
--

CREATE TABLE `is requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `is requirements_compulsory`
--

INSERT INTO `is requirements_compulsory` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('IS 312', 'Database Systems – 2', '3', 'Database Systems – 1'),
('IS 313', 'Data Storage and Retrieval', '3', 'Database Systems – 1'),
('IS 333', 'ManagementInformation Systems', '3', 'Fundamentals of Information\r\nSystems'),
('IS 345', 'Internet Applications', '3', 'Internet Technology'),
('IS 350', 'Business intelligence and data Analytical', '3', 'Probability and Statistics -2 '),
('IS 352', 'Analysis and Design ofInformation Systems-2', '3', 'System Analysis and Design –1'),
('IS 360', 'Introduction to Data Science', '3', 'Database Systems – 2'),
('IS 365', 'Big Data Technologies', '3', 'Database Systems – 1'),
('IS 414', 'Information Systems Security', '3', 'Database Systems – 1'),
('IS 448', 'Knowledge base management', '3', 'Database Systems – 2'),
('IS 451', 'Decision Support Systems', '3', 'Fundamentals of Information Systems'),
('IS 498', 'Project', '6', 'System Analysis andDesign –1\nAnd according to Article 8');

-- --------------------------------------------------------

--
-- Table structure for table `is requirements_electives`
--

CREATE TABLE `is requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `is requirements_electives`
--

INSERT INTO `is requirements_electives` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('AI 310', 'Artificial Intelligence', '3', 'Algorithms'),
('CS 352', 'Software Engineering -2 ', '3', 'Software Engineering -1'),
('IS 334', 'Accounting Information Systems', '3', 'Fundamentals of Information Systems'),
('IS 415', 'Object Oriented Database', '3', 'Database Systems – 1'),
('IS 416', 'Distributed Database', '3', 'Database Systems – 1'),
('IS 421', 'Data Mining', '3', 'Database Systems – 1'),
('IS 422', 'Data Warehousing ', '3', 'Database Systems – 1'),
('IS 434', 'Quality Assurance of Information Systems and Programming', '3', 'Analysis and Design of Information Systems-2'),
('IS 435', 'Information Centers Management', '3', '-'),
('IS 441', 'Intelligent Information Systems', '3', 'Artificial Intelligence'),
('IS 442', 'E-Commerce', '3', 'Internet Applications'),
('IS 443', 'Geographical Information Systems', '3', 'Database Systems – 1'),
('IS 444', 'Multimedia Information Systems ', '3', 'Database Systems – 1'),
('IS 450', 'Software testing and integration', '3', 'Analysis and Design of Information Systems-2'),
('IS 453', 'Information Systems Development Methodologies', '3', 'Analysis and Design of Information Systems-2'),
('IS 455', 'Software Quality Assurance and Testing', '3', 'Fundamentals of Information Systems'),
('IS 460', 'Introduction to deep learning', '3', 'Knowledge base management'),
('IS 496', 'Selected Topics in Information Systems ', '3', 'Level 4'),
('IT 423', 'Information and Computer Networks Security', '3', 'Computers Network -1 ');

-- --------------------------------------------------------

--
-- Table structure for table `it requirements_compulsory`
--

CREATE TABLE `it requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `it requirements_compulsory`
--

INSERT INTO `it requirements_compulsory` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('AI 310', 'Artificial Intelligence', '3', 'Algorithms'),
('IT 311', 'Computer Architecture', '3', 'Logic Design'),
('IT 321', 'Communication Technology', '3', 'Data Communication '),
('IT 322', 'Computers Network-2', '3', 'Computers Network-1'),
('IT 331', 'Computer Graphics – 1', '3', 'Programming-1'),
('IT 341', 'Digital Signal Processing', '3', 'Discrete Mathematics'),
('IT 342', 'Pattern Recognitions', '3', '-'),
('IT 423', 'Information and Computer Networks Security', '3', 'Computers Network-1'),
('IT 433', 'Multimedia', '3', 'Programming-1'),
('IT 441', 'Image Processing – 1', '3', 'Signals and Systems'),
('IT 444', 'Computer Vision', '3', 'Algorithms'),
('IT 498', 'Project', '6', 'Computers Network-1\r\nAnd according to Article 8');

-- --------------------------------------------------------

--
-- Table structure for table `it requirements_electives`
--

CREATE TABLE `it requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name` longtext NOT NULL,
  `hours` longtext NOT NULL,
  `prerequest` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `it requirements_electives`
--

INSERT INTO `it requirements_electives` (`code`, `course_Name`, `hours`, `prerequest`) VALUES
('CS 352', 'Software Engineering – 2', '3', 'Software Engineering – 1'),
('IS 312', 'Database Systems – 2', '3', 'Database Systems – 1'),
('IS 345', 'Internet Applications', '3', 'Internet Technology'),
('IT 312', 'Microprocessors', '3', 'Logic Design'),
('IT 313', 'Computer Interfaces', '3', 'Computer Architecture'),
('IT 332', 'Computer Graphics – 2', '3', 'Computer Graphics – 1'),
('IT 411', 'Distributed and Parallel computer systems', '3', 'Computer Architecture'),
('IT 412', 'Real Time Systems', '3', 'Computer Architecture'),
('IT 414', 'Embedded Systems', '3', 'Microprocessors'),
('IT 415', 'Robotics', '3', 'Discrete Mathematics'),
('IT 422', 'Wireless and Mobile Networks', '3', 'Computer Networks - 2'),
('IT 425', 'Embedded Internet of things System', '3', 'Embedded Systems'),
('IT 431', 'Virtual Reality', '3', 'Computer Graphics-1'),
('IT 442', 'Image Processing – 2', '3', 'Image Processing – 1'),
('IT 443', 'Speech Processing', '3', 'Signals and Systems'),
('IT 455', 'Image, audio and Video Processing', '3', 'Speech Processing'),
('IT 456', '3D Modeling and Animation', '3', 'Computer Graphics - 1'),
('IT 457', 'Development Game', '3', 'Computer Graphics - 1'),
('IT 496', 'Selected Topics in Information Technology', '3', 'Level 4');

-- --------------------------------------------------------

--
-- Table structure for table `registers`
--

CREATE TABLE `registers` (
  `Id` int(11) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `FirstName` longtext NOT NULL,
  `LastName` longtext NOT NULL,
  `Password` longtext NOT NULL,
  `Token` longtext NOT NULL,
  `role` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `registers`
--

INSERT INTO `registers` (`Id`, `Email`, `FirstName`, `LastName`, `Password`, `Token`, `role`) VALUES
(1, 'user@example.com', 'string', 'string', '$2a$11$RFTHdTPkPF0pDxXYZwM89.PHsKZreL7UJLv4.xMpMszhPHqLgNHK6', 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjEiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJ1c2VyQGV4YW1wbGUuY29tIiwianRpIjoiYzM2Y2M4MDAtZWY1NS00NjIzLThiNmYtYmVkNGVlZTIyZmYzIiwiZXhwIjoiMTczMjQ0MDY1NCIsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NzE1NSIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3Q6NTAwMCJ9.oFJWxG4_sHwekEXFsyS4r1tOaQWfhAOSPE-GMOAObVU', 'Admin'),
(2, 'use1r@example.com', 'string', 'string', '$2a$11$c.g8gw5aXNc7Ev0CXHnW0upa4015FT8Op7y75QAd0X7aTjS2f363i', 'null', 'Student'),
(3, 'abdalrahmanaaziz3@gmail.com', 'abdalrahman', 'abdelaziz', '$2a$11$wp9iz16XDjUM17g4ZspYb.yj9KAnWgLrz3q0e/rnHqY/xkxmTQ/J6', 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjMiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJhYmRhbHJhaG1hbmFheml6M0BnbWFpbC5jb20iLCJqdGkiOiJjMjI2NzM4ZS0zNTI3LTQzZTgtYTZkYS1mZGFmYjY2MmRhMzAiLCJleHAiOiIxNzMyNDQxMjAyIiwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo3MTU1IiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo1MDAwIn0.S_W8TuqrggpPldnatEpVYwWo1pKdJ2Cd0v2NZK_Rpes', 'Student'),
(4, 'user123@example.com', 'string', 'string', '$2a$11$XKJZCviX3fA9y3ZP2aujcusLmdKu6glMch2m7xyTo/X0D1pSQgKJu', 'null', 'Student');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20241122105213_allTable', '8.0.10'),
('20241123225022_addTableUSer', '8.0.10');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ai requirements_compulsory`
--
ALTER TABLE `ai requirements_compulsory`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `ai requirements_electives`
--
ALTER TABLE `ai requirements_electives`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `cs requirements_compulsory`
--
ALTER TABLE `cs requirements_compulsory`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `cs requirements_electives`
--
ALTER TABLE `cs requirements_electives`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `faculty requirements_compulsory`
--
ALTER TABLE `faculty requirements_compulsory`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `faculty requirements_electives`
--
ALTER TABLE `faculty requirements_electives`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `general requirements_compulsory`
--
ALTER TABLE `general requirements_compulsory`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `general requirements_electives`
--
ALTER TABLE `general requirements_electives`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `is requirements_compulsory`
--
ALTER TABLE `is requirements_compulsory`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `is requirements_electives`
--
ALTER TABLE `is requirements_electives`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `it requirements_compulsory`
--
ALTER TABLE `it requirements_compulsory`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `it requirements_electives`
--
ALTER TABLE `it requirements_electives`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `registers`
--
ALTER TABLE `registers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `IX_registers_Email` (`Email`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `registers`
--
ALTER TABLE `registers`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
