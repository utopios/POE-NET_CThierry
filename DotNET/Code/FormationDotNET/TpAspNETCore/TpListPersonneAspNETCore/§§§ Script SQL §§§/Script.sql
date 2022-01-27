--Drop TABLE personne;

/*
 * Création table PERSON
 */
CREATE TABLE [dbo].[PERSONNE]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [titre] VARCHAR(5) NOT NULL, 
    [nom] VARCHAR(50) NOT NULL, 
    [prenom] VARCHAR(50) NOT NULL, 
    [email] VARCHAR(50) NOT NULL, 
    [telephone] VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)

/*
 * Ajout Personnes
 */ 
INSERT INTO [dbo].[PERSONNE] ([titre], [prenom], [nom], [email], [telephone]) 
VALUES (N'Mr', N'Anthony', N'Di Persio', N'anthony@utopios.net', N'+33 6 12 34 56 78'),
        (N'Mlle', N'Tata', N'Toto', N'tatatoto@monemail.com', N'+33 9 87 65 43 21'),
        (N'Mr', N'Minet', N'Gros', N'grosminet@monemail.com', N'+33 6 12 34 56 78'),
        (N'Mme', N'Jane', N'Doe', N'janedoe@gmail.com', N'+33 9 87 65 43 21'),
        (N'Mr', N'Bernard', N'Minet', N'bernard.m@free.fr', N'+33 6 14 76 23 45'),
        (N'Mlle', N'Jessica', N'Rabbit', N'jr@caramail.fr', N'+33 6 77 77 77 77'),
        (N'Mr', N'Zorro', N'Legrand', N'dondiego@gmx.com', N'+33 9 87 65 43 21'),
        (N'Mr', N'Foo', N'Bar', N'foo@bar.com', N'+33 9 13 24 35 46'),
        (N'Mr', N'Menvussa', N'Gérard', N'gerardmenvussa@troplol.com', N'+33 6 12 45 78 32')

