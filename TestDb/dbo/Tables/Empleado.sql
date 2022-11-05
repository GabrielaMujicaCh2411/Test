CREATE TABLE [dbo].[Empleado] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [Nombre]          NVARCHAR (250)  NULL,
    [Apellidos]       NVARCHAR (250)  NULL,
    [FechaNacimiento] DATETIME        NULL,
    [FechaIngreso]    DATETIME        NULL,
    [IdCargo]         INT             NULL,
    [Sueldo]          DECIMAL (18, 2) NULL,
    [AFP]             NVARCHAR (50)   NULL,
    CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Empleado_Cargo] FOREIGN KEY ([Id]) REFERENCES [dbo].[Cargo] ([Id])
);



