CREATE TABLE `lab_patient` (
  `labPatientID` int(10) NOT NULL AUTO_INCREMENT,
  `labPatientName` varchar(45) NOT NULL,
  `labPatientAge` int(11) NOT NULL,
  `labPatientGender` varchar(10) NOT NULL,
  `labPatientEmail` varchar(45) NOT NULL,
  `labPatientPhone` varchar(10) NOT NULL,
  PRIMARY KEY (`labPatientID`),
  UNIQUE KEY `labPatientEmail_UNIQUE` (`labPatientEmail`),
  UNIQUE KEY `labPatientPhone_UNIQUE` (`labPatientPhone`)
) ENGINE=InnoDB AUTO_INCREMENT=1000000022 DEFAULT CHARSET=utf8;




