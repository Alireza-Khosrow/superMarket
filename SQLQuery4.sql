CREATE TABLE [dbo].[sellerTable] (
    [sellerId]    INT          NOT NULL,
    [sellerName]  VARCHAR (50) NOT NULL,
    [sellerAge]   INT          NOT NULL,
    [sellerPhone] VARCHAR (50) NOT NULL,
    [sellerPass]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([sellerId] ASC)
);

