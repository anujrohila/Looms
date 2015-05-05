-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 19, 2013 at 05:48 PM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `ecom_development`
--

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE IF NOT EXISTS `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `category_id` int(11) DEFAULT NULL,
  `product_name` varchar(255) DEFAULT NULL,
  `product_short_desc` text,
  `product_long_desc` text,
  `quantity` int(11) DEFAULT NULL,
  `price` float DEFAULT NULL,
  `photo` varchar(255) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  `is_delete` tinyint(1) DEFAULT NULL,
  `created_by` int(11) DEFAULT NULL,
  `updated_by` int(11) DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=140 ;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`id`, `category_id`, `product_name`, `product_short_desc`, `product_long_desc`, `quantity`, `price`, `photo`, `is_active`, `is_delete`, `created_by`, `updated_by`, `created_at`, `updated_at`) VALUES
(1, 11, 'Levis', 'High star slim jeans for man', 'levis jeans brand', 5, 2599, '20131215184707.jpg', 1, 0, 1, 1, '2013-12-15 13:17:07', '2013-12-15 13:17:07'),
(2, 0, 'Blue-ds-colt-32', 'Blue-ds-colt-jeans for men', 'levis jeans foe men', 10, 999, '20131215194654.jpg', 1, 0, 1, 1, '2013-12-15 14:15:54', '2013-12-15 14:16:54'),
(3, 57, 'hsb-00-2-high-star-32', 'High star slim jeans for man', 'Levis ', 5, 799, '20131215194831.jpg', 1, 0, 1, 1, '2013-12-15 14:18:31', '2013-12-15 14:18:31'),
(4, 62, 'Formal Shirt', 'Blue Cuffle', 'New Arrival shirt', 12, 699, '20131215195046.jpg', 1, 0, 1, 1, '2013-12-15 14:20:46', '2013-12-15 14:20:46'),
(5, 62, 'Formal Shirt', 'Green-auburn-hill-40', 'Trouser now aviable', 10, 419, '20131215195305.jpg', 1, 0, 1, 1, '2013-12-15 14:23:05', '2013-12-15 14:23:05'),
(6, 12, 'Shoes', 'black-elm-green-kelp', 'Puma Shoes', 10, 899, '20131215212754.jpg', 1, 0, 1, 1, '2013-12-15 15:57:54', '2013-12-15 15:57:54'),
(7, 12, 'Shoes', 'dark-shadow-black-high-risk-red', 'Puma - 7', 5, 4498, '20131215212905.jpg', 1, 0, 1, 1, '2013-12-15 15:59:05', '2013-12-15 15:59:05'),
(8, 12, 'Shoes', 'biking-red', 'Puma - 9', 10, 1529, '20131215213020.jpg', 1, 0, 1, 1, '2013-12-15 16:00:20', '2013-12-15 16:00:20'),
(9, 12, 'Formal Shoes', 'swagger-42', 'Black-1909', 10, 695, '20131215213200.jpg', 1, 0, 1, 1, '2013-12-15 16:02:00', '2013-12-15 16:02:00'),
(10, 65, 'Black-pv7205', 'Formal Shoes', 'Provogue-42', 10, 1609, '20131215213346.jpg', 1, 0, 1, 1, '2013-12-15 16:03:46', '2013-12-15 16:03:46'),
(11, 65, 'Brown-1907', 'Formal Shoes', 'swagger-43', 11, 1659, '20131215213502.jpg', 1, 0, 1, 1, '2013-12-15 16:05:02', '2013-12-15 16:05:02'),
(12, 65, 'Brown-854182', 'hush-puppies-8', 'Casual shoes', 6, 3419, '20131215213645.jpg', 1, 0, 1, 1, '2013-12-15 16:06:45', '2013-12-15 16:06:45'),
(13, 66, 'black-leaf-green-186318', 'puma-12', 'Formal Shoes', 15, 1609, '20131215213814.jpg', 1, 0, 1, 1, '2013-12-15 16:08:14', '2013-12-15 16:08:14'),
(14, 66, 'Grey-dandelion-304829', 'puma-9', 'Formal Shoes', 6, 1749, '20131215213941.jpg', 1, 0, 1, 1, '2013-12-15 16:09:41', '2013-12-15 16:09:41'),
(15, 66, 'Blue-861030', 'power-6', 'Casual shoes', 3, 349, '20131215214056.jpg', 1, 0, 1, 1, '2013-12-15 16:10:56', '2013-12-15 16:10:56'),
(16, 64, 'black-rosso-corsa', 'puma-9', 'Formal Shoes', 10, 5248, '20131215214219.jpg', 1, 0, 1, 1, '2013-12-15 16:12:19', '2013-12-15 16:12:19'),
(17, 64, 'black-golden', 'sparx-8', 'Sport Shoes new brands', 2, 1889, '20131215214348.jpg', 1, 0, 1, 1, '2013-12-15 16:13:48', '2013-12-15 16:13:48'),
(18, 64, 'white-blue-black-silver', 'reebok-9', 'Casual shoes available', 9, 3009, '20131215214516.jpg', 1, 0, 1, 1, '2013-12-15 16:15:16', '2013-12-15 16:15:16'),
(19, 128, 'pp-6', 'corporate-bazaar-color-changing', 'Digital Clock', 5, 510, '20131215222947.jpg', 1, 0, 1, 1, '2013-12-15 16:59:47', '2013-12-15 16:59:47'),
(20, 43, 'canon-125', 'Canon ', 'Digital Camera', 6, 11495, '20131215223145.jpg', 1, 0, 1, 1, '2013-12-15 17:01:45', '2013-12-15 17:01:45'),
(21, 43, 'canon-a4000', 'Canon', 'New arrival canon', 5, 8155, '20131215223258.jpg', 1, 0, 1, 1, '2013-12-15 17:02:58', '2013-12-15 17:02:58'),
(22, 43, 'canon-eos', '600d-slr', 'Panasonic', 5, 32900, '20131215223432.jpg', 1, 0, 1, 1, '2013-12-15 17:04:32', '2013-12-15 17:04:32'),
(23, 44, 'nikon-coolpix-l28', 'Cool Pix', 'Canon', 5, 5310, '20131215223610.jpg', 1, 0, 1, 1, '2013-12-15 17:06:10', '2013-12-15 17:06:10'),
(24, 44, 'nikon-coolpix-l820', 'advance-point-and-shoot', 'Panasonic', 2, 53596, '20131215223732.jpg', 1, 0, 1, 1, '2013-12-15 17:07:32', '2013-12-15 17:07:32'),
(25, 44, 'nikon-d5100', 'Cool Pix', 'HD Cam', 5, 29000, '20131215223900.jpg', 1, 0, 1, 1, '2013-12-15 17:09:00', '2013-12-15 17:09:00'),
(26, 0, 'panasonic-dmc-fh4', 'point-shoot', 'Canon', 2, 4990, '20131215224646.jpg', 1, 0, 1, 1, '2013-12-15 17:16:46', '2013-12-15 17:16:46'),
(27, 45, 'panasonic-hx-dc3', 'camcorder', 'Nikon new Arrival ', 2, 12990, '20131215224835.jpg', 1, 0, 1, 1, '2013-12-15 17:18:35', '2013-12-15 17:18:35'),
(28, 45, 'panasonic-lumix-dmc-s3', 'Point Shoot', 'Sony HD Cam', 20, 4800, '20131215224956.jpg', 1, 0, 1, 1, '2013-12-15 17:19:56', '2013-12-15 17:19:56'),
(29, 46, 'sony-cyber-shot-dsc-w710', 'Point Shoot', 'Canon', 6, 5990, '20131215225202.jpg', 1, 0, 1, 1, '2013-12-15 17:22:02', '2013-12-15 17:22:02'),
(30, 46, 'sony-dsc-h100', 'Point Shoot', 'Canon', 10, 9255, '20131215225351.jpg', 1, 0, 1, 1, '2013-12-15 17:23:51', '2013-12-15 17:23:51'),
(31, 0, 'sony-cybershot-dsc-wx300', 'Point Shoot', 'Panasonic', 5, 17600, '20131215225442.jpg', 1, 0, 1, 1, '2013-12-15 17:24:42', '2013-12-15 17:24:42'),
(32, 129, 'horo-hr050-00', 'Horo 050', 'avilable in all nearest Shop', 11, 250, '20131215225651.jpg', 1, 0, 1, 1, '2013-12-15 17:26:51', '2013-12-15 17:26:51'),
(33, 129, 'horo-hr098', 'Horo 98', 'avilable in all nearest Shop', 10, 599, '20131215225750.jpg', 1, 0, 1, 1, '2013-12-15 17:27:50', '2013-12-15 17:27:50'),
(34, 126, 'orpat-tbzl367', 'Orpat', 'Available ', 8, 699, '20131215225933.jpg', 1, 0, 1, 1, '2013-12-15 17:29:33', '2013-12-15 17:29:33'),
(35, 126, 'orpat-tbsmzl867', 'Orapat', 'Good Quality', 8, 499, '20131215230037.jpg', 1, 0, 1, 1, '2013-12-15 17:30:37', '2013-12-15 17:30:37'),
(36, 127, 'dizionario-meea82b1314', 'Dizionario Black', 'Horo Cool Clock', 9, 599, '20131215230238.jpg', 1, 0, 1, 1, '2013-12-15 17:32:38', '2013-12-15 17:32:38'),
(37, 127, 'dizionario-meea801213', 'Dizionario Blue', 'Horo Cool Clock', 50, 399, '20131215230358.jpg', 1, 0, 1, 1, '2013-12-15 17:33:58', '2013-12-15 17:33:58'),
(38, 38, 'samsung-galaxy-note', 'HD Video Supporte', 'avilable in all nearest Shop', 5, 46900, '20131215230629.jpg', 1, 0, 1, 1, '2013-12-15 17:36:29', '2013-12-15 17:36:29'),
(39, 38, 'samsung-galaxy-note-800', 'Wide Screen', 'Micromax Tablat now aviable', 5, 34990, '20131215230754.jpg', 1, 0, 1, 1, '2013-12-15 17:37:54', '2013-12-15 17:37:54'),
(40, 38, 'samsung-galaxy-tab-3', 'Slim model', 'Micromax Tablat now aviable', 2, 25999, '20131215230934.jpg', 1, 0, 1, 1, '2013-12-15 17:39:34', '2013-12-15 17:39:34'),
(41, 35, 'apple-ipad', '64 gb supported', '64 gb internal memory aviable', 1, 52000, '20131215231225.jpg', 1, 0, 1, 1, '2013-12-15 17:42:25', '2013-12-15 17:42:25'),
(42, 35, 'apple-ipad-mini-wi-fi-and-cellular-32gb', '32 gb supported', 'Samsung 64 gb supportes with calling facility', 8, 35000, '20131215231401.jpg', 1, 0, 1, 1, '2013-12-15 17:44:01', '2013-12-15 17:44:01'),
(43, 37, 'asus-nexus7-1b085a', 'Wide Screen', 'Samsung 64 gb supportes with calling facility', 6, 11999, '20131215231536.jpg', 1, 0, 1, 1, '2013-12-15 17:45:36', '2013-12-15 17:45:36'),
(44, 37, 'asus-nexus-7', 'wide screen with 16 gb internal memory', 'Samsung 64 gb supportes with calling facility', 10, 8999, '20131215231650.jpg', 1, 0, 1, 1, '2013-12-15 17:46:50', '2013-12-15 17:46:50'),
(45, 47, 'dell-cn-04rphy', '1 tbHD', '1 tb avilable', 40, 3999, '20131215231918.jpg', 1, 0, 1, 1, '2013-12-15 17:49:18', '2013-12-15 17:49:18'),
(46, 47, 'transcend-storejet', '1 tbHD', 'Good Configuration Laptop Availble', 12, 4499, '20131215232029.jpg', 1, 0, 1, 1, '2013-12-15 17:50:29', '2013-12-15 17:50:29'),
(47, 47, 'wd-wdbkxh5000ard', '1 tbHD', 'lock supporte with security Drive', 9, 4450, '20131215232141.jpg', 1, 0, 1, 1, '2013-12-15 17:51:41', '2013-12-15 17:51:41'),
(48, 49, 'audio-technica', 'White headphone', 'NEw Product also available', 10, 253, '20131215232301.jpg', 1, 0, 1, 1, '2013-12-15 17:53:01', '2013-12-15 17:53:01'),
(49, 49, 'philips-shp1900', 'Good Voice Clearity', 'NEw Product also available', 40, 549, '20131215232418.jpg', 1, 0, 1, 1, '2013-12-15 17:54:18', '2013-12-15 17:54:18'),
(50, 49, 'hp-h1000', 'Good Voice Clearity', 'New arrival canon', 10, 358, '20131215232528.jpg', 1, 0, 1, 1, '2013-12-15 17:55:28', '2013-12-15 17:55:28'),
(51, 40, 'Dell-inspiron-notebook', '1 tb hd', 'intel cor i5 3rd generation', 5, 40900, '20131216122549.jpg', 1, 0, 1, 1, '2013-12-16 06:55:49', '2013-12-16 06:55:49'),
(52, 40, 'dell-vostro-2420-notebook', '500 gb HD', 'intel cor i5 2nd generation', 5, 32500, '20131216122702.jpg', 1, 0, 1, 1, '2013-12-16 06:57:02', '2013-12-16 06:57:02'),
(53, 40, 'Dell-vostro-notebook', '1 tbHD', 'Intel core i5 3rd generation', 2, 39500, '20131216122822.jpg', 1, 0, 1, 1, '2013-12-16 06:58:22', '2013-12-16 06:58:22'),
(54, 40, 'Dell-vostro-1450-notebook', '500 gbHD', 'intel cor i3 2nd generation processor', 5, 27490, '20131216122951.jpg', 1, 0, 1, 1, '2013-12-16 06:59:51', '2013-12-16 06:59:51'),
(55, 0, 'Ddell-vostro-1550-ci3-notebook', '500 gb HD', 'intel cor i3 2nd generation processor Linux operating system', 5, 26240, '20131216123107.jpg', 1, 0, 1, 1, '2013-12-16 07:01:07', '2013-12-16 07:01:07'),
(56, 39, 'HP-notebook-455', '500 gb HD', 'intel cor i3 2nd generation processor', 5, 21250, '20131216123301.jpg', 1, 0, 1, 1, '2013-12-16 07:03:01', '2013-12-16 07:03:01'),
(57, 39, 'HP-notebook-650', '500 gb HD', 'intel cor i3 2nd generation processor', 3, 27725, '20131216123419.jpg', 1, 0, 1, 1, '2013-12-16 07:04:19', '2013-12-16 07:04:19'),
(58, 39, 'HP-pavilion-notebook', '1tb HD', 'intel core i5 3rd generation', 2, 70000, '20131216123737.jpg', 1, 0, 1, 1, '2013-12-16 07:07:37', '2013-12-16 07:07:37'),
(59, 41, 'lenovo-essential-notebook', '500 gb HD 2bg RAM', 'intel cor i3 2nd generation processor', 5, 25690, '20131216123910.jpg', 1, 0, 1, 1, '2013-12-16 07:09:10', '2013-12-16 07:09:10'),
(60, 41, 'Lenovo-essential-notebook', '500 gb HD 4bg RAM', 'intel cor i5 2nd generation', 2, 31450, '20131216124025.jpg', 1, 0, 1, 1, '2013-12-16 07:10:25', '2013-12-16 07:10:25'),
(61, 41, 'Lenovo-essential-notebook', '1 tbHD 6gb RAM', 'intel cor i5 3rd generation', 5, 46250, '20131216124137.jpg', 1, 0, 1, 1, '2013-12-16 07:11:37', '2013-12-16 07:11:37'),
(62, 33, 'Micromax-bolt-a26', '64 gb internal memory', '2gb ram', 5, 15000, '20131216124325.jpg', 1, 0, 1, 1, '2013-12-16 07:13:25', '2013-12-16 07:13:25'),
(63, 33, 'Micromax-canvas-fun-canvas', '64 gb internal memory', 'wide screen high gh processor', 2, 25000, '20131216124442.jpg', 1, 0, 1, 1, '2013-12-16 07:14:42', '2013-12-16 07:14:42'),
(64, 33, 'micromax-x103', 'memory card supported', 'only audio supported Device', 10, 2000, '20131216124555.jpg', 1, 0, 1, 1, '2013-12-16 07:15:55', '2013-12-16 07:15:55'),
(65, 33, 'Micromax-eclipse-q66', '16 gb supported', 'wifi supported', 5, 5000, '20131216124649.jpg', 1, 0, 1, 1, '2013-12-16 07:16:49', '2013-12-16 07:16:49'),
(66, 14, 'etrol-free-size', 'Brown Color', 'Cool', 15, 695, '20131216124905.jpg', 1, 0, 1, 1, '2013-12-16 07:19:05', '2013-12-16 07:19:05'),
(67, 14, 'fms-022-103-flying-machine', 'Marron Shining', 'Sunglasses', 12, 836, '20131216125014.jpg', 1, 0, 1, 1, '2013-12-16 07:20:14', '2013-12-16 07:20:14'),
(68, 14, 'm102br1-fastrack', 'Red Shading', 'Sunglasses', 6, 1795, '20131216125112.jpg', 1, 0, 1, 1, '2013-12-16 07:21:12', '2013-12-16 07:21:12'),
(69, 14, 'fms-014-205-flying-machine', 'Brown Shading', 'Sunglasses', 10, 835, '20131216125214.jpg', 1, 0, 1, 1, '2013-12-16 07:22:14', '2013-12-16 07:22:14'),
(70, 73, 'Rayban-57', 'Black Shading', 'Wayfarer Sunglasses', 5, 6790, '20131216125418.jpg', 1, 0, 1, 1, '2013-12-16 07:24:18', '2013-12-16 07:24:18'),
(71, 73, 'Opium', 'Pink Shadding', 'Wayfarer Sunglasses', 5, 1495, '20131216125524.jpg', 1, 0, 1, 1, '2013-12-16 07:25:24', '2013-12-16 07:25:24'),
(72, 73, 'polaroid-eyewear', 'Brown Shading', 'Wayfarer Sunglasses', 5, 3661, '20131216125617.jpg', 1, 0, 1, 1, '2013-12-16 07:26:17', '2013-12-16 07:26:17'),
(73, 73, 'provogue', 'Blue shadding', 'Wayfarer Sunglasses', 7, 2750, '20131216125707.jpg', 1, 0, 1, 1, '2013-12-16 07:27:07', '2013-12-16 07:27:07'),
(74, 68, 'Casio-a554', 'Black Wrist Watch', 'Cashio cool Watch for Men', 5, 2270, '20131216125959.jpg', 1, 0, 1, 1, '2013-12-16 07:29:59', '2013-12-16 07:29:59'),
(75, 68, 'Casio-s059', 'Black Digital Watch', 'Casio cool Watch for Men', 8, 4995, '20131216130131.jpg', 1, 0, 1, 1, '2013-12-16 07:31:31', '2013-12-16 07:31:31'),
(76, 68, 'Casio-g271', 'Black Wrist Watch', 'Casio cool Watch for Men', 5, 6995, '20131216130314.jpg', 1, 0, 1, 1, '2013-12-16 07:33:14', '2013-12-16 07:33:14'),
(77, 67, 'Fastrack-3022sl01', 'Black Wrist Watch', 'Fastrack Coll Watch for Men', 5, 2595, '20131216130459.jpg', 1, 0, 1, 1, '2013-12-16 07:34:59', '2013-12-16 07:34:59'),
(78, 67, 'Fastrack-9915pp33', 'Red Wrist watch', 'Fastrack Cool Watch for Men', 10, 728, '20131216130634.jpg', 1, 0, 1, 1, '2013-12-16 07:36:34', '2013-12-16 07:36:34'),
(79, 67, 'Fastrack-788pp04', 'Black Wrist Watch', 'Fastrack Cool Watch for Men', 11, 895, '20131216130756.jpg', 1, 0, 1, 1, '2013-12-16 07:37:56', '2013-12-16 07:37:56'),
(80, 70, 'mh24-timex', 'Black with blue shading Wrist Watch', 'Timex Cool Watch for Men', 10, 1169, '20131216130935.jpg', 1, 0, 1, 1, '2013-12-16 07:39:35', '2013-12-16 07:39:35'),
(81, 69, 'Titan-nd390ym03', 'Titan Gold Watch', 'Titan Gold Watch', 10, 1995, '20131218232059.jpg', 1, 0, 1, 1, '2013-12-18 17:50:59', '2013-12-18 17:50:59'),
(82, 69, 'Titan-1445yl06', 'Titan black watch', 'Titan watch for cool men', 5, 1595, '20131218232250.jpg', 1, 0, 1, 1, '2013-12-18 17:52:50', '2013-12-18 17:52:50'),
(83, 69, 'Titan-1580yl04', 'Titan gold watch', 'Titan watch for cool men', 8, 1795, '20131218232419.jpg', 1, 0, 1, 1, '2013-12-18 17:54:19', '2013-12-18 17:54:19'),
(84, 69, 'Titan-1585sl03', 'Black Wrist Watch', 'Titan watch for cool men', 15, 1995, '20131218232538.jpg', 1, 0, 1, 1, '2013-12-18 17:55:38', '2013-12-18 17:55:38'),
(85, 69, 'Titan-nc9317bm', 'Silver ', '', 12, 2795, '20131218232704.jpg', 1, 0, 1, 1, '2013-12-18 17:57:04', '2013-12-18 17:57:04'),
(86, 69, 'Titan-nc9317bm', 'Silver+Golden', 'Titan Gold Watch', 12, 2795, '20131218232806.jpg', 1, 0, 1, 1, '2013-12-18 17:58:06', '2013-12-18 17:58:06'),
(87, 75, 'broun-riti-riwaz', 'Brown saree', 'Silk Material', 15, 700, '20131218233044.jpg', 1, 0, 1, 1, '2013-12-18 18:00:44', '2013-12-18 18:00:44'),
(88, 75, 'bred-prafful', 'Colorful saree', 'Colorful saree with silk material', 5, 1198, '20131218233216.jpg', 1, 0, 1, 1, '2013-12-18 18:02:16', '2013-12-18 18:02:16'),
(89, 75, 'ennthra', 'White with golden material', 'Silk Material', 19, 799, '20131218233326.jpg', 1, 0, 1, 1, '2013-12-18 18:03:26', '2013-12-18 18:03:26'),
(90, 75, 'urban-vastra', 'Green Saree', 'Saree from urban mills', 78, 1299, '20131218233448.jpg', 1, 0, 1, 1, '2013-12-18 18:04:48', '2013-12-18 18:04:48'),
(91, 75, 'urban-vastra', 'Urban Vastra', 'Saree from urban mills', 56, 999, '20131218233605.jpg', 1, 0, 1, 1, '2013-12-18 18:06:05', '2013-12-18 18:06:05'),
(92, 77, 'pink-avirate', 'Short dress', 'Skirt for summer season', 4, 1560, '20131218233918.jpg', 1, 0, 1, 1, '2013-12-18 18:09:18', '2013-12-18 18:09:18'),
(93, 77, 'vero-moda', 'Short dress', 'Skirt for summer season', 4, 2490, '20131218234158.jpg', 1, 0, 1, 1, '2013-12-18 18:11:58', '2013-12-18 18:11:58'),
(94, 77, 'black-freecult', 'Black Dress', 'Party Wear', 14, 1619, '20131218234305.jpg', 1, 0, 1, 1, '2013-12-18 18:13:05', '2013-12-18 18:13:05'),
(95, 77, 'alissa-purple', 'Purple Dress', 'Party Wear', 1, 2420, '20131218234409.jpg', 1, 0, 1, 1, '2013-12-18 18:14:09', '2013-12-18 18:14:09'),
(96, 77, 'magnetic-design', 'Black Dress', 'Party Wear', 23, 1499, '20131218234513.jpg', 1, 0, 1, 1, '2013-12-18 18:15:13', '2013-12-18 18:15:13'),
(97, 77, 'coral-harpa', 'Pink short Skirt', 'Design for summer', 14, 958, '20131218234621.jpg', 1, 0, 1, 1, '2013-12-18 18:16:21', '2013-12-18 18:16:21'),
(98, 74, 'jealous', 'Pink top', 'cotton material', 6, 699, '20131218234852.jpg', 1, 0, 1, 1, '2013-12-18 18:18:52', '2013-12-18 18:18:52'),
(99, 74, 'orange-harpa', 'Pink top', 'Design for summer', 25, 719, '20131218235011.jpg', 1, 0, 1, 1, '2013-12-18 18:20:11', '2013-12-18 18:20:11'),
(100, 74, 'pink-harpa', 'Pink Harpa', 'cotton material', 17, 453, '20131218235131.jpg', 1, 0, 1, 1, '2013-12-18 18:21:31', '2013-12-18 18:21:31'),
(101, 74, 'blue-global', 'Blue Chudidar', 'Special for Navratri Design', 12, 1299, '20131218235251.jpg', 1, 0, 1, 1, '2013-12-18 18:22:51', '2013-12-18 18:22:51'),
(102, 82, 'black-converse canvas', 'Black Canvas for Ladies only', 'Canvas shoes available for all size and color', 8, 1186, '20131219185138.jpg', 1, 0, 1, 1, '2013-12-19 13:21:38', '2013-12-19 13:21:38'),
(103, 82, 'black-green-converse canvas shoes', 'Black and Green Converse', 'Black canvas with green converse', 5, 839, '20131219185319.jpg', 1, 0, 1, 1, '2013-12-19 13:23:19', '2013-12-19 13:23:19'),
(104, 82, 'chestnu-pavers-england ', 'Brown Color with 9 size', 'Brown Full size shooes', 2, 4499, '20131219185456.jpg', 1, 0, 1, 1, '2013-12-19 13:24:56', '2013-12-19 13:24:56'),
(105, 79, 'brown-32-6178-metro-40-', 'Brown Metro', 'Flate sandle for women', 32, 1290, '20131219185659.jpg', 1, 0, 1, 1, '2013-12-19 13:26:59', '2013-12-19 13:26:59'),
(106, 79, 'camel-lavie', 'Lavies Flate', 'Brown levis Camel', 5, 1296, '20131219185801.jpg', 1, 0, 1, 1, '2013-12-19 13:28:01', '2013-12-19 13:28:01'),
(107, 79, 'green flat', 'green flat', 'green flate with angle design', 1, 1499, '20131219185947.jpg', 1, 0, 1, 1, '2013-12-19 13:29:47', '2013-12-19 13:29:47'),
(108, 79, 'pink-lavie', 'pink Levis', 'flate levis for women', 9, 1047, '20131219190108.jpg', 1, 0, 1, 1, '2013-12-19 13:31:08', '2013-12-19 13:31:08'),
(109, 80, 'beige-catwalk', 'High heels in black', 'High heels for tenager', 12, 699, '20131219190254.jpg', 1, 0, 1, 1, '2013-12-19 13:32:54', '2013-12-19 13:32:54'),
(110, 80, 'brown-melhs', 'pavers-england', 'High heels available for women', 6, 3001, '20131219190429.jpg', 1, 0, 1, 1, '2013-12-19 13:34:29', '2013-12-19 13:34:29'),
(111, 80, 'gold-multi-jennaah', 'Gold heel', 'High heels available for women', 1, 5999, '20131219190536.jpg', 1, 0, 1, 1, '2013-12-19 13:35:36', '2013-12-19 13:35:36'),
(112, 80, 'orange-lavie', 'Levis High heels', 'Levis Brand heels for Women', 5, 2236, '20131219190641.jpg', 1, 0, 1, 1, '2013-12-19 13:36:41', '2013-12-19 13:36:41'),
(113, 80, 'yellow-catwalk', 'Yellow Cat High heels', 'High heels available for women', 8, 699, '20131219190740.jpg', 1, 0, 1, 1, '2013-12-19 13:37:40', '2013-12-19 13:37:40'),
(114, 81, 'black-white-puma-3', 'Rose Violet Sport shoes', 'Puma body train ls pearl gym & fitness shoes ', 4, 3009, '20131219191013.jpg', 1, 0, 1, 1, '2013-12-19 13:40:13', '2013-12-19 13:40:13'),
(115, 81, 'blue-1220', 'newfeel-7', 'White and blue sport shoes', 7, 649, '20131219191144.jpg', 1, 0, 1, 1, '2013-12-19 13:41:44', '2013-12-19 13:41:44'),
(116, 81, 'orange-white-1647', 'newfeel-39', 'lightweight bellies', 10, 649, '20131219191327.jpg', 1, 0, 1, 1, '2013-12-19 13:43:27', '2013-12-19 13:43:27'),
(117, 81, 'white-orange-1647', 'newfeel 39', 'New feel light weight bellies', 6, 649, '20131219191440.jpg', 1, 0, 1, 1, '2013-12-19 13:44:40', '2013-12-19 13:44:40'),
(118, 115, 'nivia-football', 'Nivia Vertigo football', 'Sport instruments', 5, 1776, '20131219192931.jpg', 1, 0, 1, 1, '2013-12-19 13:59:31', '2013-12-19 13:59:31'),
(119, 115, 'nivia-foam', 'Hend Nivia Form', 'Phycal instrument for Practis ', 10, 349, '20131219193105.jpg', 1, 0, 1, 1, '2013-12-19 14:01:05', '2013-12-19 14:01:05'),
(120, 115, 'nivia-soft-grip', 'Nivia branded soft grip', 'Phycal instrument for Practis', 6, 637, '20131219193156.jpg', 1, 0, 1, 1, '2013-12-19 14:01:56', '2013-12-19 14:01:56'),
(121, 115, 'nivia-fitness-glove', 'Leather Gloves', 'Phycal instrument for Practis', 5, 649, '20131219193256.jpg', 1, 0, 1, 1, '2013-12-19 14:02:56', '2013-12-19 14:02:56'),
(122, 112, 'sg-batting-pads-optipro', 'Young batting Pads', 'Sports instromet of SG Products', 5, 692, '20131219193717.jpg', 1, 0, 1, 1, '2013-12-19 14:07:17', '2013-12-19 14:07:17'),
(123, 112, 'sg-club', 'Sipper Bottle', 'Sports instromet of SG Products', 50, 109, '20131219193831.jpg', 1, 0, 1, 1, '2013-12-19 14:08:31', '2013-12-19 14:08:31'),
(124, 112, 'sg-inner-gloves-campus', 'Batting Gloves', 'Sports instromet of SG Products', 45, 79, '20131219193941.jpg', 1, 0, 1, 1, '2013-12-19 14:09:41', '2013-12-19 14:09:41'),
(125, 112, 'sg-max-cover', 'Kashmeer Willow Cricket bat in Short handle', 'Sports instromet of SG Products', 9, 976, '20131219194121.jpg', 1, 0, 1, 1, '2013-12-19 14:11:21', '2013-12-19 14:11:21'),
(126, 113, 'head-silicone-shadow', 'Swimming Cap ', 'Head Sports and Fitness Instrument', 5, 699, '20131219194456.jpg', 1, 0, 1, 1, '2013-12-19 14:14:56', '2013-12-19 14:14:56'),
(127, 113, 'head-venom', 'Swimming Google in Blue Color', 'Head Sports and Fitness Instrument', 5, 667, '20131219194600.jpg', 1, 0, 1, 1, '2013-12-19 14:16:00', '2013-12-19 14:16:00'),
(128, 113, 'tennis-racquet', 'nano-ti-impulse', 'Tennis Racket', 8, 2588, '20131219194709.jpg', 1, 0, 1, 1, '2013-12-19 14:17:09', '2013-12-19 14:17:09'),
(129, 116, 'puma-wicket-keeping-pads', 'Senior Wicket Keeping Pads', 'Sports instruments Of Puma Brands', 5, 1979, '20131219200223.jpg', 1, 0, 1, 1, '2013-12-19 14:32:23', '2013-12-19 14:32:23'),
(130, 116, 'puma-batting-gloves', 'Shadow black puma Gloves', 'Sports instruments Of Puma Brands', 5, 3799, '20131219200322.jpg', 1, 0, 1, 1, '2013-12-19 14:33:22', '2013-12-19 14:33:22'),
(131, 116, 'puma-pulse-Bat', 'English Willow Cricket Bat', 'Sports instruments Of Puma Brands', 5, 3579, '20131219200425.jpg', 1, 0, 1, 1, '2013-12-19 14:34:25', '2013-12-19 14:34:25'),
(132, 114, 'cosco-aqua-wave', 'Swimming Google', 'Cosco-Sports Instrument', 10, 290, '20131219200836.jpg', 1, 0, 1, 1, '2013-12-19 14:38:36', '2013-12-19 14:38:36'),
(133, 114, 'cosco-nylon-net', 'Bandminton Net', 'Cosco-Sports Instrument', 10, 550, '20131219200950.jpg', 1, 0, 1, 1, '2013-12-19 14:39:50', '2013-12-19 14:39:50'),
(134, 114, 'cosco-shin-guard-shooter', 'Shooter Shin Guard', 'Cosco-Sports Instrument', 10, 120, '20131219201110.jpg', 1, 0, 1, 1, '2013-12-19 14:41:10', '2013-12-19 14:41:10'),
(135, 114, 'cosco-volleyball', 'Volley Ball Multi Color', 'Cosco-Sports Instrument', 10, 622, '20131219201227.jpg', 1, 0, 1, 1, '2013-12-19 14:42:27', '2013-12-19 14:42:27'),
(136, 117, 'adidas-master-blaster bat', 'Autograph Cricket bat', 'Cricket Instrument', 10, 119, '20131219201702.jpg', 1, 0, 1, 1, '2013-12-19 14:47:02', '2013-12-19 14:47:02'),
(137, 117, 'abdominal-guard', 'Abdominal Guard', 'Cricket Instrument', 25, 125, '20131219201817.jpg', 1, 0, 1, 1, '2013-12-19 14:48:17', '2013-12-19 14:48:17'),
(138, 117, 'masuri-full-face-basic', 'Cricket Hemlet', 'Cricket Instrument', 10, 899, '20131219201917.jpg', 1, 0, 1, 1, '2013-12-19 14:49:17', '2013-12-19 14:49:17'),
(139, 117, 'sg-inner-gloves', 'Inner Gloves For youth ', 'Cricket Instrument', 10, 119, '20131219202057.jpg', 1, 0, 1, 1, '2013-12-19 14:50:57', '2013-12-19 14:50:57');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
