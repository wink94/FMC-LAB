CREATE TABLE `lab_payment` (
`labPaymentID` int(11) NOT NULL AUTO_INCREMENT,
  `labPatientID` int(10) NOT NULL,
  
  `labPaymentStatus` tinyint(1) NOT NULL DEFAULT '0',
 `PatientType` varchar(10) not null,
 `PatientAmount` double not null,
 
  PRIMARY KEY (`labPaymentID`),
  

  
  CONSTRAINT `fK_LPmnt_LP` FOREIGN KEY (`labPatientID`) REFERENCES `lab_patient` (`labPatientID`) ON DELETE CASCADE ON UPDATE CASCADE
  

  
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

INSERT INTO lab_payment(labPatientID,labPaymentStatus,PatientType,PatientAmount) VALUES();

