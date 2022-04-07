IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Trips')
BEGIN
    CREATE TABLE dbo.[Trips] (
		[Id] 		INT IDENTITY(1,1),
		
		[TravelerId]		INT NOT NULL,
		[Date]			DATETIME NULL,
		[SourceId]		INT NULL,
		[SourcePlaceTypeId]	INT NULL,
		[DestinationId]		INT NULL,
		[DestinationPlaceTypeId]	INT NULL,
		
		[ReasonTripId]		INT NULL,
		[StartTime]		TIME NULL,
		[EndTime]		TIME NULL,
		
		[TransportId]	INT NULL,
		[Observations]	NVARCHAR(200) NULL,
		[DateStr] VARCHAR(MAX) NULL
	);

	ALTER TABLE Trips
	ADD CONSTRAINT PK_Trips PRIMARY KEY (Id);
	
	ALTER TABLE Trips
	ADD CONSTRAINT FK_Trips_Travelers_TravelerId
	FOREIGN KEY (TravelerId) REFERENCES [Travelers](Id);
	
	ALTER TABLE Trips
	ADD CONSTRAINT FK_Trips_Locations_SourceId
	FOREIGN KEY (SourceId) REFERENCES [Locations](Id);
	
	ALTER TABLE Trips
	ADD CONSTRAINT FK_Trips_Codes_SourcePlaceTypeId
	FOREIGN KEY (SourcePlaceTypeId) REFERENCES [Codes](Id);
	
	ALTER TABLE Trips
	ADD CONSTRAINT FK_Trips_Locations_DestinationId
	FOREIGN KEY (DestinationId) REFERENCES [Locations](Id);
	
	ALTER TABLE Trips
	ADD CONSTRAINT FK_Trips_Codes_DestinationPlaceTypeId
	FOREIGN KEY (DestinationPlaceTypeId) REFERENCES [Codes](Id);
	
	ALTER TABLE Trips
	ADD CONSTRAINT FK_Trips_Codes_ReasonTripId
	FOREIGN KEY (ReasonTripId) REFERENCES [Codes](Id);
	
	ALTER TABLE Trips
	ADD CONSTRAINT FK_Trips_Codes_TransportId
	FOREIGN KEY (TransportId) REFERENCES [Codes](Id);
END;	