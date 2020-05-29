CREATE DATABASE FlightBooking;

USE FlightBooking;

SELECT * FROM Customer;
SELECT * FROM Ticket;

CREATE TABLE Booking (

	CustomerID int ,
	TicketID int ,
	Subtotal decimal(2,0) NOT NULL,
	Tax decimal(2,0) NOT NULL,
	Total decimal(2,0) NOT NULL,
	DateBooked date NOT NULL,
	PaymentMethod varchar(50) NOT NULL,
	IsPaid bit NOT NULL,
	Description varchar(150) NOT NULL,

	CONSTRAINT booking_pk PRIMARY KEY (CustomerID,TicketID),
	CONSTRAINT FK_customer
		FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
	CONSTRAINT FK_ticket
		FOREIGN KEY (TicketID) REFERENCES Ticket (TicketID)
);

SELECT * FROM Booking;