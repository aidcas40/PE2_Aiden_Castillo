CREATE TABLE [dbo].[Product] (
    [ProdId]      INT          IDENTITY (1, 1) NOT NULL,
    [ProdName]    VARCHAR (50) NULL,
    [ProdDesc]     VARCHAR(100)        NULL,
    [ProdMfr]     VARCHAR (50) NULL,
    [ProdCtgy]    VARCHAR (50) NULL,
    [ProdPrice]   MONEY        NULL,
    [ProdQty]     INT          NULL,
    [ProdRelDate] DATE         NULL,
    [ProdRecDate] DATE         NULL,
    PRIMARY KEY CLUSTERED ([ProdId] ASC)
);