CREATE TABLE [dbo].[UserManagements] (
    [PersonalName]       NVARCHAR (MAX) NULL,
    [PersonalSurname]    NVARCHAR (MAX) NULL,
    [PersonalPassword]   INT            DEFAULT ((0)) NOT NULL,
    [PersonalCreateDate] INT            DEFAULT ((0)) NOT NULL,
    [PersonalRole]       NVARCHAR (MAX) NULL,
    [TicketMoney]        INT            NOT NULL,
    [ID]                 INT            IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_UserManagements] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO

