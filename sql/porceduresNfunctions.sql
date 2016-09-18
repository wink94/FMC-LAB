DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `check_email_exist`(in email varchar(45) )
begin
	
	select count(labPatientEmail) into @val from lab_patient where labPatientEmail = email;
    select @val;
end$$
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `check_phone_exist`(in phone varchar(10) )
begin
	
	select count(labPatientPhone) into @val from lab_patient where labPatientPhone = phone;
    select @val;
end$$
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `lab_check_labTestStausAndUpdate`(in PID int(10),in TestID varchar(10))
begin
	declare val int;
	select labTestNo into val   from lab_test_result where labPatientID = PID and labTestID = TestID and labAppointmentStatus =false ;
    
    if val is not null 
		then 
        
        update   lab_test_result set labAppointmentStatus = true where labTestNo = val;
        
	end if;
    
end$$
DELIMITER ;
