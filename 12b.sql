--CREATE DATABASE sale12B;
/*
CREATE TABLE CUSTOMER(
idCUSTOMER int NOT NULL,
name VARCHAR(20),
family VARCHAR(20),
EGN VARCHAR(10),
idTown INT,
Adress VARCHAR(50),
phone VARCHAR(14),
email VARCHAR(20)
);*/
/*
CREATE TABLE TOWN(
 idTown INT,
 nameTown VARCHAR(50),
 obshtinaTown VARCHAR(50),
 oblastTown VARCHAR (50)
);*/

/* INSERT INTO TOWN
(idTown,nameTown,obshtinaTown,oblastTown)
VALUES(1,'Blagoevgrad','Blagoevgrad','Blagoevgrad'),
(2,'Purvomai','Petrich','Blagoevgrad'),
(3,'Kresna','Kresna','Blagoevgrad'),
(4,'Dupnitsa','Dupnitsa','Blagoevgrad'),
(5,'Sandanski','Sandanski','Blagoevgrad');


DELETE FROM TOWN 
WHERE nameTown = 'Sofia';*/

--SELECT * FROM TOWN;
/*
INSERT INTO CUSTOMER
(idCUSTOMER,name,family,EGN,idTown,Adress,phone,email)
VALUES
(1,'Alexander','Georgiev','0343160000',2,'Maiski livadi','0887699919','ageorgiev@abv.bg'),
(2,'Bojidara','Gibarova','0352290070',1,'Elenovo','0877699929','djibarova@abv.bg'),
(3,'Boris','Dumbov','0345050000',5,'ul. Marenska','0887699939','bdambov@abv.bg'),
(4,'Borislava','Todorinska','0352310010',1,'Strumsko','0887699949','btodorinska@abv.bg'),
(5,'Boqn','Arkadiev','0345180000',1,'Elenovo 2','0887699959','barkadiev@abv.bg'),
(6,'Vasil','Angelov','0351140000',1,'Center','0877699969','vangelov@abv.bg'),
(7,'Veliko','Fotev','0345240000',4,'kv. Dupkite','0877699979','vfotev@abv.bg'),
(8,'Viktoria','Draleva','0350180039',1,'Alen mak','0897690299','vdraleva@abv.bg'),
(9,'Georgi','Arnaudov','0343220020',1,'Osvobojdenie','0877693399','garnaudov@abv.bg'),
(10,'Georgi','Georgiev','0343160000',1,'Staro Strumsko','0897639109','ggeorgiev@abv.bg'),
(11,'Denis','Lazarov','0343160000',3,'ul. Vurbishka','0897629119','dlazarov@abv.bg'),
(12,'Denislava','Novachka','0343160050',1,'Balarbashi','0897619129','deninovachka@abv.bg'),
(13,'Dimitrinka','Ivanova','0343160030',1,'Orlova chuka','0897612139','dimiivanova@abv.bg');*/
--select * from customer;

--CREATE TABLE Stoka(
--idStoka INT,
--nameStoka VARCHAR(30),
--idVidStoka INT
--);

--SELECT * FROM CUSTOMER;
--SELECT CUSTOMER.name,TOWN.nameTown
--FROM CUSTOMER
--INNER JOIN TOWN ON TOWN.idTown=CUSTOMER.idCUSTOMER;
--;

--INSERT INTO Stoka
--(idStoka,nameStoka,idVidStoka)
--VALUES
--(1,'key mause',123),
--(2,'keyboard',435),
--(3,'monitor',567),
--(4,'computer',789)

--select * from stoka;

--CREATE TABLE VidStoka(
--idVID INT,
--VidStoka VARCHAR(30)
--);

--INSERT INTO VidStoka
--(idVid,VidStoka)
--VALUES
--(123,'microsoft'),
--(435,'razer'),
--(567,'dell'),
--(789,'cempi')

--select * from vidstoka;




