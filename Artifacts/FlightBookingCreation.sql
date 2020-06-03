CREATE DATABASE FlightBooking;

USE FlightBooking;
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

CREATE TABLE Booking (
	CustomerID int ,
	TicketID int ,
	Subtotal decimal(6,2) NOT NULL,
	Tax decimal(6,2) NOT NULL,
	Total decimal(6,2) NOT NULL,
	DateBooked datetime NOT NULL,
	PaymentMethod varchar(50) NOT NULL,
	IsPaid bit NOT NULL,
	Description varchar(150)  NULL,

	CONSTRAINT booking_pk PRIMARY KEY (CustomerID,TicketID),
	CONSTRAINT FK_customer
		FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
	CONSTRAINT FK_ticket
		FOREIGN KEY (TicketID) REFERENCES Ticket (TicketID)
);

DROP TABLE Booking;

INSERT INTO Customer (FirstName, MiddleName, LastName, StreetNumber, StreetName, City, Province, Country, PostalCode, CellNumber, HomeNumber, Email)
VALUES
('Michael','','Dickerson',200,'Evergreen Drive','Moncton','NB','Canada','E1G 2G4','(506)875-0901','(506)876-2918','mikedickerson@outlook.com'),
('Tokyo','San','Mangekyo',1990,'Harimoto Street','Tokyo','','Japan','','0982730192','0982739183','mangekyo.tokyo@gmail.com');


INSERT INTO Ticket
VALUES
--(convert(datetime,'12-7-2020 23:00'),convert(datetime,'12-7-2020 12:00'),'NRT','YUL','Tokyo','Montreal',0,'Business','EVA',760.20,'This is a cheap ticket to go to Canada from Japan',3),
('10-7-2020 23:00','11-7-2020 1:00','YUL','YQM','Montreal','Moncton',0,'Economy','AC',250.00,'This is the only night flight from Montreal to Moncton',12);



SELECT TicketID,DepartureAirport + ' - ' + ArrivalAirport + ' (' + CONVERT(VARCHAR(MAX),DepartureTime) + ')'AS TicketInfo FROM Ticket;
SELECT * FROM Customer;
SELECT * FROM Ticket;
SELECT * FROM Booking;

SELECT CustomerID,FirstName + ' ' + LastName FROM Customer;

INSERT INTO Booking
(CustomerID ,TicketID,Subtotal,Tax,Total,DateBooked,PaymentMethod,IsPaid,Description)
VALUES
(1,14, 1000.45, 150.07, 1150.52,CONVERt(datetime,'23-01-2020',105),'Credit Card',1,NULL),
(3, 12, 760.20, 114.03, 874.23,CONVERT(datetime,'04-05-2020',105),'PayPal', 1, NULL),
(4,14, 1000.45, 150.07, 1150.52, CONVERT(datetime,'04-04-2020',105),'By Cash',0,'Will be paid at the airport in cash');
