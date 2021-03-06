
/****** Object:  Table [dbo].[SubGroup]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('SubGroup','U')>0
DROP TABLE [SubGroup]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubGroup](
	[SubGroupID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [varchar](100) NOT NULL,
	[MainGroupID] [int] NULL,
	[EnteredDate] [datetime] NULL,
	[Contents] [varchar](max) NULL,
 CONSTRAINT [PK_SubGroup] PRIMARY KEY CLUSTERED 
(
	[SubGroupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Shop]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('Shop','U')>0
DROP TABLE [Shop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shop](
	[ShopID] [int] IDENTITY(1,1) NOT NULL,
	[ShopName] [varchar](100) NULL,
	[ShopAddress] [varchar](1000) NULL,
	[ShopPhone] [varchar](100) NULL,
	[ShopEmail] [varchar](1000) NULL,
	[ShopWeiXin] [varchar](100) NULL,
	[ShopQQ] [varchar](50) NULL,
	[ShopFax] [varchar](100) NULL,
 CONSTRAINT [PK_Shop] PRIMARY KEY CLUSTERED 
(
	[ShopID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrderSetting]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('OrderSetting','U')>0
DROP TABLE [OrderSetting]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrderSetting](
	[OrderSettingID] [int] IDENTITY(1,1) NOT NULL,
	[OrderTitle] [varchar](100) NULL,
	[Comment] [varchar](2000) NULL,
	[CommentTitle] [varchar](100) NULL,
 CONSTRAINT [PK_OrderSetting] PRIMARY KEY CLUSTERED 
(
	[OrderSettingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('Order','U')>0
DROP TABLE [Order]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[EnteredDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[Status] [varchar](100) NULL,
	[CreateDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[Comment] [varchar](5000) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[AdvanceAmount] [decimal](18, 2) NULL,
	[ExpendDays] [decimal](18, 2) NULL,
	[GroupContent] [varchar](max) NULL,
	[SubGroupID] [int] NULL,
	[GroupName] [varchar](100) NULL,
	[SubGroupName] [varchar](100) NULL,
	[GroupID] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据录入日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order', @level2type=N'COLUMN',@level2name=N'EnteredDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'订单状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'下单时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结单时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order', @level2type=N'COLUMN',@level2name=N'FinishDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order', @level2type=N'COLUMN',@level2name=N'Comment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'订单总金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order', @level2type=N'COLUMN',@level2name=N'TotalAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预付款，定金' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order', @level2type=N'COLUMN',@level2name=N'AdvanceAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本单耗费天数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order', @level2type=N'COLUMN',@level2name=N'ExpendDays'
GO
/****** Object:  Table [dbo].[MainGroup]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('MainGroup','U')>0
DROP TABLE [MainGroup]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MainGroup](
	[MainGroupID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [varchar](100) NOT NULL,
	[EnteredDate] [datetime] NULL,
 CONSTRAINT [PK_MainGroup] PRIMARY KEY CLUSTERED 
(
	[MainGroupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomFieldType]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('CustomFieldType','U')>0
DROP TABLE CustomFieldType
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomFieldType](
	[CustomFieldTypeID] [int] IDENTITY(1,1) NOT NULL,
	[CustomFieldTypeName] [varchar](100) NULL,
 CONSTRAINT [PK_CustomFieldType] PRIMARY KEY CLUSTERED 
(
	[CustomFieldTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomFieldDataList]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('CustomFieldDataList','U')>0
DROP TABLE [CustomFieldDataList]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomFieldDataList](
	[CustomFieldDataListID] [int] IDENTITY(1,1) NOT NULL,
	[CustomFieldItemName] [varchar](100) NULL,
	[CustomFieldID] [int] NULL,
 CONSTRAINT [PK_CustomFieldDataList] PRIMARY KEY CLUSTERED 
(
	[CustomFieldDataListID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自定义控件主键ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CustomFieldDataList', @level2type=N'COLUMN',@level2name=N'CustomFieldID'
GO
/****** Object:  Table [dbo].[CustomFieldData]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('CustomFieldData','U')>0
DROP TABLE [CustomFieldData]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomFieldData](
	[CustomFieldDataID] [int] IDENTITY(1,1) NOT NULL,
	[CustomFieldValue] [varchar](max) NULL,
	[EnteredDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[CustomFieldID] [int] NULL,
	[TableID] [int] NULL,
 CONSTRAINT [PK_CustomFieldData] PRIMARY KEY CLUSTERED 
(
	[CustomFieldDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自定义字段主键ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CustomFieldData', @level2type=N'COLUMN',@level2name=N'CustomFieldID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'具体实体数据的主键ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CustomFieldData', @level2type=N'COLUMN',@level2name=N'TableID'
GO
/****** Object:  Table [dbo].[CustomField]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('CustomField','U')>0
DROP TABLE [CustomField]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomField](
	[CustomFieldID] [int] IDENTITY(1,1) NOT NULL,
	[CustomFieldName] [varchar](100) NULL,
	[CustomFieldTypeID] [int] NULL,
	[EnteredDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[IsAlive] [bit] NULL,
	[CustomFieldDefaultValue] [varchar](100) NULL,
	[TableIndex] [int] NULL,
	[IsPrint] [bit] NULL,
 CONSTRAINT [PK_CustomField] PRIMARY KEY CLUSTERED 
(
	[CustomFieldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'表类型标示，客户表Customer：1， 订单表Order：2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CustomField', @level2type=N'COLUMN',@level2name=N'TableIndex'
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 02/13/2017 22:01:24 ******/

IF OBJECT_ID('Customer','U')>0
DROP TABLE [Customer]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](100) NULL,
	[CustomerPhone] [varchar](50) NULL,
	[EnteredDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[WeiXin] [varchar](100) NULL,
	[QQ] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Address] [varchar](200) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[V_GroupInfo]    Script Date: 02/13/2017 22:01:25 ******/

IF OBJECT_ID('V_GroupInfo','V')>0
DROP VIEW [V_GroupInfo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[V_GroupInfo]
as
SELECT     m.GroupName, sb.GroupName AS SubGroupName, sb.Contents,sb.SubGroupID
FROM         dbo.SubGroup AS sb LEFT OUTER JOIN
                      dbo.MainGroup AS m ON sb.MainGroupID = m.MainGroupID
GO