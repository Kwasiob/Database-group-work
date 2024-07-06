-- data population file
INSERT INTO PaymentMethod (pMethodNo) VALUES (1);
INSERT INTO PaymentMethod (pMethodNo) VALUES (2);
INSERT INTO PaymentMethod (pMethodNo) VALUES (3);

SELECT * FROM PaymentMethod


-- Sample INSERT statements for Registration table
INSERT INTO Registration (registrationNo, registrationDate, delegateNo, courseFeeNo, registerEmployeeNo, courseNo)
VALUES (1, TO_DATE('2024-07-01', 'YYYY-MM-DD'), 1, 1, 1, 1);

INSERT INTO Registration (registrationNo, registrationDate, delegateNo, courseFeeNo, registerEmployeeNo, courseNo)
VALUES (2, TO_DATE('2024-07-02', 'YYYY-MM-DD'), 2, 2, 2, 2);

-- Ensure delegateNo, courseFeeNo, registerEmployeeNo, courseNo exist in their respective tables

-- Sample INSERT statements for Delegate table
INSERT INTO Delegate (delegateNo, delegateTitle, delegateFName, delegateLName, delegateStreet, delegateCity, delegateState, delegateZipCode, attTelNo, attFaxNo, attEmailAddress, clientNo)
VALUES (1, 'Mr', 'John', 'Doe', '123 Main St', 'Anytown', 'AnyState', '12345', '555-123-4567', '555-987-6543', 'john.doe@example.com', 1);

INSERT INTO Delegate (delegateNo, delegateTitle, delegateFName, delegateLName, delegateStreet, delegateCity, delegateState, delegateZipCode, attTelNo, attFaxNo, attEmailAddress, clientNo)
VALUES (2, 'Ms', 'Jane', 'Smith', '456 Elm St', 'Othertown', 'OtherState', '54321', '555-987-6543', '555-123-4567', 'jane.smith@example.com', 2);

-- Add more INSERT statements as needed
-- Sample INSERT statements for Employee table
INSERT INTO Employee (employeeNo) VALUES (1);
INSERT INTO Employee (employeeNo) VALUES (2);
-- Add more INSERT statements as needed
-- Sample INSERT statements for Course table
INSERT INTO Course (courseNo, courseName, courseDescription, startDate, startTime, endDate, endTime, maxDelegates, confirmed, delivererEmployeeNo, courseTypeNo)
VALUES (1, 'Introduction to SQL', 'Basic SQL concepts and queries', TO_DATE('2024-08-01', 'YYYY-MM-DD'), TIMESTAMP '2024-08-01 09:00:00', TO_DATE('2024-08-03', 'YYYY-MM-DD'), TIMESTAMP '2024-08-03 17:00:00', 20, 'Y', 1, 1);

INSERT INTO Course (courseNo, courseName, courseDescription, startDate, startTime, endDate, endTime, maxDelegates, confirmed, delivererEmployeeNo, courseTypeNo)
VALUES (2, 'Advanced Java Programming', 'Advanced Java concepts and practices', TO_DATE('2024-08-05', 'YYYY-MM-DD'), TIMESTAMP '2024-08-05 10:00:00', TO_DATE('2024-08-07', 'YYYY-MM-DD'), TIMESTAMP '2024-08-07 18:00:00', 15, 'Y', 2, 2);

-- Add more INSERT statements as needed
-- Sample INSERT statements for CourseFee table
INSERT INTO CourseFee (courseFeeNo, feeDescription, fee, courseNo)
VALUES (1, 'Standard Fee', 500, 1);

INSERT INTO CourseFee (courseFeeNo, feeDescription, fee, courseNo)
VALUES (2, 'Advanced Fee', 700, 2);

-- Add more INSERT statements as needed

-- Sample INSERT statements for Client table
INSERT INTO Client (clientNo) VALUES (1);
INSERT INTO Client (clientNo) VALUES (2);
INSERT INTO Client (clientNo) VALUES (3);
-- Add more INSERT statements as needed

INSERT INTO CourseType (courseTypeNo, courseTypeDescription)
VALUES
  (1, 'Programming Languages')


INSERT INTO CourseType (courseTypeNo, courseTypeDescription)
VALUES
  (3, 'Networking Fundamentals')
  (4, 'Web Development'),
  (5, 'Software Engineering');


SELECT * FROM Invoice

INSERT INTO Invoice (invoiceNo,dateRaised, creditCardNo, holdersName, expiryDate, registrationNo, pMethodNo)
VALUES (1, SYSDATE, '1234567890123456', 'John Doe', TO_DATE('2024-12-31', 'YYYY-MM-DD'), 1, 1);

