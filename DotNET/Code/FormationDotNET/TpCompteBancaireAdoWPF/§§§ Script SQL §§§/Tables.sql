Drop TABLE clientBanque;
Drop TABLE clientCompte;
Drop TABLE compte;
Drop TABLE operation;
/*
 * Création table Utilisateur
 */
CREATE TABLE [dbo].[clientBanque]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [nom] VARCHAR(50) NOT NULL, 
    [prenom] VARCHAR(50) NOT NULL, 
    [telephone] VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)
/*
 * Création table Compte
 */
CREATE TABLE [dbo].[compte]
(
	[Id] INT IDENTITY (1, 1) NOT NULL,       
    [solde]  DECIMAL (10, 2) NOT NULL,
    [taux]   DECIMAL  (2, 1) NOT NULL,
    [coutOperation]   DECIMAL  (4, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)
/*
 * Création table Clientcompte
 */
CREATE TABLE [dbo].[clientCompte]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [idClient]       INT    NOT NULL,    
    [idCompte]       INT    NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)
/*
 * Création table opération
 */
CREATE TABLE [dbo].[operation]
(
	[Id] INT IDENTITY (1, 1) NOT NULL,
    [idcompte]    VARCHAR (50) NOT NULL,
    [dateOperation] DATETIME     NOT NULL,
    [montant]      DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)
-- Ajouter des comptes

INSERT INTO [dbo].[compte] ( [solde], [taux], [coutOperation]) VALUES ( CAST(220.00 AS Decimal(10, 2)), CAST(0.0 AS Decimal(2, 1)), CAST(0.00 AS Decimal(4, 2)))
INSERT INTO [dbo].[compte] ( [solde], [taux], [coutOperation]) VALUES ( CAST(382.80 AS Decimal(10, 2)), CAST(4.0 AS Decimal(2, 1)), CAST(0.00 AS Decimal(4, 2)))
INSERT INTO [dbo].[compte] ( [solde], [taux], [coutOperation]) VALUES ( CAST(416.00 AS Decimal(10, 2)), CAST(0.0 AS Decimal(2, 1)), CAST(2.00 AS Decimal(4, 2)))

-- Ajouter des clients

INSERT INTO [dbo].[clientBanque] ( [nom], [prenom], [telephone]) VALUES ( N'Di Persio', N'Anthony', N'+33 6 45 78 96 52')
INSERT INTO [dbo].[clientBanque] ( [nom], [prenom], [telephone]) VALUES ( N'Abadi', N'Ihab', N'+33 6 41 23 58 74')
INSERT INTO [dbo].[clientBanque] ( [nom], [prenom], [telephone]) VALUES ( N'Abadi', N'Marine', N'+33 6 45 47 12 36')

-- ajout relation client => Compte

INSERT INTO [dbo].[clientCompte] ( [idClient], [idCompte]) VALUES ( 1, 1)
INSERT INTO [dbo].[clientCompte] ( [idClient], [idCompte]) VALUES ( 2, 2)
INSERT INTO [dbo].[clientCompte] ( [idClient], [idCompte]) VALUES ( 3, 3)



-- Ajouter les opérations
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'1', N'2022-01-17 14:13:00', CAST(50.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'2', N'2022-01-17 14:13:04', CAST(50.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'1', N'2022-01-17 14:13:13', CAST(-30.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'2', N'2022-01-17 14:13:17', CAST(-30.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'3', N'2022-01-17 14:13:21', CAST(-30.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'3', N'2022-01-17 14:13:21', CAST(-2.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'2', N'2022-01-17 14:13:25', CAST(12.80 AS Decimal(10, 2)))
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'3', N'2022-01-17 14:20:21', CAST(50.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'3', N'2022-01-17 14:20:28', CAST(-2.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[operation] ( [idcompte], [dateOperation], [montant]) VALUES ( N'2', N'2022-01-17 14:21:24', CAST(50.00 AS Decimal(10, 2)))

