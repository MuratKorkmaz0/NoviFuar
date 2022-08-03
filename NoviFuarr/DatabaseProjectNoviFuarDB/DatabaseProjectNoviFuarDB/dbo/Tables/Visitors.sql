CREATE TABLE [dbo].[Visitors] (
    [ID]       INT           NOT NULL,
    [Name]     NVARCHAR (10) NULL,
    [Surname]  NVARCHAR (10) NULL,
    [BarCodes] IMAGE         NULL,
    CONSTRAINT [PK_Visitor] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO

