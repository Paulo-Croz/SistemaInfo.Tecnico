USE [ListaAPI]
GO

/****** Object: Table [dbo].[Lista] Script Date: 13/08/2021 00:22:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lista] (
    [Latitude]  DECIMAL (15, 9) NOT NULL,
    [Longitude] DECIMAL (15, 9) NOT NULL,
    [Motorista] VARCHAR (100)   NOT NULL,
    [Cidade]    VARCHAR (100)   NOT NULL,
    [Nota]      INT             NOT NULL,
    [Contrato]  INT             NOT NULL
);


