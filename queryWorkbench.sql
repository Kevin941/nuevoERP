-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db_erp
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.10-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `t_cliente`
--

DROP TABLE IF EXISTS `t_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_cliente` (
  `idCliente` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `nombreCompania` varchar(255) DEFAULT NULL,
  `nombreContacto` varchar(255) DEFAULT NULL,
  `cargoContacto` varchar(255) DEFAULT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `ciudad` varchar(255) DEFAULT NULL,
  `region` varchar(50) DEFAULT NULL,
  `codigoPostal` varchar(10) DEFAULT NULL,
  `pais` varchar(100) DEFAULT NULL,
  `telefono` varchar(100) DEFAULT NULL,
  `fax` varchar(100) DEFAULT NULL,
  `mail` varchar(255) DEFAULT NULL,
  `borrado` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=201 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_cliente`
--

LOCK TABLES `t_cliente` WRITE;
/*!40000 ALTER TABLE `t_cliente` DISABLE KEYS */;
INSERT INTO `t_cliente` VALUES (1,'Dapibus Quam Quis Consulting','Jasper Valenzuela','Gerente de Sistemas','1361 Nullam Avenue','Guanajuato','México','15765','México','03 08 00 74 40','02 92 97 49 36','laoreet@ipsum.ca',0),(2,'Orci Quis Limited','Dalton Hoover','Gerente de Sistemas','Ap #406-3082 Ac Rd.','León','México','71083','México','05 11 20 16 65','01 89 63 40 24','malesuada.augue.ut@elit.org',0),(3,'Urna Inc.','Armando Hawkins','Gerente de Ventas','P.O. Box 381, 1866 Augue Street','Yucatán','México','4715KA','México','02 38 00 80 70','08 56 25 80 20','venenatis.lacus@justo.edu',0),(4,'Non Lorem Vitae Limited','Owen Figueroa','Gerente de Mercadotectia','Ap #875-2940 Nullam Rd.','Quintana Roo','México','41000','México','01 63 48 92 76','03 75 21 31 12','erat.nonummy.ultricies@vitae.ca',0),(5,'In Cursus Et Inc.','Neil Dennis','Gerente de Ventas','4584 Euismod St.','Sinaloa','México','67415','México','08 47 14 04 41','01 84 56 52 33','lorem@velit.co.uk',0),(6,'Arcu LLC','Noble Wooten','Gerente de Ventas','230-4542 Urna Street','Puebla','México','99-908','México','06 14 07 49 68','01 98 77 58 45','est.Mauris@necmalesuada.ca',0),(7,'Tristique Pharetra Associates','Jakeem Fry','Gerente de Sistemas','P.O. Box 991, 1650 Cursus. Avenue','San Luis','México','87701','México','05 66 72 32 37','09 25 20 12 71','diam@Nam.org',0),(8,'Magna Corporation','Denton Oliver','Gerente de Sistemas','7338 Nascetur Rd.','San Luis','México','9644','México','07 78 55 86 30','06 74 04 11 76','augue.malesuada.malesuada@Vestibulum.co.uk',0),(9,'Penatibus Corp.','Vincent Hoffman','Gerente de Mercadotectia','P.O. Box 380, 5531 Erat Av.','Guanajuato','México','52041','México','06 74 34 63 66','04 19 03 57 94','Sed.pharetra@Etiam.edu',0),(10,'Fermentum Fermentum Foundation','Akeem Nicholson','Gerente de Sistemas','385-3628 Libero. Av.','Morelos','México','6150','México','03 06 83 63 34','06 17 22 99 32','vulputate.dui@magnaLoremipsum.edu',0),(11,'Eget Mollis Lectus Company','Samson Holden','Gerente de Ventas','601-3917 Praesent Avenue','Tlaxcala','México','38346','México','08 95 98 65 50','09 90 61 04 43','tellus@purus.edu',0),(12,'Neque Industries','Raymond Buckner','Gerente de Sistemas','Ap #870-8754 Fermentum St.','Tamaulipas','México','96451','México','09 02 35 84 01','09 96 43 94 21','eu.euismod@mollis.edu',0),(13,'In Tempus Eu Associates','Nolan Ball','Gerente de Mercadotectia','P.O. Box 452, 3216 Euismod Street','Distrito Federal','México','48644','México','03 53 12 74 47','08 83 96 15 90','vestibulum.nec@antedictumcursus.net',0),(14,'Facilisis Inc.','Coby Benjamin','Gerente de Ventas','9802 Nunc. Rd.','Sinaloa','México','8410OA','México','06 13 89 43 74','02 89 41 63 84','Mauris@elitEtiam.com',0),(15,'Fringilla Euismod Company','Kane Mcbride','Gerente de Ventas','501-6992 At, Street','Jalisco','México','60-262','México','09 80 34 95 61','08 34 12 00 89','mi.fringilla.mi@eros.co.uk',0),(16,'Molestie Orci Tincidunt Institute','Roth Riley','Gerente de Ventas','1570 Egestas. St.','Tlaxcala','México','8989','México','03 99 86 17 74','07 84 26 23 97','Morbi.metus.Vivamus@vitaeposuereat.ca',0),(17,'Enim Etiam LLC','Phillip Gould','Gerente de Sistemas','Ap #890-5763 Eget Rd.','Sonora','México','92439-578','México','07 13 05 00 00','04 47 44 96 59','vitae.aliquam.eros@cursus.edu',0),(18,'Ut Corporation','Seth Carter','Gerente de Sistemas','989-3733 Ante. Road','Tlaxcala','México','3468','México','08 71 29 62 87','06 99 64 02 37','Curabitur.dictum.Phasellus@sem.org',0),(19,'Fringilla Donec Industries','Oren Austin','Gerente de Mercadotectia','820-9691 Cursus Rd.','San Luis','México','405556','México','05 21 22 98 84','03 06 49 19 86','erat.nonummy@Nuncmauriselit.com',0),(20,'Faucibus Morbi LLC','Elvis Sweet','Gerente de Ventas','487-8342 Tellus Street','Querétaro','México','10536','México','03 75 92 28 27','07 19 82 36 30','pretium.aliquet@rutrumFusce.co.uk',0),(21,'Ornare LLP','Dale Graves','Gerente de Mercadotectia','P.O. Box 703, 931 Fringilla Road','Puebla','México','78703','México','07 39 17 03 27','06 58 44 74 72','est.arcu.ac@Donecatarcu.edu',0),(22,'Mi Lorem Incorporated','Macaulay Mueller','Gerente de Sistemas','8485 Eget Av.','Guanajuato','México','7629','México','05 58 37 97 79','09 56 34 43 28','et.tristique@lacusvestibulumlorem.com',0),(23,'Elit Pellentesque Associates','Nasim Pena','Gerente de Mercadotectia','P.O. Box 192, 4089 Ipsum Av.','Nayarit','México','15908','México','05 48 63 42 39','05 30 50 10 98','lobortis@eu.net',0),(24,'Tincidunt Adipiscing Mauris Limited','Kareem Vasquez','Gerente de Sistemas','Ap #893-7405 Lacus Ave','Baja','México','797794','México','07 00 47 29 95','02 97 37 25 53','est.mollis@pretium.co.uk',0),(25,'Diam Ltd','Cole Vazquez','Gerente de Ventas','321-6358 Tellus Av.','Michoacán','México','37900','México','05 84 19 30 99','06 67 37 82 07','nec@Phaselluselitpede.co.uk',0),(26,'Sem Molestie Sodales Foundation','Lawrence Rodriguez','Gerente de Mercadotectia','5806 In, Avenue','Hidalgo','México','238902','México','08 27 17 65 28','07 19 36 06 88','Aenean.gravida@Sedmolestie.net',0),(27,'Adipiscing Incorporated','Nolan Booker','Gerente de Mercadotectia','P.O. Box 968, 6314 Eu, Avenue','Morelos','México','27983','México','09 12 59 53 05','01 19 62 66 64','tempor.erat@eratsemperrutrum.org',0),(28,'Sed Sapien LLP','Isaiah Slater','Gerente de Ventas','Ap #355-3565 Mauris St.','Nayarit','México','7332','México','02 74 02 50 71','05 17 68 39 73','elit.pellentesque.a@adipiscingnonluctus.net',0),(29,'Feugiat Incorporated','Blake Oneill','Gerente de Ventas','933-6970 Mauris Rd.','Tlaxcala','México','43946-676','México','01 59 69 14 00','01 84 23 49 69','Integer@purus.net',0),(30,'Nulla Aliquet LLC','Yuli Bryant','Gerente de Sistemas','3243 Metus Ave','Hidalgo','México','X9Z 9J8','México','07 34 55 54 18','03 46 97 35 69','amet.dapibus.id@scelerisquesed.ca',0),(31,'Varius Orci In Inc.','Alvin Stein','Gerente de Ventas','583-3532 Ac, St.','California','México','61367','México','08 43 70 28 44','03 87 08 84 95','ac@cursusaenim.ca',0),(32,'Turpis Foundation','Zahir Leach','Gerente de Mercadotectia','P.O. Box 132, 9462 Eleifend. Avenue','Morelos','México','61110','México','08 54 75 00 47','01 00 94 92 74','at.egestas.a@disparturient.com',0),(33,'Cum Sociis Incorporated','Forrest Le','Gerente de Ventas','262-8720 Magnis Rd.','Puebla','México','19789','México','08 70 15 86 48','08 94 47 12 46','Curabitur.ut@Quisqueac.ca',0),(34,'Dolor Fusce Inc.','Steven Pittman','Gerente de Sistemas','P.O. Box 199, 3095 Parturient St.','Campeche','México','BN4T 5KQ','México','07 45 40 11 92','04 42 28 78 81','Sed@cursusluctusipsum.org',0),(35,'Enim Corp.','Harding Petty','Gerente de Ventas','216-3849 Arcu. Av.','Guanajuato','México','22701','México','04 86 22 48 75','06 68 28 27 65','et@Integer.ca',0),(36,'Mattis Cras Eget Ltd','Kennan Baker','Gerente de Mercadotectia','P.O. Box 405, 4493 Porta Road','Hidalgo','México','20217','México','07 66 64 29 95','03 02 16 00 19','habitant.morbi@sagittis.co.uk',0),(37,'Vitae Velit Corp.','Keefe Hahn','Gerente de Sistemas','Ap #653-7532 Eu Avenue','Baja','México','55-347','México','03 00 34 32 41','07 77 19 87 22','fermentum.metus.Aenean@portaelit.co.uk',0),(38,'Sed Diam Lorem Consulting','Gavin Lowery','Gerente de Sistemas','3150 Aliquam St.','Chiapas','México','21318','México','03 49 31 44 26','09 62 26 81 84','arcu.Vestibulum.ut@placerat.org',0),(39,'Ut Sagittis Lobortis Associates','Mark Hays','Gerente de Mercadotectia','122-4283 Ultrices, St.','Zacatecas','México','34951','México','04 03 04 29 79','04 46 98 61 70','Nulla@convallisdolorQuisque.net',0),(40,'Nunc Corp.','Lucian Lang','Gerente de Sistemas','925-3826 Sed Rd.','Tamaulipas','México','82-387','México','01 32 47 53 06','04 74 82 36 00','ridiculus.mus.Proin@lectus.org',0),(41,'Odio Phasellus At Corp.','Duncan Livingston','Gerente de Sistemas','6995 Iaculis Rd.','Jalisco','México','51824','México','07 51 59 89 38','04 69 89 10 33','enim.non.nisi@euismod.com',0),(42,'In Molestie Tortor LLC','Lane Wilkinson','Gerente de Mercadotectia','6318 Et Street','Campeche','México','7802WT','México','08 90 42 68 26','06 09 66 08 42','sed@metuseu.org',0),(43,'Velit Corp.','Addison Stevens','Gerente de Mercadotectia','Ap #228-494 Bibendum Avenue','Yucatán','México','28450','México','01 43 86 06 29','04 30 77 94 23','a@dolorFuscemi.org',0),(44,'Iaculis Odio PC','Wayne Hicks','Gerente de Sistemas','Ap #593-5058 Neque Ave','Campeche','México','N1C 6H7','México','09 11 93 77 04','06 61 71 35 56','metus@nunc.org',0),(45,'Eu Lacus Quisque Incorporated','Kenneth Elliott','Gerente de Ventas','9955 Semper Ave','California Sur','México','36414','México','08 56 36 83 45','07 79 01 68 03','condimentum.eget.volutpat@Fuscemollis.com',0),(46,'Sapien Cras PC','Aidan Stuart','Gerente de Ventas','Ap #685-9962 Dui. Ave','Chihuahua','México','01720-181','México','01 98 18 26 37','06 10 22 20 36','Aenean.eget.magna@Nam.net',0),(47,'Turpis Ltd','Aquila Rodriguez','Gerente de Ventas','244-4648 Fusce St.','Colima','México','E2C 0A4','México','01 62 99 80 74','05 51 51 02 58','arcu.et@egetlacusMauris.net',0),(48,'Tempor Institute','Owen Noble','Gerente de Sistemas','3788 Aenean St.','Aguascalientes','México','38-346','México','02 94 74 27 43','01 81 68 50 61','sed.leo.Cras@noncursus.com',0),(49,'Suspendisse Ac Associates','Ray Frost','Gerente de Ventas','Ap #854-9482 Quisque Rd.','Oaxaca','México','40483','México','03 33 42 59 09','03 57 81 16 28','mollis.Duis@aliquam.com',0),(50,'Nunc Associates','Timothy Gaines','Gerente de Ventas','Ap #104-2136 Sapien. Rd.','California Sur','México','7026','México','08 84 55 97 49','07 45 23 35 94','ut.nisi.a@eu.co.uk',0),(51,'Vehicula Pellentesque Tincidunt Incorporated','Nasim Oneal','Gerente de Mercadotectia','1443 In, Road','Michoacán','México','15016','México','07 05 69 08 82','09 33 72 13 58','Nam.interdum@ultrices.net',0),(52,'Odio Inc.','Elmo Mooney','Gerente de Ventas','Ap #433-4378 Sem Avenue','Baja','México','07330-120','México','03 09 16 10 08','01 16 17 96 40','dolor.nonummy@Maurisvestibulumneque.edu',0),(53,'Ut Dolor Industries','Forrest Lewis','Gerente de Ventas','P.O. Box 364, 2296 Morbi Av.','Durango','México','9132','México','03 78 18 22 73','04 86 77 85 86','lobortis@dapibusid.com',0),(54,'Lectus Pede Ltd','Bernard Britt','Gerente de Mercadotectia','980-6482 Nunc St.','Chiapas','México','27430','México','05 57 01 99 37','06 00 38 49 65','vulputate@penatibuset.ca',0),(55,'Gravida Aliquam Tincidunt Consulting','Jin Wong','Gerente de Mercadotectia','2928 Dolor Road','Zacatecas','México','805856','México','03 07 94 80 37','04 43 85 94 22','id.ante.Nunc@sodales.edu',0),(56,'Pede Ac Urna Associates','Quinlan Mitchell','Gerente de Sistemas','P.O. Box 275, 9595 Tincidunt Road','Potosí','México','294556','México','07 90 52 92 99','08 66 09 87 55','aliquet@euismodenim.net',0),(57,'Ac Consulting','Stewart Burton','Gerente de Ventas','5531 Sem Avenue','Durango','México','77460','México','01 29 38 13 39','06 68 17 30 84','nec.imperdiet.nec@vitaeeratVivamus.net',0),(58,'Blandit Industries','Hilel Ratliff','Gerente de Mercadotectia','P.O. Box 893, 773 Nibh Rd.','Potosí','México','99207','México','09 57 71 61 52','08 53 35 35 20','non.hendrerit@dapibus.net',0),(59,'Erat In Consulting','Quamar Foley','Gerente de Sistemas','403-6380 Eleifend. Rd.','Aguascalientes','México','003107','México','02 34 49 52 04','07 82 98 55 74','quis.diam@hendreritDonecporttitor.com',0),(60,'Mi Eleifend Foundation','Colt Meyers','Gerente de Sistemas','Ap #579-9449 A Rd.','Aguascalientes','México','20813','México','03 27 52 72 22','02 80 60 04 09','eget.lacus.Mauris@aliquet.net',0),(61,'Netus Et Company','Kenneth Glover','Gerente de Mercadotectia','8805 Eleifend Avenue','Coahuila','México','7908QZ','México','01 66 77 06 77','01 02 81 03 15','ante.ipsum.primis@ullamcorpervelitin.com',0),(62,'Iaculis Consulting','Jerome Cross','Gerente de Ventas','6207 Eget, St.','Quintana Roo','México','800780','México','02 97 34 23 15','05 16 55 31 56','nulla.vulputate.dui@sedfacilisis.ca',0),(63,'Quis Accumsan Incorporated','Amal Salinas','Gerente de Sistemas','P.O. Box 189, 9862 Diam Street','Jalisco','México','40819','México','04 99 67 29 96','07 80 75 62 59','vel@atortorNunc.co.uk',0),(64,'Proin Velit Ltd','Quamar Buchanan','Gerente de Ventas','P.O. Box 142, 4078 Dui. St.','Campeche','México','2074','México','04 67 89 81 69','01 47 31 93 23','vel@auctor.ca',0),(65,'Dignissim Pharetra Company','Marsden Poole','Gerente de Sistemas','246-8238 At Rd.','Sonora','México','63-105','México','03 09 29 44 98','06 38 13 14 37','pharetra.ut.pharetra@Donectempor.edu',0),(66,'Proin Ultrices Duis Corporation','Ethan Valdez','Gerente de Ventas','Ap #226-5843 Nisi St.','Guanajuato','México','937690','México','03 05 47 93 44','07 17 17 81 35','ac@Proinmi.edu',0),(67,'Dignissim Lacus Company','Ray Aguirre','Gerente de Ventas','P.O. Box 466, 4884 Eu, Av.','Nuevo','México','24543','México','09 81 27 39 38','09 18 92 49 84','in.cursus@utnulla.net',0),(68,'Ut Lacus Nulla LLP','Brennan Joyner','Gerente de Ventas','Ap #208-9854 Eu, St.','Nayarit','México','152371','México','09 30 26 61 91','07 90 91 17 48','dictum.magna.Ut@nequetellusimperdiet.co.uk',0),(69,'Et Lacinia Consulting','Leonard Coffey','Gerente de Ventas','783-304 Eleifend. Avenue','Sinaloa','México','39076','México','03 23 09 78 96','07 72 97 80 07','vitae.sodales.nisi@eratvolutpatNulla.edu',0),(70,'Habitant Morbi Tristique Company','Vance Justice','Gerente de Mercadotectia','9473 Cubilia Rd.','León','México','728025','México','02 22 80 53 03','05 72 02 86 01','ridiculus@velarcuCurabitur.edu',0),(71,'Sit Ltd','Wyatt Padilla','Gerente de Ventas','844-6377 Eget, Rd.','Tamaulipas','México','978830','México','02 35 84 84 87','07 16 37 12 54','bibendum.sed@Proinsedturpis.org',0),(72,'Sed Eu Eros Associates','Quentin Mcdaniel','Gerente de Sistemas','255-4890 In Rd.','Guanajuato','México','74422','México','07 70 31 25 38','08 40 16 75 53','aliquet@adipiscing.co.uk',0),(73,'Ullamcorper Velit In Limited','Erich Guy','Gerente de Mercadotectia','220-4904 Tempor, Rd.','Oaxaca','México','894425','México','05 50 72 75 95','05 79 33 30 54','sapien.Cras@liberonecligula.edu',0),(74,'Et Commodo At Consulting','Hamilton Church','Gerente de Ventas','5078 Facilisis Av.','Tamaulipas','México','21192','México','06 59 85 60 87','08 50 32 51 24','diam.Sed@aliquamenim.edu',0),(75,'Aliquam Consulting','Zachery Good','Gerente de Ventas','P.O. Box 665, 4245 Lorem, Road','Distrito Federal','México','24373','México','02 39 21 21 18','05 46 70 03 10','gravida.mauris@dui.com',0),(76,'Sagittis Associates','Hammett Glover','Gerente de Mercadotectia','604-1871 Sed St.','San Luis','México','97608','México','06 37 05 97 86','03 49 27 66 24','tincidunt.congue.turpis@etnunc.ca',0),(77,'Magnis Inc.','Palmer Decker','Gerente de Mercadotectia','P.O. Box 942, 985 Mus. Av.','Zacatecas','México','61535','México','08 47 25 21 18','02 10 29 57 45','sagittis.augue@vitae.ca',0),(78,'Imperdiet Erat Foundation','Joel Kim','Gerente de Mercadotectia','806-8929 Sit Road','San Luis','México','8976JN','México','03 92 73 19 93','04 03 70 36 46','et.tristique.pellentesque@augueporttitorinterdum.co.uk',0),(79,'Arcu Vivamus Sit Consulting','Quamar Mcfadden','Gerente de Mercadotectia','4334 Venenatis Av.','Sinaloa','México','03173','México','05 83 11 87 15','04 16 26 28 68','nunc.ullamcorper.eu@gravidamauris.net',0),(80,'Massa Rutrum Consulting','Nissim Delgado','Gerente de Ventas','472-4955 Elit. Av.','Baja','México','78-410','México','07 08 72 10 18','02 53 21 50 91','accumsan.interdum@aliquetdiamSed.net',0),(81,'Ornare Industries','Moses Knowles','Gerente de Sistemas','7144 Adipiscing Street','Morelos','México','90576','México','09 60 81 44 89','07 95 83 06 89','commodo.tincidunt@eu.co.uk',0),(82,'Tincidunt Vehicula Risus LLC','Kirk Ware','Gerente de Mercadotectia','238 Ut, Avenue','Sonora','México','H3S 4L1','México','05 44 70 12 35','09 43 16 26 18','senectus@nisidictum.net',0),(83,'Morbi Inc.','Carlos Cantrell','Gerente de Sistemas','3062 Cursus Av.','Veracruz','México','7090','México','05 90 14 86 27','02 03 20 03 14','commodo.tincidunt@nec.net',0),(84,'Nunc PC','Brian Conrad','Gerente de Mercadotectia','813-7030 Sed Street','Quintana Roo','México','67231','México','07 41 05 54 65','08 07 09 92 24','rutrum.eu.ultrices@famesacturpis.org',0),(85,'Mauris Ut Mi Incorporated','Vladimir Martin','Gerente de Ventas','P.O. Box 605, 5645 Vehicula. Rd.','Guanajuato','México','98202','México','04 23 47 35 22','06 20 48 03 71','lectus.Cum@mifringilla.edu',0),(86,'Cursus In Incorporated','Vance Paul','Gerente de Mercadotectia','112-7388 Integer Avenue','California','México','777102','México','03 55 15 04 15','04 04 45 81 95','tristique@Suspendisse.net',0),(87,'In Company','Cullen Petty','Gerente de Mercadotectia','Ap #352-6368 Diam. Ave','Oaxaca','México','010489','México','05 00 04 34 78','09 86 23 82 89','egestas@magna.com',0),(88,'Mauris Blandit Company','Nigel Randall','Gerente de Ventas','3304 Mattis. Road','Potosí','México','5423','México','07 60 59 07 65','04 34 35 83 38','Cras@anunc.net',0),(89,'A Purus Duis LLP','Simon Phillips','Gerente de Sistemas','Ap #433-6601 Felis, Ave','Aguascalientes','México','38647-018','México','01 43 70 93 56','02 75 88 66 39','malesuada.fames.ac@ridiculusmus.net',0),(90,'Proin Eget Odio Institute','George Houston','Gerente de Mercadotectia','Ap #621-1941 Auctor Rd.','Jalisco','México','X2Q 9QM','México','04 89 55 38 05','01 52 75 08 59','nunc.nulla.vulputate@sem.ca',0),(91,'Turpis Nec Incorporated','Quinlan Mccall','Gerente de Sistemas','Ap #187-3792 Donec Avenue','León','México','7410','México','07 81 83 71 82','01 00 78 96 28','Vivamus@neque.edu',0),(92,'Sit Amet LLP','Forrest Ashley','Gerente de Sistemas','Ap #642-8363 Cubilia Avenue','Nayarit','México','32697','México','01 01 87 73 03','08 77 07 22 17','mauris.elit@amagna.com',0),(93,'Et LLC','Phelan Osborne','Gerente de Mercadotectia','P.O. Box 307, 3943 Duis Street','Veracruz','México','1542FJ','México','01 62 91 71 53','02 18 31 97 67','sit.amet@etrutrum.co.uk',0),(94,'Blandit Congue Limited','Jonas Rodriquez','Gerente de Mercadotectia','Ap #922-4839 Ut St.','Potosí','México','7622TT','México','05 51 47 79 81','01 51 54 76 03','augue@Phasellus.org',0),(95,'Duis Volutpat Foundation','Gareth Huber','Gerente de Mercadotectia','P.O. Box 405, 7973 Nonummy Av.','Jalisco','México','5185','México','06 59 34 41 54','08 84 70 28 72','luctus@atauctor.edu',0),(96,'At Fringilla Purus Associates','George Coffey','Gerente de Mercadotectia','P.O. Box 857, 4390 Aliquet Avenue','Aguascalientes','México','A1H 3G5','México','04 72 74 33 57','04 27 41 97 01','amet.consectetuer@diamluctuslobortis.net',0),(97,'Quisque Corporation','Colt Petersen','Gerente de Mercadotectia','P.O. Box 701, 2771 Non, Street','Sonora','México','21602','México','05 60 10 78 59','08 76 43 59 49','erat@Etiamlaoreetlibero.co.uk',0),(98,'Enim Consequat LLC','Basil Patrick','Gerente de Ventas','Ap #488-6837 Luctus Street','Potosí','México','JL18 8JZ','México','07 39 01 46 11','09 40 81 71 17','eget@justo.co.uk',0),(99,'Semper Cursus Associates','Nathaniel Marsh','Gerente de Mercadotectia','703-9279 In, Ave','Hidalgo','México','472169','México','06 83 08 43 55','03 24 90 12 75','lobortis.nisi.nibh@dapibus.ca',0),(100,'Consectetuer Adipiscing Company','Arsenio Gordon','Gerente de Mercadotectia','534-4687 Quis, Ave','Tlaxcala','México','4014','México','06 89 65 55 06','07 46 37 39 75','est@accumsanlaoreet.com',0),(101,'Neque Company','Armand Osborn','Gerente de Ventas','9739 Ac, Av.','Morelos','México','99629','México','04 76 61 94 07','06 54 96 16 57','pellentesque.eget.dictum@nequeseddictum.org',0),(102,'Sed Eu Incorporated','Matthew Gomez','Gerente de Ventas','7336 Erat St.','Hidalgo','México','44154','México','02 40 72 19 51','09 45 62 58 75','Donec.luctus@nullamagna.edu',0),(103,'Risus Incorporated','Stuart Lindsay','Gerente de Ventas','Ap #269-717 Ut Avenue','Morelos','México','581412','México','05 94 32 57 58','08 85 20 69 22','adipiscing.elit.Aliquam@odioEtiamligula.net',0),(104,'Nunc Quisque Ornare Industries','Brent Vasquez','Gerente de Ventas','Ap #528-8936 Neque Rd.','Puebla','México','98187','México','04 96 61 53 90','05 41 13 19 08','dui@nuncsit.net',0),(105,'Libero Est Congue LLP','Chaim Vazquez','Gerente de Sistemas','9868 Cursus Ave','Coahuila','México','90259-067','México','03 92 79 05 96','07 51 72 95 68','dictum.mi.ac@sit.com',0),(106,'Mi Lorem LLC','Joseph Melendez','Gerente de Mercadotectia','P.O. Box 204, 8985 Ornare. Av.','Tlaxcala','México','08287','México','08 32 23 71 98','09 91 81 59 00','fermentum@anteVivamus.co.uk',0),(107,'A Auctor Non Inc.','Lyle Heath','Gerente de Sistemas','Ap #259-1902 Semper St.','Hidalgo','México','9712GD','México','04 96 09 62 14','04 75 67 96 38','tristique.neque@ipsumnuncid.edu',0),(108,'Nunc Sollicitudin Associates','Emerson Harding','Gerente de Sistemas','1492 Eu Rd.','Colima','México','56069','México','07 51 87 35 24','05 25 40 03 14','egestas.nunc.sed@Sednuncest.com',0),(109,'Elementum Consulting','Baker Vargas','Gerente de Mercadotectia','343-8133 Lacus Av.','Morelos','México','78-690','México','04 04 39 53 92','06 69 86 76 57','aliquet@luctusipsumleo.com',0),(110,'Ac Turpis Corp.','Hop Kane','Gerente de Mercadotectia','Ap #266-5156 Orci, Road','Tamaulipas','México','H9P 4K7','México','08 36 71 80 42','07 28 43 90 55','nunc.id.enim@dignissimMaecenas.com',0),(111,'Ac Orci LLP','Eric Hayes','Gerente de Mercadotectia','390-3217 Commodo Rd.','Nuevo','México','17420','México','07 01 29 98 38','07 32 83 43 36','dolor.vitae.dolor@aliquet.edu',0),(112,'Ac Urna Ut Company','Clinton Fernandez','Gerente de Sistemas','P.O. Box 266, 473 Odio. Ave','León','México','22045','México','08 35 16 17 52','07 52 45 46 05','eu.erat@Mauris.com',0),(113,'Egestas Fusce Aliquet LLC','Jerome Austin','Gerente de Ventas','Ap #820-3914 Donec St.','Baja','México','18-784','México','05 71 48 59 50','03 01 04 40 20','scelerisque.scelerisque.dui@sapien.com',0),(114,'Malesuada Associates','James Diaz','Gerente de Ventas','911-9304 Enim Ave','Morelos','México','50761','México','04 08 16 68 90','07 58 22 82 42','facilisis.lorem@est.co.uk',0),(115,'Integer Aliquam Inc.','Brandon Elliott','Gerente de Sistemas','406-3918 Cum Avenue','Nuevo','México','38237','México','06 55 33 78 06','02 26 34 91 34','vel.arcu@sem.ca',0),(116,'Magna Et Industries','Hyatt Cotton','Gerente de Mercadotectia','Ap #745-5291 Sociosqu St.','Guanajuato','México','636950','México','06 35 17 12 23','01 11 56 09 27','odio@est.edu',0),(117,'Duis Dignissim Incorporated','Wallace Moss','Gerente de Sistemas','755-9258 Amet Rd.','Nuevo','México','8987','México','06 99 92 59 39','01 56 05 47 93','Sed.nec@rutrumFusce.org',0),(118,'Quisque Fringilla Euismod Associates','August Crawford','Gerente de Ventas','P.O. Box 988, 9589 Eget, Ave','Distrito Federal','México','15774','México','07 69 33 11 56','01 98 95 56 40','Fusce.feugiat.Lorem@Phasellusdolor.edu',0),(119,'Nascetur Ridiculus Mus LLP','Kevin Larson','Gerente de Ventas','6340 Risus Ave','California','México','31417','México','05 96 02 46 61','08 68 75 23 14','Nulla.eget.metus@orciUtsemper.ca',0),(120,'Ut PC','Connor Hawkins','Gerente de Ventas','1884 Eleifend St.','Hidalgo','México','7843','México','05 29 02 01 06','03 55 68 70 31','tempus.non@sitametconsectetuer.co.uk',0),(121,'Fusce Aliquam Enim Inc.','Coby Buchanan','Gerente de Ventas','Ap #718-2546 Et St.','California','México','9087','México','06 36 20 89 99','01 55 15 01 13','magnis@pedenec.co.uk',0),(122,'Vestibulum Accumsan Ltd','Michael Durham','Gerente de Sistemas','3592 Eget Rd.','Estado de México','México','456270','México','06 16 56 59 63','06 58 17 84 48','mi.enim.condimentum@arcuSed.ca',0),(123,'Eleifend Nunc Risus Foundation','Tarik Collins','Gerente de Ventas','383-518 Donec St.','Colima','México','53164','México','07 24 56 59 08','01 31 96 87 32','nec@acmieleifend.edu',0),(124,'Arcu Industries','Theodore Massey','Gerente de Ventas','9126 Etiam Street','Baja','México','987378','México','06 09 54 86 09','04 46 27 60 71','Fusce.feugiat.Lorem@tristiquesenectus.co.uk',0),(125,'Ipsum Porta Elit Inc.','Cole Ortega','Gerente de Mercadotectia','P.O. Box 758, 5904 Justo Rd.','Quintana Roo','México','40612','México','02 72 47 36 71','07 18 34 88 84','cursus.in.hendrerit@tinciduntpede.net',0),(126,'Morbi Sit Amet Industries','Travis Vasquez','Gerente de Sistemas','Ap #796-9785 Quisque St.','Campeche','México','58947','México','07 36 25 09 97','08 71 56 13 99','Aliquam@consectetuereuismod.com',0),(127,'Metus Sit Amet Corp.','Dorian Abbott','Gerente de Ventas','525-3929 Orci. Road','Tabasco','México','9520','México','08 92 90 80 75','04 76 10 00 34','tempor.diam.dictum@justo.net',0),(128,'Quis LLC','Thaddeus Terry','Gerente de Ventas','3344 Pellentesque Av.','Morelos','México','6461SA','México','01 54 86 13 22','02 69 52 12 82','malesuada.ut@NulladignissimMaecenas.com',0),(129,'Tempus Scelerisque Lorem LLP','Murphy Roy','Gerente de Sistemas','943-1852 Ut Ave','Guanajuato','México','46978','México','04 80 04 85 75','02 79 91 95 09','blandit@Vivamusnon.com',0),(130,'Nunc Limited','Dane Graves','Gerente de Sistemas','Ap #445-3107 Sociosqu St.','Colima','México','84094-581','México','05 35 28 18 44','05 73 63 80 88','rutrum.Fusce.dolor@molestieSedid.ca',0),(131,'Ut Company','Rudyard Freeman','Gerente de Ventas','4171 Eu St.','Nayarit','México','479600','México','01 90 75 26 28','02 02 18 37 46','magna.sed@ipsumcursusvestibulum.co.uk',0),(132,'Donec Est Consulting','Isaiah Shaw','Gerente de Sistemas','P.O. Box 829, 5090 Lectus Rd.','Tabasco','México','75002','México','05 32 17 60 26','05 17 24 95 69','malesuada@Duis.edu',0),(133,'Purus Sapien Inc.','Brent Nelson','Gerente de Mercadotectia','Ap #720-4618 Tempor St.','Nuevo','México','16525','México','04 42 81 10 10','09 21 68 72 36','Vestibulum@augueSed.net',0),(134,'Purus Maecenas Libero Limited','Grady Buckner','Gerente de Mercadotectia','166-647 Malesuada Rd.','Tabasco','México','6349','México','05 63 75 14 29','09 07 62 10 08','rutrum@ornareFusce.edu',0),(135,'Ultrices Inc.','Merritt Kidd','Gerente de Ventas','P.O. Box 126, 5422 Tincidunt. Street','Tamaulipas','México','59294','México','09 77 69 27 38','06 03 42 99 18','eu.neque@eudolor.com',0),(136,'Sem Semper Corporation','Dillon Norris','Gerente de Sistemas','P.O. Box 388, 6359 In Road','Durango','México','152338','México','04 17 17 09 48','09 16 11 04 27','ac.tellus@ultricesVivamusrhoncus.co.uk',0),(137,'Adipiscing Lacus Ut Ltd','Micah Hebert','Gerente de Ventas','444 Semper Rd.','San Luis','México','647578','México','09 05 43 21 65','09 78 18 31 78','auctor.Mauris@luctusaliquetodio.ca',0),(138,'Odio A Purus Institute','Peter Cleveland','Gerente de Sistemas','Ap #753-4431 Cursus. Road','Distrito Federal','México','792391','México','09 61 25 96 66','02 71 32 70 66','convallis@egestasligulaNullam.org',0),(139,'Curabitur Egestas Nunc Inc.','Raja Garrett','Gerente de Sistemas','4135 Velit Ave','Morelos','México','08599','México','07 53 51 68 33','07 35 67 99 63','Nam@velvulputate.co.uk',0),(140,'Gravida LLC','Devin Bond','Gerente de Mercadotectia','Ap #793-2427 Ac Av.','Zacatecas','México','372713','México','05 41 18 66 17','02 38 26 37 73','ante@ac.edu',0),(141,'Risus Donec Limited','Garrett Pugh','Gerente de Sistemas','Ap #559-3449 Enim. Avenue','Baja','México','411959','México','06 75 39 93 05','07 12 53 39 19','Nullam.enim.Sed@odio.net',0),(142,'Elit Ltd','Mohammad Cochran','Gerente de Ventas','Ap #460-6757 Augue. Ave','Guanajuato','México','921890','México','03 01 01 76 29','05 06 04 39 73','Mauris.eu.turpis@Suspendissealiquetsem.net',0),(143,'Egestas Rhoncus Proin Foundation','Dexter Buckner','Gerente de Ventas','Ap #750-2578 Aliquam Av.','Oaxaca','México','99093','México','04 71 76 31 74','01 29 46 47 31','mauris.sagittis@nondui.edu',0),(144,'Molestie LLC','Giacomo Morton','Gerente de Ventas','719-6466 Tellus Avenue','Yucatán','México','819827','México','09 68 72 27 87','08 18 84 04 66','sem.Nulla.interdum@Fusce.co.uk',0),(145,'Non Incorporated','Aaron Patton','Gerente de Ventas','487-5389 Dolor Ave','California','México','90292','México','05 76 89 69 49','05 40 20 44 22','Integer@apurus.edu',0),(146,'Ac Mattis Ornare PC','Lev Conway','Gerente de Ventas','P.O. Box 895, 2401 Cursus, Road','Durango','México','61600','México','05 38 83 37 02','06 63 80 25 70','molestie.orci.tincidunt@VivamusrhoncusDonec.co.uk',0),(147,'Malesuada Augue Institute','Ivor Middleton','Gerente de Sistemas','P.O. Box 292, 2248 Fermentum Road','Durango','México','54011','México','09 49 36 40 68','03 68 63 27 62','lectus.sit.amet@blanditNamnulla.net',0),(148,'Nulla Semper PC','Lars Simmons','Gerente de Sistemas','Ap #111-768 A Street','Colima','México','97117','México','09 55 50 36 01','05 31 98 43 29','Donec.felis.orci@faucibus.com',0),(149,'Varius Limited','Linus Charles','Gerente de Ventas','4718 Aenean Road','Nayarit','México','50347','México','08 66 73 93 94','06 55 02 25 50','nec@SuspendisseeleifendCras.org',0),(150,'Ac Eleifend Vitae Corp.','Benjamin Carroll','Gerente de Sistemas','9709 Libero Av.','Baja','México','110916','México','09 58 61 43 62','03 89 13 23 85','congue.a@orci.com',0),(151,'Ipsum Primis In PC','Lars Donaldson','Gerente de Sistemas','Ap #862-759 Diam St.','Michoacán','México','33539-235','México','06 34 46 78 63','09 87 38 44 37','porta.elit@malesuadafamesac.co.uk',0),(152,'Sit Amet Incorporated','Malachi Holder','Gerente de Mercadotectia','246-8902 Nunc. Av.','Chihuahua','México','KZ5A 4ZC','México','05 89 13 50 62','07 29 60 49 04','Nunc@et.edu',0),(153,'Aliquam Adipiscing Lobortis LLP','Baxter Trevino','Gerente de Mercadotectia','P.O. Box 415, 2164 Fringilla. Rd.','Morelos','México','9496','México','01 16 80 85 29','03 89 09 02 54','quam.dignissim.pharetra@pellentesquea.net',0),(154,'Metus Sit Amet Limited','Herman Pope','Gerente de Mercadotectia','P.O. Box 164, 7551 Tortor St.','Quintana Roo','México','516664','México','05 90 14 54 91','07 32 07 61 66','vestibulum.Mauris.magna@Donecfelisorci.org',0),(155,'Condimentum Donec PC','Sean Rosa','Gerente de Ventas','984-4367 Eget, Road','Quintana Roo','México','1728','México','02 94 55 94 25','01 20 93 42 53','tincidunt@id.com',0),(156,'Elit Curabitur Sed Foundation','Leonard Bender','Gerente de Ventas','282-6333 Bibendum St.','California','México','205440','México','05 97 87 32 62','09 33 25 39 83','euismod.est.arcu@ipsum.ca',0),(157,'Libero Proin Incorporated','Hayden Prince','Gerente de Ventas','P.O. Box 492, 6111 Eros St.','Zacatecas','México','42609','México','09 37 25 78 42','07 59 34 00 70','mauris@laoreetlectusquis.org',0),(158,'Sed Eu Eros Institute','Hamilton Hunt','Gerente de Ventas','825-6205 Fusce Ave','León','México','664383','México','01 10 75 93 66','09 46 81 62 41','velit.Aliquam@necorci.com',0),(159,'Fusce Mollis Duis PC','Blake Richmond','Gerente de Sistemas','P.O. Box 186, 5914 Cursus Ave','Nuevo','México','963446','México','08 33 67 01 62','08 45 19 11 29','dictum.Phasellus@Vivamusnibh.ca',0),(160,'Mi Lacinia Consulting','Tarik Talley','Gerente de Mercadotectia','P.O. Box 963, 8009 In St.','Nayarit','México','77240','México','03 90 50 29 95','06 91 72 40 25','Nulla.aliquet.Proin@estcongue.com',0),(161,'Malesuada Malesuada Incorporated','Aidan Kaufman','Gerente de Mercadotectia','6569 Quis Street','Tlaxcala','México','77-323','México','04 15 99 29 34','03 51 04 54 28','mauris@egetdictum.com',0),(162,'Egestas Industries','Denton Hill','Gerente de Ventas','P.O. Box 608, 7874 Rhoncus. Av.','Aguascalientes','México','31382','México','06 35 93 89 74','08 79 56 98 15','hymenaeos.Mauris@musProin.com',0),(163,'Elementum Purus Foundation','Phelan Pittman','Gerente de Sistemas','331 Commodo Rd.','Oaxaca','México','510943','México','09 42 53 05 98','04 41 42 21 91','Donec.non@Etiam.edu',0),(164,'Duis Consulting','Leonard Slater','Gerente de Mercadotectia','4966 Dolor. Rd.','Estado de México','México','B5J 8C1','México','05 66 40 39 96','04 87 73 37 09','porttitor@massaMaurisvestibulum.net',0),(165,'Pede Ac Urna LLC','Slade Morgan','Gerente de Ventas','377-2783 At, Rd.','Guerrero','México','41324','México','03 77 80 36 12','03 15 64 40 27','risus.Quisque.libero@a.com',0),(166,'Nunc Incorporated','Kennan Rosales','Gerente de Sistemas','Ap #653-8934 Ut Road','Coahuila','México','64986','México','06 39 52 88 23','01 29 52 85 60','tempor.erat.neque@augueacipsum.com',0),(167,'Ante Consulting','Rahim Munoz','Gerente de Ventas','Ap #650-3178 Magna Rd.','Tamaulipas','México','345709','México','05 06 70 58 26','05 87 80 40 17','ut.molestie@pulvinararcuet.co.uk',0),(168,'Mauris Sit Consulting','Oleg Mcdaniel','Gerente de Mercadotectia','P.O. Box 548, 2108 Fusce Rd.','Tlaxcala','México','249005','México','01 90 47 78 38','07 36 29 49 82','Mauris.vestibulum.neque@eu.net',0),(169,'Aliquam Adipiscing Inc.','Carson Alvarado','Gerente de Sistemas','P.O. Box 194, 6870 Mauris Avenue','Colima','México','4661HO','México','05 82 79 06 62','07 38 47 27 11','dis.parturient@nec.com',0),(170,'Dolor Quam LLC','Ciaran Curtis','Gerente de Sistemas','P.O. Box 128, 5423 Duis St.','Veracruz','México','G73 7MR','México','05 99 09 15 27','04 66 93 63 75','nonummy.Fusce.fermentum@ipsumnonarcu.co.uk',0),(171,'Congue In Limited','Vernon Lowery','Gerente de Mercadotectia','379-6875 Et, Ave','Yucatán','México','156325','México','08 58 01 77 87','01 29 10 46 01','iaculis.lacus@Aenean.com',0),(172,'Ac Consulting','Seth Odonnell','Gerente de Ventas','7300 Mauris Av.','Michoacán','México','22057','México','05 79 36 87 18','06 71 99 10 01','iaculis.enim.sit@turpis.edu',0),(173,'Nec Corporation','Bernard Jacobson','Gerente de Mercadotectia','1179 Convallis Rd.','Nayarit','México','485784','México','01 48 60 84 65','06 45 30 02 93','sagittis@dapibus.com',0),(174,'Ullamcorper Corp.','Cain Lamb','Gerente de Sistemas','P.O. Box 617, 6409 Aliquam Street','Jalisco','México','28737-208','México','01 30 39 52 30','01 93 31 75 40','elit.a.feugiat@tristiquesenectus.co.uk',0),(175,'Risus Morbi Metus PC','Logan Mcintosh','Gerente de Sistemas','3133 Quisque St.','Aguascalientes','México','4050','México','04 40 00 68 49','02 47 07 29 74','eu.ligula@sociisnatoquepenatibus.co.uk',0),(176,'Eget Dictum Corp.','Declan Workman','Gerente de Sistemas','857-6664 Aliquam St.','Nayarit','México','93380','México','08 40 73 73 86','01 67 43 66 76','metus.Vivamus@eleifend.edu',0),(177,'Sit LLP','Hall Pena','Gerente de Mercadotectia','Ap #358-8584 A St.','Potosí','México','55015','México','07 55 12 13 16','08 26 04 69 14','erat.in@etultricesposuere.edu',0),(178,'Velit Egestas Lacinia PC','Vincent Mays','Gerente de Mercadotectia','Ap #637-655 Vel St.','Durango','México','2042','México','04 97 49 83 34','09 73 63 00 05','Maecenas.mi@eueleifendnec.org',0),(179,'Ut Odio Vel Consulting','Damon Hinton','Gerente de Sistemas','7217 Purus Street','Yucatán','México','3843','México','09 86 59 98 87','03 43 19 14 49','a.scelerisque@Curabitur.edu',0),(180,'Scelerisque Lorem Ipsum Ltd','Vernon Young','Gerente de Ventas','Ap #452-1495 Parturient St.','Michoacán','México','38613','México','01 55 85 63 25','06 88 77 58 32','egestas.a@aclibero.ca',0),(181,'Ut Limited','Nash Estrada','Gerente de Ventas','P.O. Box 393, 8808 Risus. St.','Guanajuato','México','49976','México','06 60 06 47 17','09 00 47 18 64','congue@fringillaporttitor.com',0),(182,'Risus At Fringilla Associates','Vance Ratliff','Gerente de Mercadotectia','440-8695 Quis Rd.','Nayarit','México','8173','México','02 03 91 76 52','05 47 31 34 27','ultrices@Vestibulum.co.uk',0),(183,'Ante Corporation','Hayden Leach','Gerente de Ventas','557-6923 Sed Avenue','Zacatecas','México','65-240','México','02 30 69 18 00','08 52 99 33 02','montes.nascetur.ridiculus@nunc.edu',0),(184,'Tempor Augue Ac Corp.','Jameson Stewart','Gerente de Ventas','Ap #590-6482 Risus. Avenue','Aguascalientes','México','2496','México','09 45 90 25 50','07 31 18 63 45','pede@Sedcongue.org',0),(185,'Lacinia Orci Incorporated','Kieran Maddox','Gerente de Ventas','Ap #546-8023 Eros. Street','Baja','México','04310','México','05 06 74 62 35','09 05 36 40 11','eget@sapiencursusin.com',0),(186,'Dictum Ultricies Ligula LLC','Guy Humphrey','Gerente de Mercadotectia','4157 Feugiat Street','Oaxaca','México','31-083','México','06 35 79 63 83','04 60 70 18 77','Suspendisse.non@ametconsectetueradipiscing.net',0),(187,'Adipiscing Corporation','Gavin Rodriquez','Gerente de Sistemas','Ap #643-839 Ante Road','Nayarit','México','67489','México','01 04 96 43 61','02 68 56 03 08','gravida.mauris@ipsumnon.edu',0),(188,'Quisque Varius Nam LLC','Troy Meyers','Gerente de Ventas','P.O. Box 189, 8872 Hendrerit Avenue','Durango','México','E6S 1OC','México','06 07 64 10 42','06 19 12 21 97','Suspendisse@tellusid.org',0),(189,'Amet Corp.','Rahim Holman','Gerente de Mercadotectia','550-2922 Sed Rd.','Tamaulipas','México','45834','México','01 30 38 31 23','01 49 88 19 36','nisi.a.odio@feugiatLoremipsum.ca',0),(190,'Lorem Lorem LLC','Xander Hoffman','Gerente de Sistemas','410-9766 Tincidunt Street','California Sur','México','L5P 8W3','México','03 33 29 01 39','03 88 47 04 66','sem@imperdietullamcorperDuis.com',0),(191,'At Pretium Aliquet LLP','Dustin Kinney','Gerente de Ventas','937-4187 Id, Ave','Estado de México','México','8136','México','01 01 38 59 94','07 86 69 00 25','lectus.ante.dictum@rutrummagna.co.uk',0),(192,'Aliquam Consulting','Marvin Steele','Gerente de Ventas','4370 Id Rd.','Campeche','México','88239','México','08 35 29 52 37','09 85 24 58 08','rhoncus@malesuadaaugueut.edu',0),(193,'Sit Amet Dapibus Limited','Gage Rogers','Gerente de Sistemas','Ap #823-4512 Quam Avenue','Quintana Roo','México','79791','México','03 55 89 61 51','04 16 30 63 17','felis@pretium.net',0),(194,'Nulla Interdum Curabitur Company','Fritz Grant','Gerente de Ventas','P.O. Box 895, 2541 Nunc Av.','California','México','03797','México','05 92 42 29 63','04 00 45 59 22','egestas.Fusce.aliquet@Sed.com',0),(195,'Semper Dui Lectus Associates','Griffith Thompson','Gerente de Ventas','Ap #512-6625 Donec Rd.','Zacatecas','México','8122','México','06 35 48 63 10','09 67 00 06 16','luctus.et@ipsumporta.co.uk',0),(196,'Commodo Tincidunt Corporation','Amal Roach','Gerente de Mercadotectia','P.O. Box 972, 168 Integer St.','Distrito Federal','México','2659NZ','México','05 04 74 48 44','06 98 87 87 39','sem@Aeneangravidanunc.com',0),(197,'Elit Company','Arthur Holt','Gerente de Sistemas','P.O. Box 871, 6924 Aliquam St.','Colima','México','M5P 3K5','México','04 29 49 37 32','04 88 84 22 33','hendrerit.neque.In@eratnequenon.co.uk',0),(198,'Ut Molestie In LLC','Guy Kane','Gerente de Ventas','P.O. Box 812, 7384 Metus Rd.','Yucatán','México','20419','México','05 55 94 77 59','04 10 11 26 20','tellus.justo.sit@tempor.org',0),(199,'At Velit Pellentesque Corporation','Amery Dunlap','Gerente de Ventas','Ap #168-3551 Duis Av.','Aguascalientes','México','6850','México','07 50 50 59 71','01 66 97 48 79','velit@fermentumrisusat.co.uk',0),(200,'Nec Ltd','Neville Quinn','Gerente de Ventas','683 Nisl. St.','Michoacán','México','521223','México','03 41 39 99 45','02 22 03 19 07','sit.amet@lectusNullamsuscipit.co.uk',0);
/*!40000 ALTER TABLE `t_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_compras`
--

DROP TABLE IF EXISTS `t_compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_compras` (
  `idCompra` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `idCliente` mediumint(9) DEFAULT NULL,
  `fechaPedido` varchar(255) DEFAULT NULL,
  `fechaEntrega` varchar(255) DEFAULT NULL,
  `fechaEnvio` varchar(255) DEFAULT NULL,
  `fechaPago` varchar(255) DEFAULT NULL,
  `formaDeEnvio` varchar(255) DEFAULT NULL,
  `destinatario` varchar(255) DEFAULT NULL,
  `direccionDestinatario` varchar(255) DEFAULT NULL,
  `ciudadDestinatario` varchar(255) DEFAULT NULL,
  `regionDestinatario` varchar(50) DEFAULT NULL,
  `codigoPostalDestinatario` varchar(10) DEFAULT NULL,
  `paisDestinatario` varchar(100) DEFAULT NULL,
  `telefonoDestinatario` varchar(100) DEFAULT NULL,
  `faxDestinatario` varchar(100) DEFAULT NULL,
  `mailDeContacto` varchar(255) DEFAULT NULL,
  `subtotal` varchar(255) DEFAULT NULL,
  `iva` varchar(255) DEFAULT NULL,
  `monto` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idCompra`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_compras`
--

LOCK TABLES `t_compras` WRITE;
/*!40000 ALTER TABLE `t_compras` DISABLE KEYS */;
INSERT INTO `t_compras` VALUES (1,0,'21/03/2016','21/03/2016','21/03/2016','21/03/2016','A domicilio','American Eagle','a','a','a','a','a','a','a','a','3000','480','3480'),(2,0,'22/03/2016','22/03/2016','22/03/2016','22/03/2016','En mostrador','American Eagle','a','a','a','a','a','a','a','a','12000','1920','13920');
/*!40000 ALTER TABLE `t_compras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_detallecompra`
--

DROP TABLE IF EXISTS `t_detallecompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_detallecompra` (
  `idCompra` mediumint(9) NOT NULL,
  `idProducto` mediumint(9) NOT NULL,
  `cantidad` mediumint(9) DEFAULT NULL,
  `total` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idCompra`,`idProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_detallecompra`
--

LOCK TABLES `t_detallecompra` WRITE;
/*!40000 ALTER TABLE `t_detallecompra` DISABLE KEYS */;
INSERT INTO `t_detallecompra` VALUES (1,1,3,'3000'),(2,1,12,'12000');
/*!40000 ALTER TABLE `t_detallecompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_detalleventa`
--

DROP TABLE IF EXISTS `t_detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_detalleventa` (
  `idVenta` mediumint(9) NOT NULL,
  `idProducto` mediumint(9) NOT NULL,
  `cantidad` mediumint(9) DEFAULT NULL,
  `total` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idVenta`,`idProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_detalleventa`
--

LOCK TABLES `t_detalleventa` WRITE;
/*!40000 ALTER TABLE `t_detalleventa` DISABLE KEYS */;
INSERT INTO `t_detalleventa` VALUES (1,2,1,'1000'),(2,4,1,'1000'),(3,2,1,'1000'),(4,1,2,'2000'),(5,2,2,'2000'),(6,2,6,'6000');
/*!40000 ALTER TABLE `t_detalleventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_producto`
--

DROP TABLE IF EXISTS `t_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_producto` (
  `idProducto` mediumint(8) NOT NULL AUTO_INCREMENT,
  `codigoDelProducto` varchar(255) DEFAULT NULL,
  `descripcion` text,
  `precio` float DEFAULT NULL,
  `existencia` mediumint(9) DEFAULT NULL,
  `fechaCaducidad` varchar(255) DEFAULT NULL,
  `lote` varchar(255) DEFAULT NULL,
  `borrado` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`idProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_producto`
--

LOCK TABLES `t_producto` WRITE;
/*!40000 ALTER TABLE `t_producto` DISABLE KEYS */;
INSERT INTO `t_producto` VALUES (1,'Codigo 1','Descripcion 1',1000,42,'21/03/2016','lote1',0),(2,'Codigo 2','Descripcion 2',1000,39,'21/03/2016','lote2',0),(3,'Codigo 3','Descripcion 3',1000,50,'21/03/2016','lote3',0),(4,'Codigo 4','Descripcion 4',1000,49,'21/03/2016','lote4',0),(5,'Codigo 5','Descripcion 5',1000,50,'21/03/2016','lote5',0),(6,'Codigo 6','Descripcion 6',1000,50,'21/03/2016','lote6',0),(7,'Codigo 7','Descripcion 7',1000,50,'21/03/2016','lote7',0),(8,'Codigo 8','Descripcion 8',1000,50,'21/03/2016','lote8',0),(9,'Codigo 9','Descripcion 9',1000,50,'21/03/2016','lote9',0),(10,'Codigo 10','Descripcion 10',1000,50,'21/03/2016','lote10',0),(11,'Codigo 11','Descripcion 11',1000,50,'21/03/2016','lote11',0),(12,'Codigo 12','Descripcion 12',1000,50,'21/03/2016','lote12',0),(13,'Codigo 13','Descripcion 13',1000,50,'21/03/2016','lote13',0),(14,'Codigo 14','Descripcion 14',1000,50,'21/03/2016','lote14',0),(15,'Codigo 15','Descripcion 15',1000,50,'21/03/2016','lote15',0),(16,'Codigo 16','Descripcion 16',1000,50,'21/03/2016','lote16',0),(17,'Codigo 17','Descripcion 17',1000,50,'21/03/2016','lote17',0),(18,'Codigo 18','Descripcion 18',1000,50,'21/03/2016','lote18',0),(19,'Codigo 19','Descripcion 19',1000,50,'21/03/2016','lote19',0),(20,'Codigo 20','Descripcion 20',1000,50,'21/03/2016','lote20',0);
/*!40000 ALTER TABLE `t_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_proveedor`
--

DROP TABLE IF EXISTS `t_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_proveedor` (
  `idProveedor` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `nombreProveedor` varchar(255) DEFAULT NULL,
  `nombreContacto` varchar(255) DEFAULT NULL,
  `cargoContacto` varchar(255) DEFAULT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `ciudad` varchar(255) DEFAULT NULL,
  `mail` varchar(255) DEFAULT NULL,
  `region` varchar(50) DEFAULT NULL,
  `codigoPostal` varchar(10) DEFAULT NULL,
  `pais` varchar(100) DEFAULT NULL,
  `telefono` varchar(100) DEFAULT NULL,
  `fax` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_proveedor`
--

LOCK TABLES `t_proveedor` WRITE;
/*!40000 ALTER TABLE `t_proveedor` DISABLE KEYS */;
INSERT INTO `t_proveedor` VALUES (1,'Consectetuer Mauris Limited','India Paul','Gerente de Mercadotecnia','910-4923 Pede. Av.','Nayarit','consectetuer.mauris.id@nuncQuisque.ca','México','521666','México','09 65 72 85 86','03 44 94 35 91'),(2,'Enim Consulting','Zeus Parks','Gerente de Ventas','Ap #983-217 Semper Rd.','Puebla','Vivamus@Vivamusrhoncus.org','México','254857','México','06 22 33 87 78','08 58 00 91 85'),(3,'Leo Cras Ltd','Barbara W. Chaney','Gerente de Mercadotecnia','P.O. Box 675, 984 Leo. St.','Jalisco','orci.lacus.vestibulum@metusInnec.ca','México','014552','México','06 36 26 19 69','02 63 91 89 33'),(4,'Donec Tempor Incorporated','Zenaida G. Bird','Gerente de Sistemas','253-4389 Elit, Rd.','Coahuila','massa.Vestibulum.accumsan@acmattis.co.uk','México','343649','México','05 16 58 50 95','02 52 32 66 12'),(5,'Mauris PC','Francesca M. Thompson','Gerente de Mercadotecnia','8393 Neque. Street','Estado de México','dolor@elementum.ca','México','878491','México','04 76 69 25 50','04 08 76 68 64'),(6,'Vitae Mauris Sit Company','Nelle Waters','Gerente de Sistemas','Ap #974-9008 Eget, Street','Guerrero','interdum.Curabitur.dictum@musProin.net','México','487041','México','02 23 51 48 02','01 28 30 17 56'),(7,'Nonummy Ipsum Industries','Dakota Ray','Gerente de Sistemas','Ap #445-6251 Neque Av.','Tabasco','ullamcorper.Duis.at@ataugue.edu','México','515744','México','02 04 90 86 30','06 89 71 72 43'),(8,'Cum Institute','Herrod Mueller','Gerente de Mercadotecnia','636-5545 Eleifend, Rd.','Durango','eu@eratvitae.edu','México','091524','México','03 59 69 30 48','01 94 05 49 39'),(9,'Vitae Inc.','Dustin Vega','Gerente de Ventas','9500 Vestibulum St.','Distrito Federal','Donec.est@justoPraesentluctus.org','México','258548','México','06 78 13 53 74','07 45 26 44 17'),(10,'Nulla Company','Laura J. Hendricks','Gerente de Mercadotecnia','9013 Magnis Avenue','Yucatán','accumsan.laoreet@purusgravidasagittis.ca','México','481942','México','03 12 95 27 95','02 41 50 85 89');
/*!40000 ALTER TABLE `t_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_ventas`
--

DROP TABLE IF EXISTS `t_ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_ventas` (
  `idVenta` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `idCliente` mediumint(9) DEFAULT NULL,
  `fechaPedido` varchar(255) DEFAULT NULL,
  `fechaEntrega` varchar(255) DEFAULT NULL,
  `fechaEnvio` varchar(255) DEFAULT NULL,
  `fechaPago` varchar(255) DEFAULT NULL,
  `formaDeEnvio` varchar(255) DEFAULT NULL,
  `destinatario` varchar(255) DEFAULT NULL,
  `direccionDestinatario` varchar(255) DEFAULT NULL,
  `ciudadDestinatario` varchar(255) DEFAULT NULL,
  `regionDestinatario` varchar(50) DEFAULT NULL,
  `codigoPostalDestinatario` varchar(10) DEFAULT NULL,
  `paisDestinatario` varchar(100) DEFAULT NULL,
  `telefonoDestinatario` varchar(100) DEFAULT NULL,
  `faxDestinatario` varchar(100) DEFAULT NULL,
  `mailDeContacto` varchar(255) DEFAULT NULL,
  `subtotal` varchar(255) DEFAULT NULL,
  `iva` varchar(255) DEFAULT NULL,
  `monto` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idVenta`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_ventas`
--

LOCK TABLES `t_ventas` WRITE;
/*!40000 ALTER TABLE `t_ventas` DISABLE KEYS */;
INSERT INTO `t_ventas` VALUES (1,2,'22/03/2016','22/03/2016','22/03/2016','22/03/2016','En mostrador','Orci Quis Limited','Ap #406-3082 Ac Rd.','León','México','71083','México','05 11 20 16 65','01 89 63 40 24','malesuada.augue.ut@elit.org','1000','160','1160'),(2,7,'22/03/2016','22/03/2016','22/03/2016','22/03/2016','En mostrador','Tristique Pharetra Associates','P.O. Box 991, 1650 Cursus. Avenue','San Luis','México','87701','México','05 66 72 32 37','09 25 20 12 71','diam@Nam.org','1000','160','1160'),(3,2,'22/03/2016','22/03/2016','22/03/2016','22/03/2016','En mostrador','Orci Quis Limited','Ap #406-3082 Ac Rd.','León','México','71083','México','05 11 20 16 65','01 89 63 40 24','malesuada.augue.ut@elit.org','1000','160','1160'),(4,1,'22/03/2016','22/03/2016','22/03/2016','22/03/2016','A domicilio','Dapibus Quam Quis Consulting','1361 Nullam Avenue','Guanajuato','México','15765','México','03 08 00 74 40','02 92 97 49 36','laoreet@ipsum.ca','2000','320','2320'),(5,13,'22/03/2016','22/03/2016','22/03/2016','22/03/2016','A domicilio','In Tempus Eu Associates','P.O. Box 452, 3216 Euismod Street','Distrito Federal','México','48644','México','03 53 12 74 47','08 83 96 15 90','vestibulum.nec@antedictumcursus.net','2000','320','2320'),(6,75,'22/03/2016','22/03/2016','22/03/2016','22/03/2016','En mostrador','Aliquam Consulting','P.O. Box 665, 4245 Lorem, Road','Distrito Federal','México','24373','México','02 39 21 21 18','05 46 70 03 10','gravida.mauris@dui.com','6000','960','6960');
/*!40000 ALTER TABLE `t_ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_ciudadesmayorescompras`
--

DROP TABLE IF EXISTS `v_ciudadesmayorescompras`;
/*!50001 DROP VIEW IF EXISTS `v_ciudadesmayorescompras`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_ciudadesmayorescompras` AS SELECT 
 1 AS `ciudad`,
 1 AS `Compras_por_ciudad`,
 1 AS `montoTotal`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_clientesfrecuentes`
--

DROP TABLE IF EXISTS `v_clientesfrecuentes`;
/*!50001 DROP VIEW IF EXISTS `v_clientesfrecuentes`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_clientesfrecuentes` AS SELECT 
 1 AS `idCliente`,
 1 AS `nombreCompania`,
 1 AS `ciudad`,
 1 AS `comprasRealizadas`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_clientesmayorescompras`
--

DROP TABLE IF EXISTS `v_clientesmayorescompras`;
/*!50001 DROP VIEW IF EXISTS `v_clientesmayorescompras`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_clientesmayorescompras` AS SELECT 
 1 AS `idCliente`,
 1 AS `nombreCompania`,
 1 AS `ciudad`,
 1 AS `montoTotal`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_clientesporciudad`
--

DROP TABLE IF EXISTS `v_clientesporciudad`;
/*!50001 DROP VIEW IF EXISTS `v_clientesporciudad`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_clientesporciudad` AS SELECT 
 1 AS `ciudad`,
 1 AS `cantidadDeClientes`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_productosmasvendidos`
--

DROP TABLE IF EXISTS `v_productosmasvendidos`;
/*!50001 DROP VIEW IF EXISTS `v_productosmasvendidos`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_productosmasvendidos` AS SELECT 
 1 AS `idProducto`,
 1 AS `codigoDelProducto`,
 1 AS `descripcion`,
 1 AS `existencia`,
 1 AS `cantidadVendidos`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `v_ciudadesmayorescompras`
--

/*!50001 DROP VIEW IF EXISTS `v_ciudadesmayorescompras`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_ciudadesmayorescompras` AS (select `t_cliente`.`ciudad` AS `ciudad`,(select count(0) from `t_ventas` where (`t_ventas`.`ciudadDestinatario` = `t_cliente`.`ciudad`)) AS `Compras_por_ciudad`,(select sum(`t_ventas`.`monto`) from `t_ventas` where (`t_ventas`.`ciudadDestinatario` = `t_cliente`.`ciudad`)) AS `montoTotal` from (`t_ventas` join `t_cliente` on((`t_cliente`.`idCliente` = `t_ventas`.`idCliente`))) group by `t_cliente`.`ciudad` order by (select count(0) from `t_ventas` where (`t_ventas`.`ciudadDestinatario` = `t_cliente`.`ciudad`)) desc) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_clientesfrecuentes`
--

/*!50001 DROP VIEW IF EXISTS `v_clientesfrecuentes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_clientesfrecuentes` AS (select `t_cliente`.`idCliente` AS `idCliente`,`t_cliente`.`nombreCompania` AS `nombreCompania`,`t_cliente`.`ciudad` AS `ciudad`,(select count(0) from `t_ventas` where (`t_ventas`.`idCliente` = `t_cliente`.`idCliente`)) AS `comprasRealizadas` from (`t_ventas` join `t_cliente` on((`t_cliente`.`idCliente` = `t_ventas`.`idCliente`))) group by `t_cliente`.`idCliente` order by (select count(0) from `t_ventas` where (`t_ventas`.`idCliente` = `t_cliente`.`idCliente`)) desc) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_clientesmayorescompras`
--

/*!50001 DROP VIEW IF EXISTS `v_clientesmayorescompras`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_clientesmayorescompras` AS (select `t_cliente`.`idCliente` AS `idCliente`,`t_cliente`.`nombreCompania` AS `nombreCompania`,`t_cliente`.`ciudad` AS `ciudad`,(select sum(`t_ventas`.`monto`) from `t_ventas` where (`t_ventas`.`idCliente` = `t_cliente`.`idCliente`)) AS `montoTotal` from (`t_ventas` join `t_cliente` on((`t_cliente`.`idCliente` = `t_ventas`.`idCliente`))) group by `t_cliente`.`idCliente` order by (select sum(`t_ventas`.`monto`) from `t_ventas` where (`t_ventas`.`idCliente` = `t_cliente`.`idCliente`)) desc) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_clientesporciudad`
--

/*!50001 DROP VIEW IF EXISTS `v_clientesporciudad`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_clientesporciudad` AS (select `v_ciudadesmayorescompras`.`ciudad` AS `ciudad`,(select count(0) from `t_cliente` where (`t_cliente`.`ciudad` = `v_ciudadesmayorescompras`.`ciudad`)) AS `cantidadDeClientes` from `v_ciudadesmayorescompras`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_productosmasvendidos`
--

/*!50001 DROP VIEW IF EXISTS `v_productosmasvendidos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_productosmasvendidos` AS (select `t_producto`.`idProducto` AS `idProducto`,`t_producto`.`codigoDelProducto` AS `codigoDelProducto`,`t_producto`.`descripcion` AS `descripcion`,`t_producto`.`existencia` AS `existencia`,(select sum(`t_detalleventa`.`cantidad`) from `t_detalleventa` where (`t_producto`.`idProducto` = `t_detalleventa`.`idProducto`)) AS `cantidadVendidos` from (`t_detalleventa` join `t_producto`) where (`t_producto`.`idProducto` = `t_detalleventa`.`idProducto`) group by `t_producto`.`idProducto` order by (select sum(`t_detalleventa`.`cantidad`) from `t_detalleventa` where (`t_producto`.`idProducto` = `t_detalleventa`.`idProducto`)) desc) */;
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

-- Dump completed on 2016-03-22 18:02:15
