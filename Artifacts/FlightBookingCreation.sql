USE [FlightBooking]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking]') AND type in (N'U'))
ALTER TABLE [dbo].[Booking] DROP CONSTRAINT IF EXISTS [FK_ticket]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking]') AND type in (N'U'))
ALTER TABLE [dbo].[Booking] DROP CONSTRAINT IF EXISTS [FK_customer]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 6/6/2020 3:47:29 PM ******/
DROP TABLE IF EXISTS [dbo].[Ticket]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 6/6/2020 3:47:29 PM ******/
DROP TABLE IF EXISTS [dbo].[Login]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/6/2020 3:47:29 PM ******/
DROP TABLE IF EXISTS [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 6/6/2020 3:47:29 PM ******/
DROP TABLE IF EXISTS [dbo].[Booking]
GO
USE [master]
GO
/****** Object:  Database [FlightBooking]    Script Date: 6/6/2020 3:47:29 PM ******/
DROP DATABASE IF EXISTS [FlightBooking]
GO
/****** Object:  Database [FlightBooking]    Script Date: 6/6/2020 3:47:29 PM ******/
CREATE DATABASE [FlightBooking]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FlightBooking', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FlightBooking.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FlightBooking_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FlightBooking_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FlightBooking] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FlightBooking].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FlightBooking] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FlightBooking] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FlightBooking] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FlightBooking] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FlightBooking] SET ARITHABORT OFF 
GO
ALTER DATABASE [FlightBooking] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FlightBooking] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FlightBooking] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FlightBooking] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FlightBooking] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FlightBooking] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FlightBooking] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FlightBooking] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FlightBooking] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FlightBooking] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FlightBooking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FlightBooking] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FlightBooking] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FlightBooking] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FlightBooking] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FlightBooking] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FlightBooking] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FlightBooking] SET RECOVERY FULL 
GO
ALTER DATABASE [FlightBooking] SET  MULTI_USER 
GO
ALTER DATABASE [FlightBooking] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FlightBooking] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FlightBooking] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FlightBooking] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FlightBooking] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FlightBooking', N'ON'
GO
ALTER DATABASE [FlightBooking] SET QUERY_STORE = OFF
GO
USE [FlightBooking]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 6/6/2020 3:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[CustomerID] [int] NOT NULL,
	[TicketID] [int] NOT NULL,
	[Subtotal] [decimal](6, 2) NOT NULL,
	[Tax] [decimal](6, 2) NOT NULL,
	[Total] [decimal](6, 2) NOT NULL,
	[DateBooked] [datetime] NOT NULL,
	[PaymentMethod] [varchar](50) NOT NULL,
	[IsPaid] [bit] NOT NULL,
	[Description] [varchar](150) NULL,
 CONSTRAINT [booking_pk] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC,
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/6/2020 3:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](25) NOT NULL,
	[MiddleName] [varchar](25) NULL,
	[LastName] [varchar](25) NOT NULL,
	[StreetNumber] [int] NOT NULL,
	[StreetName] [varchar](50) NOT NULL,
	[City] [varchar](25) NOT NULL,
	[Province] [varchar](25) NULL,
	[Country] [varchar](25) NOT NULL,
	[PostalCode] [varchar](15) NULL,
	[CellNumber] [varchar](20) NOT NULL,
	[HomeNumber] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 6/6/2020 3:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 6/6/2020 3:47:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[TicketID] [int] IDENTITY(1,1) NOT NULL,
	[DepartureTime] [datetime] NOT NULL,
	[ArrivalTime] [datetime] NOT NULL,
	[DepartureAirport] [varchar](100) NOT NULL,
	[ArrivalAirport] [varchar](100) NOT NULL,
	[StartPlace] [varchar](100) NOT NULL,
	[Destination] [varchar](100) NOT NULL,
	[MealIncluded] [bit] NOT NULL,
	[SeatType] [varchar](25) NOT NULL,
	[AirlinesName] [varchar](100) NOT NULL,
	[InitialPrice] [decimal](6, 2) NOT NULL,
	[Description] [varchar](150) NULL,
	[QuantityLeft] [int] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (1, 14, CAST(1000.45 AS Decimal(6, 2)), CAST(150.07 AS Decimal(6, 2)), CAST(1150.52 AS Decimal(6, 2)), CAST(N'2020-01-23T00:00:00.000' AS DateTime), N'Credit Card', 1, N'Will have the chance to be delayed.')
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (1, 15, CAST(678.99 AS Decimal(6, 2)), CAST(101.85 AS Decimal(6, 2)), CAST(780.84 AS Decimal(6, 2)), CAST(N'2020-05-31T15:15:10.000' AS DateTime), N'Debit Card', 0, N'Will be paid at June 1st 2020 by Scotiabank.')
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (2, 13, CAST(250.00 AS Decimal(6, 2)), CAST(37.50 AS Decimal(6, 2)), CAST(287.50 AS Decimal(6, 2)), CAST(N'2020-05-13T15:55:44.000' AS DateTime), N'Debit Card', 1, NULL)
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (3, 12, CAST(760.20 AS Decimal(6, 2)), CAST(114.03 AS Decimal(6, 2)), CAST(874.23 AS Decimal(6, 2)), CAST(N'2020-05-04T00:00:00.000' AS DateTime), N'PayPal', 1, NULL)
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (4, 12, CAST(760.20 AS Decimal(6, 2)), CAST(114.03 AS Decimal(6, 2)), CAST(874.23 AS Decimal(6, 2)), CAST(N'2020-06-19T13:45:17.000' AS DateTime), N'By Cash', 1, N'Will be paid at the airport.')
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (4, 14, CAST(1000.45 AS Decimal(6, 2)), CAST(150.07 AS Decimal(6, 2)), CAST(1150.52 AS Decimal(6, 2)), CAST(N'2020-04-04T00:00:00.000' AS DateTime), N'By Cash', 0, N'Will be paid at the airport in cash')
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (4, 19, CAST(490.00 AS Decimal(6, 2)), CAST(73.50 AS Decimal(6, 2)), CAST(563.50 AS Decimal(6, 2)), CAST(N'2020-06-25T13:43:44.000' AS DateTime), N'PayPal', 0, N'Is being processed by the bank.')
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (5, 12, CAST(760.20 AS Decimal(6, 2)), CAST(114.03 AS Decimal(6, 2)), CAST(874.23 AS Decimal(6, 2)), CAST(N'2020-02-14T15:11:25.000' AS DateTime), N'PayPal', 1, N'Is pending by PayPal')
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (8, 18, CAST(545.00 AS Decimal(6, 2)), CAST(81.75 AS Decimal(6, 2)), CAST(626.75 AS Decimal(6, 2)), CAST(N'2020-06-01T15:23:02.000' AS DateTime), N'Credit Card', 1, NULL)
INSERT [dbo].[Booking] ([CustomerID], [TicketID], [Subtotal], [Tax], [Total], [DateBooked], [PaymentMethod], [IsPaid], [Description]) VALUES (11, 17, CAST(999.99 AS Decimal(6, 2)), CAST(150.00 AS Decimal(6, 2)), CAST(1149.99 AS Decimal(6, 2)), CAST(N'2020-06-01T14:35:22.000' AS DateTime), N'Credit Card', 1, NULL)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (1, N'Nguyen', N'Son', N'Pham', 402, N'Glencairn Drive', N'Moncton', N'NB', N'Canada', N'E1G 1Y4', N'(506)875-8286', N'(506)865-2019', N'phsonnguyen@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (2, N'Michael', NULL, N'Dickerson', 200, N'Evergreen Drive', N'Moncton', N'NB', N'Canada', N'E1G 2G4', N'(506)875-0901', N'(506)876-2918', N'mikedickerson@outlook.com')
INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (3, N'Tokyo', N'San', N'Mangekyo', 1990, N'Harimoto Street', N'Tokyo', NULL, N'Japan', NULL, N'0982730192', N'0982739183', N'mangekyo.tokyo@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (4, N'Francesco', NULL, N'Bollipop', 123, N'Mountain Road', N'Moncton', N'NB', N'Canada', N'E1G Y7G', N'(506)875-0910', N'(506)865-9902', N'BolliFrank@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (5, N'Mangeko', N'Sanawa', N'Kyle', 231, N'Harika Street', N'Osaka', NULL, N'Japan', NULL, N'092837123', N'098273019', N'KyleSanMan@yahoo.com')
INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (7, N'Minh', N'Hoang', N'Tran', 729, N'Saosori Street', N'Osaka', NULL, N'Japan', NULL, N'0908548889', N'0916610701', N'minh.tranhoang@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (8, N'Huy', N'Thanh', N'Phan', 12, N'Hickery Lane', N'Toronto', N'Ontario', N'Canada', N'O9A E1T', N'(800)982-3928', N'(506)909-0092', N'ptthuy@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (9, N'Franklin', N'D.', N'Castle', 376, N'Drowney Street', N'Halifax', N'Nova Scotia', N'Canada', N'F2R 6Y5', N'098209103', N'098877092', N'CastleDFrank@yahoo.com')
INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (10, N'Tolousie', NULL, N'Lancaster', 231, N'Polymere Lane', N'Montreal', N'Quebec', N'Canada', N'E3T 4E2', N'(800)576-9381', N'(800)576-0923', N'LancasterTolousie@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [StreetNumber], [StreetName], [City], [Province], [Country], [PostalCode], [CellNumber], [HomeNumber], [Email]) VALUES (11, N'Nhi', N'Hoang', N'Tran', 103, N'Hashinama Street', N'Kyoto', NULL, N'Japan', NULL, N'0928309283', N'0918304923', N'thtnhi@gmail.com')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([UserID], [Username], [Password]) VALUES (1, N'nguyenpham', N'12345')
INSERT [dbo].[Login] ([UserID], [Username], [Password]) VALUES (2, N'ryanhiga', N'54321')
INSERT [dbo].[Login] ([UserID], [Username], [Password]) VALUES (3, N'flightcharles', N'13579')
INSERT [dbo].[Login] ([UserID], [Username], [Password]) VALUES (4, N'sophomoreplay', N'il9a1tb')
SET IDENTITY_INSERT [dbo].[Login] OFF
SET IDENTITY_INSERT [dbo].[Ticket] ON 

INSERT [dbo].[Ticket] ([TicketID], [DepartureTime], [ArrivalTime], [DepartureAirport], [ArrivalAirport], [StartPlace], [Destination], [MealIncluded], [SeatType], [AirlinesName], [InitialPrice], [Description], [QuantityLeft]) VALUES (12, CAST(N'2020-12-07T23:00:00.000' AS DateTime), CAST(N'2020-12-07T12:00:00.000' AS DateTime), N'NRT', N'YUL', N'Tokyo', N'Montreal', 1, N'Business', N'EVA', CAST(760.20 AS Decimal(6, 2)), N'This is a cheap ticket to go to Canada from Japan', 3)
INSERT [dbo].[Ticket] ([TicketID], [DepartureTime], [ArrivalTime], [DepartureAirport], [ArrivalAirport], [StartPlace], [Destination], [MealIncluded], [SeatType], [AirlinesName], [InitialPrice], [Description], [QuantityLeft]) VALUES (13, CAST(N'2020-10-07T23:00:00.000' AS DateTime), CAST(N'2020-11-07T01:00:00.000' AS DateTime), N'YUL', N'YQM', N'Montreal', N'Moncton', 0, N'Economy', N'AC', CAST(250.00 AS Decimal(6, 2)), N'This is the only night flight from Montreal to Moncton', 12)
INSERT [dbo].[Ticket] ([TicketID], [DepartureTime], [ArrivalTime], [DepartureAirport], [ArrivalAirport], [StartPlace], [Destination], [MealIncluded], [SeatType], [AirlinesName], [InitialPrice], [Description], [QuantityLeft]) VALUES (14, CAST(N'2020-08-06T07:55:00.000' AS DateTime), CAST(N'2020-08-06T12:00:00.000' AS DateTime), N'NRT', N'YYZ', N'Tokyo', N'Toronto', 1, N'First Class', N'ANA', CAST(1000.45 AS Decimal(6, 2)), N'This is the first flight from Japan to Toronto after the COVID-19 pandemic', 50)
INSERT [dbo].[Ticket] ([TicketID], [DepartureTime], [ArrivalTime], [DepartureAirport], [ArrivalAirport], [StartPlace], [Destination], [MealIncluded], [SeatType], [AirlinesName], [InitialPrice], [Description], [QuantityLeft]) VALUES (15, CAST(N'2020-06-02T21:13:31.000' AS DateTime), CAST(N'2020-06-02T15:30:31.000' AS DateTime), N'YUL', N'NRT', N'Montreal', N'Tokyo', 1, N'Economy', N'ANA', CAST(678.99 AS Decimal(6, 2)), NULL, 23)
INSERT [dbo].[Ticket] ([TicketID], [DepartureTime], [ArrivalTime], [DepartureAirport], [ArrivalAirport], [StartPlace], [Destination], [MealIncluded], [SeatType], [AirlinesName], [InitialPrice], [Description], [QuantityLeft]) VALUES (17, CAST(N'2020-07-03T16:05:47.000' AS DateTime), CAST(N'2020-07-03T12:05:47.000' AS DateTime), N'YVR', N'ITM', N'Vancouver', N'Osaka', 1, N'Premium Economy', N'EVA', CAST(999.99 AS Decimal(6, 2)), N'The only flight from Vancouver to Osaka', 10)
INSERT [dbo].[Ticket] ([TicketID], [DepartureTime], [ArrivalTime], [DepartureAirport], [ArrivalAirport], [StartPlace], [Destination], [MealIncluded], [SeatType], [AirlinesName], [InitialPrice], [Description], [QuantityLeft]) VALUES (18, CAST(N'2020-06-27T13:25:02.000' AS DateTime), CAST(N'2020-06-27T19:25:02.000' AS DateTime), N'YYZ', N'YQM', N'Toronto', N'Moncton', 0, N'Economy', N'WJA', CAST(545.00 AS Decimal(6, 2)), N'First flight of the evening to Moncton (small jet).', 2)
INSERT [dbo].[Ticket] ([TicketID], [DepartureTime], [ArrivalTime], [DepartureAirport], [ArrivalAirport], [StartPlace], [Destination], [MealIncluded], [SeatType], [AirlinesName], [InitialPrice], [Description], [QuantityLeft]) VALUES (19, CAST(N'2020-07-09T20:50:13.000' AS DateTime), CAST(N'2020-07-10T01:30:13.000' AS DateTime), N'YYZ', N'YHZ', N'Toronto', N'Halifax', 0, N'Economy', N'EVA', CAST(490.00 AS Decimal(6, 2)), N'Night Flight from Toronto to Halifax', 9)
INSERT [dbo].[Ticket] ([TicketID], [DepartureTime], [ArrivalTime], [DepartureAirport], [ArrivalAirport], [StartPlace], [Destination], [MealIncluded], [SeatType], [AirlinesName], [InitialPrice], [Description], [QuantityLeft]) VALUES (20, CAST(N'2020-07-02T14:14:05.000' AS DateTime), CAST(N'2020-07-02T18:14:05.000' AS DateTime), N'YVR', N'HND', N'Vancouver', N'Toronto', 0, N'Economy', N'EVA', CAST(200.00 AS Decimal(6, 2)), NULL, 74)
SET IDENTITY_INSERT [dbo].[Ticket] OFF
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_customer]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_ticket] FOREIGN KEY([TicketID])
REFERENCES [dbo].[Ticket] ([TicketID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_ticket]
GO
USE [master]
GO
ALTER DATABASE [FlightBooking] SET  READ_WRITE 
GO