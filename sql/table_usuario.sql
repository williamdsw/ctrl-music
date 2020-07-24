﻿CREATE TABLE [dbo].[USUARIO] (
    [COD_USUARIO] INT			   IDENTITY(1,1) NOT NULL,
    [USUARIO]         VARCHAR (10) NOT NULL,
    [SENHA]           VARCHAR (10) NOT NULL,
    [CSENHA]          VARCHAR (10) NOT NULL,
    [ADMINISTRADOR]   BIT          NULL,
	[COD_FUNCIONARIO] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([COD_USUARIO] ASC), 
    CONSTRAINT [FK_USUARIO_1] FOREIGN KEY ([COD_FUNCIONARIO]) REFERENCES [FUNCIONARIO] ([COD_FUNCIONARIO])
);

