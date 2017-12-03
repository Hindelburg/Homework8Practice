CREATE TABLE Artists(
	id		int	IDENTITY NOT NULL,
	aName	varchar(100) NOT NULL,
	DOB		date		 NOT NULL,
	city	varchar(100) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Artworks(
	id		int IDENTITY NOT NULL,
	aName	varchar(100) NOT NULL,
	idA		int			 NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (idA) REFERENCES Artists(id)
);

CREATE TABLE Genres(
	id		int IDENTITY NOT NULL,
	gName	varchar(100) NOT NULL
	PRIMARY KEY (id)
);

CREATE TABLE Classifications(
	id		int IDENTITY NOT NULL,
	idA		int			 NOT NULL,
	idG		int			 NOT NULL,
	FOREIGN KEY (idA) REFERENCES Artworks(id),
	FOREIGN KEY (idg) REFERENCES Genres(id),
	PRIMARY KEY (id)
)

INSERT INTO dbo.Artists(aName, DOB, city) VALUES
	('M.C. Escher', '06/17/1898', 'Leeuwarden, Netherlands'),
	('Leonardo Da Vinci', '05/02/1519', 'Vinci, Italy'),
	('Hatip Mehmed Efendi', '11/18/1680', 'Unknown'),
	('Salvador Dali', '05/11/1904', 'Figueres, Spain')
GO

INSERT INTO dbo.Artworks(aName, idA) VALUES
	('Circle Limit III', 1),
	('Twon Tree', 1),
	('Mona Lisa', 2),
	('The Vitruvian Man', 2),
	('Ebru', 3),
	('Honey Is Sweeter Than Blood', 4)
GO

INSERT INTO dbo.Genres(gName) VALUES
	('Tesselation'),
	('Surrealism'),
	('Portrait'),
	('Renaissance')
GO

INSERT INTO dbo.Classifications(idA, idG) VALUES
	(1, 1),
	(2, 1),
	(2, 2),
	(3, 3),
	(3, 4),
	(4, 4),
	(5, 1),
	(6, 2)
GO