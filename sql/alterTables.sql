





alter table lab_appointment add constraint fK_LA_LP foreign key(labPatientID)  references lab_patient(labPatientID)
  on delete cascade on update cascade;



alter table lab_test_result add constraint fK_LTR_LP foreign key(labPatientID)  references lab_patient(labPatientID)
 on delete cascade on update cascade;

alter table lab_test_result add constraint fK_LTR_LT foreign key(labTestID)  references lab_test(labTestID)
on delete cascade on update cascade;