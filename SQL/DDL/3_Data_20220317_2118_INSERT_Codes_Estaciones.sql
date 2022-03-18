BEGIN tran
INSERT INTO [Codes]([Value], [Key], [Group], [Description])
VALUES
	('Otoño','Otoño','Estacion',N'Otoño'),
	('Invierno','Invierno','Estacion',N'Invierno'),
	('Primavera','Primavera','Estacion',N'Primavera'),
	('Verano','Verano','Estacion',N'Verano');
COMMIT