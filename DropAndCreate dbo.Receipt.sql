USE [ProPaymentContext-f0b6c6cf-6a2d-43f1-a2b4-98b344f914a6]
GO

/****** Object: Table [dbo].[Receipt] Script Date: 2019-04-30 09:38:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Receipt];


GO
CREATE TABLE [dbo].[Receipt] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [MatchDateTime]  DATETIME2 (7)  NOT NULL,
    [HockeyMatchId]  INT            NULL,
    [RefereeId]      INT            NULL,
    [MatchName]      NVARCHAR (MAX) NULL,
    [Fee]            FLOAT (53)     NULL,
    [Alowence]       FLOAT (53)     NULL,
    [TravelCost]     FLOAT (53)     NULL,
    [LateMatchStart] FLOAT (53)     NULL,
    [TotalPayment]   FLOAT (53)     NULL,
    [ArenaId]        INT  NULL,
    [TravelDistance] FLOAT (53)     NULL,
    [TravelFee]      FLOAT (53)     NULL
);


