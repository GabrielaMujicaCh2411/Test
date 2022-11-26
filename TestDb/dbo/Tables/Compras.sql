CREATE TABLE [dbo].[Compras] (
    [ClienteId]    INT NOT NULL,
    [NumeroCompra] INT NULL,
    CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED ([ClienteId] ASC)
);

