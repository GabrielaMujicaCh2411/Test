Create procedure sp_eliminacion_logica
@ClienteId INT,
@Estado int  

AS 
UPDATE dbo.Cliente SET  
       [Estado] = @Estado
       WHERE ClienteId= @ClienteId