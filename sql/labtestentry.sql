create table lab_blood_test (

Num int auto_increment,
PatientID int(10) unique,
Sugar int,
blood_cell_count_WBC int,
blood_cell_count_RBC int,
platelet_count int,
primary key(Num)
);


create table lipid_profile_test (

Num int auto_increment,
PatientID int(10) unique,
HDL double,
LDL double,
serum_cholesterol double,
primary key(Num)
);

create table scans (

Num int auto_increment,
PatientID int(10) unique,
MRI boolean,
CT boolean,
XRAY boolean,
primary key(Num)
);

insert into scans values(null,1234567890,true,false,true)