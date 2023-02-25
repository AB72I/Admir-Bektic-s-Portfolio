insert into REGION (REGION_NAME) values ('MidWest');
insert into REGION (REGION_NAME) values ('NorthWest');
insert into REGION (REGION_NAME) values ('South');
insert into REGION (REGION_NAME) values ('SouthWest');
insert into REGION (REGION_NAME) values ('SouthEast');
insert into REGION (REGION_NAME) values ('New England');
insert into REGION (REGION_NAME) values ('Great Lakes');

insert into CUSTOMER (Customer_Name, CP_Name, Phone, Email, REGIONID, Date_Added, Date_Updated) values ('Airport Bikes', 'Tina', '622-091-9900', 'tina234@gmail.com', '1', (TO_DATE('2023/02/05', 'yyyy/mm/dd')), (TO_DATE('2023/02/05', 'yyyy/mm/dd')));
insert into CUSTOMER (Customer_Name, CP_Name, Phone, Email, REGIONID, Date_Added, Date_Updated) values ('Capital Bikes', 'Tony', '601-234-0911', 'tony2001@att.com', '4', (TO_DATE('2023/02/05', 'yyyy/mm/dd')), (TO_DATE('2023/02/05', 'yyyy/mm/dd')));
insert into CUSTOMER (Customer_Name, CP_Name, Phone, Email, REGIONID, Date_Added, Date_Updated) values ('Alster Cycling', 'Pam', '411-001-2145', 'moblig@icloud.com', '3', (TO_DATE('2023/02/05', 'yyyy/mm/dd')), (TO_DATE('2023/02/05', 'yyyy/mm/dd')));
insert into CUSTOMER (Customer_Name, CP_Name, Phone, Email, REGIONID, Date_Added, Date_Updated) values ('Run Swim Bike', 'Elly', '314-628-0032', 'macsmenace@ruwsbi.com', '1', (TO_DATE('2023/02/05', 'yyyy/mm/dd')), (TO_DATE('2023/02/05', 'yyyy/mm/dd')));

insert into ADDRESS_TYPE (Type_code) values('Home');
insert into ADDRESS_TYPE (Type_code) values('Billing');
insert into ADDRESS_TYPE (Type_code) values('Shipping');
insert into ADDRESS_TYPE (Type_code) values('Home/Billing');
insert into ADDRESS_TYPE (Type_code) values('Home/Shipping');
insert into ADDRESS_TYPE (Type_code) values('Billing/Shipping');
insert into ADDRESS_TYPE (Type_code) values('Home/Billing/Shipping');

insert into ADDRESS (CUSTOMERID, TYPEID, Street_address, city, state, zip_code, country) values (1, 1, '45020 Aviation Drive', 'Saint Louis', 'MO', '63166', 'US');
insert into ADDRESS (CUSTOMERID, TYPEID, Street_address, city, state, zip_code, country) values (1, 2, '719 41 North Street', 'Saint Louis', 'MO', '63217', 'US');
insert into ADDRESS (CUSTOMERID, TYPEID, Street_address, city, state, zip_code, country) values (1, 3, '5698 Elmonte Drive', 'Saint Louis', 'MO', '63132', 'US');
insert into ADDRESS (CUSTOMERID, TYPEID, Street_address, city, state, zip_code, country) values (2, 7, '3235 Mi Casa Court', 'Birmingham', 'AL', '35203', 'US');
insert into ADDRESS (CUSTOMERID, TYPEID, Street_address, city, state, zip_code, country) values (3, 1, '5698 Sunshine Drive', 'Chicago', 'IL', '60610', 'US');
insert into ADDRESS (CUSTOMERID, TYPEID, Street_address, city, state, zip_code, country) values (3, 6, '12 State Street', 'Chicago', 'IL', '61610', 'US');
insert into ADDRESS (CUSTOMERID, TYPEID, Street_address, city, state, zip_code, country) values (4, 1, '2530 Willow Court', 'Clearwater', 'FL', '33755', 'US');
insert into ADDRESS (CUSTOMERID, TYPEID, Street_address, city, state, zip_code, country) values (4, 2, '2530 Willow Court', 'Clearwater', 'FL', '33755', 'US');
insert into ADDRESS (CUSTOMERID, TYPEID, Street_address, city, state, zip_code, country) values (4, 3, '2530 Willow Court', 'Clearwater', 'FL', '33755', 'US');