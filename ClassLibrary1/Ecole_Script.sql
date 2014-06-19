DROP TABLE Eleves;
DROP TABLE Modules;
DROP TABLE Matieres;
DROP TABLE Notes;



CREATE TABLE Notes(
		numNotes INT PRIMARY KEY,
		note INT NOT NULL CHECK(note BETWEEN 1 AND 6),
		poidsNote INT NOT NULL CHECK(poidsNote BETWEEN 1 AND 100)
);

CREATE TABLE Matieres(
		numMatiere INT PRIMARY KEY,
		fknumNote INT FOREIGN KEY REFERENCES Notes(numNotes),
		nomMatiere VARCHAR(20) NOT NULL UNIQUE,
		nbNote INT,
		poidsMatiere INT NOT NULL CHECK(poidsMatiere BETWEEN 1 AND 100)
);
CREATE TABLE Modules
(
		numModule INT PRIMARY KEY,
		fknumMatiere INT FOREIGN KEY REFERENCES Matieres(numMatiere),
		nomModule VARCHAR(20) NOT NULL UNIQUE,
		nbMatiere INT
);

CREATE TABLE Eleves
(
		numEleve INT PRIMARY KEY,
		fknumModule INT FOREIGN KEY REFERENCES Modules(numModule),
		nomEleve VARCHAR(20) NOT NULL UNIQUE,
		motDePasse VARCHAR(20)
);

INSERT INTO Notes(numNotes, note, poidsNote )
VALUES (1, 5, 50);
