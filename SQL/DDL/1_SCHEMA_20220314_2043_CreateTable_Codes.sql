IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Codes')
BEGIN
    CREATE TABLE dbo.[Codes] (
		[Id] 			INT IDENTITY(1,1),
		[Value] 		VARCHAR(100) NOT NULL,
		[Key]			VARCHAR(50) NOT NULL,
		[Group]			VARCHAR(100) NOT NULL,
		[Description]	NVARCHAR(200) NULL
	);

	ALTER TABLE dbo.[Codes]
	ADD CONSTRAINT PK_Codes PRIMARY KEY (Id);
	
	CREATE NONCLUSTERED INDEX IX_Codes_Key_Group ON [Codes]([Key], [Group]);
END;