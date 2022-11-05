CREATE TABLE [dbo].[Cargo] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (250) NULL,
    CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED ([Id] ASC)
);

