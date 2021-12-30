-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: estate_agency_db
-- ------------------------------------------------------
-- Server version	8.0.26

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


--
--Initialize database
--
CREATE DATABASE IF NOT EXISTS estate_agency_db;
USE estate_agency_db;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20211120160307_01_adding_requests','5.0.12'),('20211125204648_02_AddMainPhotoUrl','5.0.12'),('20211126115047_03_ExtendsEstateAndOffer','5.0.12'),('20211126122509_04_AddFieldOfferType','5.0.12'),('20211126122552_05_CreateOfferPreviewView','5.0.12'),('20211202130028_06_ImproveEstates','5.0.12'),('20211202181042_07_AddApartment','5.0.12'),('20211202215610_08_AddDivisonOfferField','5.0.12'),('20211202220029_09_CreateEsateOfferPreviewView','5.0.12'),('20211202220926_10_CreateApartmentOfferPreviewView','5.0.12'),('20211203115019_11_AddRentOptionToApartmentOfferPreview','5.0.12'),('20211203115339_12_AddRentOptionToEstateOfferPreview','5.0.12'),('20211203123116_13_DivisonSelectedDataIntoApartment','5.0.12'),('20211203123549_14_DivisonSelectedDataIntoEstate','5.0.12'),('20211203201143_15_CreateFullApartmentOfferView','5.0.12'),('20211204113903_15_CreateApartmentOfferView','5.0.12'),('20211204134712_16_CreateEstateOfferView','5.0.12'),('20211205121135_17_AddAgentToOfferPreview','5.0.12'),('20211205121348_17_AddAgentToOfferPreview','5.0.12'),('20211205130130_18_AddAgentToEstateOfferPreview','5.0.12'),('20211205171346_19_AddMarketAndGasInstallationField','5.0.12'),('20211205171953_20_AddMarketAndGasToEstateOffer','5.0.12'),('20211205180942_21_AddMarketToApartmmentOffer','5.0.12');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `addresses`
--

DROP TABLE IF EXISTS `addresses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `addresses` (
  `id_address` int NOT NULL AUTO_INCREMENT,
  `street` varchar(45) DEFAULT NULL,
  `estate_number` varchar(15) NOT NULL,
  `apartment_number` varchar(15) DEFAULT NULL,
  `city` varchar(45) NOT NULL,
  `zip_code` varchar(6) NOT NULL,
  `google_maps_url` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`id_address`),
  UNIQUE KEY `id_address_UNIQUE` (`id_address`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `addresses`
--

LOCK TABLES `addresses` WRITE;
/*!40000 ALTER TABLE `addresses` DISABLE KEYS */;
INSERT INTO `addresses` VALUES (1,'Armii Krajowej','34',NULL,'Katowice','40-671','https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2553.1076693474606!2d18.969448315937797!3d50.21520841216792!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4716ceb869e781ef%3A0x4c419db380e8b8a9!2sArmii%20Krajowej%2034%2C%2040-698%20Katowice!5e0!3m2!1spl!2spl!4v1638361276512!5m2!1spl!2spl'),(2,'Królowej Jadwigii','191',NULL,'Kraków','30-212','https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d959.3495762596273!2d19.88159585626716!3d50.06463757259463!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47165be9be956b2d%3A0x37effb3c66d36b5d!2sKr%C3%B3lowej%20Jadwigi%20191%2C%2030-218%20Krak%C3%B3w!5e0!3m2!1spl!2spl!4v1638361107431!5m2!1spl!2spl'),(3,'Sobańskiego','75',NULL,'Katowice','40-685','https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d902.8000750136854!2d18.964963786579546!3d50.20779745230782!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4716ceb5b0d29609%3A0xae637524c78fc34a!2sSoba%C5%84skiego%2075%2C%2040-685%20Katowice!5e0!3m2!1spl!2spl!4v1638361378583!5m2!1spl!2spl'),(4,'Rozdzienskiego','100','34','Katowice','40-203','https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2550.6361294619683!2d19.03959441593911!3d50.26137990885099!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4716cfcc8a06be63%3A0x3a17e642e89f8209!2saleja%20Ro%C5%BAdzie%C5%84skiego%20100%2C%2040-203%20Katowice!5e0!3m2!1spl!2spl!4v1638361679711!5m2!1spl!2spl');
/*!40000 ALTER TABLE `addresses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `agents`
--

DROP TABLE IF EXISTS `agents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agents` (
  `id_agents` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `full_Name` varchar(90) DEFAULT NULL,
  `area` tinyint NOT NULL,
  `email` varchar(70) DEFAULT NULL,
  `phone_number` varchar(12) DEFAULT NULL,
  `photo_url` varchar(100) DEFAULT NULL,
  `description` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`id_agents`),
  UNIQUE KEY `id_agents_UNIQUE` (`id_agents`),
  KEY `FK_agent_trade_idx` (`area`),
  CONSTRAINT `FK_agent_trade` FOREIGN KEY (`area`) REFERENCES `trade_info` (`id_info`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agents`
--

LOCK TABLES `agents` WRITE;
/*!40000 ALTER TABLE `agents` DISABLE KEYS */;
INSERT INTO `agents` VALUES (1,'Hubert','Kosowski','Hubert Kosowski',1,'hubert.kosowski@someestates.com','501965324','img/pexels-andrea-piacquadio-3778876.jpg','Brat szefa'),(2,'Anna','Hozer','Anna Hozer',1,'anna.hozer@someestates.com','887457772','img/pexels-anastasiya-gepp-1462630.jpg',' przyszła szefa'),(3,'Magda','Leśniak','Magda Leśniak',2,'magdalena.lesniak@someestates.com','772398114','img/pexels-edmond-dantès-4347368.jpg','przyjaciolka  szefa'),(4,'Konrad','Gaik','Konrad Gaik',1,'konrad.gaik@someestates.com','504567298','img/pexels-andrea-piacquadio-3760339.jpg','dobry ziomek szefa');
/*!40000 ALTER TABLE `agents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `apartment_offer_preview_view`
--

DROP TABLE IF EXISTS `apartment_offer_preview_view`;
/*!50001 DROP VIEW IF EXISTS `apartment_offer_preview_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `apartment_offer_preview_view` AS SELECT 
 1 AS `id_offers`,
 1 AS `agent`,
 1 AS `offer_name`,
 1 AS `has_rent`,
 1 AS `rent_value`,
 1 AS `price`,
 1 AS `price_for_meter`,
 1 AS `offer_type`,
 1 AS `offer_status`,
 1 AS `property_area`,
 1 AS `inside_design`,
 1 AS `number_of_rooms`,
 1 AS `main_photo_url`,
 1 AS `city`,
 1 AS `street`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `apartment_offer_view`
--

DROP TABLE IF EXISTS `apartment_offer_view`;
/*!50001 DROP VIEW IF EXISTS `apartment_offer_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `apartment_offer_view` AS SELECT 
 1 AS `id_offers`,
 1 AS `agent`,
 1 AS `publishing_date`,
 1 AS `area`,
 1 AS `price`,
 1 AS `details`,
 1 AS `offer_name`,
 1 AS `price_for_meter`,
 1 AS `offer_type`,
 1 AS `has_rent`,
 1 AS `rent_value`,
 1 AS `market`,
 1 AS `property_area`,
 1 AS `furnishings`,
 1 AS `has_balcony`,
 1 AS `floor_number`,
 1 AS `number_of_rooms`,
 1 AS `has_bathroom`,
 1 AS `parking_space`,
 1 AS `heating`,
 1 AS `inside_design`,
 1 AS `kitchen_equipment`,
 1 AS `bathroom_equipment`,
 1 AS `building_name`,
 1 AS `build_year`,
 1 AS `building_type`,
 1 AS `number_of_floors`,
 1 AS `distance_to_forest`,
 1 AS `distance_to_river`,
 1 AS `distance_to_mountains`,
 1 AS `distance_to_highway`,
 1 AS `distance_to_center`,
 1 AS `distance_to_mall`,
 1 AS `distance_to_lake`,
 1 AS `distance_to_coast`,
 1 AS `other_details`,
 1 AS `street`,
 1 AS `estate_number`,
 1 AS `apartment_number`,
 1 AS `city`,
 1 AS `zip_code`,
 1 AS `google_maps_url`,
 1 AS `property_state`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `apartments`
--

DROP TABLE IF EXISTS `apartments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `apartments` (
  `id_apartment` int NOT NULL AUTO_INCREMENT,
  `address` int DEFAULT NULL,
  `property_state` tinyint DEFAULT NULL,
  `property_area` decimal(7,2) DEFAULT NULL,
  `furnishings` tinyint(1) DEFAULT NULL,
  `has_balcony` tinyint(1) DEFAULT NULL,
  `floor_number` tinyint DEFAULT NULL,
  `number_of_rooms` tinyint DEFAULT NULL,
  `has_bathroom` tinyint(1) DEFAULT NULL,
  `parking_space` tinyint(1) DEFAULT NULL,
  `heating` varchar(100) DEFAULT NULL,
  `inside_design` varchar(100) DEFAULT NULL,
  `kitchen_equipment` varchar(500) DEFAULT NULL,
  `bathroom_equipment` varchar(500) DEFAULT NULL,
  `building_name` varchar(150) DEFAULT NULL,
  `build_year` int DEFAULT NULL,
  `building_type` varchar(100) DEFAULT NULL,
  `number_of_floors` tinyint DEFAULT NULL,
  `main_photo_url` varchar(300) DEFAULT NULL,
  `near_forest` bit(1) DEFAULT NULL,
  `near_river` bit(1) DEFAULT NULL,
  `near_mountains` bit(1) DEFAULT NULL,
  `near_highway` bit(1) DEFAULT NULL,
  `near_center` bit(1) DEFAULT NULL,
  `near_mall` bit(1) DEFAULT NULL,
  `near_lake` bit(1) DEFAULT NULL,
  `near_coast` bit(1) DEFAULT NULL,
  `distance_to_forest` decimal(3,1) DEFAULT NULL,
  `distance_to_river` decimal(3,1) DEFAULT NULL,
  `distance_to_mountains` decimal(3,1) DEFAULT NULL,
  `distance_to_highway` decimal(3,1) DEFAULT NULL,
  `distance_to_center` decimal(3,1) DEFAULT NULL,
  `distance_to_mall` decimal(3,1) DEFAULT NULL,
  `distance_to_lake` decimal(3,1) DEFAULT NULL,
  `distance_to_coast` decimal(3,1) DEFAULT NULL,
  `other_details` text,
  PRIMARY KEY (`id_apartment`),
  UNIQUE KEY `id_apartment_UNIQUE` (`id_apartment`),
  KEY `FK_apartment_state_idx` (`property_state`),
  KEY `FK_apartment_trade_info_idx` (`building_type`),
  KEY `IX_apartments_address` (`address`),
  CONSTRAINT `FK_apartment_address` FOREIGN KEY (`address`) REFERENCES `addresses` (`id_address`) ON DELETE RESTRICT,
  CONSTRAINT `FK_apartment_status` FOREIGN KEY (`property_state`) REFERENCES `statuses` (`id_status`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apartments`
--

LOCK TABLES `apartments` WRITE;
/*!40000 ALTER TABLE `apartments` DISABLE KEYS */;
INSERT INTO `apartments` VALUES (1,4,6,60.00,1,1,12,5,1,1,'1','postkomunizm','Piekarnik,Zmywarka,Lodówka,Zlewozmywak,Szafki','Kabina prysznicowa,Pralka,Suszarka,Umywalka,Lustro','Osiedle Walentego Roździeńskiego',1978,'2',24,'img/pexels-chait-goli-1918291.jpg',_binary '\0',_binary '\0',_binary '\0',_binary '',_binary '',_binary '',_binary '',_binary '\0',NULL,NULL,NULL,0.5,1.1,0.7,2.9,NULL,NULL);
/*!40000 ALTER TABLE `apartments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `estate_offer_preview_view`
--

DROP TABLE IF EXISTS `estate_offer_preview_view`;
/*!50001 DROP VIEW IF EXISTS `estate_offer_preview_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `estate_offer_preview_view` AS SELECT 
 1 AS `id_offers`,
 1 AS `agent`,
 1 AS `offer_name`,
 1 AS `has_rent`,
 1 AS `rent_value`,
 1 AS `price`,
 1 AS `price_for_meter`,
 1 AS `offer_type`,
 1 AS `offer_status`,
 1 AS `property_area`,
 1 AS `number_of_rooms`,
 1 AS `main_photo_url`,
 1 AS `city`,
 1 AS `street`,
 1 AS `name`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `estate_offer_view`
--

DROP TABLE IF EXISTS `estate_offer_view`;
/*!50001 DROP VIEW IF EXISTS `estate_offer_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `estate_offer_view` AS SELECT 
 1 AS `id_offers`,
 1 AS `agent`,
 1 AS `publishing_date`,
 1 AS `area`,
 1 AS `price`,
 1 AS `details`,
 1 AS `offer_name`,
 1 AS `price_for_meter`,
 1 AS `offer_type`,
 1 AS `has_rent`,
 1 AS `rent_value`,
 1 AS `market`,
 1 AS `name`,
 1 AS `property_area`,
 1 AS `build_date`,
 1 AS `number_of_rooms`,
 1 AS `floors`,
 1 AS `other_details`,
 1 AS `has_balcony`,
 1 AS `furnishings`,
 1 AS `main_photo_url`,
 1 AS `roof_type`,
 1 AS `electricity`,
 1 AS `water_connection`,
 1 AS `basement`,
 1 AS `garage`,
 1 AS `plot`,
 1 AS `fence`,
 1 AS `heating`,
 1 AS `sewers`,
 1 AS `distance_to_forest`,
 1 AS `distance_to_river`,
 1 AS `distance_to_mountains`,
 1 AS `distance_to_highway`,
 1 AS `distance_to_center`,
 1 AS `distance_to_mall`,
 1 AS `distance_to_lake`,
 1 AS `distance_to_coast`,
 1 AS `gas_installation`,
 1 AS `street`,
 1 AS `estate_number`,
 1 AS `city`,
 1 AS `zip_code`,
 1 AS `google_maps_url`,
 1 AS `property_status`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `estates`
--

DROP TABLE IF EXISTS `estates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estates` (
  `id_estate` int NOT NULL AUTO_INCREMENT,
  `address` int DEFAULT NULL,
  `property_type` tinyint DEFAULT NULL,
  `property_area` decimal(8,1) DEFAULT NULL,
  `build_date` year DEFAULT NULL,
  `property_status` tinyint DEFAULT NULL,
  `number_of_rooms` tinyint DEFAULT NULL,
  `floors` tinyint DEFAULT NULL,
  `near_forest` tinyint(1) DEFAULT NULL,
  `near_river` tinyint(1) DEFAULT NULL,
  `near_mountains` tinyint(1) DEFAULT NULL,
  `near_highway` tinyint(1) DEFAULT NULL,
  `near_center` tinyint(1) DEFAULT NULL,
  `near_mall` tinyint(1) DEFAULT NULL,
  `near_lake` tinyint(1) DEFAULT NULL,
  `near_coast` tinyint(1) DEFAULT NULL,
  `distance_to_forest` decimal(3,1) DEFAULT NULL,
  `distance_to_river` decimal(3,1) DEFAULT NULL,
  `distance_to_mountains` decimal(3,1) DEFAULT NULL,
  `distance_to_highway` decimal(3,1) DEFAULT NULL,
  `distance_to_center` decimal(3,1) DEFAULT NULL,
  `distance_to_mall` decimal(3,1) DEFAULT NULL,
  `distance_to_lake` decimal(3,1) DEFAULT NULL,
  `distance_to_coast` decimal(3,1) DEFAULT NULL,
  `other_details` text,
  `has_balcony` tinyint(1) DEFAULT NULL,
  `furnishings` tinyint(1) DEFAULT NULL,
  `main_photo_url` varchar(150) DEFAULT NULL,
  `basement` tinyint(1) DEFAULT NULL,
  `electricity` tinyint(1) DEFAULT NULL,
  `fence` tinyint(1) DEFAULT NULL,
  `garage` tinyint(1) DEFAULT NULL,
  `heating` varchar(100) DEFAULT NULL,
  `plot` decimal(7,2) DEFAULT NULL,
  `roof_type` varchar(75) DEFAULT NULL,
  `sewers` tinyint(1) DEFAULT NULL,
  `water_connection` tinyint(1) DEFAULT NULL,
  `gas_installation` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_estate`),
  KEY `FK_estate_address_idx` (`address`),
  KEY `FK_estate_status_idx` (`property_status`),
  KEY `FK_estate_trade_info_idx` (`property_type`),
  CONSTRAINT `FK_estate_address` FOREIGN KEY (`address`) REFERENCES `addresses` (`id_address`),
  CONSTRAINT `FK_estate_status` FOREIGN KEY (`property_status`) REFERENCES `statuses` (`id_status`),
  CONSTRAINT `FK_estate_trade_info` FOREIGN KEY (`property_type`) REFERENCES `trade_info` (`id_info`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estates`
--

LOCK TABLES `estates` WRITE;
/*!40000 ALTER TABLE `estates` DISABLE KEYS */;
INSERT INTO `estates` VALUES (1,1,22,150.0,2018,6,10,2,1,1,0,0,0,0,0,0,1.1,1.7,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,'img/pexels-binyamin-mellish-186077.jpg',1,1,1,1,'ogrzewanie gazowe',20.00,'blacha',1,1,1),(2,2,22,120.0,1988,6,8,2,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0.7,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,'img/pexels-vivint-solar-2850472.jpg',1,1,1,1,'ogrzewanie miejskie',17.00,'papa',1,1,1);
/*!40000 ALTER TABLE `estates` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `meetings`
--

DROP TABLE IF EXISTS `meetings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `meetings` (
  `id_meetings` int NOT NULL AUTO_INCREMENT,
  `date_of_meeting` datetime NOT NULL,
  `agent` int DEFAULT NULL,
  `customer_name` varchar(90) DEFAULT NULL,
  `customer_number` varchar(12) DEFAULT NULL,
  `customer_email` varchar(70) DEFAULT NULL,
  `in_estate` bit(1) DEFAULT NULL,
  `estate_address` int DEFAULT NULL,
  `other_address` varchar(200) DEFAULT NULL,
  `status` tinyint DEFAULT NULL,
  PRIMARY KEY (`id_meetings`),
  UNIQUE KEY `id_meetings_UNIQUE` (`id_meetings`),
  KEY `FK_meetings_agent_idx` (`agent`),
  KEY `FK_meetings_status_idx` (`status`),
  KEY `FK_estate_address_idx` (`estate_address`),
  CONSTRAINT `FK_meetings_address` FOREIGN KEY (`estate_address`) REFERENCES `addresses` (`id_address`),
  CONSTRAINT `FK_meetings_agent` FOREIGN KEY (`agent`) REFERENCES `agents` (`id_agents`),
  CONSTRAINT `FK_meetings_status` FOREIGN KEY (`status`) REFERENCES `statuses` (`id_status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meetings`
--

LOCK TABLES `meetings` WRITE;
/*!40000 ALTER TABLE `meetings` DISABLE KEYS */;
/*!40000 ALTER TABLE `meetings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `offer_preview_view`
--

DROP TABLE IF EXISTS `offer_preview_view`;
/*!50001 DROP VIEW IF EXISTS `offer_preview_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `offer_preview_view` AS SELECT 
 1 AS `offer_name`,
 1 AS `price`,
 1 AS `price_for_meter`,
 1 AS `offer_type`,
 1 AS `offer_status`,
 1 AS `property_area`,
 1 AS `number_of_rooms`,
 1 AS `main_photo_url`,
 1 AS `city`,
 1 AS `street`,
 1 AS `name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `offers`
--

DROP TABLE IF EXISTS `offers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `offers` (
  `id_offers` int NOT NULL AUTO_INCREMENT,
  `estate` int DEFAULT NULL,
  `agent` int DEFAULT NULL,
  `publishing_date` date DEFAULT NULL,
  `area` tinyint DEFAULT NULL,
  `price` decimal(12,2) DEFAULT NULL,
  `offer_status` tinyint DEFAULT NULL,
  `views` int DEFAULT NULL,
  `promoted` bit(1) DEFAULT NULL,
  `details` text,
  `offer_name` varchar(150) DEFAULT NULL,
  `price_for_meter` decimal(8,2) DEFAULT NULL,
  `offer_type` varchar(150) DEFAULT NULL,
  `apartment` int DEFAULT NULL,
  `has_rent` tinyint(1) DEFAULT NULL,
  `rent_value` decimal(7,2) DEFAULT NULL,
  `is_estate` tinyint(1) DEFAULT NULL,
  `market` varchar(75) DEFAULT NULL,
  PRIMARY KEY (`id_offers`),
  UNIQUE KEY `id_offers_UNIQUE` (`id_offers`),
  KEY `FK_offer_agent_idx` (`agent`),
  KEY `FK_offer_status_idx` (`offer_status`),
  KEY `FK_offer_estate_idx` (`estate`),
  KEY `FK_offer_trade_info_idx` (`area`),
  KEY `IX_offers_apartment` (`apartment`),
  CONSTRAINT `FK_offer_agent` FOREIGN KEY (`agent`) REFERENCES `agents` (`id_agents`),
  CONSTRAINT `FK_offer_apartment` FOREIGN KEY (`apartment`) REFERENCES `apartments` (`id_apartment`) ON DELETE RESTRICT,
  CONSTRAINT `FK_offer_estate` FOREIGN KEY (`estate`) REFERENCES `estates` (`id_estate`),
  CONSTRAINT `FK_offer_status` FOREIGN KEY (`offer_status`) REFERENCES `statuses` (`id_status`),
  CONSTRAINT `FK_offer_trade_info` FOREIGN KEY (`area`) REFERENCES `trade_info` (`id_info`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `offers`
--

LOCK TABLES `offers` WRITE;
/*!40000 ALTER TABLE `offers` DISABLE KEYS */;
INSERT INTO `offers` VALUES (1,1,1,'2021-12-03',1,599999.00,1,NULL,NULL,'Dom jednorodzinny wybudowany w nowoczesnym stylu, idealna opcja dla niewielkiej rodziny','Katowice, Piotrkowice',3999.99,'sprzedaz',NULL,0,NULL,1,'Pierwotny'),(2,2,3,'2021-12-03',2,450000.00,1,NULL,NULL,'Dom jednorodzinny na obrzeżach Krakowa to idealny wybór dla osób, które cenią sobie zarówno zalety mieszkania w mieście jak i spokój podmiejskiego życia','Kraków, Zwierzyniiec',3750.00,'sprzedaz',NULL,0,NULL,1,'Wtórny'),(3,NULL,2,'2021-12-03',1,1200.00,1,NULL,NULL,'Mieszkanie w centrum Katowic, urzadzone w stylu postkomunistycznym, zachwyci was swoimi detalami już od pierwszego wejrzenia','Katowice, Osiedle Rozdzeńskiego',20.00,'wynajem',1,1,1200.00,0,'Wtórny');
/*!40000 ALTER TABLE `offers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `photos`
--

DROP TABLE IF EXISTS `photos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `photos` (
  `id_Photo` int NOT NULL AUTO_INCREMENT,
  `estate` int DEFAULT NULL,
  `photo_url` varchar(100) DEFAULT NULL,
  `apartment` int DEFAULT NULL,
  PRIMARY KEY (`id_Photo`),
  UNIQUE KEY `id_Photo_UNIQUE` (`id_Photo`),
  KEY `FK_photo_estate_idx` (`estate`),
  KEY `IX_photos_apartment` (`apartment`),
  CONSTRAINT `FK_photo_apartment` FOREIGN KEY (`apartment`) REFERENCES `apartments` (`id_apartment`) ON DELETE RESTRICT,
  CONSTRAINT `FK_photo_estate` FOREIGN KEY (`estate`) REFERENCES `estates` (`id_estate`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `photos`
--

LOCK TABLES `photos` WRITE;
/*!40000 ALTER TABLE `photos` DISABLE KEYS */;
/*!40000 ALTER TABLE `photos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requests`
--

DROP TABLE IF EXISTS `requests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `requests` (
  `IdRequest` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `email` varchar(75) DEFAULT NULL,
  `phone_name` varchar(15) DEFAULT NULL,
  `description` varchar(100) DEFAULT NULL,
  `service` tinyint NOT NULL,
  `request_status` tinyint NOT NULL,
  PRIMARY KEY (`IdRequest`),
  KEY `FK_request_status_idx` (`request_status`),
  KEY `FK_request_trade_info_idx` (`service`),
  CONSTRAINT `FK_request_status` FOREIGN KEY (`request_status`) REFERENCES `statuses` (`id_status`) ON DELETE CASCADE,
  CONSTRAINT `FK_request_trade_info` FOREIGN KEY (`service`) REFERENCES `trade_info` (`id_info`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requests`
--

LOCK TABLES `requests` WRITE;
/*!40000 ALTER TABLE `requests` DISABLE KEYS */;
/*!40000 ALTER TABLE `requests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `statuses`
--

DROP TABLE IF EXISTS `statuses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `statuses` (
  `id_status` tinyint NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `short_name` varchar(3) DEFAULT NULL,
  `domain` varchar(50) DEFAULT NULL,
  `desc` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statuses`
--

LOCK TABLES `statuses` WRITE;
/*!40000 ALTER TABLE `statuses` DISABLE KEYS */;
INSERT INTO `statuses` VALUES (1,'aktywna','AKT','offer',NULL),(2,'zarezerwowana','REZ','offer',NULL),(3,'wycofana','WYC','offer',NULL),(4,'zakończona','ZAK','offer',NULL),(5,'deweloperski','DEV','property',NULL),(6,'do zamieszkania','MIE','property',NULL),(7,'do remontu','REM','property',NULL),(8,'premium','PRE','property',NULL),(9,'złożone','ZLO','request',NULL),(10,'przetworzone','PRZ','request',NULL),(11,'zakończone','ZKR','request',NULL),(12,'anulowane','ANR','request',NULL);
/*!40000 ALTER TABLE `statuses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trade_info`
--

DROP TABLE IF EXISTS `trade_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trade_info` (
  `id_info` tinyint NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `key_name` varchar(45) NOT NULL,
  `short_name` varchar(3) NOT NULL,
  `description` varchar(100) DEFAULT NULL,
  `domain` varchar(50) NOT NULL,
  PRIMARY KEY (`id_info`),
  UNIQUE KEY `key_name_UNIQUE` (`key_name`),
  UNIQUE KEY `short_name_UNIQUE` (`short_name`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trade_info`
--

LOCK TABLES `trade_info` WRITE;
/*!40000 ALTER TABLE `trade_info` DISABLE KEYS */;
INSERT INTO `trade_info` VALUES (1,'Śląsk','silesian','SLA','województwo','tradeArea'),(2,'Małopolska','lesserPoland','MAL','województwo','tradeArea'),(3,'Opole','opole','OPL','województwo','tradeArea'),(4,'Dolny Śląsk','lowerSilesian','DOL','województwo','tradeArea'),(5,'Lubuskie','lubusz','LBU','województwo','tradeArea'),(6,'Zachodniopomorskie','westPomeranian','ZAC','województwo','tradeArea'),(7,'Pomorskie','pomeranian','POM','województwo','tradeArea'),(8,'Wielkopolskie','greaterPoland','WIE','województwo','tradeArea'),(9,'Łódzkie','lodzkie','LOD','województwo','tradeArea'),(10,'Kujawsko-Pomorskie','kuyavianPomeranian','KUJ','województwo','tradeArea'),(11,'Mazowieckie','masovian','MAZ','województwo','tradeArea'),(12,'Warmińsko-Mazurskie','warmianMasurian','WAR','województwo','tradeArea'),(13,'Podlaskie','podlaskie','PDL','województwo','tradeArea'),(14,'Lubelskie','ublin','LUB','województwo','tradeArea'),(15,'Podkarpackie','subcarpathian','PDK','województwo','tradeArea'),(16,'Świętokrzystkie','holyCross','SWI','województwo','tradeArea'),(17,'Zakup nieruchomości','buyEstate','ZAN','usługa','service'),(18,'Sprzedaż nieruchomości','sellEstate','SPN','usługa','service'),(19,'Doradztwo','advisement','DOR','usługa','service'),(20,'Projektowanie wnętrz','insideDesign','PRO','usługa','service'),(21,'Inne','other','INN','usługa','service'),(22,'Dom jednorodzinny','singleHouse','DMJ','nieruchomość','property'),(23,'Dom wielorodzinny','familyHouse','DMW','nieruchomość','property'),(24,'Bliźniak','twinHouse','BLI','nieruchomość','property'),(25,'Willa','villa','WIL','nieruchomość','property'),(26,'Rezydencja','residence','RES','nieruchomość','porperty'),(27,'Domek letniskowy','summerHouse','DML','nieruchomość','property'),(28,'Kamienica','tenement','KAM','typBudynku','buildingType'),(29,'Blok','block','BLO','typBudynku','buildingType'),(30,'Apartamentowiec','apartmentHouse','APA','typBudynku','buildingType'),(31,'Mieszkanie','apartment','APR','nieruchomość','property');
/*!40000 ALTER TABLE `trade_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `apartment_offer_preview_view`
--

/*!50001 DROP VIEW IF EXISTS `apartment_offer_preview_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `apartment_offer_preview_view` AS select `o`.`id_offers` AS `id_offers`,`o`.`agent` AS `agent`,`o`.`offer_name` AS `offer_name`,`o`.`has_rent` AS `has_rent`,`o`.`rent_value` AS `rent_value`,`o`.`price` AS `price`,`o`.`price_for_meter` AS `price_for_meter`,`o`.`offer_type` AS `offer_type`,`o`.`offer_status` AS `offer_status`,`ap`.`property_area` AS `property_area`,`ap`.`inside_design` AS `inside_design`,`ap`.`number_of_rooms` AS `number_of_rooms`,`ap`.`main_photo_url` AS `main_photo_url`,`ad`.`city` AS `city`,`ad`.`street` AS `street` from ((`offers` `o` left join `apartments` `ap` on((`o`.`apartment` = `ap`.`id_apartment`))) left join `addresses` `ad` on((`ap`.`address` = `ad`.`id_address`))) where (`o`.`is_estate` = 0) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `apartment_offer_view`
--

/*!50001 DROP VIEW IF EXISTS `apartment_offer_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `apartment_offer_view` AS select `o`.`id_offers` AS `id_offers`,`o`.`agent` AS `agent`,`o`.`publishing_date` AS `publishing_date`,`o`.`area` AS `area`,`o`.`price` AS `price`,`o`.`details` AS `details`,`o`.`offer_name` AS `offer_name`,`o`.`price_for_meter` AS `price_for_meter`,`o`.`offer_type` AS `offer_type`,`o`.`has_rent` AS `has_rent`,`o`.`rent_value` AS `rent_value`,`o`.`market` AS `market`,`ap`.`property_area` AS `property_area`,`ap`.`furnishings` AS `furnishings`,`ap`.`has_balcony` AS `has_balcony`,`ap`.`floor_number` AS `floor_number`,`ap`.`number_of_rooms` AS `number_of_rooms`,`ap`.`has_bathroom` AS `has_bathroom`,`ap`.`parking_space` AS `parking_space`,`ap`.`heating` AS `heating`,`ap`.`inside_design` AS `inside_design`,`ap`.`kitchen_equipment` AS `kitchen_equipment`,`ap`.`bathroom_equipment` AS `bathroom_equipment`,`ap`.`building_name` AS `building_name`,`ap`.`build_year` AS `build_year`,`ap`.`building_type` AS `building_type`,`ap`.`number_of_floors` AS `number_of_floors`,`ap`.`distance_to_forest` AS `distance_to_forest`,`ap`.`distance_to_river` AS `distance_to_river`,`ap`.`distance_to_mountains` AS `distance_to_mountains`,`ap`.`distance_to_highway` AS `distance_to_highway`,`ap`.`distance_to_center` AS `distance_to_center`,`ap`.`distance_to_mall` AS `distance_to_mall`,`ap`.`distance_to_lake` AS `distance_to_lake`,`ap`.`distance_to_coast` AS `distance_to_coast`,`ap`.`other_details` AS `other_details`,`ad`.`street` AS `street`,`ad`.`estate_number` AS `estate_number`,`ad`.`apartment_number` AS `apartment_number`,`ad`.`city` AS `city`,`ad`.`zip_code` AS `zip_code`,`ad`.`google_maps_url` AS `google_maps_url`,`s`.`name` AS `property_state` from (((`offers` `o` left join `apartments` `ap` on((`o`.`apartment` = `ap`.`id_apartment`))) left join `addresses` `ad` on((`ap`.`address` = `ad`.`id_address`))) left join `statuses` `s` on((`ap`.`property_state` = `s`.`id_status`))) where (`o`.`is_estate` = 0) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `estate_offer_preview_view`
--

/*!50001 DROP VIEW IF EXISTS `estate_offer_preview_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `estate_offer_preview_view` AS select `o`.`id_offers` AS `id_offers`,`o`.`agent` AS `agent`,`o`.`offer_name` AS `offer_name`,`o`.`has_rent` AS `has_rent`,`o`.`rent_value` AS `rent_value`,`o`.`price` AS `price`,`o`.`price_for_meter` AS `price_for_meter`,`o`.`offer_type` AS `offer_type`,`o`.`offer_status` AS `offer_status`,`e`.`property_area` AS `property_area`,`e`.`number_of_rooms` AS `number_of_rooms`,`e`.`main_photo_url` AS `main_photo_url`,`a`.`city` AS `city`,`a`.`street` AS `street`,`t`.`name` AS `name` from (((`offers` `o` left join `estates` `e` on((`o`.`estate` = `e`.`id_estate`))) left join `addresses` `a` on((`e`.`address` = `a`.`id_address`))) left join `trade_info` `t` on((`e`.`property_type` = `t`.`id_info`))) where (`o`.`is_estate` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `estate_offer_view`
--

/*!50001 DROP VIEW IF EXISTS `estate_offer_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `estate_offer_view` AS select `o`.`id_offers` AS `id_offers`,`o`.`agent` AS `agent`,`o`.`publishing_date` AS `publishing_date`,`o`.`area` AS `area`,`o`.`price` AS `price`,`o`.`details` AS `details`,`o`.`offer_name` AS `offer_name`,`o`.`price_for_meter` AS `price_for_meter`,`o`.`offer_type` AS `offer_type`,`o`.`has_rent` AS `has_rent`,`o`.`rent_value` AS `rent_value`,`o`.`market` AS `market`,`t`.`name` AS `name`,`e`.`property_area` AS `property_area`,`e`.`build_date` AS `build_date`,`e`.`number_of_rooms` AS `number_of_rooms`,`e`.`floors` AS `floors`,`e`.`other_details` AS `other_details`,`e`.`has_balcony` AS `has_balcony`,`e`.`furnishings` AS `furnishings`,`e`.`main_photo_url` AS `main_photo_url`,`e`.`roof_type` AS `roof_type`,`e`.`electricity` AS `electricity`,`e`.`water_connection` AS `water_connection`,`e`.`basement` AS `basement`,`e`.`garage` AS `garage`,`e`.`plot` AS `plot`,`e`.`fence` AS `fence`,`e`.`heating` AS `heating`,`e`.`sewers` AS `sewers`,`e`.`distance_to_forest` AS `distance_to_forest`,`e`.`distance_to_river` AS `distance_to_river`,`e`.`distance_to_mountains` AS `distance_to_mountains`,`e`.`distance_to_highway` AS `distance_to_highway`,`e`.`distance_to_center` AS `distance_to_center`,`e`.`distance_to_mall` AS `distance_to_mall`,`e`.`distance_to_lake` AS `distance_to_lake`,`e`.`distance_to_coast` AS `distance_to_coast`,`e`.`gas_installation` AS `gas_installation`,`a`.`street` AS `street`,`a`.`estate_number` AS `estate_number`,`a`.`city` AS `city`,`a`.`zip_code` AS `zip_code`,`a`.`google_maps_url` AS `google_maps_url`,`s`.`name` AS `property_status` from ((((`offers` `o` left join `estates` `e` on((`o`.`estate` = `e`.`id_estate`))) left join `addresses` `a` on((`e`.`address` = `a`.`id_address`))) left join `trade_info` `t` on((`e`.`property_type` = `t`.`id_info`))) left join `statuses` `s` on((`e`.`property_status` = `s`.`id_status`))) where (`o`.`is_estate` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `offer_preview_view`
--

/*!50001 DROP VIEW IF EXISTS `offer_preview_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `offer_preview_view` AS select `o`.`offer_name` AS `offer_name`,`o`.`price` AS `price`,`o`.`price_for_meter` AS `price_for_meter`,`o`.`offer_type` AS `offer_type`,`o`.`offer_status` AS `offer_status`,`e`.`property_area` AS `property_area`,`e`.`number_of_rooms` AS `number_of_rooms`,`e`.`main_photo_url` AS `main_photo_url`,`a`.`city` AS `city`,`a`.`street` AS `street`,`t`.`name` AS `name` from (((`offers` `o` left join `estates` `e` on((`o`.`estate` = `e`.`id_estate`))) left join `addresses` `a` on((`e`.`address` = `a`.`id_address`))) left join `trade_info` `t` on((`e`.`property_type` = `t`.`id_info`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-16 18:42:36
