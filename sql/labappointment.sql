CREATE TABLE `lab_appointment` (
  `labAppointmentID` int(7) NOT NULL AUTO_INCREMENT,
  `labAppointmentDate` date NOT NULL,
  `labPatientID` int(10) DEFAULT NULL,
  PRIMARY KEY (`labAppointmentID`),
  KEY `fK_LA_LP` (`labPatientID`),
  CONSTRAINT `fK_LA_LP` FOREIGN KEY (`labPatientID`) REFERENCES `lab_patient` (`labPatientID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1000018 DEFAULT CHARSET=utf8;



