
DROP TABLE Note;
DROP TABLE Matiere;
DROP TABLE Module;
DROP TABLE Eleve;




CREATE TABLE Eleve
(
		numEleve INT PRIMARY KEY IDENTITY(1,1),
		nomEleve VARCHAR(20) NOT NULL UNIQUE,
		motDePasse VARCHAR(20)
);

CREATE TABLE Module
(
		numModule INT PRIMARY KEY IDENTITY(1,1),
		nomModule VARCHAR(20) NOT NULL UNIQUE,
		nbMatiere INT
);

/* Table de liaison Eleve * - * Module */
CREATE TABLE Suit
(
		numEleve INT FOREIGN KEY REFERENCES Eleve(numEleve),
		numModules INT FOREIGN KEY REFERENCES Module(numModule), 
		constraint pksuitID PRIMARY KEY(numEleve, numModules)
);



CREATE TABLE Matiere(
		numMatiere INT PRIMARY KEY IDENTITY(1,1),
		fknumModule INT FOREIGN KEY REFERENCES Module(numModule),
		nomMatiere VARCHAR(20) NOT NULL UNIQUE,
		nbNote INT,
		poidsMatiere INT NOT NULL CHECK(poidsMatiere BETWEEN 1 AND 100)
);

CREATE TABLE Note(
		numNotes INT PRIMARY KEY IDENTITY(1,1),
		fknumMatiere INT FOREIGN KEY REFERENCES Matiere(numMatiere),
		note INT NOT NULL CHECK(note BETWEEN 1 AND 6),
		poidsNote INT NOT NULL CHECK(poidsNote BETWEEN 1 AND 100)
);


INSERT INTO Eleve(nomEleve, motDePasse)
VALUES ('TOTO', 'PASSO');
INSERT INTO Eleve(nomEleve, motDePasse)
VALUES ('TATI', 'PASSO');
INSERT INTO Eleve(nomEleve, motDePasse)
VALUES ('TONTON', 'PASSO');
INSERT INTO Eleve(nomEleve, motDePasse)
VALUES ('TOTOCHE', 'PASSO');
INSERT INTO Eleve(nomEleve, motDePasse)
VALUES ('TATINE', 'PASSO');
INSERT INTO Eleve(nomEleve, motDePasse)
VALUES ('TALOUCHE', 'PASSO');

INSERT INTO Module(nomEleve, motDePasse)
VALUES ('TATINE', 'PASSO');
INSERT INTO Modul(nomEleve, motDePasse)
VALUES ('TALOUCHE', 'PASSO');

/*INSERT INTO Notes(numNotes, fknumMatiere, note, poidsNote )
VALUES (1, 1, 2, 50);
INSERT INTO Notes(numNotes, fknumMatiere, note, poidsNote )
VALUES (2, 1, 4, 50);

INSERT INTO Notes(numNotes, fknumMatiere, note, poidsNote )
VALUES (3, 2, 4, 50);
INSERT INTO Notes(numNotes, fknumMatiere, note, poidsNote )
VALUES (4, 2, 6, 50);*/

