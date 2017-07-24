USE [DHCurbside]
GO

/****** Object:  Table [dbo].[Provider]    Script Date: 7/22/2017 9:16:47 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WhitelistEmail](
	[WhitelistEmailId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetimeoffset](7) NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL,
	[ModifiedDate] [datetimeoffset](7) NOT NULL,
	[DeactivatedDate] [datetimeoffset](7) NULL,
 CONSTRAINT [PK_WhitelistEmail] PRIMARY KEY CLUSTERED 
(
	[WhitelistEmailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO