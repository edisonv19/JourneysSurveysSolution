IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Places')
BEGIN
    CREATE TABLE dbo.[Places] (
		[Id] 	INT IDENTITY(1,1),
		
		[CategoryId]	INT NOT NULL,
		[Code]		VARCHAR(50) NOT NULL,
		[Description]	NVARCHAR(200) NULL,
		[Coordinates_Json]	VARCHAR(MAX) NULL,
		[ParentId]		INT NULL
	);

	ALTER TABLE dbo.[Places]
	ADD CONSTRAINT PK_Places PRIMARY KEY (Id);
	
	ALTER TABLE dbo.[Places]
	ADD CONSTRAINT FK_Places_Codes_CategoryId FOREIGN KEY (CategoryId) REFERENCES dbo.[Codes](Id);
	
	ALTER TABLE dbo.[Places]
	ADD CONSTRAINT FK_Places_Places_ParentId FOREIGN KEY (ParentId) REFERENCES dbo.[Places](Id);
	
	ALTER TABLE dbo.[Places]
	ADD CONSTRAINT UC_Places_Code UNIQUE (Code);
	
	CREATE NONCLUSTERED INDEX IX_Places_Code  
    ON dbo.[Places](Code);  
END;