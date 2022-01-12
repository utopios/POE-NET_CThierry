DROP TABLE PERSONNE

CREATE TABLE PERSONNE
(
	[id] INT IDENTITY(1,1) NOT NULL,
	[titre] VARCHAR(5) NOT NULL,
	[prenom] VARCHAR(50) NOT NULL,
	[nom] VARCHAR(50) NOT NULL,
	[email] VARCHAR(50) NOT NULL,
	[telephone] VARCHAR(17) NOT NULL,
	PRIMARY KEY CLUSTERED ([id]ASC)
)

INSERT INTO PERSONNE (titre,prenom,nom,email,telephone)
VALUES ('Mr','Anthony','Di Persio','anthony@utopios.net','+33 6 12 34 56 78'),
		('Mlle', 'Tata', 'Toto', 'tatatoto@monemail.com', '0987654321'),
		('Mr', 'Minet', 'Gros', 'grosminet@monemail.com', '0612345678'),
		('Mme', 'Jane', 'Doe', 'janedoe@gmail.com', '0987654321'),
		('Mr', 'Bernard', 'Minet', 'bernard.m@free.fr', '0614762345'),
		('Mlle', 'Jessica', 'Rabbit', 'jr@caramail.fr', '0677777777'),
		('Mr', 'Zorro', 'Legrand', 'dondiego@gmx.com', '0987654321'),
		('Mme', 'Foo', 'Bar', 'foo@bar.com', '0913243546');