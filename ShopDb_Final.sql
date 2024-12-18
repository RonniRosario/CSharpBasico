USE [master]
GO
/****** Object:  Database [ShopDb]    Script Date: 12/10/2024 9:58:25 PM ******/
CREATE DATABASE [ShopDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ShopDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ShopDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ShopDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ShopDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ShopDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopDb] SET  MULTI_USER 
GO
ALTER DATABASE [ShopDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShopDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShopDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ShopDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [ShopDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ShopDb]
GO
/****** Object:  User [shopUser]    Script Date: 12/10/2024 9:58:25 PM ******/
CREATE USER [shopUser] FOR LOGIN [shopUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [shopUser]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12/10/2024 9:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[categoryid] [int] IDENTITY(1,1) NOT NULL,
	[categoryname] [nvarchar](15) NOT NULL,
	[description] [nvarchar](200) NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[creation_user] [int] NOT NULL,
	[modify_date] [datetime] NULL,
	[modify_user] [int] NULL,
	[delete_user] [int] NULL,
	[delete_date] [datetime] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[categoryid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/10/2024 9:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[custid] [int] IDENTITY(1,1) NOT NULL,
	[companyname] [nvarchar](40) NOT NULL,
	[contactname] [nvarchar](30) NOT NULL,
	[contacttitle] [nvarchar](30) NOT NULL,
	[address] [nvarchar](60) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[city] [nvarchar](15) NOT NULL,
	[region] [nvarchar](15) NULL,
	[postalcode] [nvarchar](10) NULL,
	[country] [nvarchar](15) NOT NULL,
	[phone] [nvarchar](24) NOT NULL,
	[fax] [nvarchar](24) NULL,
	[creation_date] [datetime] NOT NULL,
	[creation_user] [int] NOT NULL,
	[modify_date] [datetime] NULL,
	[modify_user] [int] NULL,
	[delete_user] [int] NULL,
	[delete_date] [datetime] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[custid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 12/10/2024 9:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[empid] [int] IDENTITY(1,1) NOT NULL,
	[lastname] [nvarchar](20) NOT NULL,
	[firstname] [nvarchar](10) NOT NULL,
	[title] [nvarchar](30) NOT NULL,
	[titleofcourtesy] [nvarchar](25) NOT NULL,
	[birthdate] [datetime] NOT NULL,
	[hiredate] [datetime] NOT NULL,
	[address] [nvarchar](60) NOT NULL,
	[city] [nvarchar](15) NOT NULL,
	[region] [nvarchar](15) NULL,
	[postalcode] [nvarchar](10) NULL,
	[country] [nvarchar](15) NOT NULL,
	[phone] [nvarchar](24) NOT NULL,
	[mgrid] [int] NULL,
	[creation_date] [datetime] NOT NULL,
	[creation_user] [int] NOT NULL,
	[modify_date] [datetime] NULL,
	[modify_user] [int] NULL,
	[delete_user] [int] NULL,
	[delete_date] [datetime] NULL,
	[deleted] [bit] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 12/10/2024 9:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[orderid] [int] NOT NULL,
	[productid] [int] NOT NULL,
	[unitprice] [money] NOT NULL,
	[qty] [smallint] NOT NULL,
	[discount] [numeric](4, 3) NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[orderid] ASC,
	[productid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/10/2024 9:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[orderid] [int] IDENTITY(1,1) NOT NULL,
	[custid] [int] NULL,
	[empid] [int] NOT NULL,
	[orderdate] [datetime] NOT NULL,
	[requireddate] [datetime] NOT NULL,
	[shippeddate] [datetime] NULL,
	[shipperid] [int] NOT NULL,
	[freight] [money] NOT NULL,
	[shipname] [nvarchar](40) NOT NULL,
	[shipaddress] [nvarchar](60) NOT NULL,
	[shipcity] [nvarchar](15) NOT NULL,
	[shipregion] [nvarchar](15) NULL,
	[shippostalcode] [nvarchar](10) NULL,
	[shipcountry] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/10/2024 9:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[productid] [int] IDENTITY(1,1) NOT NULL,
	[productname] [nvarchar](40) NOT NULL,
	[supplierid] [int] NOT NULL,
	[categoryid] [int] NOT NULL,
	[unitprice] [money] NOT NULL,
	[discontinued] [bit] NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[creation_user] [int] NOT NULL,
	[modify_date] [datetime] NULL,
	[modify_user] [int] NULL,
	[delete_user] [int] NULL,
	[delete_date] [datetime] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[productid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shippers]    Script Date: 12/10/2024 9:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shippers](
	[shipperid] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](40) NOT NULL,
	[phone] [nvarchar](24) NOT NULL,
	[address] [nvarchar](60) NULL,
	[city] [nvarchar](60) NULL,
	[region] [nvarchar](15) NULL,
	[postalcode] [varchar](10) NULL,
	[country] [int] NULL,
	[creation_date] [datetime] NOT NULL,
	[creation_user] [int] NOT NULL,
	[modify_date] [datetime] NULL,
	[modify_user] [int] NULL,
	[delete_user] [int] NULL,
	[delete_date] [int] NULL,
	[deleted] [bit] NULL,
 CONSTRAINT [PK_Shippers] PRIMARY KEY CLUSTERED 
(
	[shipperid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 12/10/2024 9:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[supplierid] [int] IDENTITY(1,1) NOT NULL,
	[companyname] [nvarchar](40) NOT NULL,
	[contactname] [nvarchar](30) NOT NULL,
	[contacttitle] [nvarchar](30) NOT NULL,
	[address] [nvarchar](60) NOT NULL,
	[city] [nvarchar](15) NOT NULL,
	[region] [nvarchar](15) NULL,
	[postalcode] [nvarchar](10) NULL,
	[country] [nvarchar](15) NOT NULL,
	[phone] [nvarchar](24) NOT NULL,
	[fax] [nvarchar](24) NULL,
	[creation_date] [datetime] NOT NULL,
	[creation_user] [int] NOT NULL,
	[modify_date] [datetime] NULL,
	[modify_user] [int] NULL,
	[delete_user] [int] NULL,
	[delete_date] [datetime] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[supplierid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (1, N'Acme Corporation', N'John Doe', N'Sales Manager', N'1234 Elm St.', N'micompay@micompany.com', N'Los Angeles', N'California', N'90001', N'USA', N'213-555-1234', N'213-555-5678', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 1, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (2, N'Beta Solutions', N'Sarah Lee', N'Marketing Director', N'5678 Maple Ave.', N'micompay@micompany.com', N'San Francisco', N'California', N'94105', N'USA', N'415-555-2345', N'415-555-6789', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 2, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (3, N'Gamma Industries', N'Carlos Garcia', N'Chief Executive Officer', N'9101 Pine Rd.', N'micompay@micompany.com', N'Chicago', N'Illinois', N'60601', N'USA', N'312-555-3456', N'312-555-7890', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 3, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (4, N'Delta Enterprises', N'Emma White', N'Operations Manager', N'2345 Oak Blvd.', N'micompay@micompany.com', N'New York', N'New York', N'10001', N'USA', N'212-555-4567', N'212-555-8901', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 4, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (5, N'Epsilon LLC', N'David Black', N'Project Lead', N'6789 Birch Dr.', N'micompay@micompany.com', N'Miami', N'Florida', N'33101', N'USA', N'305-555-5678', N'305-555-0123', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 5, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (6, N'Zeta Innovations', N'Olivia Brown', N'Product Manager', N'1357 Cedar Ln.', N'micompay@micompany.com', N'Houston', N'Texas', N'77001', N'USA', N'713-555-6789', N'713-555-1234', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 6, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (7, N'Eta Enterprises', N'William Johnson', N'Chief Operating Officer', N'2468 Pine St.', N'micompay@micompany.com', N'Dallas', N'Texas', N'75201', N'USA', N'214-555-7890', N'214-555-2345', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 7, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (8, N'Theta Solutions', N'Sophia Martinez', N'Customer Support Lead', N'3690 Oakwood Ave.', N'micompay@micompany.com', N'Phoenix', N'Arizona', N'85001', N'USA', N'602-555-8901', N'602-555-3456', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 8, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (9, N'Iota Technologies', N'Lucas Lee', N'Business Development Manager', N'4820 Willow Rd.', N'micompay@micompany.com', N'Denver', N'Colorado', N'80201', N'USA', N'303-555-9012', N'303-555-4567', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 9, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Customers] ([custid], [companyname], [contactname], [contacttitle], [address], [email], [city], [region], [postalcode], [country], [phone], [fax], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (10, N'Kappa Co.', N'Ava Harris', N'Finance Director', N'5831 Redwood Dr.', N'micompay@micompany.com', N'Seattle', N'Washington', N'98101', N'USA', N'206-555-0123', N'206-555-6789', CAST(N'2024-12-10T21:11:27.450' AS DateTime), 10, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (1, N'Smith', N'Martin', N'Manager', N'Mr.', CAST(N'1985-06-15T00:00:00.000' AS DateTime), CAST(N'2010-03-01T00:00:00.000' AS DateTime), N'123 Main St', N'New York', N'NY', N'10001', N'USA', N'123-456-7890', 1, CAST(N'2024-12-10T19:58:03.877' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (2, N'Doe', N'Jane', N'Assistant Manager', N'Ms.', CAST(N'1990-07-20T00:00:00.000' AS DateTime), CAST(N'2015-06-15T00:00:00.000' AS DateTime), N'456 Elm St', N'Los Angeles', N'CA', N'90001', N'USA', N'987-654-3210', 2, CAST(N'2024-12-10T16:54:30.710' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (3, N'Brown', N'Charlie', N'Clerk', N'Mr.', CAST(N'1995-02-25T00:00:00.000' AS DateTime), CAST(N'2019-01-10T00:00:00.000' AS DateTime), N'789 Maple Ave', N'Chicago', N'IL', N'60601', N'USA', N'456-789-0123', 3, CAST(N'2024-12-10T16:54:30.710' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (4, N'Johnson', N'Emily', N'Sales Representative', N'Ms.', CAST(N'1987-08-30T00:00:00.000' AS DateTime), CAST(N'2011-05-20T00:00:00.000' AS DateTime), N'321 Oak St', N'Houston', N'TX', N'77001', N'USA', N'321-654-9870', 4, CAST(N'2024-12-10T16:54:30.710' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (5, N'Williams', N'Michael', N'Technician', N'Mr.', CAST(N'1992-11-15T00:00:00.000' AS DateTime), CAST(N'2017-09-05T00:00:00.000' AS DateTime), N'654 Pine St', N'Phoenix', N'AZ', N'85001', N'USA', N'789-123-4567', 5, CAST(N'2024-12-10T16:54:30.710' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (6, N'Taylor', N'Sophia', N'Engineer', N'Ms.', CAST(N'1998-01-10T00:00:00.000' AS DateTime), CAST(N'2021-02-01T00:00:00.000' AS DateTime), N'987 Cedar St', N'Philadelphia', N'PA', N'19101', N'USA', N'123-987-6543', 6, CAST(N'2024-12-10T16:54:30.710' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (7, N'Harris', N'James', N'Analyst', N'Mr.', CAST(N'1993-05-25T00:00:00.000' AS DateTime), CAST(N'2018-04-15T00:00:00.000' AS DateTime), N'147 Birch St', N'San Antonio', N'TX', N'78201', N'USA', N'654-321-0987', 7, CAST(N'2024-12-10T16:54:30.710' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (8, N'Clark', N'Mia', N'Consultant', N'Ms.', CAST(N'1989-10-05T00:00:00.000' AS DateTime), CAST(N'2014-07-10T00:00:00.000' AS DateTime), N'258 Walnut Ave', N'Dallas', N'TX', N'75201', N'USA', N'789-654-3210', 8, CAST(N'2024-12-10T16:54:30.710' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (9, N'Lewis', N'Ethan', N'Developer', N'Mr.', CAST(N'1996-03-15T00:00:00.000' AS DateTime), CAST(N'2020-11-01T00:00:00.000' AS DateTime), N'369 Poplar Blvd', N'San Diego', N'CA', N'92101', N'USA', N'321-789-6540', 9, CAST(N'2024-12-10T16:54:30.710' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (10, N'Walker', N'Olivia', N'Accountant', N'Ms.', CAST(N'1988-12-25T00:00:00.000' AS DateTime), CAST(N'2012-08-20T00:00:00.000' AS DateTime), N'852 Fir Ln', N'San Jose', N'CA', N'95101', N'USA', N'456-123-7890', 10, CAST(N'2024-12-10T16:54:30.710' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (24, N'Rosario Sánchez', N'Ronni', N'Sales Manager', N'Mr', CAST(N'1999-04-12T15:06:00.000' AS DateTime), CAST(N'2021-12-03T05:08:00.000' AS DateTime), N'calle jesus', N'santo domingo', NULL, NULL, N'China', N'8092929132', NULL, CAST(N'2024-12-10T18:39:04.317' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (33, N'Smith', N'John', N'Manager', N'Manager', CAST(N'1985-06-15T00:00:00.000' AS DateTime), CAST(N'2010-03-01T00:00:00.000' AS DateTime), N'123 Main', N'New York', NULL, NULL, N'USA', N'123-456-7890', NULL, CAST(N'2024-12-10T19:19:04.943' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Employees] ([empid], [lastname], [firstname], [title], [titleofcourtesy], [birthdate], [hiredate], [address], [city], [region], [postalcode], [country], [phone], [mgrid], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (34, N'Brown', N'Charlie', N'Clerk', N'Mr.', CAST(N'1995-02-25T00:00:00.000' AS DateTime), CAST(N'2019-01-10T00:00:00.000' AS DateTime), N'789 Maple ', N'Chicago', NULL, NULL, N'USA', N'456-789-0123', NULL, CAST(N'2024-12-10T19:20:52.790' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (1, N'Coca-Cola-Zero ', 0, 0, 0.8000, 0, CAST(N'2024-12-10T19:44:13.757' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (2, N'Pepsi Zero', 0, 0, 0.7000, 0, CAST(N'2024-12-10T15:25:32.487' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (3, N'Doritos Nacho Cheese', 2, 2, 2.5000, 0, CAST(N'2024-12-10T11:10:47.997' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (4, N'Lays Classic', 2, 2, 2.2500, 0, CAST(N'2024-12-10T11:10:47.997' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (5, N'KitKat ', 3, 3, 1.1000, 0, CAST(N'2024-12-10T11:10:47.997' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (6, N'Snickers', 3, 3, 1.2000, 0, CAST(N'2024-12-10T11:10:47.997' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (7, N'Leche Entera', 4, 4, 1.5000, 0, CAST(N'2024-12-10T11:10:47.997' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (8, N'Huevos Dozen', 5, 4, 2.7500, 0, CAST(N'2024-12-10T11:10:47.997' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (9, N'Pan de Molde', 6, 5, 1.8000, 0, CAST(N'2024-12-10T11:10:47.997' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (10, N'Mantequilla ', 7, 5, 2.2000, 0, CAST(N'2024-12-10T11:10:47.997' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Products] ([productid], [productname], [supplierid], [categoryid], [unitprice], [discontinued], [creation_date], [creation_user], [modify_date], [modify_user], [delete_user], [delete_date], [deleted]) VALUES (11, N'Galleticas Dino', 1, 1, 1.2300, 0, CAST(N'2024-12-10T15:39:06.190' AS DateTime), 1, NULL, NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [DF_Categories_creation_date]  DEFAULT (getdate()) FOR [creation_date]
GO
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [DF_Categories_creation_user]  DEFAULT ((1)) FOR [creation_user]
GO
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [DF_Categories_deleted]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customers_email]  DEFAULT (N'micompay@micompany.com') FOR [email]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DEFAULT_Customers_creation_date]  DEFAULT (getdate()) FOR [creation_date]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DEFAULT_Customers_creation_user]  DEFAULT ((1)) FOR [creation_user]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DEFAULT_Customers_deleted]  DEFAULT ((1)) FOR [deleted]
GO
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [DEFAULT_Employees_creation_date]  DEFAULT (getdate()) FOR [creation_date]
GO
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [DEFAULT_Employees_creation_user]  DEFAULT ((1)) FOR [creation_user]
GO
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [DEFAULT_Employees_deleted]  DEFAULT ((1)) FOR [deleted]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DFT_OrderDetails_unitprice]  DEFAULT ((0)) FOR [unitprice]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DFT_OrderDetails_qty]  DEFAULT ((1)) FOR [qty]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DFT_OrderDetails_discount]  DEFAULT ((0)) FOR [discount]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DFT_Orders_freight]  DEFAULT ((0)) FOR [freight]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DFT_Products_unitprice]  DEFAULT ((0)) FOR [unitprice]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DFT_Products_discontinued]  DEFAULT ((0)) FOR [discontinued]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_creation_date]  DEFAULT (getdate()) FOR [creation_date]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_creation_user]  DEFAULT ((1)) FOR [creation_user]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_deleted]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[Shippers] ADD  CONSTRAINT [DEFAULT_Shippers_creation_date]  DEFAULT (getdate()) FOR [creation_date]
GO
ALTER TABLE [dbo].[Shippers] ADD  CONSTRAINT [DEFAULT_Shippers_creation_user]  DEFAULT ((1)) FOR [creation_user]
GO
ALTER TABLE [dbo].[Suppliers] ADD  CONSTRAINT [DF_Suppliers_creation_date]  DEFAULT (getdate()) FOR [creation_date]
GO
ALTER TABLE [dbo].[Suppliers] ADD  CONSTRAINT [DF_Suppliers_creation_user]  DEFAULT ((1)) FOR [creation_user]
GO
ALTER TABLE [dbo].[Suppliers] ADD  CONSTRAINT [DF_Suppliers_deleted]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Employees] FOREIGN KEY([mgrid])
REFERENCES [dbo].[Employees] ([empid])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Employees]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [CHK_birthdate] CHECK  (([birthdate]<=getdate()))
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [CHK_birthdate]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [CHK_discount] CHECK  (([discount]>=(0) AND [discount]<=(1)))
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [CHK_discount]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [CHK_qty] CHECK  (([qty]>(0)))
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [CHK_qty]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [CHK_unitprice] CHECK  (([unitprice]>=(0)))
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [CHK_unitprice]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [CHK_Products_unitprice] CHECK  (([unitprice]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CHK_Products_unitprice]
GO
USE [master]
GO
ALTER DATABASE [ShopDb] SET  READ_WRITE 
GO
