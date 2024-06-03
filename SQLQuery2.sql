CREATE TABLE [dbo].[billTable] (
    [BillId]     INT           NOT NULL,
    [SellerName] NVARCHAR (50) NOT NULL,
    [billDate]   NVARCHAR (50) NOT NULL,
    [TotAmt]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([BillId] ASC)
);

