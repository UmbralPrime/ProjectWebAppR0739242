SET IDENTITY_INSERT [dbo].[Activiteit] ON
INSERT INTO [dbo].[Activiteit] ([Id], [Naam], [Beschrijving]) VALUES (1, N'Test', N'dit is een test')
SET IDENTITY_INSERT [dbo].[Activiteit] OFF

SET IDENTITY_INSERT [dbo].[Groep] ON
INSERT INTO [dbo].[Groep] ([Id], [Naam]) VALUES (1, N'Jeugd')
INSERT INTO [dbo].[Groep] ([Id], [Naam]) VALUES (2, N'Recreanten')
INSERT INTO [dbo].[Groep] ([Id], [Naam]) VALUES (3, N'Competitie A')
INSERT INTO [dbo].[Groep] ([Id], [Naam]) VALUES (4, N'Competitie B')
SET IDENTITY_INSERT [dbo].[Groep] OFF

SET IDENTITY_INSERT [dbo].[Album] ON
INSERT INTO [dbo].[Album] ([Id], [Titel], [Datum]) VALUES (1, N'Ijszwemmen', N'2022-12-18 00:00:00')
INSERT INTO [dbo].[Album] ([Id], [Titel], [Datum]) VALUES (2, N'Dag van de HRC', N'2021-08-07 00:00:00')
INSERT INTO [dbo].[Album] ([Id], [Titel], [Datum]) VALUES (3, N'Schapenhof Traineractiviteit', N'2022-04-10 00:00:00')
SET IDENTITY_INSERT [dbo].[Album] OFF

SET IDENTITY_INSERT [dbo].[Afbeelding] ON
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (1, N'\images\DSC00418.JPG', 1)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (2, N'\images\DSC00427.JPG', 1)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (3, N'\images\DSC00435.JPG', 1)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (4, N'\images\DSC00479.JPG', 1)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (5, N'\images\DSC00481.JPG', 1)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (6, N'\images\DSC00664.JPG', 1)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (7, N'\images\DagHrc\20210807_094215.jpg', 2)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (8, N'\images\DagHrc\20210807_100440.jpg', 2)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (9, N'\images\DagHrc\20210807_102321.jpg', 2)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (10, N'\images\DagHrc\20210807_105510.jpg', 2)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (11, N'\images\TrainersActiv\Schapenhof1.jpeg', 3)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (12, N'\images\TrainersActiv\Schapenhof2.jpeg', 3)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (13, N'\images\TrainersActiv\Schapenhof3.jpeg', 3)
INSERT INTO [dbo].[Afbeelding] ([Id], [linkAfbeelding], [AlbumId]) VALUES (14, N'\images\TrainersActiv\Schapenhof4.jpeg', 3)
SET IDENTITY_INSERT [dbo].[Afbeelding] OFF

SET IDENTITY_INSERT [dbo].[Artikel] ON
INSERT INTO [dbo].[Artikel] ([Id], [Titel], [Inhoud], [Datum]) VALUES (1, N'Test', N'Dit artikel is een test', N'2022-12-12 00:00:00')
INSERT INTO [dbo].[Artikel] ([Id], [Titel], [Inhoud], [Datum]) VALUES (3, N'Verslag Pk Antwerpen', N'PK Antwerpen 2021 

Onze 3de editie van het Provinciaal Kampioenschap zit er weer op. En het was er één voor in de boekjes.We hebben helaas geen medailles kunnen binnenhalen met het zwemmen. Maar qua organisatie hebben we zeker en vast goud gehaald. Dus willen we nogmaals alle zwemmers, helpers, sponsors en supporters bedanken voor hun enthousiaste bijdrage aan de wedstrijd!', N'2021-11-21 21:53:00')
INSERT INTO [dbo].[Artikel] ([Id], [Titel], [Inhoud], [Datum]) VALUES (4, N'Bijscholingen 2020', N'Dit jaar organiseren we 3 bijscholingen. Inschrijven kan reeds via RedFed.

Klik hiervoor op een link bij onderstaande data:', N'2020-02-15 21:18:00')
SET IDENTITY_INSERT [dbo].[Artikel] OFF

SET IDENTITY_INSERT [dbo].[ArtikelGroep] ON
INSERT INTO [dbo].[ArtikelGroep] ([Id], [GroepId], [ArtikelId]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[ArtikelGroep] OFF

SET IDENTITY_INSERT [dbo].[Activiteit] ON
INSERT INTO [dbo].[Activiteit] ([Id], [Naam], [Beschrijving], [Datum]) VALUES (1, N'Test', N'dit is een test', N'2024-01-01 00:00:00')
INSERT INTO [dbo].[Activiteit] ([Id], [Naam], [Beschrijving], [Datum]) VALUES (2, N'PK Antwerpen', N'Het Pk antwerpen is weer hier, wil je dit jaar ook meedoen met de wedstrijd? Contacteer dan zeker een van je traines', N'2023-11-21 00:00:00')
INSERT INTO [dbo].[Activiteit] ([Id], [Naam], [Beschrijving], [Datum]) VALUES (3, N'Bijscholing', N'De bijscholing voor je reddersdiploma is weer hier, schrijf je in via onderstaande link', N'2023-04-08 00:00:00')
SET IDENTITY_INSERT [dbo].[Activiteit] OFF

SET IDENTITY_INSERT [dbo].[ActiviteitGroep] ON
INSERT INTO [dbo].[ActiviteitGroep] ([Id], [ActiviteitId], [GroepId]) VALUES (1, 3, 2)
INSERT INTO [dbo].[ActiviteitGroep] ([Id], [ActiviteitId], [GroepId]) VALUES (2, 2, 2)
INSERT INTO [dbo].[ActiviteitGroep] ([Id], [ActiviteitId], [GroepId]) VALUES (3, 2, 1)
INSERT INTO [dbo].[ActiviteitGroep] ([Id], [ActiviteitId], [GroepId]) VALUES (4, 2, 3)
INSERT INTO [dbo].[ActiviteitGroep] ([Id], [ActiviteitId], [GroepId]) VALUES (5, 2, 4)
INSERT INTO [dbo].[ActiviteitGroep] ([Id], [ActiviteitId], [GroepId]) VALUES (6, 3, 3)
INSERT INTO [dbo].[ActiviteitGroep] ([Id], [ActiviteitId], [GroepId]) VALUES (7, 3, 4)
SET IDENTITY_INSERT [dbo].[ActiviteitGroep] OFF


