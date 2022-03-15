IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Locations')
BEGIN
    CREATE TABLE dbo.[Locations] (
		[Id] 	INT IDENTITY(1,1),
		
		[Street]		VARCHAR(100) NOT NULL,
		[Number]		VARCHAR(100) NOT NULL,
		[Latitude]		FLOAT NULL,
		[Longitude]		FLOAT NULL,
		[CensusRadiusId]	INT NULL,
		[ZoneId]		INT NOT NULL,
		[CategoryId]	INT NULL,
		[Description]	NVARCHAR(200) NULL,
		[Radius]		INT NULL,
		[ResidentialZoneTypeId]		INT NULL
	);

	ALTER TABLE Locations
	ADD CONSTRAINT PK_Locations PRIMARY KEY (Id);
	
	ALTER TABLE Locations
	ADD CONSTRAINT FK_Locations_Places_CensusRadiusId
	FOREIGN KEY (CensusRadiusId) REFERENCES [Places](Id);
	
	ALTER TABLE Locations
	ADD CONSTRAINT FK_Locations_Places_ZoneId
	FOREIGN KEY (ZoneId) REFERENCES [Places](Id);
	
	ALTER TABLE Locations
	ADD CONSTRAINT FK_Locations_Codes_CategoryId
	FOREIGN KEY (CategoryId) REFERENCES [Codes](Id);
	
	ALTER TABLE Locations
	ADD CONSTRAINT FK_Locations_Codes_ResidentialZoneTypeId
	FOREIGN KEY (ResidentialZoneTypeId) REFERENCES [Codes](Id);
END;