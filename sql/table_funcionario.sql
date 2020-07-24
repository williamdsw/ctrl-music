CREATE TABLE [dbo].[FUNCIONARIO] (
    [COD_FUNCIONARIO] INT           IDENTITY (1, 1) NOT NULL,
    [NOME]            VARCHAR (150) NOT NULL,
    [CPF]             VARCHAR (15)  NOT NULL,
    [RG]              VARCHAR (15)  NOT NULL,
    [DATA_NASCIMENTO] DATE          NOT NULL,
    [DATA_CADASTRO]   DATE          NOT NULL,
    [TURNO]           CHAR (1)      NOT NULL,
    [TEL_RESIDENCIAL] VARCHAR (15)  NOT NULL,
    [TEL_CELULAR]     VARCHAR (15)  NOT NULL,
    [EMAIL]           VARCHAR (50)  NOT NULL,
    [GENERO]          VARCHAR (10)  NOT NULL,
    [CARGO]           VARCHAR (30)  NOT NULL,
    [ENDERECO]        VARCHAR (200) NOT NULL,
    [BAIRRO]          VARCHAR (100) NOT NULL,
    [CIDADE]          VARCHAR (100) NOT NULL,
    [UF]              CHAR (2)      NOT NULL,
    [CEP]             VARCHAR (15)  NOT NULL,
    [IMGCAM]          VARCHAR (MAX)         NOT NULL,
    PRIMARY KEY CLUSTERED ([COD_FUNCIONARIO] ASC)
);

