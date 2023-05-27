DELETE FROM Artist;
DBCC CHECKIDENT (Artist, RESEED, 0);

SET IDENTITY_INSERT [dbo].[Artist] ON
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (1, N'NewJeans', N'638058485179546128.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (2, N'LOONA', N'638058489004609070.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (3, N'LADIES'' CODE', N'638058554486609538.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (4, N'Red Velvet', N'638059446432559006.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (5, N'SHINEE', N'638059447901481658.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (6, N'Wonder Girls', N'638059450808002463.jfif')
SET IDENTITY_INSERT [dbo].[Artist] OFF
