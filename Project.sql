--table creation file

CREATE TABLE Client (
    clientNo NUMBER PRIMARY KEY
);

CREATE TABLE Delegate (
    delegateNo NUMBER PRIMARY KEY,
    delegateTitle VARCHAR2(50),
    delegateFName VARCHAR2(50),
    delegateLName VARCHAR2(50),
    delegateStreet VARCHAR2(50),
    delegateCity VARCHAR2(50),
    delegateState VARCHAR2(50),
    delegateZipCode VARCHAR2(10),
    attTelNo VARCHAR2(20),
    attFaxNo VARCHAR2(20),
    attEmailAddress VARCHAR2(50),
    clientNo NUMBER,
    FOREIGN KEY (clientNo) REFERENCES Client(clientNo)
);

CREATE TABLE Employee (
    employeeNo NUMBER PRIMARY KEY
);

CREATE TABLE Location (
    locationNo NUMBER PRIMARY KEY,
    locationName VARCHAR2(100),
    maxSize NUMBER
);

CREATE TABLE CourseType (
    courseTypeNo NUMBER PRIMARY KEY,
    courseTypeDescription VARCHAR2(100)
);

CREATE TABLE Course (
    courseNo NUMBER PRIMARY KEY,
    courseName VARCHAR2(100),
    courseDescription VARCHAR2(500),
    startDate DATE,
    startTime TIMESTAMP,
    endDate DATE,
    endTime TIMESTAMP,
    maxDelegates NUMBER,
    confirmed CHAR(1),
    delivererEmployeeNo NUMBER,
    courseTypeNo NUMBER,
    FOREIGN KEY (delivererEmployeeNo) REFERENCES Employee(employeeNo),
    FOREIGN KEY (courseTypeNo) REFERENCES CourseType(courseTypeNo)
);

CREATE TABLE CourseFee (
    courseFeeNo NUMBER PRIMARY KEY,
    feeDescription VARCHAR2(100),
    fee NUMBER,
    courseNo NUMBER,
    FOREIGN KEY (courseNo) REFERENCES Course(courseNo)
);

CREATE TABLE Booking (
    bookingNo NUMBER PRIMARY KEY,
    bookingDate DATE,
    locationNo NUMBER,
    courseNo NUMBER,
    bookingEmployeeNo NUMBER,
    FOREIGN KEY (locationNo) REFERENCES Location(locationNo),
    FOREIGN KEY (courseNo) REFERENCES Course(courseNo),
    FOREIGN KEY (bookingEmployeeNo) REFERENCES Employee(employeeNo)
);
CREATE TABLE PaymentMethod (
    pMethodNo NUMBER PRIMARY KEY
);
CREATE TABLE PaymentMethod (
    pMethodNo NUMBER PRIMARY KEY
);

CREATE TABLE Registration (
    registrationNo NUMBER PRIMARY KEY,
    registrationDate DATE,
    delegateNo NUMBER,
    courseFeeNo NUMBER,
    registerEmployeeNo NUMBER,
    courseNo NUMBER,
    FOREIGN KEY (delegateNo) REFERENCES Delegate(delegateNo),
    FOREIGN KEY (courseFeeNo) REFERENCES CourseFee(courseFeeNo),
    FOREIGN KEY (registerEmployeeNo) REFERENCES Employee(employeeNo),
    FOREIGN KEY (courseNo) REFERENCES Course(courseNo)
);

CREATE TABLE Invoice (
    invoiceNo NUMBER PRIMARY KEY,
    dateRaised DATE,
    datePaid DATE,
    creditCardNo VARCHAR2(20),
    holdersName VARCHAR2(100),
    expiryDate DATE,
    registrationNo NUMBER,
    pMethodNo NUMBER,
    FOREIGN KEY (registrationNo) REFERENCES Registration(registrationNo),
    FOREIGN KEY (pMethodNo) REFERENCES PaymentMethod(pMethodNo)
);

CREATE TABLE LogTable (
    logId NUMBER PRIMARY KEY,
    logDate TIMESTAMP,
    tableName VARCHAR2(100),
    operation VARCHAR2(100)
);