CREATE DATABASE assignment2;

use assignment2;

CREATE TABLE customers(
customerNumber VARCHAR(8) PRIMARY KEY,
customerName VARCHAR(50) NULL,
customerLastName VARCHAR(30) NULL,
customerFirstName VARCHAR(30) NULL,
phone INT NULL,
addressLine1 VARCHAR(100) NULL,
addressLine2 VARCHAR(100) NULL,
city VARCHAR(30) NULL,
state VARCHAR(30) NULL,
postalCode INT NULL,
country VARCHAR(30) NULL,
salesRepEmployeeNumber VARCHAR(8),
creditLimit INT NULL,
);

use assignment2;

CREATE TABLE products(
productCode VARCHAR(8) PRIMARY KEY,
productName VARCHAR(50) NULL,
productLine VARCHAR(8) NULL,
productScale INT NULL,
productVendor VARCHAR(50) NULL,
productDescription VARCHAR(100) NULL,
quantityInStock INT NULL,
buyPrice INT NULL,
MSRP INT NULL
);

use assignment2;

CREATE TABLE productLines(
productCode VARCHAR(8) PRIMARY KEY,
textDescription VARCHAR(100) NULL,
htmlDescription VARCHAR(50) NULL,
image varbinary(max) NULL
);

use assignment2;

CREATE TABLE orders(
orderNumber VARCHAR(8) PRIMARY KEY,
orderDate DATE NULL,
requiredDate DATE NULL,
shippedDate DATE NULL,
status VARCHAR(15) NULL,
comments VARCHAR(100) NULL,
customerNumber VARCHAR(8)
);

use assignment2;

CREATE TABLE orderdetails(
orderNumber VARCHAR(8),
productCode VARCHAR(8),
quantityOrdered INT NULL,
priceEach INT NULL,
orderLineNumber INT NULL
);

use assignment2;

CREATE TABLE payments(
checkNumber VARCHAR(8) PRIMARY KEY,
customerNumber VARCHAR(8),
paymentDate DATE NULL,
amount INT NULL
);

use assignment2;

CREATE TABLE employees(
employeeNumber VARCHAR(8) PRIMARY KEY,
lastName VARCHAR(50) NULL,
firstName VARCHAR(50) NULL,
extension INT NULL,
email VARCHAR(100) NULL,
officeCode VARCHAR(8),
reportsTo VARCHAR(8),
jobTitle VARCHAR(30) NULL
);

use assignment2;

CREATE TABLE offices(
officeCode VARCHAR(8) PRIMARY KEY,
city VARCHAR(30) NULL,
phone INT NULL,
addressLine1 VARCHAR(100) NULL,
addressLine2 VARCHAR(100) NULL,
state VARCHAR(30) NULL,
country VARCHAR(30) NULL,
postalCode INT NULL,
territory VARCHAR(30) NULL
);

use assignment2;

INSERT INTO customers VALUES
('cust0001','Dean1 Firdaus1','Firdaus1','Dean1','0811111','Jalan Alamat 1','','Jakarta Selatan','DKI Jakarta','11111','Indonesia','empl0008',1111111),
('cust0002','Dean2 Firdaus2','Firdaus2','Dean2','0822222','Jalan Alamat 2','','Jakarta Barat','DKI Jakarta','22222','Indonesia','empl0007',2222222),
('cust0003','Dean3 Firdaus3','Firdaus3','Dean3','0833333','Jalan Alamat 3','','Jakarta Timur','DKI Jakarta','33333','Indonesia','empl0006',3333333),
('cust0004','Dean4 Firdaus4','Firdaus4','Dean4','0844444','Jalan Alamat 4','','Bandung','Jawa Barat','44444','Indonesia','empl0009',4444444),
('cust0005','Dean5 Firdaus5','Firdaus5','Dean5','0855555','Jalan Alamat 5','','Bogor','Jawa Barat','55555','Indonesia','empl0009',5555555),
('cust0006','Dean6 Firdaus6','Firdaus6','Dean6','0866666','Jalan Alamat 6','','Bekasi','Jawa Barat','66666','Indonesia','empl0006',6666666),
('cust0007','Dean7 Firdaus7','Firdaus7','Dean7','0877777','Jalan Alamat 7','','Jakarta Selatan','DKI Jakarta','77777','Indonesia','empl0007',7777777),
('cust0008','Dean8 Firdaus8','Firdaus8','Dean8','0888888','Jalan Alamat 8','','Jakarta Selatan','DKI Jakarta','88888','Indonesia','empl0006',8888888),
('cust0009','Dean9 Firdaus9','Firdaus9','Dean9','0899999','Jalan Alamat 9','','Jakarta Barat','DKI Jakarta','99999','Indonesia','empl0006',9999999),
('cust0010','Dean10 Firdaus10','Firdaus10','Dean10','0800000','Jalan Alamat 10','','Jakarta Barat','DKI Jakarta','10000','Indonesia','empl0007',1000000)
;

SELECT * FROM customers;

use assignment2;

INSERT INTO employees VALUES
('empl0001','Dean1','Firdaus1',111,'firdaus1@gmail.com','offi0001','','CEO'),
('empl0002','Dean2','Firdaus2',222,'firdaus2@gmail.com','offi0002','empl0001','CTO'),
('empl0003','Dean3','Firdaus3',333,'firdaus3@gmail.com','offi0003','empl0001','CFO'),
('empl0004','Dean4','Firdaus4',444,'firdaus4@gmail.com','offi0004','empl0001','Manager1'),
('empl0005','Dean5','Firdaus5',555,'firdaus5@gmail.com','offi0005','empl0002','Manager2'),
('empl0006','Dean6','Firdaus6',666,'firdaus6@gmail.com','offi0006','empl0004','Clerk1'),
('empl0007','Dean7','Firdaus7',777,'firdaus7@gmail.com','offi0007','empl0004','Clerk2'),
('empl0008','Dean8','Firdaus8',888,'firdaus8@gmail.com','offi0008','empl0004','Clerk3'),
('empl0009','Dean9','Firdaus9',999,'firdaus9@gmail.com','offi0009','empl0005','Clerk4'),
('empl0010','Dean10','Firdaus10',100,'firdaus10@gmail.com','offi0010','empl0005','Clerk5')
;

SELECT * FROM employees;

use assignment2;

INSERT INTO offices VALUES
('offi0001','Jakarta Selatan',011111,111,'Jalan Kantor 1','','DKI Jakarta',11111,'Good'),
('offi0002','Jakarta Selatan',022222,222,'Jalan Kantor 2','','DKI Jakarta',22222,'Good'),
('offi0003','Jakarta Barat',033333,333,'Jalan Kantor 3','','DKI Jakarta',33333,'Good'),
('offi0004','Bandung',044444,444,'Jalan Kantor 4','','Jawa Barat',44444,'Flood'),
('offi0005','Bogor',055555,555,'Jalan Kantor 5','','Jawa Barat',55555,'Flood'),
('offi0006','Bekasi',066666,666,'Jalan Kantor 6','','Jawa Barat',66666,'Good'),
('offi0007','Jakarta Barat',077777,777,'Jalan Kantor 7','','DKI Jakarta',77777,'Good'),
('offi0008','Jakarta Barat',088888,888,'Jalan Kantor 8','','DKI Jakarta',88888,'Flood'),
('offi0009','Jakarta Pusat',099999,999,'Jalan Kantor 9','','DKI Jakarta',99999,'Good'),
('offi0010','Depok',010000,100,'Jalan Kantor 10','','Jawa Barat',10000,'Good')
;

SELECT * FROM offices;

use assignment2;

INSERT INTO orderdetails VALUES
('orde0001','prco0001',5,500000,1),
('orde0002','prco0002',10,250000,2),
('orde0003','prco0003',10,200000,3),
('orde0004','prco0004',20,75000,4),
('orde0005','prco0005',50,20000,5),
('orde0006','prco0006',25,50000,6),
('orde0007','prco0007',15,25000,7),
('orde0008','prco0008',10,150000,8),
('orde0009','prco0009',5,500000,9),
('orde0010','prco0010',15,100000,10)
;

SELECT * FROM orderdetails;