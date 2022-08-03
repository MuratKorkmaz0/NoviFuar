CREATE TABLE [dbo].[Visitors] (
    [VisitorID] INT            NOT NULL,
    [Name]      NVARCHAR (MAX) NULL,
    [Surname]   NVARCHAR (MAX) NULL,
    [BarCode]   INT            NULL,
    [barCodeID] INT            NULL,
    CONSTRAINT [PK_Visitors] PRIMARY KEY CLUSTERED ([VisitorID] ASC),
    CONSTRAINT [FK_Visitors_BarCodes_barCodeID] FOREIGN KEY ([barCodeID]) REFERENCES [dbo].[BarCodes] ([ID])
);


GO

CREATE NONCLUSTERED INDEX [IX_Visitors_barCodeID]
    ON [dbo].[Visitors]([barCodeID] ASC);


GO

