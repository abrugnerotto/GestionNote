
DROP TABLE Notes;
DROP TABLE Matieres;
DROP TABLE Modules;
DROP TABLE Eleves;




CREATE TABLE Eleves
(
		numEleve INT PRIMARY KEY,
		nomEleve VARCHAR(20) NOT NULL UNIQUE,
		motDePasse VARCHAR(20)
);

CREATE TABLE Modules
(
		numModule INT PRIMARY KEY,
		fknumEleve INT FOREIGN KEY REFERENCES Eleves(numEleve),
		nomModule VARCHAR(20) NOT NULL UNIQUE,
		nbMatiere INT
);

CREATE TABLE Matieres(
		numMatiere INT PRIMARY KEY,
		fknumModule INT FOREIGN KEY REFERENCES Modules(numModule),
		nomMatiere VARCHAR(20) NOT NULL UNIQUE,
		nbNote INT,
		poidsMatiere INT NOT NULL CHECK(poidsMatiere BETWEEN 1 AND 100)
);

CREATE TABLE Notes(
		numNotes INT PRIMARY KEY,
		fknumMatiere INT FOREIGN KEY REFERENCES Matieres(numMatiere),
		note INT NOT NULL CHECK(note BETWEEN 1 AND 6),
		poidsNote INT NOT NULL CHECK(poidsNote BETWEEN 1 AND 100)
);


INSERT INTO Eleves(numEleve, nomEleve, motDePasse)
VALUES (1, 'TOTO', 'TATA');

/*INSERT INTO Notes(numNotes, fknumMatiere, note, poidsNote )
VALUES (1, 1, 2, 50);
INSERT INTO Notes(numNotes, fknumMatiere, note, poidsNote )
VALUES (2, 1, 4, 50);

INSERT INTO Notes(numNotes, fknumMatiere, note, poidsNote )
VALUES (3, 2, 4, 50);
INSERT INTO Notes(numNotes, fknumMatiere, note, poidsNote )
VALUES (4, 2, 6, 50);*/

