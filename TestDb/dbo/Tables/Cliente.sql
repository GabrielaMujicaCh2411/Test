CREATE TABLE [dbo].[Cliente] (
    [ClienteId]        INT           NOT NULL,
    [Nombre]           NVARCHAR (50) NULL,
    [Apellido]         NVARCHAR (50) NULL,
    [TipoCliente]      INT           NULL,
    [SituacionLaboral] NVARCHAR (50) NULL,
    [Estado]           INT           NULL,
    [IdClienteCompras] INT           NULL,
    CONSTRAINT [PK_dbo.Cliente] PRIMARY KEY CLUSTERED ([ClienteId] ASC)
);

