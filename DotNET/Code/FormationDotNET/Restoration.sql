DROP TABLE Utilisateur

CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT  IDENTITY(1,1) NOT NULL, 
    [nom] VARCHAR(50) NOT NULL, 
    [prenom] VARCHAR(50) NOT NULL, 
    [email] VARCHAR(50) NOT NULL, 
    [telephone] VARCHAR(17) NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)

-- Injection multiples
INSERT INTO [dbo].[Utilisateur] ([nom], [prenom],[email],[telephone])
VALUES ('Abadi','Ihab','ihab@utopios.net','+33 6 78 91 23 45'),
('Doe','John','jd@gamil.com','+33 6 23 45 67 89'),
('Doe','Jane','jane@yahoo.fr','+33 6 98 76 54 32'),
('Duss','Jean-Claude','jcduss@bronzes.net','+33 6 01 02 03 04'),
('Apeupré','Jean-Michel','jmapeupre@chante.fr','+33 6 01 04 06 08'),
('Di Persio','Anthony','anthony@utopios.net','+33 6 12 34 56 78')