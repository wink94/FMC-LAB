create table lab_blood_test (

Num int auto_increment,
PatientID int(10) ,
Sugar int default null,
blood_cell_count_WBC int default null,
blood_cell_count_RBC int default null,
platelet_count int default null,
primary key(Num),
CONSTRAINT `fK_LBT_LP` FOREIGN KEY (`PatientID`) REFERENCES `lab_patient` (`labPatientID`) ON DELETE CASCADE ON UPDATE CASCADE
);


CREATE TABLE `lab_lipid_profile_test` (
  `Num` int(11) NOT NULL AUTO_INCREMENT,
  `PatientID` int(10) NOT NULL,
  `HDL` double DEFAULT NULL,
  `LDL` double DEFAULT NULL,
  `serum_cholesterol` double DEFAULT NULL,
  PRIMARY KEY (`Num`),
  KEY `fK_LPT_LP` (`PatientID`),
  CONSTRAINT `fK_LPT_LP` FOREIGN KEY (`PatientID`) REFERENCES `lab_patient` (`labPatientID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
create table scans (

Num int auto_increment,
PatientID int(10) unique,
MRI boolean,
CT boolean,
XRAY boolean,
primary key(Num)
);

insert into scans values(null,1234567890,true,false,true)