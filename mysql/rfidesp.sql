/*
 Navicat Premium Data Transfer

 Source Server         : ss.linmb.com
 Source Server Type    : MySQL
 Source Server Version : 50644
 Source Host           : ss.linmb.com:3306
 Source Schema         : rfidesp

 Target Server Type    : MySQL
 Target Server Version : 50644
 File Encoding         : 65001

 Date: 10/11/2019 17:50:00
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for bumenlist
-- ----------------------------
DROP TABLE IF EXISTS `bumenlist`;
CREATE TABLE `bumenlist`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `BUMENID` int(11) NOT NULL,
  `BUMENNAME` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`ID`, `BUMENID`) USING BTREE,
  INDEX `BUMENID`(`BUMENID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of bumenlist
-- ----------------------------
INSERT INTO `bumenlist` VALUES (1, 1, '企划部');
INSERT INTO `bumenlist` VALUES (2, 2, '财务部');
INSERT INTO `bumenlist` VALUES (3, 3, '人事部');
INSERT INTO `bumenlist` VALUES (4, 4, '营销部');
INSERT INTO `bumenlist` VALUES (5, 5, '技术部');
INSERT INTO `bumenlist` VALUES (6, 6, '采购部');

-- ----------------------------
-- Table structure for flaglist
-- ----------------------------
DROP TABLE IF EXISTS `flaglist`;
CREATE TABLE `flaglist`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `FLAGID` int(3) NOT NULL,
  `FLAG` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`ID`, `FLAGID`) USING BTREE,
  INDEX `FLAGID`(`FLAGID`) USING BTREE,
  INDEX `ID`(`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of flaglist
-- ----------------------------
INSERT INTO `flaglist` VALUES (1, 1, '缺勤');
INSERT INTO `flaglist` VALUES (2, 2, '在岗');
INSERT INTO `flaglist` VALUES (3, 3, '下班');
INSERT INTO `flaglist` VALUES (4, 4, '请假');
INSERT INTO `flaglist` VALUES (5, 5, '外勤');

-- ----------------------------
-- Table structure for historylist
-- ----------------------------
DROP TABLE IF EXISTS `historylist`;
CREATE TABLE `historylist`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DATE` date NOT NULL,
  `WORKERID` bigint(25) NOT NULL,
  `FLAG` varchar(5) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `WORKTIME` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ID`, `WORKERID`) USING BTREE,
  INDEX `ID`(`ID`) USING BTREE,
  INDEX `WORKERID`(`WORKERID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 407 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for login
-- ----------------------------
DROP TABLE IF EXISTS `login`;
CREATE TABLE `login`  (
  `ID` int(255) NOT NULL AUTO_INCREMENT,
  `user` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of login
-- ----------------------------
INSERT INTO `login` VALUES (1, 'admin', 'admin');

-- ----------------------------
-- Table structure for rfesp
-- ----------------------------
DROP TABLE IF EXISTS `rfesp`;
CREATE TABLE `rfesp`  (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `RFIDNUM` bigint(25) NOT NULL,
  `WORKERID` bigint(25) NOT NULL,
  `WORKERNAME` varchar(4) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `BUMEN` int(5) NOT NULL,
  `SEX` char(4) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `QD` datetime(0) NULL DEFAULT NULL,
  `QT` datetime(0) NULL DEFAULT NULL,
  `FLAG` int(3) NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE,
  INDEX `rfesp_ibfk_1`(`FLAG`) USING BTREE,
  INDEX `BUMEN`(`BUMEN`) USING BTREE,
  CONSTRAINT `bumenlist_rfesp` FOREIGN KEY (`BUMEN`) REFERENCES `bumenlist` (`BUMENID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `rfesp_ibfk_1` FOREIGN KEY (`FLAG`) REFERENCES `flaglist` (`FLAGID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of rfesp
-- ----------------------------
INSERT INTO `rfesp` VALUES (1, 1051132217155, 3168116101, '陈木鑫', 5, '男', '2019-11-08 21:38:55', '2019-11-08 23:39:02', 1);
INSERT INTO `rfesp` VALUES (2, 19322531217230, 3168116102, '陈衍阳', 4, '男', NULL, NULL, 1);
INSERT INTO `rfesp` VALUES (3, 225210248208, 3168116103, '郭玉林', 1, '男', NULL, NULL, 1);
INSERT INTO `rfesp` VALUES (4, 1533931217120, 3168116104, '吴建文', 1, '男', NULL, NULL, 1);
INSERT INTO `rfesp` VALUES (5, 25424630217207, 3168116105, '戴清华', 1, '女', NULL, NULL, 1);

-- ----------------------------
-- Event structure for my_event
-- ----------------------------
DROP EVENT IF EXISTS `my_event`;
delimiter ;;
CREATE EVENT `my_event`
ON SCHEDULE
EVERY '1' DAY STARTS '2019-11-08 00:00:01'
DISABLE
DO BEGIN
insert into historylist(WORKERID,WORKTIME,FLAG,DATE) select WORKERID,(UNIX_TIMESTAMP(QT)-UNIX_TIMESTAMP(QD))/3600,if(FLAG=3,FLAG,NULL),DATE_FORMAT(QT,'%Y-%m-%d') from rfesp;
update rfesp set FLAG = 1 WHERE FLAG <> 1;
update rfesp set QD = NULL,QT=NULL ;
END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
