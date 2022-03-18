IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Travelers')
BEGIN
    CREATE TABLE dbo.[Travelers] (
		[Id] 		INT IDENTITY(1,1),
		[Name]		NVARCHAR(50) NOT NULL,
		[Age]			INT NULL,
		
		[PlaceId]		INT NULL,
		[SocioEconomicLevelId]	INT NULL,
		[SexId]			INT NULL,
		[EducationLevelId]	INT NULL,
		[OccupationId]		INT NULL,
		[Identification] 	VARCHAR(100) NOT NULL
	);

	ALTER TABLE Travelers
	ADD CONSTRAINT PK_Travelers PRIMARY KEY (Id);
	
	
	ALTER TABLE Travelers
	ADD CONSTRAINT FK_Travelers_Places_PlaceId
	FOREIGN KEY (PlaceId) REFERENCES [Places](Id);
	
	ALTER TABLE Travelers
	ADD CONSTRAINT FK_Travelers_Codes_SocioEconomicLevelId
	FOREIGN KEY (SocioEconomicLevelId) REFERENCES [Codes](Id);
	
	ALTER TABLE Travelers
	ADD CONSTRAINT FK_Travelers_Codes_SexId
	FOREIGN KEY (SexId) REFERENCES [Codes](Id);
	
	ALTER TABLE Travelers
	ADD CONSTRAINT FK_Travelers_Codes_EducationLevelId
	FOREIGN KEY (EducationLevelId) REFERENCES [Codes](Id);
	
	ALTER TABLE Travelers
	ADD CONSTRAINT FK_Travelers_Codes_OccupationId
	FOREIGN KEY (OccupationId) REFERENCES [Codes](Id);
	
	CREATE NONCLUSTERED INDEX IX_Travelers_Identification
	ON [dbo].[Travelers](Identification);
END;