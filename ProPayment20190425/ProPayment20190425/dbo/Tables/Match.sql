﻿CREATE TABLE [dbo].[Match] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [MatchDateTime]  DATETIME2 (7)  NOT NULL,
    [Arena]          NVARCHAR (MAX) NULL,
    [HomeTeam]       NVARCHAR (MAX) NULL,
    [AwayTeam]       NVARCHAR (MAX) NULL,
    [ScoreHomeTeam]  INT            NULL,
    [ScoreAwayTeam]  INT            NULL,
    [Ref1]           NVARCHAR (MAX) NULL,
    [Ref2]           NVARCHAR (MAX) NULL,
    [Ref3]           NVARCHAR (MAX) NULL,
    [Ref4]           NVARCHAR (MAX) NULL,
    [MatchNumberTSM] INT            NULL,
    CONSTRAINT [PK_Match] PRIMARY KEY CLUSTERED ([Id] ASC)
);

