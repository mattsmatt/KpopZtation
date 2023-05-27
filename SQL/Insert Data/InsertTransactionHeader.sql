DELETE FROM TransactionHeader;
DBCC CHECKIDENT (TransactionHeader, RESEED, 0);

SET IDENTITY_INSERT [dbo].[TransactionHeader] ON
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (1, N'2023-06-16', 2)
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (2, N'2023-07-21', 3)
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (3, N'2023-11-02', 2)
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (4, N'2023-11-03', 4)
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (5, N'2023-12-13', 3)
SET IDENTITY_INSERT [dbo].[TransactionHeader] OFF
