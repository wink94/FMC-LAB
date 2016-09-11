CREATE TABLE `lab_test` (
  `labTestID` varchar(10) NOT NULL,
  `labTestName` varchar(45) NOT NULL,
  `labTestPrice` double NOT NULL,
  PRIMARY KEY (`labTestID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


insert into lab_test values("LT001","Blood Sugar",200);

insert into lab_test values("LT002","Blood Cell Count",600);

insert into lab_test values("LT003","Cholesterol Test",500);
insert into lab_test values("LT004","CT Scan",400);
insert into lab_test values("LT005","MRI Scan",3000);
insert into lab_test values("LT006","X-RAY",1000);
insert into lab_test values("LT007","Platelet Count",800)
