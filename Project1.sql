-- Stored procedure file

-- Stored Procedure to Insert an Invoice
CREATE OR REPLACE PROCEDURE insert_invoice(
    p_invoiceNo IN NUMBER,
    p_dateRaised IN DATE,
    p_datePaid IN DATE,
    p_creditCardNo IN VARCHAR2,
    p_holdersName IN VARCHAR2,
    p_expiryDate IN DATE,
    p_registrationNo IN NUMBER,
    p_pMethodNo IN NUMBER
) AS
BEGIN
    INSERT INTO Invoice(invoiceNo, dateRaised, datePaid, creditCardNo, holdersName, expiryDate, registrationNo, pMethodNo)
    VALUES (p_invoiceNo, p_dateRaised, p_datePaid, p_creditCardNo, p_holdersName, p_expiryDate, p_registrationNo, p_pMethodNo);
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'An error occurred: ' || SQLERRM);
END;
/

-- Stored Procedure to Update an Invoice
CREATE OR REPLACE PROCEDURE update_invoice(
    p_invoiceNo IN NUMBER,
    p_dateRaised IN DATE,
    p_datePaid IN DATE,
    p_creditCardNo IN VARCHAR2,
    p_holdersName IN VARCHAR2,
    p_expiryDate IN DATE,
    p_registrationNo IN NUMBER,
    p_pMethodNo IN NUMBER
) AS
BEGIN
    UPDATE Invoice
    SET dateRaised = p_dateRaised,
        datePaid = p_datePaid,
        creditCardNo = p_creditCardNo,
        holdersName = p_holdersName,
        expiryDate = p_expiryDate,
        registrationNo = p_registrationNo,
        pMethodNo = p_pMethodNo
    WHERE invoiceNo = p_invoiceNo;
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20002, 'An error occurred: ' || SQLERRM);
END;
/

-- Stored Procedure to Delete an Invoice
CREATE OR REPLACE PROCEDURE delete_invoice(
    p_invoiceNo IN NUMBER
) AS
BEGIN
    DELETE FROM Invoice
    WHERE invoiceNo = p_invoiceNo;
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20003, 'An error occurred: ' || SQLERRM);
END;
/

-- Trigger to log insertions into the Invoice table
CREATE OR REPLACE TRIGGER trg_after_insert_invoice
AFTER INSERT ON Invoice
FOR EACH ROW
BEGIN
    INSERT INTO Invoice_Log(invoiceNo, dateRaised, datePaid, creditCardNo, holdersName, expiryDate, registrationNo, pMethodNo, logDate)
    VALUES (:NEW.invoiceNo, :NEW.dateRaised, :NEW.datePaid, :NEW.creditCardNo, :NEW.holdersName, :NEW.expiryDate, :NEW.registrationNo, :NEW.pMethodNo, SYSDATE);
END;
/

-- Function to retrieve all invoices
CREATE OR REPLACE FUNCTION get_all_invoices
RETURN SYS_REFCURSOR AS
    invoices_cursor SYS_REFCURSOR;
BEGIN
    OPEN invoices_cursor FOR SELECT * FROM Invoice;
    RETURN invoices_cursor;
END;
/

CREATE SEQUENCE log_seq START WITH 1;

CREATE OR REPLACE TRIGGER trg_after_insert_invoice
AFTER INSERT ON Invoice
FOR EACH ROW
BEGIN
    INSERT INTO LogTable(logId, logDate, tableName, operation)
    VALUES (log_seq.nextval, SYSTIMESTAMP, 'Invoice', 'INSERT');
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20004, 'An error occurred in trg_after_insert_invoice: ' || SQLERRM);
END;
/

CREATE OR REPLACE TRIGGER trg_after_update_invoice
AFTER UPDATE ON Invoice
FOR EACH ROW
BEGIN
    INSERT INTO LogTable(logId, logDate, tableName, operation)
    VALUES (log_seq.nextval, SYSTIMESTAMP, 'Invoice', 'UPDATE');
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20005, 'An error occurred in trg_after_update_invoice: ' || SQLERRM);
END;
/

CREATE OR REPLACE TRIGGER trg_after_delete_invoice
AFTER DELETE ON Invoice
FOR EACH ROW
BEGIN
    INSERT INTO LogTable(logId, logDate, tableName, operation)
    VALUES (log_seq.nextval, SYSTIMESTAMP, 'Invoice', 'DELETE');
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20006, 'An error occurred in trg_after_delete_invoice: ' || SQLERRM);
END;
/

CREATE OR REPLACE DIRECTORY datapump_dir AS 'C:/Users/Vinci/Desktop/404_backup';


CREATE OR REPLACE PROCEDURE backup_database AS
    h1 NUMBER;
    job_name VARCHAR2(50);
    dump_file VARCHAR2(50);
BEGIN
    -- Create a unique job name and dump file name based on the current date and time
    job_name := 'backup_job_' || TO_CHAR(SYSDATE, 'YYYYMMDD_HH24MISS');
    dump_file := 'backup_' || TO_CHAR(SYSDATE, 'YYYYMMDD_HH24MISS') || '.dmp';

    -- Create a Data Pump job with a unique name
    h1 := DBMS_DATAPUMP.OPEN(operation => 'EXPORT', job_mode => 'FULL', job_name => job_name);

    -- Specify the directory and file name for the dump file
    DBMS_DATAPUMP.ADD_FILE(handle => h1, filename => dump_file, directory => 'DATAPUMP_DIR');

    -- Start the job
    DBMS_DATAPUMP.START_JOB(handle => h1);

    -- Detach from the job
    DBMS_DATAPUMP.DETACH(handle => h1);
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error: ' || SQLERRM);
        RAISE;
END;
/



BEGIN
    backup_database;
END;
/

SELECT * FROM all_directories WHERE directory_name = 'DATAPUMP_DIR';

SELECT job_name, state FROM dba_datapump_jobs WHERE owner_name = 'SYSTEM';



-- Attach to the running job
DECLARE
    h1 NUMBER;
BEGIN
    h1 := DBMS_DATAPUMP.ATTACH('backup_job');
    DBMS_DATAPUMP.STOP_JOB(handle => h1, immediate => 1);
    DBMS_DATAPUMP.DETACH(handle => h1);
END;
/



DROP TABLE backup_job;


SELECT owner_name, job_name, operation, job_mode, state FROM dba_datapump_jobs WHERE owner_name = 'SYSTEM';


DECLARE
    h1 NUMBER;
BEGIN
    -- Attempt to attach to the existing Data Pump job
    BEGIN
        h1 := DBMS_DATAPUMP.ATTACH('backup_job');
        -- Stop the job immediately
        DBMS_DATAPUMP.STOP_JOB(h1, immediate => 1);
        -- Detach from the job
        DBMS_DATAPUMP.DETACH(h1);
    EXCEPTION
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('No existing job to stop or error occurred: ' || SQLERRM);
    END;

    -- Drop the master table for the existing job if it exists
    EXECUTE IMMEDIATE 'DROP TABLE backup_job';
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error dropping table or table does not exist: ' || SQLERRM);
END;
/


