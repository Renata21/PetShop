create database PetShopDB;
use PetShopDB;

--CREARE TABELE
create table CustomerTbl
(
    CustID      int PRIMARY KEY identity (1,1) not null,
    CustLogin   nvarchar(20)                   not null,
    CustPass    nchar(20)                      not null,
    CustName    nvarchar(20)                   not null,
    CustSurname nvarchar(20)                   not null,
    CustPhone   nvarchar(50),
    CustAdd     nvarchar(50)
);

create table EmployeeTbl
(
    EmpID      int PRIMARY KEY identity (1,1) not null,
    EmpLogin   nvarchar(20)                   not null,
    EmpPass    nchar(20)                      not null,
    EmpName    nvarchar(20)                   not null,
    EmpSurname nvarchar(20)                   not null,
    EmpDOB     date,
    EmpPhone   nvarchar(50),
    EmpAdd     nvarchar(50)
);

create table ProductTbl
(
    PrID    int primary key identity (1,1) not null,
    PrName  nvarchar(50)                   not null,
    PrType  nvarchar(20)                   not null,
    PrQty   int                            not null,
    PrPrice int                            not null
);

create table BillTbl
(
    BId       int primary key identity (1,1) not null,
    BDate     date                           not null,
    CustId    int                            not null,
    CustLogin varchar(20)                    not null,
    EmpLogin  varchar(20),
    Amt       int                            not null
);

--CREARE CONSTRANGERI
ALTER TABLE ProductTbl
    ADD CONSTRAINT df_PrQty
        DEFAULT '1' FOR PrQty;

ALTER TABLE ProductTbl
    ADD CONSTRAINT CHK_PrPrice CHECK (PrPrice > 0);

ALTER TABLE BillTbl
    ADD CONSTRAINT CHK_Amt CHECK (Amt > 0);

ALTER TABLE BillTbl
    ADD CONSTRAINT FK_CustId
        FOREIGN KEY (CustId) REFERENCES CustomerTbl (CustID);

--ADAUGARE DATE
insert into CustomerTbl (CustLogin, CustPass, CustName, CustSurname, CustPhone, CustAdd)
values ('eric', '123', 'Eric', 'Escabar', '069647571', 'eric123@gmail.com'),
       ('angelica', 'pisicute123', 'Angela', 'Olaru', '078381293', 'angelica_olaru@gmail.com'),
       ('hoobit', 'pestera98', 'Marla', 'Boiden', '076289162', 'marlaboiden@gmailcom'),
       ('finica', 'cristinel21', 'Cristian', 'Finica', '062938210', 'finica@gmail.com'),
       ('pisi', 'imiIubescPisica', 'Marco', 'Istrate', '067493206', 'istrate@gmail.com');

insert into EmployeeTbl (EmpLogin, EmpPass, EmpName, EmpSurname, EmpDOB, EmpPhone, EmpAdd)
values ('admin', 'admin', 'Administrator', 'Administrator', '', '', 'admin@pethouse.com'),
       ('reni', 'reni', 'Renata', 'Celac', '2003-12-21', '078265621', 'celac.renata@pethouse.com'),
       ('cristi', 'cristi', 'Cristian', 'Finica', '2003-08-04', '078263728', 'cristian@pethouse.com');

insert into ProductTbl(PrName, PrType, PrQty, PrPrice)
values ('Pisica siameza', 'Animal', '3', '700'),
       ('Caine buldog', 'Animal', '2', '600'),
       ('Mancare uscata pentru pisici', 'Hrana', '100', '25');