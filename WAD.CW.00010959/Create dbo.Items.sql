USE [MyDatabase]
GO

/****** Object: Table [dbo].[Items] Script Date: 4/7/2023 11:52:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Items] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (50)  NOT NULL,
    [Description]  NVARCHAR (500) NULL,
    [Quantity]     INT            NOT NULL,
    [IsPurchased]  BIT            NOT NULL,
    [PurchaseDate] DATE           NOT NULL,
    [ListId]       INT            NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Items_ListId]
    ON [dbo].[Items]([ListId] ASC);


GO
ALTER TABLE [dbo].[Items]
    ADD CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[Items]
    ADD CONSTRAINT [FK_Items_Lists_ListId] FOREIGN KEY ([ListId]) REFERENCES [dbo].[Lists] ([Id]) ON DELETE CASCADE;


	USE [MyDatabase]
GO

/****** Object: Table [dbo].[Lists] Script Date: 4/7/2023 11:52:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lists] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [CreatedDate] DATE           NOT NULL
);


