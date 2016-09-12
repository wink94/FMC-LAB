CREATE TABLE `lab_test_result` (
  `labPatientID` int(10) NOT NULL,
  `labTestID` varchar(10) NOT NULL,
  `labAppointmentStatus` tinyint(1) NOT NULL DEFAULT '0',
  `labTestNo` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`labTestNo`),
  KEY `fK_LTR_LP` (`labPatientID`),
  KEY `fK_LTR_LT` (`labTestID`),
  CONSTRAINT `fK_LTR_LP` FOREIGN KEY (`labPatientID`) REFERENCES `lab_patient` (`labPatientID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fK_LTR_LT` FOREIGN KEY (`labTestID`) REFERENCES `lab_test` (`labTestID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;





