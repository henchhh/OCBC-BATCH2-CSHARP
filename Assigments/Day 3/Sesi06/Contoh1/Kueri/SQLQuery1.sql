CREATE TABLE TB_SISWA(
NIS VARCHAR(10) PRIMARY KEY,
NAMA VARCHAR(50) NULL,
ALAMAT VARCHAR(100) NULL,
TG_LAHIR DATE NULL,
J_KELAMIN VARCHAR(1) NULL
)

ALTER TABLE TB_SISWA 
ALTER COLUMN J_KELAMIN VARCHAR(10)

INSERT INTO TB_SISWA(NIS,NAMA,ALAMAT,TG_LAHIR,J_KELAMIN)
VALUES('10001','BEJO','SURABAYA','2010-10-06','PRIA');

INSERT INTO TB_SISWA(NIS,NAMA,ALAMAT,TG_LAHIR,J_KELAMIN)
VALUES('10002','ANI','MALANG','2010-10-06','WANITA');

SELECT * FROM TB_SISWA

SELECT * FROM TB_SISWA WHERE NIS = '10001'

SELECT * FROM TB_SISWA WHERE ALAMAT LIKE 'SU%'

SELECT * FROM TB_SISWA WHERE TG_LAHIR BETWEEN '09-10-2010' AND '10-10-2010'

UPDATE TB_SISWA SET NAMA = 'BEJO SUTEDJO' WHERE NIS = '10001'

SELECT * FROM TB_SISWA

DELETE TB_SISWA WHERE NIS = '10002'

CREATE DATABASE STAFF

CREATE TABLE DATA_STAFF(
NIK INT PRIMARY KEY,
NAMA VARCHAR(50) NULL,
ALAMAT VARCHAR(200) NULL,
HANDPHONE VARCHAR(15) NULL
)

SELECT *
FROM INFORMATION_SCHEMA.TABLES;


CREATE TABLE DATA_STAFF(
NIK INT PRIMARY KEY,
NAMA VARCHAR(50) NULL,
ALAMAT VARCHAR(200) NULL,
HANDPHONE VARCHAR(15) NULL
)

USE STAFF;

EXEC sp_columns DATA_STAFF

INSERT INTO DATA_STAFF(NIK,NAMA,ALAMAT,HANDPHONE)
VALUES('10001','DEAN','JAKARTA','0812345678');

SELECT * FROM DATA_STAFF

INSERT INTO DATA_STAFF(NIK,NAMA,ALAMAT,HANDPHONE)
VALUES('10002','DEAN2','BANDUNG','0801234567');
INSERT INTO DATA_STAFF(NIK,NAMA,ALAMAT,HANDPHONE)
VALUES('10003','DEAN3','BOGOR','0813456789');

ALTER TABLE DATA_STAFF
ADD JOINDATE DATE

INSERT INTO DATA_STAFF(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10004','DEAN4','SURABAYA','0800123456','2021-11-24');

select top 3 *
FROM DATA_STAFF

CREATE TABLE STAFFOUTSOURCE(
NIK INT PRIMARY KEY,
NAMA VARCHAR(50) NULL,
ALAMAT VARCHAR(200) NULL,
HANDPHONE VARCHAR(15) NULL,
JOINDATE DATE NULL,
)

INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE)
VALUES('10001','DEAN','JAKARTA','0812345678');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE)
VALUES('10002','DEAN2','BANDUNG','0801234567');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE)
VALUES('10003','DEAN3','BOGOR','0813456789');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10004','DEAN4','SURABAYA','0800123456','2021-11-24');

INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10005','DEAN5','JAKARTA','0800123457','2021-11-10');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10006','DEAN6','PADANG','0800123454','2021-11-20');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10007','DEAN7','SEMARANG','0800123452','2021-11-20');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10008','DEAN8','SURABAYA','0800123441','2021-11-24');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10009','DEAN9','BANDUNG','0800123123','2021-11-23');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10010','DEAN10','ACEH','080012322','2021-11-21');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10011','DEAN11','PALEMBANG','080012399','2021-11-24');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10012','DEAN12','MALANG','080012411','2021-11-22');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('10013','DEAN13','BOGOR','080012411','2021-11-23');
INSERT INTO STAFFOUTSOURCE(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES('100014','DEAN14','SEMARANG','0800123452','2021-11-20');

USE STAFF

SELECT * FROM DATA_STAFF a, STAFFOUTSOURCE b
WHERE a.NIK = b.NIK
AND a.JOINDATE = b.JOINDATE;

SELECT *
FROM DATA_STAFF a
INNER JOIN STAFFOUTSOURCE b
ON a.NIK = b.NIK
WHERE a.JOINDATE = a.JOINDATE

SELECT *
FROM DATA_STAFF a
JOIN STAFFOUTSOURCE b
ON a.JOINDATE = a.JOINDATE

SELECT *
FROM DATA_STAFF a
RIGHT JOIN STAFFOUTSOURCE b
ON a.NIK = b.NIK

SELECT *
FROM DATA_STAFF a
LEFT JOIN STAFFOUTSOURCE b
ON a.NIK = b.NIK;

SELECT * FROM DATA_STAFF
UNION ALL
SELECT * FROM STAFFOUTSOURCE;

SELECT *
FROM DATA_STAFF a
FULL OUTER JOIN STAFFOUTSOURCE b
ON a.NIK = b.NIK;

SELECT * FROM DATA_STAFF;

SELECT * FROM STAFFOUTSOURCE;
