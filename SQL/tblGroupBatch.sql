USE [v1_groups]
GO

/****** Object:  Table [dbo].[tblGroupBatch]    Script Date: 01/06/2018 09:46:50 ******/
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
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Bi_MonthDate1] [int] NULL,
	[Bi_MonthDate2] [int] NULL,
	[MonthDate] [int] NULL,
	[Amount] [money] null,
	[UserCount] [int] null,
	[Status] [smallint] NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblGroupBatch] ADD  CONSTRAINT [DF_tblGroupBatch_Status]  DEFAULT ((1)) FOR [Status]
GO


