DROP TABLE SALARIE;
DROP TABLE COMMERCIAL;

CREATE TABLE [dbo].[SALARIE]
(
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [nom]       VARCHAR (50) NOT NULL,
    [matricule] VARCHAR (4)  NOT NULL,
    [categorie] VARCHAR (4)  NOT NULL,
    [service]   VARCHAR (4)  NOT NULL,
    [salaire]   FLOAT   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[COMMERCIAL]
(
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [nom]       VARCHAR (50) NOT NULL,
    [matricule] VARCHAR (4)  NOT NULL,
    [categorie] VARCHAR (4)  NOT NULL,
    [service]   VARCHAR (4)  NOT NULL,
    [salaire]   FLOAT NOT NULL,
    [chiffre]   FLOAT   NOT NULL,
    [commission]   FLOAT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[salarie] ([nom], [matricule], [categorie], [service], [salaire]) 
VALUES (N'Di Persio Anthony', N'M001', N'C001', N'S001', 1500),
		(N'Abadi Ihab', N'M002', N'C002', N'S002', 1600),
		(N'Abadi Marine', N'M003', N'C003', N'S003', 2000),
		(N'Toto Titi', N'M004', N'C004', N'S004', 4500)

INSERT INTO [dbo].[COMMERCIAL] ([nom], [matricule], [categorie], [service], [salaire],[chiffre],[commission]) 
VALUES (N'Convenant Jean-Claude', N'M005', N'C001', N'S001', 1500.00,12000.00,2.00)
		