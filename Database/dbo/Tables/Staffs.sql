CREATE TABLE [dbo].[Staffs] (
    [Staff_Id]   UNIQUEIDENTIFIER CONSTRAINT [DF_Staffs_Staff_Id] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [First_Name] NVARCHAR (50)    NOT NULL,
    [Last_Name]  NVARCHAR (50)    NOT NULL,
    [Bod]        NVARCHAR (20)    NOT NULL,
    [Education]  NVARCHAR (20)    NOT NULL,
    [Origin]     NVARCHAR (20)    NOT NULL,
    [Religion]   NVARCHAR (20)    NOT NULL,
    CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED ([Staff_Id] ASC)
);

