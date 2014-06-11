--Creation d'une table produits
--Se connecter avec: >sqlplus /nolog
--Exécution du script
-- @c:\users\dt\desktop\test\creatPieces.sql

-- sqlplus /nolog @c:\users\dt\desktop\test\creatPieces.sql

--login admin
--CONNECT system/root;

--suppression des utilisateurs
--DROP USER ecole CASCADE;

--creation des utilisateurs
--CREATE USER ecole --IDENTIFIED BY ecole;
--CREATE USER rene --IDENTIFIED BY rene;

--Ajout des privilèges
--GRANT CONNECT, RESOURCE to ecole;
--GRANT CONNECT, RESOURCE to rene;

--Connexion utillisateur
--CONNECT ecole/ecole;

CREATE TABLE Eleves
(
		numEleve INT PRIMARY KEY,
		nomEleve VARCHAR(20) NOT NULL UNIQUE,
		motDePasse VARCHAR(20)
);

CREATE TABLE Modules
(
		numModule INT PRIMARY KEY,
		nomModule VARCHAR(20) NOT NULL UNIQUE,
		nbMatiere INT
);

CREATE TABLE Matieres(
		numMatiere INT PRIMARY KEY,
		nomMatiere VARCHAR(20) NOT NULL UNIQUE,
		nbNote INT,
		poidsMatiere INT
);

CREATE TABLE Notes(
		numNotes INT PRIMARY KEY,
		note VARCHAR(20) NOT NULL,
		poidsNote INT
);
