IF EXISTS (SELECT 1 FROM sys.objects WHERE [object_id] = OBJECT_ID(N'[dbo].[Codes_GetByKeyAndGroup]') AND [type] = N'P')
BEGIN
	DROP PROCEDURE [dbo].[Codes_GetByKeyAndGroup]
END
GO

-- =================================================
-- Author:		Edison Vidal
-- Create date: 14/06/2022
-- Description:	Get a row by (Key, Group)
-- =================================================

CREATE PROCEDURE [dbo].[Codes_GetByKeyAndGroup]
	@Key 	VARCHAR(50),
	@Group 	VARCHAR(100)
AS
BEGIN
	SELECT
		[Id],
		[Value],
		[Key],
		[Group],
		[Description]
	FROM
		[Codes]
	WHERE
		[Group] = @Group AND
		[Key] = @Key;
END
GO
