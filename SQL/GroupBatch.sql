USE [v1_groups]
GO

/****** Object:  Table [dbo].[tblGroupBatch]    Script Date: 01/03/2018 09:34:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblGroupBatch](
	[BatchID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NULL,
	[BatchName] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[EndDate] [datetime] NULL,
	[Bi_MonthDate1] [int] NULL,
	[Bi_MonthDate2] [int] NULL,
	[MonthDate] [int] NULL,
	[Status] [smallint] NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


