CREATE DATABASE ShoppingCardAppDb
GO
USE [ShoppingCardAppDb]
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL primary key,
	[Name] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[DocumentNumber] [varchar](100) NOT NULL,
	[PhoneNumber] [varchar](100) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL)
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL primary key,
	[Description] [varchar](150) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Stock] [decimal](18, 0) NOT NULL)
GO

CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(1,1) NOT NULL primary key,	
	[CustomerId] [int] NOT NULL  REFERENCES Customer(ID),
	[Invoiced] [bit] NOT NULL,
	[Total] [decimal](18, 0) NOT NULL,
	[TotalItems] [decimal](18, 0) NOT NULL)
GO
CREATE TABLE [dbo].[OrderDetail](
	[ID] [int] NOT NULL primary key,
	[OrderId] [int] NOT NULL REFERENCES Order(ID),
	[ProductId] [int] NOT NULL  REFERENCES Product(ID),
	[SalesPrice] [decimal](18, 0) NOT NULL,
	[Quantity] [decimal](18, 0) NOT NULL,
	[Total] [decimal](18, 0) NOT NULL)


