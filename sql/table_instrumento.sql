CREATE TABLE [dbo].[INSTRUMENTO] (
    [COD_INSTRUMENTO] INT             IDENTITY (1, 1) NOT NULL,
    [NOME]            VARCHAR (150)   NOT NULL,
    [DISTRIBUIDOR]    VARCHAR (100)   NOT NULL,
    [MARCA]           VARCHAR (100)   NOT NULL,
    [PRECO]           NUMERIC (10, 2) NOT NULL,
    [QUANTIDADE]      INT             NOT NULL,
    [MODELO]          VARCHAR (30)    NOT NULL,
    [TIPO]            VARCHAR (20)    NOT NULL,
    [INSTRUMENTO]     VARCHAR (20)    NOT NULL,
    [ESTADO]          VARCHAR (15)    NOT NULL,
    [COR]             VARCHAR (20)    NULL,
    [ALTURA]          VARCHAR (20)    NULL,
    [LARGURA]         VARCHAR (20)    NULL,
    [PROFUNDIDADE]    VARCHAR (20)    NULL,
    [PESO]            VARCHAR (20)    NULL,
    [IMGCAM]          VARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([COD_INSTRUMENTO] ASC)
);

