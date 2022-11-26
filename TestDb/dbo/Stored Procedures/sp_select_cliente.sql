CREATE PROCEDURE sp_select_cliente
@ClienteId INT
AS 
SELECT * FROM dbo.Cliente WHERE Clienteid = @ClienteId