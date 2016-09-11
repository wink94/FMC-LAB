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
