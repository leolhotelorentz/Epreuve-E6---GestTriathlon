# GEST-TRIATHLON
Code de la base de donnée



CREATE TABLE Utilisateur (
    idUtilisateur INT NOT NULL,
    login VARCHAR(50) NOT NULL,
    nom VARCHAR(50) NOT NULL,
    prenom VARCHAR(50) NOT NULL,
    motDePasseHash CHAR(64) NOT NULL,
    role VARCHAR(30) NOT NULL,
    PRIMARY KEY (idUtilisateur),
    UNIQUE (login)
);

CREATE TABLE Categorie (
    codeCategorie INT NOT NULL,
    libelle VARCHAR(50) NOT NULL,
    ageMini INT NOT NULL,
    ageMaxi INT NOT NULL,
    PRIMARY KEY (codeCategorie)
);

CREATE TABLE Triathlete (
    numLicence INT NOT NULL,
    nom VARCHAR(50) NOT NULL,
    prenom VARCHAR(50) NOT NULL,
    sexe CHAR(1) NOT NULL,
    adresseRue VARCHAR(100) NOT NULL,
    adresseCP VARCHAR(10) NOT NULL,
    adresseVille VARCHAR(50) NOT NULL,
    dateNaissance DATE NOT NULL,
    codeCategorie INT NOT NULL,
    idUtilisateur INT NOT NULL,
    PRIMARY KEY (numLicence),
    UNIQUE (idUtilisateur),
    FOREIGN KEY (codeCategorie) REFERENCES Categorie(codeCategorie),
    FOREIGN KEY (idUtilisateur) REFERENCES Utilisateur(idUtilisateur)
);

CREATE TABLE TypeTriathlon (
    codeType INT NOT NULL,
    libelleType VARCHAR(50) NOT NULL,
    distanceNatation DECIMAL(6,2) NOT NULL,
    distanceCyclisme DECIMAL(6,2) NOT NULL,
    distanceCourse DECIMAL(6,2) NOT NULL,
    PRIMARY KEY (codeType)
);

CREATE TABLE Triathlon (
    idTriathlon INT NOT NULL,
    nomTriathlon VARCHAR(100) NOT NULL,
    lieu VARCHAR(50) NOT NULL,
    dateTriathlon DATE NOT NULL,
    codeType INT NOT NULL,
    PRIMARY KEY (idTriathlon),
    FOREIGN KEY (codeType) REFERENCES TypeTriathlon(codeType)
);

CREATE TABLE Epreuve (
    numEpreuve INT NOT NULL,
    typeEpreuve VARCHAR(20) NOT NULL,
    gpsDepart VARCHAR(100) NOT NULL,
    gpsArrivee VARCHAR(100) NOT NULL,
    idTriathlon INT NOT NULL,
    PRIMARY KEY (numEpreuve),
    FOREIGN KEY (idTriathlon) REFERENCES Triathlon(idTriathlon)
);

CREATE TABLE Natation (
    numEpreuve INT NOT NULL,
    temperatureEau DECIMAL(4,1) NOT NULL,
    PRIMARY KEY (numEpreuve),
    FOREIGN KEY (numEpreuve) REFERENCES Epreuve(numEpreuve)
);

CREATE TABLE Course (
    numEpreuve INT NOT NULL,
    denivelePositif INT NOT NULL,
    deniveleNegatif INT NOT NULL,
    PRIMARY KEY (numEpreuve),
    FOREIGN KEY (numEpreuve) REFERENCES Epreuve(numEpreuve)
);

CREATE TABLE CourseVelo (
    numEpreuve INT NOT NULL,
    penteMax DECIMAL(4,1) NOT NULL,
    PRIMARY KEY (numEpreuve),
    FOREIGN KEY (numEpreuve) REFERENCES Course(numEpreuve)
);

CREATE TABLE CoursePied (
    numEpreuve INT NOT NULL,
    PRIMARY KEY (numEpreuve),
    FOREIGN KEY (numEpreuve) REFERENCES Course(numEpreuve)
);

CREATE TABLE Inscription (
    idTriathlon INT NOT NULL,
    numDossard INT NOT NULL,
    dateInscription DATE NOT NULL,
    forfait BIT NOT NULL,
    numLicence INT NOT NULL,
    PRIMARY KEY (idTriathlon, numDossard),
    FOREIGN KEY (idTriathlon) REFERENCES Triathlon(idTriathlon),
    FOREIGN KEY (numLicence) REFERENCES Triathlete(numLicence)
);

CREATE TABLE ResultatEpreuve (
    idTriathlon INT NOT NULL,
    numDossard INT NOT NULL,
    numEpreuve INT NOT NULL,
    temps INT NOT NULL,
    PRIMARY KEY (idTriathlon, numDossard, numEpreuve),
    FOREIGN KEY (idTriathlon, numDossard)
        REFERENCES Inscription(idTriathlon, numDossard),
    FOREIGN KEY (numEpreuve) REFERENCES Epreuve(numEpreuve)
);

CREATE TABLE Laboratoire (
    idLaboratoire INT NOT NULL,
    nomLaboratoire VARCHAR(100) NOT NULL,
    adresseRue VARCHAR(100) NOT NULL,
    adresseCP VARCHAR(10) NOT NULL,
    adresseVille VARCHAR(50) NOT NULL,
    PRIMARY KEY (idLaboratoire)
);

CREATE TABLE Prelevement (
    idPrelevement INT NOT NULL,
    datePrelevement DATE NOT NULL,
    idTriathlon INT NOT NULL,
    numLicence INT NOT NULL,
    idLaboratoire INT NOT NULL,
    PRIMARY KEY (idPrelevement),
    FOREIGN KEY (idTriathlon) REFERENCES Triathlon(idTriathlon),
    FOREIGN KEY (numLicence) REFERENCES Triathlete(numLicence),
    FOREIGN KEY (idLaboratoire) REFERENCES Laboratoire(idLaboratoire)
);

INSERT INTO Utilisateur (idUtilisateur, login, nom, prenom, motDePasseHash, role)
VALUES
(1, 'jdupont', 'Dupont', 'Jean',
 CONVERT(CHAR(64), HASHBYTES('SHA2_256', 'password123'), 2),
 'athlete');

INSERT INTO Categorie (codeCategorie, libelle, ageMini, ageMaxi)
VALUES
(1, 'Junior', 16, 18),
(2, 'Senior', 19, 39),
(3, 'Veteran', 40, 60);

INSERT INTO Triathlete (
    numLicence, nom, prenom, sexe,
    adresseRue, adresseCP, adresseVille,
    dateNaissance, codeCategorie, idUtilisateur
)
VALUES
(1, 'Dupont', 'Jean', 'M',
 '12 rue des Lilas', '75001', 'Paris',
 '2000-05-12', 2, 1);

INSERT INTO TypeTriathlon (
    codeType, libelleType,
    distanceNatation, distanceCyclisme, distanceCourse
)
VALUES
(1, 'Sprint', 0.75, 20.00, 5.00);

INSERT INTO Triathlon (
    idTriathlon, nomTriathlon, lieu, dateTriathlon, codeType
)
VALUES
(1, 'Triathlon de Paris', 'Paris', '2026-06-15', 1);

INSERT INTO Epreuve (
    numEpreuve, typeEpreuve,
    gpsDepart, gpsArrivee, idTriathlon
)
VALUES
(1, 'Natation', '48.8566,2.3522', '48.8570,2.3530', 1),
(2, 'Course',   '48.8570,2.3530', '48.8580,2.3540', 1);

INSERT INTO Natation (numEpreuve, temperatureEau)
VALUES
(1, 20.0);

INSERT INTO Course (numEpreuve, denivelePositif, deniveleNegatif)
VALUES
(2, 50, 50);

INSERT INTO CoursePied (numEpreuve)
VALUES
(2);

INSERT INTO Inscription (
    idTriathlon, numDossard, dateInscription, forfait, numLicence
)
VALUES
(1, 101, '2026-05-01', 0, 1);

INSERT INTO ResultatEpreuve (
    idTriathlon, numDossard, numEpreuve, temps
)
VALUES
(1, 101, 1, 930),
(1, 101, 2, 1210);

INSERT INTO Laboratoire (
    idLaboratoire, nomLaboratoire,
    adresseRue, adresseCP, adresseVille
)
VALUES
(1, 'Lab Paris', '1 rue de la Paix', '75002', 'Paris');

INSERT INTO Prelevement (
    idPrelevement, datePrelevement,
    idTriathlon, numLicence, idLaboratoire
)
VALUES
(1, '2026-06-15', 1, 1, 1);
