DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `lab_check_labTestStausAndUpdate`(in PID int,in LabTestID varchar(10))
begin
	
	select labTestNo into @val  from lab_test_result where labPatientID = PID and labTestID = LabTestID and labAppointmentStatus =false;
    
    if @val is not null 
		then update   lab_test_result set labAppointmentStatus = true where labTestNo = val;
    
end$$
DELIMITER ;