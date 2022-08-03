CREATE TABLE [dbo].[UserRoles] (
    [Admin]                NVARCHAR (450) NOT NULL,
    [EntranceAttendant]    NVARCHAR (MAX) NULL,
    [ID]                   INT            DEFAULT ((0)) NOT NULL,
    [personalManagementID] INT            NULL,
    CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED ([Admin] ASC),
    CONSTRAINT [FK_UserRoles_UserManagements_personalManagementID] FOREIGN KEY ([personalManagementID]) REFERENCES [dbo].[UserManagements] ([ID])
);


GO

CREATE NONCLUSTERED INDEX [IX_UserRoles_personalManagementID]
    ON [dbo].[UserRoles]([personalManagementID] ASC);


GO

