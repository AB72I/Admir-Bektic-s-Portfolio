create table REGION
(
REGIONID Number not null,
Region_name varchar2(100) not null,
constraint region primary key (REGIONID)
);

create sequence INSERT_region_seq increment by 1 start with 1 nocache;

CREATE OR REPLACE TRIGGER INSERT_region_seq
BEFORE INSERT ON REGION
FOR EACH ROW
DECLARE
new_id number;
BEGIN
SELECT INSERT_region_seq.nextval INTO new_id FROM dual;
:new.REGIONid := new_id;
END;
/

CREATE TABLE CUSTOMER
(
CUSTOMERID NUMBER NOT NULL,
Customer_Name VARCHAR2(100) NOT NULL,
CP_Name VARCHAR2(50) NOT NULL,
Phone VARCHAR2(13) NOT NULL,
Email VARCHAR2(100) NOT NULL,
REGIONID number not null,
Date_Added DATE,
Date_Updated DATE,
Constraint customer_pk primary key (customerid),
Constraint customer_region_FK foreign key (regionid) references region(regionid)
);

create sequence INSERT_customer_seq increment by 1 start with 1 nocache;

CREATE OR REPLACE TRIGGER INSERT_customer_seq
BEFORE INSERT ON customer
FOR EACH ROW
DECLARE
new_id number;
BEGIN
SELECT INSERT_customer_seq.nextval INTO new_id FROM dual;
:new.CUSTOMERID := new_id;
END;
/

CREATE OR REPLACE TRIGGER  INSERT_CUSTOMER_Date
BEFORE INSERT ON CUSTOMER
FOR EACH ROW
BEGIN
:NEW.Date_Added := SYSDATE;
END;
/

CREATE OR REPLACE TRIGGER  UPDATE_CUSTOMER_Date
BEFORE UPDATE ON CUSTOMER
FOR EACH ROW
BEGIN
:NEW.Date_Updated := SYSDATE;
END;
/

CREATE TABLE ADDRESS_TYPE
( TYPEID NUMBER,
  Type_code VARCHAR(50),
  Constraint address_type_pk primary key (typeid)
);

create sequence address_type_seq increment by 1 start with 1 nocache;

CREATE OR REPLACE TRIGGER INSERT_address_type_seq
BEFORE INSERT ON address_type
FOR EACH ROW
DECLARE
new_id number;
BEGIN
SELECT address_type_seq.nextval INTO new_id FROM dual;
:new.TYPEID := new_id;
END;
/

CREATE TABLE ADDRESS
(ADDRESSID NUMBER(3),
 CUSTOMERID NUMBER(3),
 TYPEID NUMBER,
 Street_address VARCHAR(50),
 city VARCHAR(50),
 state VARCHAR(50),
 zip_code VARCHAR(50),
 country VARCHAR(50),
 Constraint address_PK primary key (addressid),
 Constraint address_customer_FK foreign key (customerid) references customer(customerid),
 Constraint address_address_type_FK foreign key (typeid) references address_type(typeid)
);

create sequence address_seq increment by 1 start with 1 nocache;

CREATE OR REPLACE TRIGGER INSERT_address_seq
BEFORE INSERT ON address
FOR EACH ROW
DECLARE
new_id number;
BEGIN
SELECT address_seq.nextval INTO new_id FROM dual;
:new.ADDRESSID := new_id;
END;
/