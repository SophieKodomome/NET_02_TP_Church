CREATE USER church WITH PASSWORD 'church';
ALTER USER church WITH SUPERUSER;

CREATE DATABASE church;
\c church;

CREATE TABLE static_expenses(
    id Serial PRIMARY KEY,
    motif VARCHAR,
    montant_unitaire int
);

CREATE TABLE variable_expenses(
    id Serial PRIMARY KEY,
    motif VARCHAR,
    montant_unitaire int,
    par VARCHAR
);

CREATE TABLE variable_expenses_depot(
    id Serial PRIMARY KEY,
    id_variable_expenses int,
    FOREIGN KEY (id_variable_expenses) REFERENCES variable_expenses(id),
    nom_unite_variable VARCHAR,
    variable int,
    mois int
);

CREATE OR REPLACE VIEW v_variable_expenses_depot AS
SELECT 
    variable_expenses_depot.id,
    id_variable_expenses,
    motif,
    montant_unitaire,
    par,
    nom_unite_variable,
    variable,
    mois
FROM variable_expenses_depot JOIN variable_expenses ON variable_expenses.id=variable_expenses_depot.id_variable_expenses;

INSERT INTO static_expenses(motif,montant_unitaire) VALUES ('salary',5000000);
INSERT INTO static_expenses(motif,montant_unitaire) VALUES ('rent',1000000);
INSERT INTO static_expenses(motif,montant_unitaire) VALUES ('insurance',1600000);
INSERT INTO static_expenses(motif,montant_unitaire) VALUES ('supply',1300000);

INSERT INTO variable_expenses(motif,montant_unitaire,par) VALUES ('electricity',400,'/kwh');
INSERT INTO variable_expenses(motif,montant_unitaire,par) VALUES ('transport',20000,'/litre dessence');

INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',60000,1);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',49000,2);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',62000,3);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',50000,4);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',49000,5);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',62000,6);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',60000,7);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',49000,8);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',65000,9);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',69000,10);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',49000,11);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (1,'kwh',62000,12);

INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',6,1);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',4,2);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',6,3);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',5,4);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',4,5);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',6,6);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',3,7);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',4,8);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',6,9);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',6,10);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',4,11);
INSERT INTO variable_expenses_depot(id_variable_expenses,nom_unite_variable,variable,mois) VALUES (2,'litre essence',6,12);

