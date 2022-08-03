CREATE TABLE [dbo].[PersonalManagement] (
    [ID]               INT           NOT NULL,
    [PersonalName]     NVARCHAR (10) NULL,
    [PersonalSurname]  NVARCHAR (10) NULL,
    [PersonalRole]     NVARCHAR (10) NULL,
    [PersonalPassword] INT           NULL,
    [CreateDate]       INT           NULL,
    [TicketMoney]      INT           NULL
);


GO