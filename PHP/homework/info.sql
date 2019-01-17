-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 2017-04-24 09:05:23
-- 服务器版本： 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `test`
--

-- --------------------------------------------------------

--
-- 表的结构 `info`
--

CREATE TABLE IF NOT EXISTS `info` (
  `id` int(11) NOT NULL,
  `PIC` varchar(20) NOT NULL,
  `name` varchar(10) NOT NULL,
  `sex` varchar(2) NOT NULL,
  `hobby` varchar(50) NOT NULL,
  `class` varchar(20) NOT NULL,
  `pwd` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `info`
--

INSERT INTO `info` (`id`, `PIC`, `name`, `sex`, `hobby`, `class`, `pwd`) VALUES
(23, 'images/2.jpg', '施xiaoxiao', '男', '自由者', '信息系统一班', 123),
(40, 'images/1.jpg', '李晓雪', '女', '看电影，逛街', '管理一班', 122),
(11, 'images/3.jpg', '吴小四', '男', '自由演唱，歌颂者', '艺术设计er班', 123),
(33, 'images/4.jpg', '曾小贤', '男', '唱反调2', '园林设计2', 123),
(40, 'imges/5.jpg', '吴chendi', '女', '兵乓球', '信息系统一班', 123);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
