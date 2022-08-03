CREATE TABLE [dbo].[BarCode] (
    [BarCodeID] INT   NOT NULL,
    [BarCodes]  IMAGE NULL,
    CONSTRAINT [PK_BarCode] PRIMARY KEY CLUSTERED ([BarCodeID] ASC)
);


GO

