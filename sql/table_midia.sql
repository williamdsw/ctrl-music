CREATE TABLE [dbo].[MIDIA] (
    [COD_MIDIA]      INT             IDENTITY (1, 1) NOT NULL,
    [NOME]           VARCHAR (150)   NOT NULL,
    [GENERO]         VARCHAR (50)    NOT NULL,
    [ANO_LANCAMENTO] INT             NOT NULL,
    [ARTISTA]        VARCHAR (100)   NOT NULL,
    [MARCA]          VARCHAR (50)    NOT NULL,
    [QUANTIDADE]     INT             NOT NULL,
    [DURACAO]        VARCHAR (20)    NOT NULL,
    [PRECO]          NUMERIC (10, 2) NOT NULL,
    [IDIOMA]         VARCHAR (50)    NOT NULL,
    [TIPO]           VARCHAR (15)    NOT NULL,
    [ESTADO]         VARCHAR (15)    NOT NULL,
    [ALTURA]         VARCHAR (20)    NULL,
    [LARGURA]        VARCHAR (20)    NULL,
    [PROFUNDIDADE]   VARCHAR (20)    NULL,
    [PESO]           VARCHAR (20)    NULL,
    [IMGCAM]         VARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([COD_MIDIA] ASC)
);

