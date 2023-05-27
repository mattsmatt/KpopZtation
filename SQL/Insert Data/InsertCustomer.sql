DELETE FROM Customer;
DBCC CHECKIDENT (Customer, RESEED, 0);

SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (1, N'Admin', N'admin@mail.com', N'admin1234', N'Female', N'Jakarta Street', N'ADM')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (2, N'John Brown', N'john.brown@mail.com', N'john1234', N'Male', N'Johnny Boy Street', N'CST')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (3, N'Amanda', N'amanda@mail.com', N'amanda1234', N'Female', N'Dolly Street', N'CST')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (4, N'Troye', N'troye@mail.com', N'troye1234', N'Male', N'Avenue Street', N'CST')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (5, N'Anthony', N'anthony@mail.com', N'anthony1234', N'Male', N'Soprano Street', N'CST')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (6, N'Robbie', N'robbie@mail.com', N'robbie1234', N'Female', N'Roman Street', N'CST')
SET IDENTITY_INSERT [dbo].[Customer] OFF
