CREATE TABLE Utilisateur (
    login VARCHAR(50) NOT NULL,
    motDePasseHash CHAR(64) NOT NULL,
    role VARCHAR(30) NOT NULL,
    PRIMARY KEY (login)
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
    login VARCHAR(50) NOT NULL,
    PRIMARY KEY (numLicence),
    UNIQUE (login),
    FOREIGN KEY (codeCategorie) REFERENCES Categorie(codeCategorie),
    FOREIGN KEY (login) REFERENCES Utilisateur(login)
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
    latitude DECIMAL(9,6) NOT NULL,
    longitude DECIMAL(9,6) NOT NULL,
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

CREATE TABLE CoursePied (
    numEpreuve INT NOT NULL,
    denivelePositif INT NOT NULL,
    deniveleNegatif INT NOT NULL,
    PRIMARY KEY (numEpreuve),
    FOREIGN KEY (numEpreuve) REFERENCES Epreuve(numEpreuve)
);

CREATE TABLE Cyclisme (
    numEpreuve INT NOT NULL,
    denivelePositif INT NOT NULL,
    deniveleNegatif INT NOT NULL,
    penteMax DECIMAL(4,1) NOT NULL,
    PRIMARY KEY (numEpreuve),
    FOREIGN KEY (numEpreuve) REFERENCES Epreuve(numEpreuve)
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

CREATE TABLE ProduitDopant ( idProduitDopant INT IDENTITY(1,1) NOT NULL, codeProduit VARCHAR(20) NOT NULL, nomProduit NVARCHAR(100) NOT NULL, tauxMax DECIMAL(10,2) NOT NULL,

CONSTRAINT PK_ProduitDopant 
    PRIMARY KEY (idProduitDopant),

CONSTRAINT UQ_ProduitDopant_nom 
    UNIQUE (nomProduit)
);

CREATE TABLE Taux ( idTaux INT IDENTITY(1,1) NOT NULL, idPrelevement INT NOT NULL, idProduitDopant INT NOT NULL, mesure DECIMAL(10,2) NULL,

CONSTRAINT PK_Taux 
    PRIMARY KEY (idTaux),

CONSTRAINT FK_Taux_Prelevement 
    FOREIGN KEY (idPrelevement)
    REFERENCES Prelevement(idPrelevement)
    ON DELETE CASCADE,

CONSTRAINT FK_Taux_ProduitDopant 
    FOREIGN KEY (idProduitDopant)
    REFERENCES ProduitDopant(idProduitDopant),

CONSTRAINT UQ_Taux_Prelevement_Produit 
    UNIQUE (idPrelevement, idProduitDopant)
);

INSERT INTO Utilisateur (login, motDePasseHash, role)
VALUES
('jdupont', CONVERT(CHAR(64), HASHBYTES('SHA2_256', 'password123'), 2), 'athlete'),
('mleclerc', CONVERT(CHAR(64), HASHBYTES('SHA2_256', 'azerty'), 2), 'athlete'),
('admin', CONVERT(CHAR(64), HASHBYTES('SHA2_256', 'admin'), 2), 'admin');

INSERT INTO Categorie (codeCategorie, libelle, ageMini, ageMaxi)
VALUES
(1, 'Junior', 16, 18),
(2, 'Senior', 19, 39),
(3, 'Veteran', 40, 65);

INSERT INTO Triathlete (
    numLicence, nom, prenom, sexe,
    adresseRue, adresseCP, adresseVille,
    dateNaissance, codeCategorie, login
)
VALUES
(1, 'Dupont', 'Jean', 'M',
 '12 rue des Lilas', '75001', 'Paris',
 '2000-05-12', 2, 'jdupont'),
(2, 'Leclerc', 'Marie', 'F',
 '8 avenue Victor Hugo', '69000', 'Lyon',
 '1995-03-22', 2, 'mleclerc');

INSERT INTO TypeTriathlon (
    codeType, libelleType,
    distanceNatation, distanceCyclisme, distanceCourse
)
VALUES
(1, 'Sprint', 0.75, 20, 5),
(2, 'Olympique', 1.5, 40, 10);

INSERT INTO Triathlon (
    idTriathlon, nomTriathlon, lieu, dateTriathlon, codeType
)
VALUES
(1, 'Triathlon de Paris', 'Paris', '2026-06-15', 1),
(2, 'Triathlon de Lyon', 'Lyon', '2026-07-10', 2),
(3, 'Triathlon de Marseille', 'Marseille', '2026-08-05', 1);

INSERT INTO Epreuve (
    numEpreuve, typeEpreuve,
    gpsDepart, gpsArrivee, idTriathlon
)
VALUES
(1, 'Natation', '48.8566,2.3522', '48.8570,2.3530', 1),
(2, 'Course',   '48.8570,2.3530', '48.8580,2.3540', 1),
(3, 'Natation', '45.7640,4.8357', '45.7650,4.8365', 2),
(4, 'Course',   '45.7650,4.8365', '45.7660,4.8370', 2),
(5, 'Natation', '43.2965,5.3698', '43.2975,5.3705', 3),
(6, 'Course',   '43.2975,5.3705', '43.2985,5.3715', 3);

INSERT INTO Natation (numEpreuve, temperatureEau)
VALUES
(1, 20.0),
(3, 18.5),
(5, 21.0);

INSERT INTO Course (numEpreuve, denivelePositif, deniveleNegatif)
VALUES
(2, 50, 50),
(4, 120, 120),
(6, 80, 80);

INSERT INTO CoursePied (numEpreuve)
VALUES
(2), (4), (6);

INSERT INTO Inscription (
    idTriathlon, numDossard, dateInscription, forfait, numLicence
)
VALUES
(1, 101, '2026-05-01', 0, 1),
(1, 102, '2026-05-02', 0, 2),
(2, 201, '2026-06-01', 0, 1),
(3, 301, '2026-07-01', 0, 2);

INSERT INTO ResultatEpreuve (
    idTriathlon, numDossard, numEpreuve, temps
)
VALUES
(1, 101, 1, 930),
(1, 101, 2, 1210),
(1, 102, 1, 980),
(1, 102, 2, 1280),
(2, 201, 3, 1020),
(2, 201, 4, 2150),
(3, 301, 5, 1100),
(3, 301, 6, 2300);

INSERT INTO Laboratoire (
    idLaboratoire, nomLaboratoire,
    adresseRue, adresseCP, adresseVille
)
VALUES
(1, 'Lab Paris', '1 rue de la Paix', '75002', 'Paris'),
(2, 'Lab Lyon', '10 rue de la République', '69001', 'Lyon');

INSERT INTO Prelevement (
    idPrelevement, datePrelevement,
    idTriathlon, numLicence, idLaboratoire
)
VALUES
(1, '2026-06-15', 1, 1, 1),
(2, '2026-06-15', 1, 2, 1),
(3, '2026-07-10', 2, 1, 2),
(4, '2026-08-05', 3, 2, 2);

INSERT INTO Triathlon (idTriathlon, nomTriathlon, lieu, dateTriathlon, codeType)
VALUES
(4, 'Triathlon de Bordeaux', 'Bordeaux', '2026-06-20', 2),
(5, 'Triathlon de Toulouse', 'Toulouse', '2026-06-30', 1),
(6, 'Triathlon de Nantes', 'Nantes', '2026-07-05', 2),
(7, 'Triathlon de Strasbourg', 'Strasbourg', '2026-07-18', 1),
(8, 'Triathlon de Lille', 'Lille', '2026-08-02', 2),
(9, 'Triathlon de Montpellier', 'Montpellier', '2026-08-15', 1);


INSERT INTO Epreuve (numEpreuve, typeEpreuve, latitude, longitude, idTriathlon)
VALUES
-- Triathlon 1
(1, 'Natation',   48.8566, 2.3522, 1),
(2, 'Cyclisme',   48.8570, 2.3530, 1),
(3, 'CoursePied', 48.8580, 2.3540, 1),

-- Triathlon 2
(4, 'Natation',   45.7640, 4.8357, 2),
(5, 'Cyclisme',   45.7650, 4.8365, 2),
(6, 'CoursePied', 45.7660, 4.8370, 2),

-- Triathlon 3
(7, 'Natation',   43.2965, 5.3698, 3),
(8, 'Cyclisme',   43.2975, 5.3705, 3),
(9, 'CoursePied', 43.2985, 5.3715, 3),

-- Triathlon 4
(10, 'Natation',   44.8378, -0.5792, 4),
(11, 'Cyclisme',   44.8388, -0.5780, 4),
(12, 'CoursePied', 44.8398, -0.5770, 4),

-- Triathlon 5
(13, 'Natation',   43.6047, 1.4442, 5),
(14, 'Cyclisme',   43.6057, 1.4452, 5),
(15, 'CoursePied', 43.6067, 1.4462, 5),

-- Triathlon 6
(16, 'Natation',   47.2184, -1.5536, 6),
(17, 'Cyclisme',   47.2194, -1.5526, 6),
(18, 'CoursePied', 47.2204, -1.5516, 6);

INSERT INTO Natation (numEpreuve, temperatureEau)
VALUES
(1, 20.0),
(4, 18.5),
(7, 21.0),
(10, 18.0),
(13, 20.5),
(16, 17.5);

INSERT INTO Cyclisme (numEpreuve, denivelePositif, deniveleNegatif, penteMax)
VALUES
(2,  300, 300, 8.5),
(5,  450, 450, 10.0),
(8,  380, 380, 7.5),
(11, 420, 420, 9.0),
(14, 360, 360, 8.0),
(17, 500, 500, 11.0);

INSERT INTO CoursePied (numEpreuve, denivelePositif, deniveleNegatif)
VALUES
(3,  80,  80),
(6, 120, 120),
(9,  90,  90),
(12, 70,  70),
(15, 60,  60),
(18, 100, 100);




