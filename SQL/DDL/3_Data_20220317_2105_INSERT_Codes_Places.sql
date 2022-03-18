BEGIN tran
INSERT INTO [Codes]([Value], [Key], [Group], [Description])
VALUES
('1','Zona','CategoriaEspacio',N'Categoría Zona'),
('2','RadioCensal','CategoriaEspacio',N'Categoría Radio Censal');
COMMIT