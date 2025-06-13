-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 178.63.129.214
-- Generation Time: Jun 12, 2025 at 08:52 PM
-- Server version: 10.11.11-MariaDB-log
-- PHP Version: 8.2.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db20723`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`db20723`@`%` PROCEDURE `POMELO_AFTER_ADD_PRIMARY_KEY` (IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255), IN `COLUMN_NAME_ARGUMENT` VARCHAR(255))   BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID INT(11);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
			AND `COLUMN_TYPE` LIKE '%int%'
			AND `COLUMN_KEY` = 'PRI';
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL AUTO_INCREMENT;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END$$

CREATE DEFINER=`db20723`@`%` PROCEDURE `POMELO_BEFORE_DROP_PRIMARY_KEY` (IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255))   BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID TINYINT(1);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `Extra` = 'auto_increment'
			AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `ai requirements_compulsory`
--

CREATE TABLE `ai requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ai requirements_compulsory`
--

INSERT INTO `ai requirements_compulsory` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('AI 310', 'Artificial Intelligence', 'الذكاء الاصطناعي', 3, 'Algorithms', 'الخوارزميات'),
('AI 320', 'Convex Optimization Theory', 'نظرية التحسين المحدب', 3, 'Mathematics-2', 'الرياضيات-2'),
('AI 330', 'Machine Learning', 'تعلم الآلة', 3, 'Probability and Statistics-2', 'الاحتمالات والإحصاء-2'),
('AI 335', 'Neural Networks & deeplearning', 'الشبكات العصبية والتعلم العميق', 3, 'Machine Learning', 'تعلم الآلة'),
('AI 360', 'Natural Language Processing', 'معالجة اللغة الطبيعية', 3, 'Artificial Intelligence', 'الذكاء الاصطناعي'),
('AI 370', 'Advanced Machine Learning', 'تعلم الآلة المتقدم', 3, 'Machine Learning', 'تعلم الآلة'),
('AI 420', 'Evolutionary Algorithm', 'الخوارزميات التطورية', 3, 'Convex Optimization Theory', 'نظرية التحسين المحدب'),
('AI 430', 'Computational Intelligence', 'الذكاء الحسابي', 3, 'Artificial Intelligence', 'الذكاء الاصطناعي'),
('AI 460', 'Natural Language Understanding', 'فهم اللغة الطبيعية', 3, 'Natural Language Processing', 'معالجة اللغة الطبيعية'),
('AI 498', 'Project', 'مشروع التخرج', 6, 'Software Engineering-1', 'هندسة البرمجيات-1'),
('IS 365', 'Big Data Technologies', 'تقنيات البيانات الضخمة', 3, 'Database Systems-1', 'أنظمة قواعد البيانات-1'),
('IT 441', 'Image processing-1', 'معالجة الصور-1', 3, 'Signals and Systems', 'الإشارات والأنظمة');

-- --------------------------------------------------------

--
-- Table structure for table `ai requirements_electives`
--

CREATE TABLE `ai requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ai requirements_electives`
--

INSERT INTO `ai requirements_electives` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('AI 350', 'Data Visualization', 'تصوير البيانات', 3, 'Probability and Statistics-2', 'الاحتمالات والإحصاء-2'),
('AI 380', 'Human Computer Interaction', 'تفاعل الإنسان والحاسوب', 3, 'Artificial Intelligence', 'الذكاء الاصطناعي'),
('AI 435', 'Spoken language Processing', 'معالجة اللغة المنطوقة', 3, 'Natural Language Processing', 'معالجة اللغة الطبيعية'),
('AI 457', 'Knowledge representation', 'تمثيل المعرفة', 3, 'Artificial Intelligence', 'الذكاء الاصطناعي'),
('AI 490', 'Bioinformatics', 'المعلوماتية الحيوية', 3, 'Artificial Intelligence', 'الذكاء الاصطناعي'),
('AI 496', 'Selected Topics in Artificial Intelligence', 'مواضيع مختارة في الذكاء الاصطناعي', 3, 'Level 4', 'المستوى الرابع'),
('CS 416', 'Advanced Algorithms', 'الخوارزميات المتقدمة', 3, 'Algorithms', 'الخوارزميات'),
('CS 460', 'Distributed systems and Cloud Computing', 'الأنظمة الموزعة والحوسبة السحابية', 3, 'Computers Network-1', 'شبكات الحاسوب-1'),
('CS 471', 'Parallel Processing and high Performance Computing', 'المعالجة المتوازية والحوسبة عالية الأداء', 3, 'Operating Systems-1', 'أنظمة التشغيل-1'),
('CS 480', 'Cryptography', 'التشفير', 3, 'Probability and Statistics-1', 'الاحتمالات والإحصاء-1'),
('IS 312', 'Database Systems-2', 'أنظمة قواعد البيانات-2', 3, 'Database Systems-1', 'أنظمة قواعد البيانات-1'),
('IS 360', 'Intorduction to Data Science', 'مقدمة في علم البيانات', 3, 'Database Systems-2', 'أنظمة قواعد البيانات-2'),
('IT 312', 'Microprocessors', 'المعالجات الدقيقة', 3, 'Logic Design', 'تصميم المنطق'),
('IT 341', 'Digital Signal Processing', 'معالجة الإشارات الرقمية', 3, 'Discrete Mathematics', 'الرياضيات المتقطعة'),
('IT 414', 'Embedded Systems', 'الأنظمة المضمنة', 3, 'Microprocessors', 'المعالجات الدقيقة'),
('IT 415', 'Robotics', 'الروبوتات', 3, 'Discrete Mathematics', 'الرياضيات المتقطعة'),
('IT 425', 'Embedded Internet of things System', 'أنظمة إنترنت الأشياء المضمنة', 3, 'Embedded Systems', 'الأنظمة المضمنة'),
('IT 443', 'Speech Processing', 'معالجة الكلام', 3, 'Signals and Systems', 'الإشارات والأنظمة'),
('IT 444', 'Computer Vision', 'رؤية الحاسوب', 3, 'Algorithms', 'الخوارزميات');

-- --------------------------------------------------------

--
-- Table structure for table `chathistories`
--

CREATE TABLE `chathistories` (
  `Id` int(11) NOT NULL,
  `Title` longtext DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `StudentId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chathistories`
--

INSERT INTO `chathistories` (`Id`, `Title`, `CreatedAt`, `StudentId`) VALUES
(1, 'ماذا يدرس الطالب في قسم علوم الحاسب', '2025-05-29 09:16:09.090878', 1),
(3, 'ماذا يدرس الطالب في قسم تكنولوجيا المعلومات؟', '2025-05-29 09:21:55.832529', 1),
(18, 'hi]', '2025-05-30 23:03:17.004269', 2),
(74, 'ؤؤؤؤؤؤؤؤؤؤؤؤؤ', '2025-06-05 15:25:47.399510', 2),
(83, 'ffffffff', '2025-06-05 15:47:05.546144', 2),
(85, 'الحضور عليه درجات؟', '2025-06-05 16:15:00.892901', 2),
(105, 'المفروض عشان انجح ف مادة اجيب كام', '2025-06-05 18:06:38.907794', 2),
(106, 'للل', '2025-06-05 18:07:23.223153', 2),
(116, NULL, '2025-06-07 15:08:46.639489', 2),
(117, NULL, '2025-06-07 15:08:53.124333', 2),
(118, NULL, '2025-06-07 15:20:13.792769', 2),
(119, NULL, '2025-06-07 16:11:56.121989', 2),
(120, 'فى غياب؟', '2025-06-07 16:11:56.121997', 2),
(121, NULL, '2025-06-07 17:31:27.614916', 2),
(122, NULL, '2025-06-07 18:02:02.323954', 2),
(123, NULL, '2025-06-07 18:02:03.097545', 2),
(124, NULL, '2025-06-07 18:02:01.980082', 2),
(125, NULL, '2025-06-07 18:02:01.935759', 2),
(126, NULL, '2025-06-07 18:02:02.547165', 2),
(127, NULL, '2025-06-07 18:02:01.936368', 2),
(128, NULL, '2025-06-07 18:02:02.138938', 2),
(129, NULL, '2025-06-07 18:02:16.016956', 2),
(130, NULL, '2025-06-07 18:40:00.884435', 2),
(131, 'فى درجات على الغياب؟', '2025-06-07 20:36:17.709089', 2),
(132, 'هاي', '2025-06-07 20:40:31.923018', 2),
(133, 'الحضور عليه غياب؟', '2025-06-08 02:58:37.818544', 2),
(134, NULL, '2025-06-08 03:03:02.370956', 2),
(135, NULL, '2025-06-08 16:42:33.310425', 2),
(136, NULL, '2025-06-08 22:41:28.464346', 2),
(137, NULL, '2025-06-08 22:55:40.885941', 2),
(138, NULL, '2025-06-08 23:03:18.219230', 2),
(139, NULL, '2025-06-08 23:03:24.215612', 2),
(140, NULL, '2025-06-08 23:03:41.647849', 2),
(141, NULL, '2025-06-08 23:04:04.706758', 2),
(142, NULL, '2025-06-08 23:04:14.170794', 2),
(143, NULL, '2025-06-08 23:04:26.550554', 2),
(144, NULL, '2025-06-08 23:17:37.029529', 2),
(145, NULL, '2025-06-08 23:21:40.683667', 2),
(146, NULL, '2025-06-08 23:21:45.232720', 2),
(147, NULL, '2025-06-08 23:22:01.397072', 2),
(148, NULL, '2025-06-08 23:46:58.107075', 2),
(149, NULL, '2025-06-08 23:48:39.233047', 2),
(150, NULL, '2025-06-08 23:55:54.087789', 2),
(151, NULL, '2025-06-09 00:02:58.227158', 2),
(152, NULL, '2025-06-09 00:03:16.947402', 2),
(153, NULL, '2025-06-09 00:12:13.540603', 2),
(154, NULL, '2025-06-09 00:12:19.242691', 2),
(155, NULL, '2025-06-09 00:18:36.431780', 2),
(156, 'فى غياب ف الكلية؟', '2025-06-09 17:08:47.434519', 2),
(157, 'hi', '2025-06-09 21:22:58.925455', 2),
(158, 'ايه مواد قسم it', '2025-06-09 21:37:49.147550', 2),
(159, NULL, '2025-06-09 21:44:58.433617', 2),
(160, NULL, '2025-06-09 22:20:39.431316', 2),
(161, NULL, '2025-06-09 22:21:01.231302', 2),
(162, NULL, '2025-06-09 22:24:16.331707', 2),
(163, NULL, '2025-06-09 22:24:52.935931', 2),
(164, 'ايه مواد قسم cs', '2025-06-09 22:29:04.384785', 2),
(165, 'hi', '2025-06-09 22:32:03.683610', 2),
(166, 'hi', '2025-06-09 22:57:15.719153', 1),
(167, 'اهلا', '2025-06-09 22:58:22.972243', 1),
(168, NULL, '2025-06-09 22:58:29.501371', 2),
(169, NULL, '2025-06-09 22:58:56.231455', 2),
(170, 'ازيك ', '2025-06-09 22:59:56.796731', 2),
(171, 'hi', '2025-06-10 09:16:53.697496', 1),
(172, 'ازيك ', '2025-06-10 19:09:41.970615', 2),
(173, 'Hello', '2025-06-10 19:22:25.611147', 1),
(174, NULL, '2025-06-10 20:26:42.477380', 2),
(175, NULL, '2025-06-10 20:27:27.517951', 2),
(176, 'How are you', '2025-06-10 20:37:07.798093', 1),
(177, NULL, '2025-06-10 20:59:24.818868', 2),
(178, NULL, '2025-06-10 21:56:23.461771', 2),
(179, NULL, '2025-06-10 23:08:41.241144', 2),
(180, 'فى غياب ف الكلية', '2025-06-10 23:09:55.869952', 2),
(181, NULL, '2025-06-10 23:15:51.435507', 2),
(182, 'Hi', '2025-06-10 23:30:48.465711', 1),
(183, 'انا عايز اعرف فى غياب ف الكلية ولا لا', '2025-06-11 03:00:35.201966', 2),
(184, 'اه', '2025-06-11 03:03:56.001880', 2),
(185, 'I want to know if there is an attendence', '2025-06-11 03:05:32.840132', 2),
(186, 'ازيك', '2025-06-11 03:09:02.253128', 2),
(187, 'اهلا يعم', '2025-06-11 03:11:49.869494', 2),
(188, 'اهلا يعم', '2025-06-11 03:18:50.661332', 2),
(189, 'اهلا يعم', '2025-06-11 03:23:37.953326', 2),
(190, 'i want to know if there is an attedndence', '2025-06-11 03:25:53.345566', 2),
(191, 'اهلا يعم', '2025-06-11 03:30:20.564237', 2),
(192, 'i want to know if there is attendence ', '2025-06-11 03:32:21.622437', 2),
(193, 'hi', '2025-06-11 11:21:42.912973', 1),
(194, 'موعد انتهاء الامتحانات لهذا العام ', '2025-06-11 15:27:13.090803', 2),
(195, NULL, '2025-06-11 15:42:10.448726', 2);

-- --------------------------------------------------------

--
-- Table structure for table `chathistoriespdf`
--

CREATE TABLE `chathistoriespdf` (
  `Id` int(11) NOT NULL,
  `Title` longtext DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `StudentId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chathistoriespdf`
--

INSERT INTO `chathistoriespdf` (`Id`, `Title`, `CreatedAt`, `StudentId`) VALUES
(2, 'Solution Structure Explanation', '2025-06-07 04:33:31.818428', 1),
(3, NULL, '2025-06-08 23:53:51.338183', 2),
(4, NULL, '2025-06-08 23:54:22.315719', 2),
(5, NULL, '2025-06-09 01:08:53.784774', 1),
(6, NULL, '2025-06-09 01:12:45.041591', 2),
(7, NULL, '2025-06-09 21:45:07.647915', 2),
(8, 'what is the refferenes at this pdf', '2025-06-09 22:04:16.814435', 2),
(9, NULL, '2025-06-09 22:20:43.498612', 2),
(10, NULL, '2025-06-09 22:24:13.176031', 2),
(11, NULL, '2025-06-09 22:33:37.586587', 2),
(12, NULL, '2025-06-09 22:41:30.655326', 2),
(13, 'OverView', '2025-06-09 22:58:58.017199', 1),
(14, NULL, '2025-06-09 22:59:01.409056', 2),
(15, 'what is this pdf about?', '2025-06-09 23:07:45.338972', 2),
(16, 'What is the overview', '2025-06-10 19:30:19.926459', 1),
(17, NULL, '2025-06-10 20:53:12.473210', 2),
(18, NULL, '2025-06-10 23:10:55.677961', 2),
(19, 'What is the title of this pdf', '2025-06-10 23:15:53.467662', 2),
(20, NULL, '2025-06-10 23:29:12.392315', 1),
(21, 'what is hacking?', '2025-06-11 03:36:02.316732', 2),
(22, NULL, '2025-06-11 03:42:11.130923', 2),
(23, NULL, '2025-06-11 03:44:26.975648', 2),
(24, 'what is hacking', '2025-06-11 03:54:19.550228', 2),
(25, NULL, '2025-06-11 03:57:10.008393', 2),
(26, NULL, '2025-06-11 04:00:26.937662', 2),
(27, 'What is the technologis in used?', '2025-06-11 05:40:14.123315', 1),
(28, 'Inroduction', '2025-06-11 07:08:10.570081', 1),
(29, 'what is hacking?', '2025-06-11 07:45:53.201099', 2),
(30, 'اسماء الفريق', '2025-06-11 08:11:28.524075', 1),
(31, 'what is hacking?', '2025-06-11 09:12:22.316964', 2),
(32, 'what is hacking?', '2025-06-11 09:57:35.070748', 2),
(33, 'what is hacking?', '2025-06-11 10:17:42.929468', 2),
(34, 'what is the technologies uesd', '2025-06-11 10:25:52.219891', 1),
(35, 'What is my name', '2025-06-11 11:23:31.011437', 1),
(36, 'what is hacking?', '2025-06-11 18:56:13.208990', 2);

-- --------------------------------------------------------

--
-- Table structure for table `chatmessagepdfs`
--

CREATE TABLE `chatmessagepdfs` (
  `MessageId` int(11) NOT NULL,
  `Question` longtext DEFAULT NULL,
  `Answer` longtext DEFAULT NULL,
  `StudentId` int(11) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `ChatId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chatmessagepdfs`
--

INSERT INTO `chatmessagepdfs` (`MessageId`, `Question`, `Answer`, `StudentId`, `CreatedAt`, `ChatId`) VALUES
(1, 'Solution Structure Explanation', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-07 04:39:23.989196', 2),
(2, 'OrderBy', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-07 04:50:03.923340', 2),
(3, 'Architecture Style', 'Onion Architecture', 1, '2025-06-07 04:55:02.788799', 2),
(4, 'overview', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-08 16:39:41.571072', 2),
(5, 'overview', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-08 16:41:34.583065', 2),
(6, 'overview', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-08 16:46:15.591299', 2),
(7, 'overview', 'enabling students to register, manage their academic courses, and calculate their GPA', 1, '2025-06-08 16:58:52.502984', 2),
(8, 'what is the refferenes at this pdf', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-09 22:07:17.285386', 8),
(9, 'summrize this pdf', 'Extracts PDF content, performs semantic search, and generates context-aware answers', 2, '2025-06-09 22:12:21.827639', 8),
(10, 'OverView', 'answers college-related questions', 1, '2025-06-09 22:59:58.946557', 13),
(11, 'what is this pdf about?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-09 23:10:03.774339', 15),
(12, 'what is this pdf about?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-09 23:12:01.016212', 15),
(13, 'What is the overview', 'academic procedures, student responsibilitie s, registration policies, and support services', 1, '2025-06-10 19:31:16.537589', 16),
(14, 'What is the title of this pdf', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-10 23:19:24.128519', 19),
(15, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 03:39:02.631875', 21),
(16, 'what is hacking', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 03:56:44.333773', 24),
(17, 'What is the technologis in used?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-11 05:42:50.688090', 27),
(18, 'What is the technologis in used?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-11 05:46:58.756484', 27),
(19, 'What is the technologis in used?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-11 06:06:49.923736', 27),
(20, 'Inroduction', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-11 07:11:43.014984', 28),
(21, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 07:50:13.690443', 29),
(22, 'what is hacking?', 'When a computer or network is accessed by an unauthorized source, usually for malicious reasons.', 2, '2025-06-11 07:56:07.446949', 29),
(23, 'what is hacking?', 'When a computer or network is accessed by an unauthorized source, usually for malicious reasons.', 2, '2025-06-11 07:57:56.027659', 29),
(24, 'what is the need for ethical hacking?', 'Session hijacking', 2, '2025-06-11 07:58:25.617838', 29),
(25, 'what is Confidentiality?', 'You must safeguard the information that you have and know. It becomes your responsibility to ensure that the information does not fall into the wrong hands. You can protect the information with appropriate permissions and encryption. If these are not applied, there are chances of disclosure, which allows an unauthorized person to access the information.', 2, '2025-06-11 07:59:51.832538', 29),
(26, 'what is the need for ethical hacking?', 'Task 2 - The Need for Ethical Hacking All systems on the internet are considered to be at risk. To be able to protect the systems of your organizations, you must know the methods used by the hackers, and the steps that you can take to prevent their attacks. Task 4 - The Ethical Aspect of Ethical Hacking An ethical hacker must follow professional principles and the code of ethics. Task 5 - Types of Threat Actors As an ethical hacker, you must know about different types of threat actors, who are any entity behind a threat, which is a potential danger to an asset.', 2, '2025-06-11 08:01:48.930615', 29),
(27, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 08:16:37.586149', 29),
(28, 'اسماء الفريق', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-11 08:16:36.941922', 30),
(29, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 08:26:21.432101', 29),
(30, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 08:40:42.557851', 29),
(31, 'what is hacking?', 'The fundamental difference between hacking and ethical hacking is permissions. Hacking is when a computer or network is accessed by an unauthorized source, usually for malicious reasons. Ethical hacking is permitted by a person or an organization.', 2, '2025-06-11 08:47:24.036417', 29),
(32, 'what is confidentiality?', 'Network.', 2, '2025-06-11 08:48:20.334474', 29),
(33, 'what is confidentiality?', 'Network.', 2, '2025-06-11 08:48:49.751349', 29),
(34, 'what is integrity?', 'This lab is designed to prepare you for the Certified Ethical Hacker v10 exam.', 2, '2025-06-11 08:49:29.348777', 29),
(35, 'how can a hacker cover his tracks?', 'An insider threat. An insider threat is an insider threat.', 2, '2025-06-11 08:50:23.941016', 29),
(36, 'اسماء الفريق', 'API Error: InternalServerError', 1, '2025-06-11 08:54:55.092999', 30),
(37, 'what is this pdf about?', 'Black Box White Box Black Box', 2, '2025-06-11 08:57:35.420657', 29),
(38, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 09:01:17.351401', 29),
(39, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 09:08:56.192884', 29),
(40, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 09:14:58.474648', 31),
(41, 'what is hacking?', 'when a computer or network is accessed by an unauthorized source, usually for malicious reasons.', 2, '2025-06-11 09:19:47.895121', 31),
(42, 'what is confidentiality?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 09:21:51.687972', 31),
(43, 'what is the need for ethical hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 09:23:59.663085', 31),
(44, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 09:32:46.755967', 31),
(45, 'overview', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 1, '2025-06-11 09:53:55.358825', 30),
(46, 'what is hacking?', 'Exception: The request was canceled due to the configured HttpClient.Timeout of 100 seconds elapsing.', 2, '2025-06-11 10:00:25.579848', 32),
(47, 'what is hacking?', 'when a computer or network is accessed by an unauthorized source, usually for malicious reasons.', 2, '2025-06-11 10:19:08.778287', 33),
(48, 'what is confidentiality?', 'You must safeguard the information that you have and know. It becomes your responsibility to ensure that the information does not fall into the wrong hands. You can protect the information with appropriate permissions and encryption. If these are not applied, there are chances of disclosure, which allows an unauthorized person to access the information.', 2, '2025-06-11 10:20:44.242845', 33),
(49, 'overview', 'لم يتم العثور على إجابة في الرد.', 1, '2025-06-11 10:23:38.487136', 30),
(50, 'structure', 'لم يتم العثور على إجابة في الرد.', 1, '2025-06-11 10:24:44.613993', 30),
(51, 'what is the technologies uesd', '.NET, ASP.NET Core, and LINQ', 1, '2025-06-11 10:27:18.089801', 34),
(52, 'what is your name', 'Abdullah Mahmoud Abdel Mohsen', 1, '2025-06-11 10:28:24.349725', 34),
(53, 'What is my name', 'Abdullah Mahmoud Abdel Mohsen', 1, '2025-06-11 11:24:08.948472', 35),
(54, 'What is the technology used', 'LINQ', 1, '2025-06-11 11:24:44.233194', 35),
(55, 'what is hacking?', 'when a computer or network is accessed by an unauthorized source, usually for malicious reasons.', 2, '2025-06-11 18:58:53.994996', 36);

-- --------------------------------------------------------

--
-- Table structure for table `chatmessages`
--

CREATE TABLE `chatmessages` (
  `Id` int(11) NOT NULL,
  `Question` longtext DEFAULT NULL,
  `Answer` longtext DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `StudentId` int(11) DEFAULT NULL,
  `ChatHistoryId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chatmessages`
--

INSERT INTO `chatmessages` (`Id`, `Question`, `Answer`, `CreatedAt`, `StudentId`, `ChatHistoryId`) VALUES
(66, 'ماذا يدرس الطالب في قسم تكنولوجيا المعلومات؟', 'يدرس الطالب في قسم تكنولوجيا المعلومات مجالات متنوعة مثل شبكات الحاسبات، وشبكات المعلومات وتطبيقاتها، وتكنولوجيا الاتصالات، وتكنولوجيا الإنترنت، وأمن وسرية المعلومات والشبكات، والتعرف على الأنماط، ومعالجة الإشارات الرقمية، والتعرف على الكلام وتوليده، ومعالجة الصور والتعرف عليها.', '2025-05-29 09:43:36.973102', 1, 3),
(67, 'ماذا يدرس الطالب في قسم تكنولوجيا المعلومات؟', 'يدرس الطالب في قسم تكنولوجيا المعلومات مجالات متنوعة مثل شبكات الحاسبات، وشبكات المعلومات وتطبيقاتها، وتكنولوجيا الاتصالات، وتكنولوجيا الإنترنت، وأمن وسرية المعلومات والشبكات، والتعرف على الأنماط، ومعالجة الإشارات الرقمية، والتعرف على الكلام وتوليده، ومعالجة الصور والتعرف عليها.', '2025-05-29 09:53:18.374478', 1, 3),
(68, 'ماذا يدرس الطالب في قسم علوم الحاسب', 'تشمل المقررات الإجبارية تعلم الآلة، وتنظيم الحاسوب، والرسومات بالحاسوب 1، وهندسة البرمجيات 2، والمعالجة المتوازية والحوسبة عالية الأداء، والذكاء الاصطناعي، والمترجمات، ونظرية الحوسبة، وأنظمة التشغيل 2، والأنظمة الموزعة والحوسبة السحابية، وأمن المعلومات وشبكات الحاسوب، ومشروع التخرج.', '2025-05-29 09:54:00.293568', 1, 3),
(69, 'ماذا يدرس الطالب في قسم علوم الحاسب', 'تشمل المقررات الإجبارية في قسم علوم الحاسب تعلم الآلة، وتنظيم الحاسوب، والرسومات بالحاسوب 1، وهندسة البرمجيات 2، والمعالجة المتوازية والحوسبة عالية الأداء، والذكاء الاصطناعي، والمترجمات، ونظرية الحوسبة، وأنظمة التشغيل 2، والأنظمة الموزعة والحوسبة السحابية، وأمن المعلومات وشبكات الحاسوب، ومشروع التخرج.', '2025-05-29 09:56:27.753483', 1, 1),
(70, 'hi]', 'لا توجد إجابة متوفرة.', '2025-05-30 23:03:46.090288', 2, 18),
(71, 'هل فى غياب فى الكلية؟', 'الكلية تسمح بنسبة غياب محددة لكل مقرر دراسي، وفي حالة تجاوز هذه النسبة، قد يتم حرمان الطالب من التقدم للامتحان النهائي.', '2025-05-30 23:04:17.304292', 2, 18),
(72, 'ؤؤؤؤؤؤؤؤؤؤؤؤؤ', 'لا توجد إجابة متوفرة.', '2025-06-05 15:26:55.501999', 2, 74),
(73, 'ffffffff', 'لا توجد إجابة متوفرة.', '2025-06-05 16:14:44.948588', 2, 83),
(74, 'الحضور عليه درجات؟', 'لا توجد إجابة متوفرة.', '2025-06-05 16:17:50.087898', 2, 85),
(75, 'فلى غياب فى الكلية؟', 'الكلية تسمح بنسبة غياب محددة لكل مقرر دراسي، وفي حالة تجاوز هذه النسبة، قد يتم حرمان الطالب من التقدم للامتحان النهائي.', '2025-06-05 16:18:07.560904', 2, 85),
(76, 'اعمال السنة من كام', 'لا توجد إجابة متوفرة.', '2025-06-05 16:18:28.799792', 2, 85),
(77, 'درجة كل مادة من كام', 'لا توجد إجابة متوفرة.', '2025-06-05 16:18:51.693648', 2, 85),
(78, 'ايه تخصصات الكلية', 'التخصصات الرئيسية تشمل: علوم الحاسب، تكنولوجيا المعلومات، نظم المعلومات، الذكاء الاصطناعي، هندسة البرمجيات، والمعلوماتية الطبية.', '2025-06-05 16:19:13.516431', 2, 85),
(79, 'ماشى', 'لا توجد إجابة متوفرة.', '2025-06-05 18:06:32.875853', 2, 85),
(80, 'المفروض عشان انجح ف مادة اجيب كام', 'يتطلب دخول الطالب الامتحان النهائي تحقيق نسبة حضور لا تقل عن 75% من المحاضرات في كل مقرر.', '2025-06-05 18:07:08.067588', 2, 105),
(81, 'للل', 'لا توجد إجابة متوفرة.', '2025-06-05 18:07:50.131225', 2, 106),
(84, 'فى غياب؟', 'في حالة الغياب عن المحاضرات، يجب على الطالب تقديم عذر مقبول لإدارة الكلية، وإذا تجاوز الغياب النسبة المسموح بها، قد يتم حرمان الطالب من التقدم للامتحان النهائي.', '2025-06-07 16:58:51.410430', 2, 120),
(85, 'فى درجات على الغياب؟', 'الكلية تسمح بنسبة غياب محددة لكل مقرر دراسي، وفي حالة تجاوز هذه النسبة، قد يتم حرمان الطالب من التقدم للامتحان النهائي.', '2025-06-07 20:36:38.797277', 2, 131),
(86, 'هاي', 'لا توجد إجابة متوفرة.', '2025-06-07 20:40:41.032751', 2, 132),
(87, 'عامل ايه انهارده', 'لا توجد إجابة متوفرة.', '2025-06-07 20:40:48.935002', 2, 132),
(88, 'ايه مواد قسم cs', 'المعلومات المتاحة تشمل المقررات الإجبارية مثل تطبيقات الإنترنت، نظم قواعد البيانات 2، تخزين واسترجاع البيانات، تحليل وتصميم نظم المعلومات 2، أمن نظم المعلومات، نظم دعم القرار، نظم المعلومات الإدارية، ذكاء الأعمال وتحليل البيانات، تكنولوجيا البيانات الكبيرة، مقدمة في علم البيانات، إدارة قواعد المعرفة، ومشروع التخرج.', '2025-06-07 20:41:04.065883', 2, 132),
(89, 'ايه المواد الاختيارية ', 'يمكن للطلاب التسجيل في المواد الاختيارية من خلال النظام الإلكتروني خلال الفترة المحددة.', '2025-06-07 20:41:20.202288', 2, 132),
(90, 'الحضور عليه غياب؟', 'في حالة الغياب عن المحاضرات، يجب على الطالب تقديم عذر مقبول لإدارة الكلية، وإذا تجاوز الغياب النسبة المسموح بها، قد يتم حرمان الطالب من التقدم للامتحان النهائي.', '2025-06-08 02:59:31.535030', 2, 133),
(91, 'ايه هى نسبة الغياب اللى اقدر اغيبها', 'يجب ألا تقل نسبة حضورك عن 75% من المحاضرات في كل مقرر، وإذا تجاوزت نسبة غيابك 25% بدون عذر مقبول، قد تُحرم من دخول الامتحان النهائي.', '2025-06-08 02:59:59.775795', 2, 133),
(92, 'hhh', 'لا توجد إجابة متوفرة.', '2025-06-08 17:37:01.387055', 2, 18),
(93, 'ايه اقسام الكلية', 'تضم الكلية 4 أقسام رئيسية: قسم علوم الحاسب، قسم تكنولوجيا المعلومات، قسم نظم المعلومات، وقسم الذكاء الاصطناعي.', '2025-06-08 18:02:12.885005', 2, 18),
(94, 'فى غياب ف الكلية؟', 'مرحبًا! 😊\nالكلية تسمح بنسبة غياب محددة لكل مقرر دراسي. إذا تجاوزت هذه النسبة، قد تُحرم من دخول الامتحان النهائي. يجب عليك تقديم عذر مقبول للكلية في حالة الغياب. تذكر أن نسبة الحضور يجب ألا تقل عن 75% في كل مقرر.', '2025-06-09 17:09:13.579474', 2, 156),
(95, 'hi', 'Hello! 😊\nمرحباً! كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول الكلية أو المقررات الدراسية؟', '2025-06-09 21:23:10.349706', 2, 157),
(96, 'how are u', 'Hello! 😊\nI\'m doing well, thank you for asking! How can I help you today?', '2025-06-09 21:23:26.765757', 2, 157),
(97, 'there is an attendenve?', 'Hello! 😊\nYes, students must achieve an attendance rate of at least 75% in each course. If you are absent, you must provide an acceptable excuse to the college administration. If your absence exceeds the permissible percentage, you may be deprived of applying for the final exam.', '2025-06-09 21:24:20.053405', 2, 157),
(98, 'what is the core courses at cs department', 'Hello! 😊\nThe core courses in the CS department are:\n\n*   Data structures (CS 214) - 3 credit hours\n*   Algorizia (CS 316) - 3 credit hours\n*   Database Systems 1 (IS 211) - 3 credit hours\n*   Systems Analysis and Design 1 (I 351) - 3 credit hours\n*   Computer Networks 1 (IT 222) - 3 credit hours\n*   Operating systems 1 (CS 241) - 3 credit hours\n*   Software Engineering 1 (CS 251) - 3 credit hours\n*   Programming 2 (CS 213) - 3 credit hours\n*   Learn the machine (AI 330) - 3 credit hours\n*   Computer Organization (CS 322) - 3 credit hours\n*   Computer Apartments 1 (IT 331) - 3 credit hours\n*   Software Engineering 2 (CS 352) - 3 credit hours\n*   Parallel treatment and high-performance computing (CS 471) - 3 credit hours\n*   Artificial Intelligence (AI 310) - 3 credit hours\n*   Translations (CS 419) - 3 credit hours\n*   Computing theory (CS 405) - 3 credit hours\n*   Operating Systems 2 (CS 342) - 3 credit hours\n*   Distributed systems and cloud computing (CS 460) - 3 credit hours\n*   Information security and computer networks (IT 423) - 3 credit hours\n*   Graduation Project (CS 498) - 6 credit hours', '2025-06-09 21:30:03.300467', 2, 157),
(99, 'what about rhe electives ', 'Hello! 😊\nThe elective courses include:\n\n*   Possibilities and Statistics 2 (S -122) - 3 credit hours\n*   The Basics of Management (HU 122) - 3 credit hours\n*   Project Management (IS 321) - 3 credit hours\n*   Signs and Systems (IT 241) - 3 credit hours\n*   Modeling and simulation (IS 241) - 3 credit hours\n*   Simulation languages ​​(IS 342) - 3 credit hours\n*   Computer Maintenance (IT 211) - 3 credit hours\n*   Programming 3 (CS 313) - 3 credit hours\n*   Economy Basics (HU 121) - 3 credit hours\n*   English 3 (HU 213) - 3 credit hours\n*   The Basics of Accounting (HU 323) - 3 credit hours\n*   Communication and negotiation skills (HU 331) - 3 credit hours\n*   Creative thinking (HU 332) - 3 credit hours\n*   Media (HU 333) - 3 credit hours\n*   Professional ethics (HU 334) - 3 credit hours\n\nAlso, the student can choose an optional course from at least three courses, including:\n\n1.  A public decision (such as Arabic or English).\n2.  A course that serves specialization (such as computer skills).\n3.  A course related to personal or academic development.', '2025-06-09 21:31:03.625342', 2, 157),
(100, 'i mean the elective of cs department', 'Hello! 😊\nThe elective courses for the CS Department include:\n\n*   Database systems 2 (IS 312) - 3 credit hours\n*   Information and programming systems quality (IS 434) - 3 credit hours\n*   Computer Vision (IT 444) - 3 credit hours\n*   Multimedia (IT 433) - 3 credit hours\n*   Learn about patterns (IT 342) - 3 credit hours\n*   Selected topics in computer science (CS 496) - 3 credit hours\n*   Microelled (IT 312) - 3 credit hours\n*   Criphyth (CS 480) - 3 credit hours\n*   Parallel treatment and high performance computing (CS 471) - 3 credit hours\n*   Distributed systems and cloud computing (CS 460) - 3 credit hours\n*   Integrated systems (IT 414) - 3 credit hours\n*   Advanced algorithms (CS 416) - 3 credit hours\n*   Digital signals (IT 341) - 3 credit hours\n*   The interaction between man and computers (AI 380) - 3 credit hours\n*   Biomatic information (AI 490) - 3 credit hours\n*   Speech therapy (IT 443) - 3 credit hours\n*   Data warehouses (IS 422) - 3 credit hours\n*   Databases distributed (IS 416) - 3 credit hours\n*   Geographical Information Systems (IS 443) - 3 credit hours\n*   Multimedia information systems (IS 444) - 3 credit hours\n*   Computer and information network security (IT 423) - 3 credit hours\n*   Software test and integration (IS 450) - 3 credit hours\n*   Software quality guarantee and test (IS 455) - 3 credit hours\n*   Introduction to deep learning (IS 460) - 3 credit hours\n*   Selected topics in Information Systems (IS 496) - 3 credit hours', '2025-06-09 21:31:37.492932', 2, 157),
(101, 'ايه مواد قسم it', 'Hello! 😊\nمرحباً! للحصول على معلومات حول مواد قسم تكنولوجيا المعلومات (IT)، يرجى تحديد ما إذا كنت تقصد المواد الإجبارية أو الاختيارية.', '2025-06-09 21:38:20.442210', 2, 158),
(102, 'الاجبارى', 'مرحبًا! 😊\nالمقررات الإجبارية في قسم تكنولوجيا المعلومات (IT) تشمل:\n\n1.  اللغة الإنجليزية 1 (HU 111) - ساعتان معتمدتان.\n2.  اللغة الإنجليزية 2 (HU 112) - ساعتان معتمدتان.\n3.  حقوق الإنسان (HU 313) - ساعتان معتمدتان.\n4.  عمارة الحاسوب (IT 311) - 3 ساعات معتمدة.\n5.  تكنولوجيا الاتصالات (IT 321) - 3 ساعات معتمدة.\n6.  شبكات الحاسوب 2 (IT 322) - 3 ساعات معتمدة.\n7.  الرسومات بالحاسوب 1 (IT 331) - 3 ساعات معتمدة.\n8.  معالجة الإشارات الرقمية (IT 341) - 3 ساعات معتمدة.\n9.  التعرف على الأنماط (IT 342) - 3 ساعات معتمدة.\n10. الوسائط المتعددة (IT 433) - 3 ساعات معتمدة.\n11. معالجة الصور 1 (IT 441) - 3 ساعات معتمدة.\n12. الذكاء الاصطناعي (AI 310) - 3 ساعات معتمدة.\n13. الرؤية بالحاسوب (IT 444) - 3 ساعات معتمدة.\n14. أمن شبكات الحاسوب والمعلومات (IT 423) - 3 ساعات معتمدة.\n15. مشروع التخرج (IT 498) - 6 ساعات معتمدة.', '2025-06-09 21:39:26.605110', 2, 158),
(103, 'ايك', 'مرحبًا! 😊\nهل تقصد مقرر Electronics I (IT 111)؟ هو مقرر عام، وعدد ساعاته المعتمدة هو 3 ساعات. يشمل المقرر مقدمة عن الإلكترونيات، العوازل، الموصلات، أشباه الموصلات، المقاومات، المكثفات، الملفات، الثنائيات، تطبيقات الثنائيات، المقومات، مصادر الطاقة، الثنائيات الباعثة للضوء، منظمات الجهد، الترانزستورات، المضخمات، المؤقتات، وتطبيقاتها.', '2025-06-09 21:44:34.369821', 2, 158),
(104, 'ازيك', 'Hello! 😊\nمرحباً! 😊 أنا بخير، شكراً لسؤالك. كيف يمكنني مساعدتك اليوم؟', '2025-06-09 21:44:43.473114', 2, 158),
(105, 'ايه مواد قسم cs', 'مواد قسم علوم الحاسب (CS) تركز على علوم الحاسب النظرية والبرمجة.', '2025-06-09 22:29:25.149035', 2, 164),
(106, 'طب قولى اساميهم', 'لم يتم تحديد أسماء مواد قسم علوم الحاسب (CS) في قاعدة البيانات المتوفرة.', '2025-06-09 22:30:02.513698', 2, 164),
(107, 'طب مواد قسم is', 'المعلومات المتوفرة تتضمن مقرر Electronics I (IT 111) وهو مقرر عام، بالإضافة إلى قائمة مقررات اختيارية في تكنولوجيا المعلومات. هل تود معرفة تفاصيل أكثر عن أي من هذه المقررات؟', '2025-06-09 22:31:04.834146', 2, 164),
(108, 'فى غياب ف الكلية؟', 'الكلية تسمح بنسبة غياب محددة لكل مقرر دراسي، وفي حالة تجاوز هذه النسبة، قد يتم حرمان الطالب من التقدم للامتحان النهائي. يجب على الطلاب تحقيق نسبة حضور لا تقل عن 75% في كل مقرر. في حالة الغياب عن المحاضرات، يجب على الطالب تقديم عذر مقبول لإدارة الكلية.', '2025-06-09 22:31:31.273585', 2, 164),
(109, 'انت عامل ايه', 'أنا هنا للمساعدة في أي أسئلة لديك بخصوص الكلية. هل هناك شيء معين يمكنني مساعدتك فيه؟', '2025-06-09 22:31:46.902043', 2, 164),
(110, 'ازيك', 'أنا هنا للمساعدة في أي أسئلة لديك بخصوص الكلية. هل هناك شيء معين يمكنني مساعدتك فيه؟', '2025-06-09 22:31:56.425648', 2, 164),
(111, 'hi', 'أنا هنا لمساعدتك في أي أسئلة لديك بخصوص الكلية. هل هناك شيء معين يمكنني مساعدتك فيه؟', '2025-06-09 22:32:12.476927', 2, 165),
(112, 'hi', 'أهلاً بك! كيف يمكنني مساعدتك؟', '2025-06-09 22:57:23.057077', 1, 166),
(113, 'how are you', 'أنا برنامج حاسوبي، لذا لا أشعر أو أمرض. كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول مقرر اللغة الإنجليزية 1 (HU 111) أو أي استفسارات أخرى؟', '2025-06-09 22:57:37.266226', 1, 166),
(114, 'عايز اسجل المواد اعمل اي ', 'لتسجيل المواد، يمكنك القيام بذلك من خلال النظام الإلكتروني للجامعة باستخدام حسابك الطلابي. المواعيد النهائية للتسجيل تُعلن عادةً في بداية كل فصل دراسي ويجب عليك الالتزام بها لتجنب أي غرامات أو مشاكل أكاديمية. يُسمح لك بالتسجيل في المقررات الدراسية بناءً على اختيارك للمستويات المختلفة، ولكن لا يُسمح بالتسجيل في مقرر أعلى إلا إذا نجحت في المقررات المطلوبة كمتطلبات للمقرر الأعلى، إلا بموافقة مجلس القسم المعني في حالات معينة.', '2025-06-09 22:57:53.227554', 1, 166),
(115, 'اهلا', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول التسجيل أو أي استفسارات أخرى؟', '2025-06-09 22:58:36.598335', 1, 167),
(116, 'ازيك ', 'أنا برنامج حاسوبي، لذا لا أشعر. كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول التسجيل أو أي استفسارات أخرى؟', '2025-06-09 23:00:05.661217', 2, 170),
(117, 'ازاى اسجل المواد ', 'لتسجيل المواد، يمكنك القيام بذلك من خلال النظام الإلكتروني للجامعة باستخدام حسابك الطلابي. المواعيد النهائية للتسجيل تُعلن عادةً في بداية كل فصل دراسي ويجب عليك الالتزام بها لتجنب أي غرامات أو مشاكل أكاديمية. ويمكنك تسجيل المواد الاختيارية من خلال النظام الإلكتروني خلال الفترة المحددة.', '2025-06-09 23:00:33.934837', 2, 170),
(118, 'طب فى غياب ف الكلية ظ', 'نعم، الكلية تسمح بنسبة غياب محددة لكل مقرر دراسي. إذا تجاوزت هذه النسبة، قد تُحرم من التقدم للامتحان النهائي. وفي حالة الغياب، يجب عليك تقديم عذر مقبول لإدارة الكلية.', '2025-06-09 23:00:58.522226', 2, 170),
(119, 'طب قولى مواد قسم vs ', 'معلومات قسم VS غير متوفرة لدي. هل تقصد قسم نظم المعلومات (IS)؟ إذا كان الأمر كذلك، تشمل المقررات الإجبارية في قسم نظم المعلومات: تطبيقات الإنترنت، نظم قواعد البيانات 2، تخزين واسترجاع البيانات، تحليل وتصميم نظم المعلومات 2، أمن نظم المعلومات، نظم دعم القرار، نظم المعلومات الإدارية، ذكاء الأعمال وتحليل البيانات، تكنولوجيا البيانات الكبيرة، مقدمة في علم البيانات، إدارة قواعد المعرفة، ومشروع التخرج. بالإضافة إلى ذلك، يشمل القسم مجالات متخصصة في الرسوم والوسائط مثل: نظم الرسم بالحاسب، الرسوم الحاسوبية المتحركة، الواقع الافتراضي، الوسائط المتعددة، ضغط البيانات وتأمينها.', '2025-06-09 23:02:21.638801', 2, 170),
(120, 'hi', 'أهلاً بك! كيف يمكنني مساعدتك؟', '2025-06-10 09:17:41.625471', 1, 171),
(121, 'كم ساعة للتخرج ', 'للتخرج، يحتاج الطالب إلى اجتياز 144 ساعة معتمدة بنجاح، موزعة على ثمانية فصول دراسية ومقسمة إلى أربعة مستويات دراسية. هذه الساعات تشمل متطلبات عامة، ومتطلبات الكلية، بالإضافة إلى متطلبات التخصص الرئيسي. الدراسة في المستويين الأول والثاني مشتركة لجميع التخصصات.', '2025-06-10 10:21:42.937448', 1, 171),
(122, 'how many hours for graduate?', 'للتخرج، يجب على الطالب اجتياز 144 ساعة معتمدة بنجاح، موزعة على ثمانية فصول دراسية ومقسمة إلى أربعة مستويات دراسية. هذه الساعات تشمل متطلبات عامة ومتطلبات الكلية بالإضافة إلى متطلبات التخصص الرئيسي.', '2025-06-10 10:22:45.632232', 1, 171),
(123, 'speak english', 'Okay, I will speak in English. How can I help you today? Do you have any questions about courses, registration, or anything else related to the university?', '2025-06-10 10:23:07.491288', 1, 171),
(124, 'how many hours for graduate?', 'To graduate, you need to successfully complete 144 credit hours. These hours are distributed over eight semesters, divided into four academic levels, and include general, college, and major requirements.', '2025-06-10 10:23:32.678390', 1, 171),
(125, 'how are you?', 'I am a computer program, so I don\'t experience feelings. How can I help you today? Do you have any questions regarding courses, departments, or university requirements?', '2025-06-10 10:23:46.406899', 1, 171),
(126, 'ما هي مادة البرمجة1', 'Programming 1 (CS 112) is a mandatory course with 3 credit hours. It requires completion of Introduction to Computer Science (CS 111) as a prerequisite.', '2025-06-10 10:24:58.235264', 1, 171),
(127, 'هل فيه حاجة معتمدة عليه ', 'نعم، يوجد مقرر أساسيات الإدارة (HU 122) وهو مقرر اختياري، وعدد ساعاته المعتمدة هو 3 ساعات. لا يوجد له متطلبات سابقة. ويمكنك تسجيل المواد الاختيارية من خلال النظام الإلكتروني خلال الفترة المحددة.', '2025-06-10 10:25:13.034852', 1, 171),
(128, 'صباح الفل ', 'صباح الفل! كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول المقررات، أو التسجيل، أو أي شيء آخر متعلق بالجامعة؟', '2025-06-10 10:26:55.259208', 1, 171),
(129, 'مساء الخير', 'مساء الخير! كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول المقررات، أو التسجيل، أو أي شيء آخر متعلق بالجامعة؟', '2025-06-10 10:27:04.344305', 1, 171),
(130, 'مساء الزفت', 'مساء الخير! كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول النتائج أو أي شيء آخر؟ سيتم الإعلان عن نتائج امتحانات الفاينل بعد 10 أيام إلى 15 يومًا من انتهاء الامتحانات.', '2025-06-10 10:27:14.329738', 1, 171),
(131, 'ازيك ', 'أنا برنامج حاسوبي، لذا لا أشعر. كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول المقررات، أو التسجيل، أو أي شيء آخر متعلق بالجامعة؟', '2025-06-10 19:10:10.547700', 2, 172),
(132, 'فى غياب ؟', 'في حالة الغياب عن المحاضرات، يجب على الطالب تقديم عذر مقبول لإدارة الكلية، وإذا تجاوز الغياب النسبة المسموح بها، قد يتم حرمان الطالب من التقدم للامتحان النهائي. الكلية تسمح بنسبة غياب محددة لكل مقرر دراسي.', '2025-06-10 19:10:31.673071', 2, 172),
(133, 'Hello', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-10 19:22:36.661378', 1, 173),
(134, 'كام ساعة للتخرج', 'للتخرج، يجب على الطالب اجتياز 144 ساعة معتمدة بنجاح موزعة على ثمانية فصول دراسية، مقسمة إلى أربعة مستويات دراسية. الدراسة في المستويين الأول والثاني مشتركة لجميع التخصصات.', '2025-06-10 19:22:52.789840', 1, 173),
(135, 'How are you', 'أنا برنامج حاسوبي، لذا لا أشعر. كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول المقررات، الأقسام، أو متطلبات الجامعة؟', '2025-06-10 20:37:23.420551', 1, 176),
(136, 'فى غياب ف الكلية', 'نعم، الكلية تسمح بنسبة غياب محددة لكل مقرر دراسي. إذا تجاوزت هذه النسبة، قد تُحرم من التقدم للامتحان النهائي.', '2025-06-10 23:10:09.517594', 2, 180),
(137, 'ايه مواد قسم cs', 'مواد قسم CS تركز على علوم الحاسب النظرية والبرمجة.', '2025-06-10 23:10:25.032565', 2, 180),
(138, 'Hi', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-10 23:30:59.250320', 1, 182),
(139, 'ايوة عايز اعرف محاضرة برمجة 1 ', 'مقرر البرمجة 1 (CS 112) هو مقرر إجباري، وعدد ساعاته المعتمدة هو 3 ساعات. يتطلب دراسة مقرر مقدمة في الحاسوب (CS 111) كمتطلب سابق. يشمل المقرر تطوير البرامج الهيكلية، حل المشكلات باستخدام تراكيب القرار، الهياكل التكرارية، تقسيم البرامج إلى وحدات فرعية، الدوال والإجراءات، أنواع البيانات المركبة مثل المصفوفات والسجلات، التعامل مع الملفات النصية والعشوائية، هياكل البيانات الديناميكية (المؤشرات)، والتكرار الذاتي (Recursion).', '2025-06-10 23:31:18.723947', 1, 182),
(140, 'كم عدد ساعات الحضور ', 'لا يوجد معلومات في قاعدة البيانات حول عدد ساعات الحضور المطلوبة. ولكن، للتخرج، يجب عليك إكمال 144 ساعة معتمدة بنجاح.', '2025-06-10 23:31:34.330902', 1, 182),
(141, 'هل تعرف شات جي بي تي ', 'أنا نظام حاسوبي مصمم للمساعدة في الإجابة على أسئلتك بناءً على المعلومات المتوفرة لدي.', '2025-06-10 23:31:52.735222', 1, 182),
(142, 'اسمك اي ', 'أنا نظام حاسوبي مصمم للمساعدة في الإجابة على أسئلتك بناءً على المعلومات المتوفرة لدي.', '2025-06-10 23:32:08.123543', 1, 182),
(143, 'اهلا', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-10 23:32:17.575461', 1, 182),
(144, 'انا عايز اعرف فى غياب ف الكلية ولا لا', 'نعم، الكلية تسمح بنسبة غياب محددة لكل مقرر دراسي، وإذا تجاوزت هذه النسبة، قد تُحرم من التقدم للامتحان النهائي. يجب عليك تحقيق نسبة حضور لا تقل عن 75% في كل مقرر.', '2025-06-11 03:01:10.966639', 2, 183),
(145, 'طب هى ايه اقسام الكلية', 'تضم الكلية ستة أقسام علمية هي: قسم علوم الحاسب، قسم نظم المعلومات، قسم تكنولوجيا المعلومات، قسم الذكاء الاصطناعي، بالإضافة إلى برنامج هندسة البرمجيات وبرنامج المعلوماتية الطبية (برامج بمصروفات).', '2025-06-11 03:01:36.379671', 2, 183),
(146, ' what is the core courses at cs department ', 'المقررات الإجبارية في قسم علوم الحاسب تتضمن:\n\n1.  هياكل البيانات (CS 214) - 3 ساعات معتمدة\n2.  الخوارزميات (CS 316) - 3 ساعات معتمدة\n3.  نظم قواعد البيانات 1 (IS 211) - 3 ساعات معتمدة\n4.  تحليل وتصميم النظم 1 (I 351) - 3 ساعات معتمدة\n5.  شبكات الحاسوب 1 (IT 222) - 3 ساعات معتمدة\n6.  نظم التشغيل 1 (CS 241) - 3 ساعات معتمدة\n7.  هندسة البرمجيات 1 (CS 251) - 3 ساعات معتمدة\n8.  البرمجة 2 (CS 213) - 3 ساعات معتمدة\n9. تعلم الآلة (AI 330) - 3 ساعات معتمدة\n10. تنظيم الحاسوب (CS 322) - 3 ساعات معتمدة\n11. شقق الحاسوب 1 (IT 331) - 3 ساعات معتمدة\n12. هندسة البرمجيات 2 (CS 352) - 3 ساعات معتمدة\n13. المعالجة المتوازية والحوسبة عالية الأداء (CS 471) - 3 ساعات معتمدة\n14. الذكاء الاصطناعي (AI 310) - 3 ساعات معتمدة\n15. الترجمة (CS 419) - 3 ساعات معتمدة\n16. نظرية الحوسبة (CS 405) - 3 ساعات معتمدة\n17. نظم التشغيل 2 (CS 342) - 3 ساعات معتمدة\n18. الأنظمة الموزعة والحوسبة السحابية (CS 460) - 3 ساعات معتمدة\n19. أمن المعلومات وشبكات الحاسوب (IT 423) - 3 ساعات معتمدة\n20. مشروع التخرج (CS 498) - 6 ساعات معتمدة', '2025-06-11 03:03:44.793972', 2, 157),
(147, 'اه', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول المقررات، أو الأقسام، أو متطلبات الجامعة؟', '2025-06-11 03:04:05.525474', 2, 184),
(148, 'اهلا', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-11 03:04:24.267926', 2, 184),
(149, 'عامل ايه', 'أنا نظام حاسوبي، لذا لا أشعر. كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول المقررات، أو الأقسام، أو متطلبات الجامعة؟', '2025-06-11 03:04:38.693068', 2, 184),
(150, 'hello', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-11 03:04:55.684449', 2, 184),
(151, 'i want to know if there is an attednence?', 'Yes, students must achieve an attendance rate of at least 75% in each course. In the event of an absence from the lectures, the student must provide an acceptable excuse for the college administration, and if the absence exceeds the permissible percentage, the student may be deprived of applying for the final exam.', '2025-06-11 03:05:26.220414', 2, 184),
(152, 'I want to know if there is an attendence', 'Yes, students must achieve an attendance rate of at least 75% in each course.', '2025-06-11 03:05:50.761945', 2, 185),
(153, 'wha tis the core courses of cs department', 'The core courses for the CS department include:\n*   Data Structures (CS 214) - 3 credit hours\n*   Algorithms (CS 316) - 3 credit hours\n*   Database Systems 1 (IS 211) - 3 credit hours\n*   Systems Analysis and Design 1 (I 351) - 3 credit hours\n*   Computer Networks 1 (IT 222) - 3 credit hours\n*   Operating Systems 1 (CS 241) - 3 credit hours\n*   Software Engineering 1 (CS 251) - 3 credit hours\n*   Programming 2 (CS 213) - 3 credit hours\n*   Machine Learning (AI 330) - 3 credit hours\n*   Computer Organization (CS 322) - 3 credit hours\n*   Computer Architecture 1 (IT 331) - 3 credit hours\n*   Software Engineering 2 (CS 352) - 3 credit hours\n*   Parallel Processing and High-Performance Computing (CS 471) - 3 credit hours\n*   Artificial Intelligence (AI 310) - 3 credit hours\n*   Compilers (CS 419) - 3 credit hours\n*   Theory of Computation (CS 405) - 3 credit hours\n*   Operating Systems 2 (CS 342) - 3 credit hours\n*   Distributed Systems and Cloud Computing (CS 460) - 3 credit hours\n*   Information Security and Computer Networks (IT 423) - 3 credit hours\n*   Graduation Project (CS 498) - 6 credit hours', '2025-06-11 03:06:17.340111', 2, 185),
(154, 'ok thank u', 'You\'re welcome! If you have any more questions in the future, feel free to ask.', '2025-06-11 03:06:37.865756', 2, 185),
(155, 'ازيك', 'أنا برنامج حاسوبي، لذا لا أشعر. كيف يمكنني مساعدتك اليوم؟ هل لديك أي أسئلة حول المقررات، أو الأقسام، أو متطلبات الجامعة؟', '2025-06-11 03:09:16.330263', 2, 186),
(156, 'اهلا يعم', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-11 03:09:30.310289', 2, 186),
(157, 'اهلا يعم', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-11 03:12:03.371921', 2, 187),
(158, 'هو الحضور عليه درجات؟', 'نعم، الحضور مهم. يتطلب دخولك الامتحان النهائي تحقيق نسبة حضور لا تقل عن 75% من المحاضرات في كل مقرر. إذا تجاوزت نسبة غيابك 25% بدون عذر مقبول، قد يتم حرمانك من دخول الامتحان النهائي وتحصل على درجة \"صفر\" في الاختبار النهائي للمقرر.', '2025-06-11 03:12:32.264377', 2, 187),
(159, 'طب هى ايه اقسام الكلية', 'تضم الكلية ستة أقسام علمية هي: قسم علوم الحاسب، قسم نظم المعلومات، قسم تكنولوجيا المعلومات، قسم الذكاء الاصطناعي، بالإضافة إلى برنامج هندسة البرمجيات وبرنامج المعلوماتية الطبية (برامج بمصروفات).', '2025-06-11 03:12:57.267409', 2, 187),
(160, 'تمام شكرا', 'على الرحب والسعة! إذا كان لديك أي أسئلة أخرى في المستقبل، فلا تتردد في طرحها.', '2025-06-11 03:13:14.695970', 2, 187),
(161, 'اهلا يعم', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-11 03:19:02.226520', 2, 188),
(162, 'هو الحضور عليه درجات ؟', 'نعم، الحضور مهم. يتطلب دخولك الامتحان النهائي تحقيق نسبة حضور لا تقل عن 75% من المحاضرات في كل مقرر. إذا تجاوزت نسبة غيابك 25% بدون عذر مقبول، قد يتم حرمانك من دخول الامتحان النهائي وتحصل على درجة \'صفر\' في درجة الاختبار النهائي للمقرر.', '2025-06-11 03:19:31.980442', 2, 188),
(163, 'اهلا يعم', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-11 03:23:46.425112', 2, 189),
(164, 'هو الحضور عليه درجات؟', 'نعم، الحضور مهم. يتطلب دخولك الامتحان النهائي تحقيق نسبة حضور لا تقل عن 75% من المحاضرات في كل مقرر. إذا تجاوزت نسبة غيابك 25% بدون عذر مقبول، قد يتم حرمانك من دخول الامتحان النهائي وتحصل على درجة \'صفر\' في درجة الاختبار النهائي للمقرر.', '2025-06-11 03:24:13.032072', 2, 189),
(165, 'طب هى ايه اقسام الكلية', 'تضم الكلية ستة أقسام علمية هي: قسم علوم الحاسب، قسم نظم المعلومات، قسم تكنولوجيا المعلومات، قسم الذكاء الاصطناعي، بالإضافة إلى برنامج هندسة البرمجيات وبرنامج المعلوماتية الطبية (برامج بمصروفات).', '2025-06-11 03:24:33.696236', 2, 189),
(166, 'تمام شكرا', 'على الرحب والسعة! إذا كان لديك أي أسئلة أخرى في المستقبل، فلا تتردد في طرحها.', '2025-06-11 03:24:50.449443', 2, 189),
(167, 'i want to know if there is an attedndence', 'Yes, students must achieve an attendance rate of at least 75% in each course.', '2025-06-11 03:26:22.557137', 2, 190),
(168, 'can u tell me what is the core courses of cs department', 'The core courses for the CS department include:\n\n*   Data Structures (CS 214) - 3 credit hours\n*   Algorithms (CS 316) - 3 credit hours\n*   Database Systems 1 (IS 211) - 3 credit hours\n*   Systems Analysis and Design 1 (I 351) - 3 credit hours\n*   Computer Networks 1 (IT 222) - 3 credit hours\n*   Operating Systems 1 (CS 241) - 3 credit hours\n*   Software Engineering 1 (CS 251) - 3 credit hours\n*   Programming 2 (CS 213) - 3 credit hours\n*   Machine Learning (AI 330) - 3 credit hours\n*   Computer Organization (CS 322) - 3 credit hours\n*   Computer Architecture 1 (IT 331) - 3 credit hours\n*   Software Engineering 2 (CS 352) - 3 credit hours\n*   Parallel Processing and High-Performance Computing (CS 471) - 3 credit hours\n*   Artificial Intelligence (AI 310) - 3 credit hours\n*   Compilers (CS 419) - 3 credit hours\n*   Theory of Computation (CS 405) - 3 credit hours\n*   Operating Systems 2 (CS 342) - 3 credit hours\n*   Distributed Systems and Cloud Computing (CS 460) - 3 credit hours\n*   Information Security and Computer Networks (IT 423) - 3 credit hours\n*   Graduation Project (CS 498) - 6 credit hours', '2025-06-11 03:26:53.271845', 2, 190),
(169, 'what about the elective courses', 'For elective courses, you can choose from various options, including:\n\n*   **General electives:** such as Arabic, English, Economy Basics (HU 121), English 3 (HU 213), Basics of Accounting (HU 323), Communication and Negotiation Skills (HU 331), Creative Thinking (HU 332), Media (HU 333), and Professional Ethics (HU 334).\n*   **Courses that serve specialization:** such as computer skills.\n*   **Courses related to personal or academic development.**\n*   **Other elective options:** Possibilities and Statistics 2 (S-122), Basics of Management (HU 122), Project Management (IS 321), Signals and Systems (IT 241), Modeling and Simulation (IS 241), Simulation Languages (IS 342), Computer Maintenance (IT 211), and Programming 3 (CS 313).\n\nPlease note that the availability of specific elective courses may vary.', '2025-06-11 03:27:26.384667', 2, 190),
(170, 'اهلا يعم', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-11 03:30:33.173890', 2, 191),
(171, 'هو فى درجات على الحضور؟', 'نعم، الحضور مهم. يتطلب دخولك الامتحان النهائي تحقيق نسبة حضور لا تقل عن 75% من المحاضرات في كل مقرر. إذا تجاوزت نسبة غيابك 25% بدون عذر مقبول، قد يتم حرمانك من دخول الامتحان النهائي وتحصل على درجة \'صفر\' في درجة الاختبار النهائي للمقرر.', '2025-06-11 03:30:55.815629', 2, 191),
(172, 'طب هى ايه اقسام الكلية', 'تضم الكلية ستة أقسام علمية هي: قسم علوم الحاسب، قسم نظم المعلومات، قسم تكنولوجيا المعلومات، قسم الذكاء الاصطناعي، بالإضافة إلى برنامج هندسة البرمجيات وبرنامج المعلوماتية الطبية (برامج بمصروفات).', '2025-06-11 03:31:17.266928', 2, 191),
(173, 'تمام شكرا', 'على الرحب والسعة! إذا كان لديك أي أسئلة أخرى في المستقبل، فلا تتردد في طرحها.', '2025-06-11 03:31:43.820573', 2, 191),
(174, 'i want to know if there is attendence ', 'Yes, students must achieve an attendance rate of at least 75% in each course.', '2025-06-11 03:32:47.609870', 2, 192),
(175, 'ok, can u tell me the core courses of cs department', 'The core courses for the CS department include:\n* Machine Learning (AI 330) - 3 credit hours\n* Computer Organization (CS 322) - 3 credit hours\n* Computer Architecture 1 (IT 331) - 3 credit hours\n* Software Engineering 2 (CS 352) - 3 credit hours\n* Parallel Processing and High-Performance Computing (CS 471) - 3 credit hours\n* Artificial Intelligence (AI 310) - 3 credit hours\n* Compilers (CS 419) - 3 credit hours\n* Computing Theory (CS 405) - 3 credit hours\n* Operating Systems 2 (CS 342) - 3 credit hours\n* Distributed Systems and Cloud Computing (CS 460) - 3 credit hours\n* Information Security and Computer Networks (IT 423) - 3 credit hours\n* Graduation Project (CS 498) - 6 credit hours', '2025-06-11 03:33:23.707547', 2, 192),
(176, 'ok thank u', 'You\'re welcome! If you have any more questions in the future, feel free to ask.', '2025-06-11 03:34:00.563771', 2, 192),
(177, 'hi', 'أهلاً بك! كيف يمكنني مساعدتك؟ هل لديك أي أسئلة حول جدول المحاضرات أو أي شيء آخر؟', '2025-06-11 11:22:05.156249', 1, 193),
(178, 'كم عدد ساعات التخرج ', 'للتخرج، يجب على الطالب اجتياز 144 ساعة معتمدة بنجاح موزعة على ثمانية فصول دراسية، مقسمة إلى أربعة مستويات دراسية. الدراسة في المستويين الأول والثاني مشتركة لجميع التخصصات. هذه الساعات تشمل متطلبات عامة، ومتطلبات الكلية إلى جانب متطلبات التخصص الرئيسي.', '2025-06-11 11:22:26.413627', 1, 193),
(179, 'موعد انتهاء الامتحانات لهذا العام ', 'يمكنك الاطلاع على جدول الامتحانات من خلال النظام الإلكتروني للجامعة. سيتم الإعلان عن النتائج خلال أسبوعين من انتهاء الامتحانات.', '2025-06-11 15:27:57.754312', 2, 194),
(180, 'ومتى مواعيد التقديم للفرق الاولى للالتحاق بالكلية ', 'للأسف، لا توجد معلومات لدي حول مواعيد التقديم للفرق الأولى للالتحاق بالكلية.', '2025-06-11 15:28:52.005727', 2, 194),
(181, 'ما الاوراق المطلوبه للطلاب المتخرجين لإنهاء إجراءات تخرجهم', 'عذراً، لا تتضمن قاعدة البيانات معلومات حول الأوراق المطلوبة للطلاب المتخرجين لإنهاء إجراءات تخرجهم.', '2025-06-11 15:30:10.350090', 2, 194),
(182, 'مواعيد نتائج الامتحانات بالكلية ', 'سيتم الإعلان عن النتائج خلال أسبوعين من انتهاء الامتحانات.', '2025-06-11 15:30:48.855801', 2, 194),
(183, 'هل هناك وظائف شاغره للخريج كمعيد بالكلية ', 'لا توجد معلومات محددة حول الوظائف الشاغرة كمعيد بالكلية، ولكن يمكن لخريجي قسم علوم الحاسب العمل في مجالات متنوعة مثل تطوير البرمجيات، تحليل البيانات، الأمن السيبراني، إدارة قواعد البيانات، وتطوير تطبيقات الويب والهواتف الذكية.', '2025-06-11 15:31:52.938707', 2, 194),
(184, 'ما هى الاماكن المتاح العمل بها لهذا التخصص ', 'يمكن لخريجي قسم علوم الحاسب العمل في مجالات متنوعة مثل تطوير البرمجيات، تحليل البيانات، الأمن السيبراني، إدارة قواعد البيانات، وتطوير تطبيقات الويب والهواتف الذكية. كما يغطي القسم تطبيقات عملية متنوعة مثل: برمجة تطبيقات نظم المعلومات، تأكيد جودة البرمجيات ونظم المعلومات، تطبيقات نظم المعلومات في المجالات المختلفة، التجارة الإلكترونية، نظم معلومات الشبكة الدولية (الإنترنت)، بحوث العمليات، النمذجة والمحاكاة، هندسة المعلومات، الأعمال الإلكترونية.', '2025-06-11 15:32:40.031098', 2, 194);

-- --------------------------------------------------------

--
-- Table structure for table `cs requirements_compulsory`
--

CREATE TABLE `cs requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cs requirements_compulsory`
--

INSERT INTO `cs requirements_compulsory` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('AI 310', 'Artificial Intelligence', 'الذكاء الاصطناعي', 3, 'Algorithms', 'الخوارزميات'),
('AI 330', 'Machine Learning', 'تعلم الآلة', 3, 'Probability and Statistics-2', 'الاحتمالات والإحصاء-2'),
('CS 322', 'Computer Organization', 'تنظيم الحاسوب', 3, 'Logic Design', 'تصميم المنطق'),
('CS 342', 'Operating Systems-2', 'أنظمة التشغيل-2', 3, 'Operating Systems-1', 'أنظمة التشغيل-1'),
('CS 352', 'Software Engineering-2', 'هندسة البرمجيات-2', 3, 'Software Engineering-1', 'هندسة البرمجيات-1'),
('CS 405', 'Theory of Computation', 'نظرية الحوسبة', 3, 'Discrete Mathematics', 'الرياضيات المتقطعة'),
('CS 419', 'Compilers', 'المترجمات', 3, 'Data Structures', 'هياكل البيانات'),
('CS 460', 'Distributed systems and Cloud Computing', 'الأنظمة الموزعة والحوسبة السحابية', 3, 'Computer Networks-1', 'شبكات الحاسوب-1'),
('CS 471', 'Parallel Processing and high Performance Computing', 'المعالجة المتوازية والحوسبة عالية الأداء', 3, 'Operating Systems-1', 'أنظمة التشغيل-1'),
('CS 498', 'Project', 'مشروع التخرج', 6, 'Software Engineering-1', 'هندسة البرمجيات-1'),
('IT 331', 'Computer Graphics-1', 'رسوميات الحاسوب-1', 3, 'Programming-1', 'برمجة-1'),
('IT 423', 'Information and Computer Networks Security', 'أمن المعلومات وشبكات الحاسوب', 3, 'Computer Networks-1', 'شبكات الحاسوب-1');

-- --------------------------------------------------------

--
-- Table structure for table `cs requirements_electives`
--

CREATE TABLE `cs requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cs requirements_electives`
--

INSERT INTO `cs requirements_electives` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('AI 335', 'Neural Networks & deep learning', 'الشبكات العصبية والتعلم العميق', 3, 'Machine Learning', 'تعلم الآلة'),
('AI 350', 'Data Visualization', 'تصوير البيانات', 3, 'Probability and Statistics-2', 'الاحتمالات والإحصاء-2'),
('AI 360', 'Natural Language Processing', 'معالجة اللغات الطبيعية', 3, 'Artificial Intelligence', 'الذكاء الاصطناعي'),
('AI 380', 'Human Computer Interaction', 'التفاعل بين الإنسان والحاسوب', 3, 'Artificial Intelligence', 'الذكاء الاصطناعي'),
('CS 410', 'Concepts of Programming Languages', 'مفاهيم لغات البرمجة', 3, 'Programming-1', 'برمجة-1'),
('CS 416', 'Advanced Algorithms', 'الخوارزميات المتقدمة', 3, 'Algorithms', 'الخوارزميات'),
('CS 480', 'Cryptography', 'علم التشفير', 3, 'Probability and Statistics-1', 'الاحتمالات والإحصاء-1'),
('CS 496', 'Selected Topics in Computer Science', 'موضوعات مختارة في علوم الحاسوب', 3, '-', '-'),
('IS 312', 'Database Systems-2', 'نظم قواعد البيانات-2', 3, 'Database Systems-1', 'نظم قواعد البيانات-1'),
('IS 434', 'Quality Assurance of Information Systems and Programming', 'ضمان الجودة في نظم المعلومات والبرمجة', 3, 'System Analysis and Design-1', 'تحليل وتصميم النظم-1'),
('IT 312', 'Microprocessors', 'المعالجات الدقيقة', 3, 'Logic Design', 'تصميم المنطق'),
('IT 342', 'Pattern Recognitions', 'تمييز الأنماط', 3, '-', '-'),
('IT 414', 'Embedded Systems', 'الأنظمة المضمنة', 3, 'Microprocessors', 'المعالجات الدقيقة'),
('IT 433', 'Multimedia', 'الوسائط المتعددة', 3, 'Programming-1', 'برمجة-1'),
('IT 441', 'Image processing-1', 'معالجة الصور-1', 3, 'Signals and Systems', 'الإشارات والأنظمة'),
('IT 444', 'Computer Vision', 'رؤية الحاسوب', 3, 'Algorithms', 'الخوارزميات');

-- --------------------------------------------------------

--
-- Table structure for table `faculty requirements_compulsory`
--

CREATE TABLE `faculty requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faculty requirements_compulsory`
--

INSERT INTO `faculty requirements_compulsory` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('CS 111', 'Introduction to Computers', 'مقدمة في الحاسبات', 3, '-', '-'),
('CS 112', 'Programming-1', 'برمجة 1', 3, 'Introduction to Computers', 'مقدمة في الحاسوب'),
('CS 213', 'Programming-2', 'برمجة 2', 3, 'Programming-1', 'برمجة 1'),
('CS 214', 'Data Structures', 'هياكل البيانات', 3, 'Programming-1', 'برمجة 1'),
('CS 221', 'Logic Design', 'تصميم منطقي', 3, '-', '-'),
('CS 241', 'Operating Systems-1', 'نظم التشغيل 1', 3, 'Programming-1', 'برمجة 1'),
('CS 251', 'Software Engineering-1', 'هندسة البرمجيات 1', 3, 'Programming-1', 'برمجة 1'),
('CS 316', 'Algorithms', 'الخوارزميات', 3, 'Data Structures', 'هياكل البيانات'),
('IS 211', 'Database Systems-1', 'نظم قواعد البيانات 1', 3, '-', '-'),
('IS 231', 'Fundamentals of Information Systems', 'أساسيات نظم المعلومات', 3, '-', '-'),
('IS 240', 'Operations Research', 'بحوث العمليات', 3, '-', '-'),
('IS 351', 'System Analysis and Design-1', 'تحليل وتصميم نظم المعلومات 1', 3, 'Fundamentals of Information Systems', 'أساسيات نظم المعلومات'),
('IT 111', 'Electronics-1', 'إلكترونيات 1', 3, '-', '-'),
('IT 221', 'Data Communication', 'تراسل البيانات', 3, 'Probability and Statistics-1', 'احتمالات وإحصاء 1'),
('IT 222', 'Computer Networks-1', 'شبكات الحاسوب 1', 3, 'Database Systems-1', 'نظم قواعد البيانات 1'),
('IT 223', 'Internet Technology', 'تكنولوجيا الإنترنت', 3, '-', '-'),
('MA 111', 'Mathematics-1', 'رياضيات 1', 3, '-', '-'),
('MA 112', 'Discrete Mathematics', 'تراكيب محددة', 3, '-', '-'),
('MA 113', 'Mathematics–2', 'رياضيات 2', 3, 'Mathematics-1', 'رياضيات 1'),
('PH 111', 'Physics', 'الفيزياء', 3, '-', '-'),
('ST 121', 'Probability and Statistics-1', 'احصاء واحتمالات 1', 3, '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `faculty requirements_electives`
--

CREATE TABLE `faculty requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faculty requirements_electives`
--

INSERT INTO `faculty requirements_electives` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('CS 313', 'Programming-3', 'برمجة 3', 3, 'Programming-2', 'برمجة 2'),
('HU 122', 'Fundamentals of Management', 'مبادئ الإدارة', 3, '-', '-'),
('IS 241', 'Modeling and Simulation', 'النمذجة والمحاكاة', 3, '-', '-'),
('IS 321', 'Projects Management', 'إدارة المشاريع', 3, 'Operations Research', 'بحوث العمليات'),
('IS 342', 'Simulation Languages', 'لغات المحاكاة', 3, 'Modeling and Simulation', 'النمذجة والمحاكاة'),
('IT 211', 'Computer Maintenance', 'صيانة الحاسوب', 3, '-', '-'),
('IT 241', 'Signals and Systems', 'الإشارات والأنظمة', 3, 'Mathematics-2', 'رياضيات 2'),
('ST 122', 'Probability and Statistics-2', 'احتمالات وإحصاء 2', 3, 'Probability and Statistics-1', 'احتمالات وإحصاء 1');

-- --------------------------------------------------------

--
-- Table structure for table `files`
--

CREATE TABLE `files` (
  `FileId` int(11) NOT NULL,
  `FileName` longtext DEFAULT NULL,
  `FilePath` longtext DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `ChatId` int(11) DEFAULT NULL,
  `StudentId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `files`
--

INSERT INTO `files` (`FileId`, `FileName`, `FilePath`, `CreatedAt`, `ChatId`, `StudentId`) VALUES
(11, 'Backend Documentation.pdf', 'C:\\Users\\Hp\\Source\\Repos\\finalProject\\finalProject\\wwwroot\\uploads\\Backend Documentation.pdf', '2025-06-07 04:37:01.269543', 2, 1),
(12, 'Backend Documentation.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\Backend Documentation.pdf', '2025-06-07 05:06:04.506228', 2, 1),
(13, 'Backend Documentation.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\Backend Documentation.pdf', '2025-06-08 16:35:22.165812', 2, 1),
(18, 'نسخة_منسقة_بانوراما.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\نسخة_منسقة_بانوراما.pdf', '2025-06-09 01:02:10.748816', 2, 1),
(19, 'Grad_Project_Report.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\Grad_Project_Report.pdf', '2025-06-09 01:13:17.682667', 6, 2),
(20, 'ACADEMIC GUdance.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\ACADEMIC GUdance.pdf', '2025-06-09 22:05:02.649573', 8, 2),
(21, 'ACADEMIC GUdance.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\ACADEMIC GUdance.pdf', '2025-06-09 22:35:41.518475', 11, 2),
(22, 'Backend-documentation.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\Backend-documentation.pdf', '2025-06-09 22:59:06.735332', 13, 1),
(23, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-09 23:08:08.413909', 15, 2),
(24, 'Paper.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\Paper.pdf', '2025-06-10 19:30:35.266513', 16, 1),
(25, 'استمارة  جماعية-فردية حضور مشروع تخرج.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\استمارة  جماعية-فردية حضور مشروع تخرج.pdf', '2025-06-10 23:16:15.304152', 19, 2),
(26, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 03:36:41.583904', 21, 2),
(27, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 03:54:55.470295', 24, 2),
(28, 'ASP-Final Project_f3a5111ed5b76dc6c2855ee47490be3d.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\ASP-Final Project_f3a5111ed5b76dc6c2855ee47490be3d.pdf', '2025-06-11 05:40:35.629049', 27, 1),
(29, 'Paper.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\Paper.pdf', '2025-06-11 07:09:29.781888', 28, 1),
(30, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 07:48:19.269538', 29, 2),
(31, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 07:55:31.236827', 29, 2),
(32, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 07:57:39.370269', 29, 2),
(33, 'استمارة  جماعية-فردية حضور مشروع تخرج.pdf', 'C:\\Users\\Hp\\Source\\Repos\\finalProject\\finalProject\\wwwroot\\uploads\\استمارة  جماعية-فردية حضور مشروع تخرج.pdf', '2025-06-11 08:13:43.523635', 30, 1),
(34, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 08:14:47.307308', 29, 2),
(35, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 08:24:32.028665', 29, 2),
(36, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 08:38:53.438084', 29, 2),
(37, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 08:46:26.345945', 29, 2),
(38, 'استمارة  جماعية-فردية حضور مشروع تخرج.pdf', 'C:\\Users\\Hp\\Source\\Repos\\finalProject\\finalProject\\wwwroot\\uploads\\استمارة  جماعية-فردية حضور مشروع تخرج.pdf', '2025-06-11 08:53:47.083461', 30, 1),
(39, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 08:56:13.649049', 29, 2),
(40, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 08:58:29.924193', 29, 2),
(41, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 08:59:28.966186', 29, 2),
(42, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 09:07:06.471977', 29, 2),
(43, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 09:13:09.874376', 31, 2),
(44, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 09:18:45.097042', 31, 2),
(45, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 09:30:57.608731', 31, 2),
(46, 'Database_Tables_Documentation.pdf', 'C:\\Users\\Hp\\Source\\Repos\\finalProject\\finalProject\\wwwroot\\uploads\\Database_Tables_Documentation.pdf', '2025-06-11 09:51:27.846610', 30, 1),
(47, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 09:58:37.482575', 32, 2),
(48, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 10:18:29.882425', 33, 2),
(49, 'AbdullahMahmoudResume (1).pdf.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\AbdullahMahmoudResume (1).pdf.pdf', '2025-06-11 10:26:20.563669', 34, 1),
(50, 'AbdullahMahmoudResume (1).pdf.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\AbdullahMahmoudResume (1).pdf.pdf', '2025-06-11 11:23:40.500338', 35, 1),
(51, '1-introduction-to-ethical-hacking.pdf', 'D:\\Sites\\site12635\\wwwroot\\wwwroot\\uploads\\1-introduction-to-ethical-hacking.pdf', '2025-06-11 18:56:57.801915', 36, 2);

-- --------------------------------------------------------

--
-- Table structure for table `general requirements_compulsory`
--

CREATE TABLE `general requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `general requirements_compulsory`
--

INSERT INTO `general requirements_compulsory` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('HU 111', 'English-1', 'اللغة الإنجليزية 1', 2, '-', '-'),
('HU 112', 'English-2', 'اللغة الإنجليزية 2', 2, 'English-1', 'اللغة الإنجليزية 1'),
('HU 313', 'Human Rights', 'حقوق الإنسان و مكافحة الفساد', 2, '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `general requirements_electives`
--

CREATE TABLE `general requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `general requirements_electives`
--

INSERT INTO `general requirements_electives` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('HU 121', 'Fundamentals of Economics', 'مبادئ الاقتصاد', 3, '-', '-'),
('HU 213', 'English-3', 'اللغة الإنجليزية 3', 3, 'English-2', 'اللغة الإنجليزية 2'),
('HU 323', 'Fundamentals of Accounting', 'مبادئ المحاسبة', 3, '-', '-'),
('HU 331', 'Communication & Negotiation Skills', 'مهارات التفاوض والاتصال', 3, '-', '-'),
('HU 332', 'Creative Thinking', 'التفكير الإبداعي', 3, '-', '-'),
('HU 333', 'Mass Communication', 'الإعلام', 3, '-', '-'),
('HU 334', 'Professional Ethics', 'الأخلاقيات المهنية', 3, '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `is requirements_compulsory`
--

CREATE TABLE `is requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `is requirements_compulsory`
--

INSERT INTO `is requirements_compulsory` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('IS 313', 'Data Storage and Retrieval', 'تخزين واسترجاع البيانات', 3, 'Database Systems-1', 'أنظمة قواعد البيانات 1'),
('IS 333', 'Management Information Systems', 'أنظمة معلومات الإدارة', 3, 'Fundamentals of Information Systems', 'أساسيات نظم المعلومات'),
('IS 345', 'Internet Applications', 'تطبيقات الإنترنت', 3, 'Internet Technology', 'تقنيات الإنترنت'),
('IS 350', 'Business intelligence and data Analytical', 'ذكاء الأعمال وتحليل البيانات', 3, 'Probability and Statistics-2', 'الاحتمالات والإحصاء 2'),
('IS 352', 'Analysis and Design of Information Systems-2', 'تحليل وتصميم نظم المعلومات-2', 3, 'System Analysis and Design-1', 'تحليل وتصميم النظم-1'),
('IS 360', 'Introduction to Data Science', 'مقدمة في علوم البيانات', 3, 'Database Systems-2', 'أنظمة قواعد البيانات 2'),
('IS 365', 'Big Data Technologies', 'تقنيات البيانات الضخمة', 3, 'Database Systems-1', 'أنظمة قواعد البيانات 1'),
('IS 414', 'Information Systems Security', 'أمن نظم المعلومات', 3, 'Database Systems-1', 'أنظمة قواعد البيانات 1'),
('IS 448', 'Knowledge base management', 'إدارة قواعد المعرفة', 3, 'Database Systems-2', 'أنظمة قواعد البيانات 2'),
('IS 451', 'Decision Support Systems', 'نظم دعم القرار', 3, 'Fundamentals of Information Systems', 'أساسيات نظم المعلومات'),
('IS 498', 'Project', 'مشروع', 6, 'System Analysis and Design-1', 'تحليل وتصميم النظم-1'),
('IT 311', 'Database Systems-2', 'أنظمة قواعد البيانات 2', 3, 'Database Systems-1', 'أنظمة قواعد البيانات 1');

-- --------------------------------------------------------

--
-- Table structure for table `is requirements_electives`
--

CREATE TABLE `is requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `is requirements_electives`
--

INSERT INTO `is requirements_electives` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('AI 310', 'Artificial Intelligence', 'الذكاء الاصطناعي', 3, 'Algorithms', 'الخوارزميات'),
('CS 352', 'Software Engineering -2', 'هندسة البرمجيات - 2', 3, 'Software Engineering -1', 'هندسة البرمجيات - 1'),
('IS 334', 'Accounting Information Systems', 'نظم معلومات المحاسبة', 3, 'Fundamentals of Information Systems', 'أساسيات نظم المعلومات'),
('IS 415', 'Object Oriented Database', 'قواعد البيانات الموجهة للكائنات', 3, 'Database Systems – 1', 'أنظمة قواعد البيانات 1'),
('IS 416', 'Distributed Database', 'قواعد البيانات الموزعة', 3, 'Database Systems – 1', 'أنظمة قواعد البيانات 1'),
('IS 421', 'Data Mining', 'تنقيب البيانات', 3, 'Database Systems – 1', 'أنظمة قواعد البيانات 1'),
('IS 422', 'Data Warehousing', 'مستودعات البيانات', 3, 'Database Systems – 1', 'أنظمة قواعد البيانات 1'),
('IS 434', 'Quality Assurance of Information Systems and Programming', 'ضمان جودة نظم المعلومات والبرمجة', 3, 'Analysis and Design of Information Systems-2', 'تحليل وتصميم نظم المعلومات-2'),
('IS 435', 'Information Centers Management', 'إدارة مراكز المعلومات', 3, '-', '-'),
('IS 441', 'Intelligent Information Systems', 'نظم المعلومات الذكية', 3, 'Artificial Intelligence', 'الذكاء الاصطناعي'),
('IS 442', 'E-Commerce', 'التجارة الإلكترونية', 3, 'Internet Applications', 'تطبيقات الإنترنت'),
('IS 443', 'Geographical Information Systems', 'نظم المعلومات الجغرافية', 3, 'Database Systems – 1', 'أنظمة قواعد البيانات 1'),
('IS 444', 'Multimedia Information Systems', 'نظم معلومات الوسائط المتعددة', 3, 'Database Systems – 1', 'أنظمة قواعد البيانات 1'),
('IS 450', 'Software testing and integration', 'اختبار البرمجيات والتكامل', 3, 'Analysis and Design of Information Systems-2', 'تحليل وتصميم نظم المعلومات-2'),
('IS 453', 'Information Systems Development Methodologies', 'منهجيات تطوير نظم المعلومات', 3, 'Analysis and Design of Information Systems-2', 'تحليل وتصميم نظم المعلومات-2'),
('IS 455', 'Software Quality Assurance and Testing', 'ضمان جودة واختبار البرمجيات', 3, 'Fundamentals of Information Systems', 'أساسيات نظم المعلومات'),
('IS 460', 'Introduction to deep learning', 'مقدمة في التعلم العميق', 3, 'Knowledge base management', 'إدارة قواعد المعرفة'),
('IS 496', 'Selected Topics in Information Systems', 'مواضيع مختارة في نظم المعلومات', 3, 'Level 4', 'المستوى 4'),
('IT 423', 'Information and Computer Networks Security', 'أمن المعلومات وشبكات الحاسوب', 3, 'Computers Network -1', 'شبكات الحاسوب - 1');

-- --------------------------------------------------------

--
-- Table structure for table `it requirements_compulsory`
--

CREATE TABLE `it requirements_compulsory` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `it requirements_compulsory`
--

INSERT INTO `it requirements_compulsory` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('AI 310', 'Artificial Intelligence', 'الذكاء الاصطناعي', 3, 'Algorithms', 'الخوارزميات'),
('IT 311', 'Computer Architecture', 'هندسة الحاسوب', 3, 'Logic Design', 'تصميم المنطق'),
('IT 321', 'Communication Technology', 'تقنية الاتصالات', 3, 'Data Communication', 'الاتصالات البيانات'),
('IT 322', 'Computers Network-2', 'شبكات الحاسوب 2', 3, 'Computer Networks-1', 'شبكات الحاسوب 1'),
('IT 331', 'Computer Graphics-1', 'الرسومات الحاسوبية 1', 3, 'Programming-1', 'البرمجة 1'),
('IT 341', 'Digital Signal Processing', 'معالجة الإشارات الرقمية', 3, 'Discrete Mathematics', 'الرياضيات المتقطعة'),
('IT 342', 'Pattern Recognitions', 'التعرف على الأنماط', 3, '-', '-'),
('IT 423', 'Information and Computer Networks Security', 'أمن المعلومات وشبكات الحاسوب', 3, 'Computer Networks-1', 'شبكات الحاسوب 1'),
('IT 433', 'Multimedia', 'الوسائط المتعددة', 3, 'Programming-1', 'البرمجة 1'),
('IT 441', 'Image Processing-1', 'معالجة الصور 1', 3, 'Signals and Systems', 'الإشارات والأنظمة'),
('IT 444', 'Computer Vision', 'الرؤية الحاسوبية', 3, 'Algorithms', 'الخوارزميات'),
('IT 498', 'Project', 'مشروع', 6, 'Computer Networks-1', 'شبكات الحاسوب 1');

-- --------------------------------------------------------

--
-- Table structure for table `it requirements_electives`
--

CREATE TABLE `it requirements_electives` (
  `code` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `course_Name_ar` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `prerequest_en` longtext DEFAULT NULL,
  `prerequest_ar` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `it requirements_electives`
--

INSERT INTO `it requirements_electives` (`code`, `course_Name_en`, `course_Name_ar`, `hours`, `prerequest_en`, `prerequest_ar`) VALUES
('CS 352', 'Software Engineering-2', 'هندسة البرمجيات-2', 3, 'Software Engineering-1', 'هندسة البرمجيات-1'),
('IS 312', 'Database Systems-2', 'أنظمة قواعد البيانات-2', 3, 'Database Systems-1', 'أنظمة قواعد البيانات-1'),
('IS 345', 'Internet Applications', 'تطبيقات الإنترنت', 3, 'Internet Technology', 'تقنية الإنترنت'),
('IT 312', 'Microprocessors', 'المعالجات الدقيقة', 3, 'Logic Design', 'تصميم المنطق'),
('IT 313', 'Computer Interfaces', 'واجهات الحاسوب', 3, 'Computer Architecture', 'هندسة الحاسوب'),
('IT 332', 'Computer Graphics-2', 'الرسومات الحاسوبية 2', 3, 'Computer Graphics-1', 'الرسومات الحاسوبية 1'),
('IT 411', 'Distributed and Parallel computer systems', 'أنظمة الحاسوب الموزعة والمتوازية', 3, 'Computer Architecture', 'هندسة الحاسوب'),
('IT 412', 'Real Time Systems', 'أنظمة الوقت الحقيقي', 3, 'Computer Architecture', 'هندسة الحاسوب'),
('IT 414', 'Embedded Systems', 'الأنظمة المدمجة', 3, 'Microprocessors', 'المعالجات الدقيقة'),
('IT 415', 'Robotics', 'الروبوتات', 3, 'Discrete Mathematics', 'الرياضيات المتقطعة'),
('IT 422', 'Wireless and Mobile Networks', 'الشبكات اللاسلكية والمتحركة', 3, 'Computers Network-2', 'شبكات الحاسوب 2'),
('IT 425', 'Embedded Internet of things System', 'الإنترنت المدمج للأشياء', 3, 'Embedded Systems', 'الأنظمة المدمجة'),
('IT 431', 'Virtual Reality', 'الواقع الافتراضي', 3, 'Computer Graphics-1', 'الرسومات الحاسوبية 1'),
('IT 442', 'Image Processing-2', 'معالجة الصور 2', 3, 'Image Processing-1', 'معالجة الصور 1'),
('IT 443', 'Speech Processing', 'معالجة الكلام', 3, 'Signals and Systems', 'الإشارات والأنظمة'),
('IT 455', 'Image, audio and Video Processing', 'معالجة الصور والصوت والفيديو', 3, 'Speech Processing', 'معالجة الكلام'),
('IT 456', '3D Modeling and Animation', 'النمذجة ثلاثية الأبعاد والرسوم المتحركة', 3, 'Computer Graphics-1', 'الرسومات الحاسوبية 1'),
('IT 457', 'Development Game', 'تطوير الألعاب', 3, 'Computer Graphics-1', 'الرسومات الحاسوبية 1'),
('IT 496', 'Selected Topics in Information Technology', 'مواضيع مختارة في تكنولوجيا المعلومات', 3, '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `StudentId` int(11) NOT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `FirstName` longtext DEFAULT NULL,
  `lastName` longtext DEFAULT NULL,
  `Password` longtext DEFAULT NULL,
  `Token` longtext DEFAULT NULL,
  `role` longtext DEFAULT NULL,
  `hours` int(11) DEFAULT NULL,
  `gpa` double DEFAULT NULL,
  `department_en` longtext DEFAULT NULL,
  `department_ar` longtext DEFAULT NULL,
  `isActive` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`StudentId`, `Email`, `FirstName`, `lastName`, `Password`, `Token`, `role`, `hours`, `gpa`, `department_en`, `department_ar`, `isActive`) VALUES
(1, 'Abdullah_20210560@fci.helwan.edu.eg', 'Abdullah', 'Mahmoud', '$2a$11$VwhBe5oeHZZq5WcI6FRbK.J/VJVKoj12zOTkxdrW67wipeSpqNplq', 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJlbWFpbCI6IkFiZHVsbGFoXzIwMjEwNTYwQGZjaS5oZWx3YW4uZWR1LmVnIiwiZmlyc3ROYW1lIjoiQWJkdWxsYWgiLCJsYXN0TmFtZSI6Ik1haG1vdWQiLCJkZXBhcnRtZW50X2VuIjoiQ1MiLCJkZXBhcnRtZW50X2FyIjoi2LnZhNmI2YUg2KfZhNit2KfYs9ioIiwianRpIjoiNGM0ODcwZGQtMjNkNi00ZmMxLWI4NGMtYjk2N2M0YTFmNTk4IiwiZXhwIjoxNzUwOTM2ODk5LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjcxNTUiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjUwMDAifQ.2kRSqbfsAVJAGDStbZeCha7Z8rmELOjifWKPC6Qy-OM', 'Student', 19, 3.139473684210526, 'CS', 'علوم الحاسب', 1),
(2, 'Abdulrahmman_20210514@fci.helwan.edu.eg', 'Abdalrahman', 'Abdelaziz', '$2a$11$Gb2A4XJ6jpZs9BjW417RU.k3/knuwNxWJND/8pLc3t6xLjfZWyI4O', 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjIiLCJlbWFpbCI6IkFiZHVscmFobW1hbl8yMDIxMDUxNEBmY2kuaGVsd2FuLmVkdS5lZyIsImZpcnN0TmFtZSI6IkFiZGFscmFobWFuIiwibGFzdE5hbWUiOiJBYmRlbGF6aXoiLCJkZXBhcnRtZW50X2VuIjoiR2VuZXJhbCIsImRlcGFydG1lbnRfYXIiOiLYudin2YUiLCJqdGkiOiIyYTdlZThjOC01ODRiLTQ0N2QtYjQzOS00NjJmZjU2OTVkODQiLCJleHAiOjE3NTA5NjQxNjcsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NzE1NSIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3Q6NTAwMCJ9.qOHv9uNqVj77FIkuxUD7k3OvQFuvLPZzbq-khvmqIf8', 'Student', 27, 3.2783333333333338, 'General', 'عام', 1);

-- --------------------------------------------------------

--
-- Table structure for table `studentsubjects`
--

CREATE TABLE `studentsubjects` (
  `Id` int(11) NOT NULL,
  `SubjectCode` varchar(255) DEFAULT NULL,
  `grade` longtext DEFAULT NULL,
  `StudentId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `studentsubjects`
--

INSERT INTO `studentsubjects` (`Id`, `SubjectCode`, `grade`, `StudentId`) VALUES
(1, 'HU 111', 'A+', 1),
(2, 'HU 111', 'A+', 2),
(3, 'HU 112', 'A', 2),
(4, 'HU 323', 'A+', 2),
(5, 'CS 111', 'B+', 2),
(6, 'IS 211', 'D+', 2),
(7, 'PH 111', 'B+', 2),
(8, 'CS 112', 'C+', 2),
(9, 'HU 112', 'B+', 1),
(10, 'CS 214', 'A', 2),
(11, 'HU 121', 'A', 1),
(12, 'HU 313', 'A+', 2),
(13, 'HU 122', 'B', 2),
(14, 'IS 231', 'D+', 2),
(15, 'HU 323', 'C+', 1),
(16, 'CS 111', 'C+', 1),
(17, 'IS 231', 'C+', 1),
(18, 'IS 211', 'C+', 1);

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `SubjectCode` varchar(255) NOT NULL,
  `course_Name_en` longtext DEFAULT NULL,
  `hours` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`SubjectCode`, `course_Name_en`, `hours`) VALUES
('AI 310', 'Artificial Intelligence', 3),
('AI 320', 'Convex Optimization Theory', 3),
('AI 330', 'Machine Learning', 3),
('AI 335', 'Neural Networks & Deep Learning', 3),
('AI 350', 'Data Visualization', 3),
('AI 360', 'Natural Language Processing', 3),
('AI 370', 'Advanced Machine Learning', 3),
('AI 380', 'Human Computer Interaction', 3),
('AI 420', 'Evolutionary Algorithm', 3),
('AI 430', 'Computational Intelligence', 3),
('AI 435', 'Spoken Language Processing', 3),
('AI 457', 'Knowledge Representation', 3),
('AI 460', 'Natural Language Understanding', 3),
('AI 490', 'Bioinformatics', 3),
('AI 496', 'Selected Topics in Artificial Intelligence', 3),
('AI 498', 'Project', 6),
('CS 111', 'Introduction to Computers', 3),
('CS 112', 'Programming-1', 3),
('CS 213', 'Programming-2', 3),
('CS 214', 'Data Structures', 3),
('CS 221', 'Logic Design', 3),
('CS 241', 'Operating Systems-1', 3),
('CS 251', 'Software Engineering-1', 3),
('CS 313', 'Programming-3', 3),
('CS 316', 'Algorithms', 3),
('CS 322', 'Computer Organization', 3),
('CS 342', 'Operating Systems-2', 3),
('CS 352', 'Software Engineering-2', 3),
('CS 405', 'Theory of Computation', 3),
('CS 410', 'Concepts of Programming Languages', 3),
('CS 416', 'Advanced Algorithms', 3),
('CS 419', 'Compilers', 3),
('CS 460', 'Distributed Systems and Cloud Computing', 3),
('CS 471', 'Parallel Processing and High Performance Computing', 3),
('CS 480', 'Cryptography', 3),
('CS 496', 'Selected Topics in Computer Science', 3),
('CS 498', 'Project', 6),
('HU 111', 'English-1', 2),
('HU 112', 'English-2', 2),
('HU 121', 'Fundamentals of Economics', 3),
('HU 122', 'Fundamentals of Management', 3),
('HU 213', 'English-3', 3),
('HU 313', 'Human Rights', 2),
('HU 323', 'Fundamentals of Accounting', 3),
('HU 331', 'Communication & Negotiation Skills', 3),
('HU 332', 'Creative Thinking', 3),
('HU 333', 'Mass Communication', 3),
('HU 334', 'Professional Ethics', 3),
('IS 211', 'Database Systems-1', 3),
('IS 231', 'Fundamentals of Information Systems', 3),
('IS 240', 'Operations Research', 3),
('IS 241', 'Modeling and Simulation', 3),
('IS 312', 'Database Systems-2', 3),
('IS 313', 'Data Storage and Retrieval', 3),
('IS 321', 'Projects Management', 3),
('IS 333', 'Management Information Systems', 3),
('IS 334', 'Accounting Information Systems', 3),
('IS 342', 'Simulation Languages', 3),
('IS 345', 'Internet Applications', 3),
('IS 350', 'Business Intelligence and Data Analytical', 3),
('IS 351', 'System Analysis and Design-1', 3),
('IS 352', 'Analysis and Design of Information Systems-2', 3),
('IS 360', 'Introduction to Data Science', 3),
('IS 365', 'Big Data Technologies', 3),
('IS 414', 'Information Systems Security', 3),
('IS 415', 'Object Oriented Database', 3),
('IS 416', 'Distributed Database', 3),
('IS 421', 'Data Mining', 3),
('IS 422', 'Data Warehousing', 3),
('IS 434', 'Quality Assurance of Information Systems and Programming', 3),
('IS 435', 'Information Centers Management', 3),
('IS 441', 'Intelligent Information Systems', 3),
('IS 442', 'E-Commerce', 3),
('IS 443', 'Geographical Information Systems', 3),
('IS 444', 'Multimedia Information Systems', 3),
('IS 448', 'Knowledge base management', 3),
('IS 450', 'Software Testing and Integration', 3),
('IS 451', 'Decision Support Systems', 3),
('IS 453', 'Information Systems Development Methodologies', 3),
('IS 455', 'Software Quality Assurance and Testing', 3),
('IS 460', 'Introduction to Deep Learning', 3),
('IS 496', 'Selected Topics in Information Systems', 3),
('IS 498', 'Project', 6),
('IT 111', 'Electronics-1', 3),
('IT 211', 'Computer Maintenance', 3),
('IT 221', 'Data Communication', 3),
('IT 222', 'Computer Networks-1', 3),
('IT 223', 'Internet Technology', 3),
('IT 241', 'Signals and Systems', 3),
('IT 311', 'Computer Architecture', 3),
('IT 312', 'Microprocessors', 3),
('IT 313', 'Computer Interfaces', 3),
('IT 321', 'Communication Technology', 3),
('IT 322', 'Computers Network-2', 3),
('IT 331', 'Computer Graphics-1', 3),
('IT 332', 'Computer Graphics-2', 3),
('IT 341', 'Digital Signal Processing', 3),
('IT 342', 'Pattern Recognition', 3),
('IT 411', 'Distributed and Parallel Computer Systems', 3),
('IT 412', 'Real Time Systems', 3),
('IT 414', 'Embedded Systems', 3),
('IT 415', 'Robotics', 3),
('IT 422', 'Wireless and Mobile Networks', 3),
('IT 423', 'Information and Computer Networks Security', 3),
('IT 425', 'Embedded Internet of Things System', 3),
('IT 431', 'Virtual Reality', 3),
('IT 433', 'Multimedia', 3),
('IT 441', 'Image Processing-1', 3),
('IT 442', 'Image Processing-2', 3),
('IT 443', 'Speech Processing', 3),
('IT 444', 'Computer Vision', 3),
('IT 455', 'Image, Audio and Video Processing', 3),
('IT 456', '3D Modeling and Animation', 3),
('IT 457', 'Game Development', 3),
('IT 496', 'Selected Topics in Information Technology', 3),
('IT 498', 'Project', 6),
('MA 111', 'Mathematics-1', 3),
('MA 112', 'Discrete Mathematics', 3),
('MA 113', 'Mathematics-2', 3),
('PH 111', 'Physics', 3),
('ST 121', 'Probability and Statistics-1', 3),
('ST 122', 'Probability and Statistics-2', 3);

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
('20250530233547_allTablesAndInsertData', '8.0.15'),
('20250606142912_addChatPDF', '8.0.15'),
('20250607025631_ChatPDF', '8.0.15'),
('20250607042356_updatechatPDF', '8.0.15');

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
-- Indexes for table `chathistories`
--
ALTER TABLE `chathistories`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_ChatHistories_StudentId` (`StudentId`);

--
-- Indexes for table `chathistoriespdf`
--
ALTER TABLE `chathistoriespdf`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_ChatHistoriesPDF_StudentId` (`StudentId`);

--
-- Indexes for table `chatmessagepdfs`
--
ALTER TABLE `chatmessagepdfs`
  ADD PRIMARY KEY (`MessageId`),
  ADD KEY `IX_chatMessagePDFs_ChatId` (`ChatId`),
  ADD KEY `IX_chatMessagePDFs_StudentId` (`StudentId`);

--
-- Indexes for table `chatmessages`
--
ALTER TABLE `chatmessages`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_ChatMessages_ChatHistoryId` (`ChatHistoryId`),
  ADD KEY `IX_ChatMessages_StudentId` (`StudentId`);

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
-- Indexes for table `files`
--
ALTER TABLE `files`
  ADD PRIMARY KEY (`FileId`),
  ADD KEY `IX_Files_ChatId` (`ChatId`),
  ADD KEY `IX_Files_StudentId` (`StudentId`);

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
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`StudentId`),
  ADD UNIQUE KEY `IX_Students_Email` (`Email`);

--
-- Indexes for table `studentsubjects`
--
ALTER TABLE `studentsubjects`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_StudentSubjects_StudentId` (`StudentId`),
  ADD KEY `IX_StudentSubjects_SubjectCode` (`SubjectCode`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`SubjectCode`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chathistories`
--
ALTER TABLE `chathistories`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=196;

--
-- AUTO_INCREMENT for table `chathistoriespdf`
--
ALTER TABLE `chathistoriespdf`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `chatmessagepdfs`
--
ALTER TABLE `chatmessagepdfs`
  MODIFY `MessageId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- AUTO_INCREMENT for table `chatmessages`
--
ALTER TABLE `chatmessages`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=185;

--
-- AUTO_INCREMENT for table `files`
--
ALTER TABLE `files`
  MODIFY `FileId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `StudentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `studentsubjects`
--
ALTER TABLE `studentsubjects`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `chathistories`
--
ALTER TABLE `chathistories`
  ADD CONSTRAINT `FK_ChatHistories_Students_StudentId` FOREIGN KEY (`StudentId`) REFERENCES `students` (`StudentId`);

--
-- Constraints for table `chathistoriespdf`
--
ALTER TABLE `chathistoriespdf`
  ADD CONSTRAINT `FK_ChatHistoriesPDF_Students_StudentId` FOREIGN KEY (`StudentId`) REFERENCES `students` (`StudentId`);

--
-- Constraints for table `chatmessagepdfs`
--
ALTER TABLE `chatmessagepdfs`
  ADD CONSTRAINT `FK_chatMessagePDFs_ChatHistoriesPDF_ChatId` FOREIGN KEY (`ChatId`) REFERENCES `chathistoriespdf` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_chatMessagePDFs_Students_StudentId` FOREIGN KEY (`StudentId`) REFERENCES `students` (`StudentId`) ON DELETE CASCADE;

--
-- Constraints for table `chatmessages`
--
ALTER TABLE `chatmessages`
  ADD CONSTRAINT `FK_ChatMessages_ChatHistories_ChatHistoryId` FOREIGN KEY (`ChatHistoryId`) REFERENCES `chathistories` (`Id`),
  ADD CONSTRAINT `FK_ChatMessages_Students_StudentId` FOREIGN KEY (`StudentId`) REFERENCES `students` (`StudentId`);

--
-- Constraints for table `files`
--
ALTER TABLE `files`
  ADD CONSTRAINT `FK_Files_ChatHistoriesPDF_ChatId` FOREIGN KEY (`ChatId`) REFERENCES `chathistoriespdf` (`Id`),
  ADD CONSTRAINT `FK_Files_Students_StudentId` FOREIGN KEY (`StudentId`) REFERENCES `students` (`StudentId`);

--
-- Constraints for table `studentsubjects`
--
ALTER TABLE `studentsubjects`
  ADD CONSTRAINT `FK_StudentSubjects_Students_StudentId` FOREIGN KEY (`StudentId`) REFERENCES `students` (`StudentId`),
  ADD CONSTRAINT `FK_StudentSubjects_Subjects_SubjectCode` FOREIGN KEY (`SubjectCode`) REFERENCES `subjects` (`SubjectCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
