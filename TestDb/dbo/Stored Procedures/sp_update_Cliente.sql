CREATE PROCEDURE sp_update_Cliente
@ClienteId INT,
@Nombre NVARCHAR(50),  
@Apellido NVARCHAR(50),
@TipoCliente INT,
@SituacionLaboral NVARCHAR(50)
AS 
UPDATE dbo.Cliente SET  
       [Nombre] = @Nombre,
       [Apellido] = @Apellido,
	   [TipoCliente] = @TipoCliente,
	   [SituacionLaboral] = @SituacionLaboral
       WHERE ClienteId= @ClienteId