USE [VballPlayerPMSDatabase]
GO
/****** Object:  Table [dbo].[Players]    Script Date: 28/06/2025 9:50:15 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Players](
	[Name] [nchar](100) NOT NULL,
	[Age] [int] NOT NULL,
	[Position] [nchar](100) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Leica Erica                                                                                         ', 23, N'Spiker                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Leica Erica Laica                                                                                   ', 28, N'Spiker                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'aguas                                                          Ivy  Aguas                           ', 25, N'Libero                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Mananes, Jessica                                                                                    ', 19, N'Spiker                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Carmelita                                                                                           ', 31, N'Middle Hitter                                                                                       ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'JESS                                                                                                ', 17, N'Libero                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Cedrick                                                                                             ', 15, N'Spiker                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Jessabel                                                                                            ', 24, N'Blocker                                                                                             ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'sicajess                                                                                            ', 16, N'Blocker                                                                                             ')
GO
