USE [master]
GO
/****** Object:  Database [ComputerClub]    Script Date: 06.06.2025 11:32:55 ******/
CREATE DATABASE [ComputerClub]
GO
USE [ComputerClub]
GO
/****** Object:  Table [dbo].[Computers]    Script Date: 06.06.2025 11:32:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Computers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[type] [nvarchar](20) NULL,
	[cost_hour] [decimal](10, 2) NULL,
	[status] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 06.06.2025 11:32:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sessions]    Script Date: 06.06.2025 11:32:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sessions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[computer_id] [int] NULL,
	[start_time] [datetime2](7) NULL,
	[end_time] [datetime2](7) NULL,
	[total_cost] [decimal](10, 2) NULL,
	[status] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 06.06.2025 11:32:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](255) NULL,
	[password] [nvarchar](255) NULL,
	[full_name] [nvarchar](100) NULL,
	[email] [nvarchar](100) NULL,
	[balance] [decimal](10, 2) NULL,
	[role_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Computers] ON 

INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (1, N'PC-01', N'Обычный', CAST(150.00 AS Decimal(10, 2)), N'Активный')
INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (2, N'PC-02', N'Обычный', CAST(150.00 AS Decimal(10, 2)), N'Активный')
INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (3, N'PC-03', N'Обычный', CAST(150.00 AS Decimal(10, 2)), N'Активный')
INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (4, N'PC-04', N'Обычный', CAST(150.00 AS Decimal(10, 2)), N'Активный')
INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (5, N'PC-05', N'Премиум', CAST(300.00 AS Decimal(10, 2)), N'Не работает')
INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (6, N'PC-06', N'Премиум', CAST(300.00 AS Decimal(10, 2)), N'Активный')
INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (7, N'PC-07', N'Премиум', CAST(300.00 AS Decimal(10, 2)), N'Активный')
INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (8, N'PC-08', N'VIP', CAST(400.00 AS Decimal(10, 2)), N'Активный')
INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (9, N'PC-09', N'VIP', CAST(400.00 AS Decimal(10, 2)), N'Активный')
INSERT [dbo].[Computers] ([id], [name], [type], [cost_hour], [status]) VALUES (10, N'PC-10', N'VIP', CAST(400.00 AS Decimal(10, 2)), N'Активный')
SET IDENTITY_INSERT [dbo].[Computers] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id], [role_name]) VALUES (1, N'Администратор')
INSERT [dbo].[Roles] ([id], [role_name]) VALUES (2, N'Пользователь')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Sessions] ON 

INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (1, 2, 3, CAST(N'2025-06-06T10:56:06.4135027' AS DateTime2), CAST(N'2025-06-06T13:56:06.4135027' AS DateTime2), CAST(450.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (2, 3, 7, CAST(N'2025-06-06T11:11:04.8109614' AS DateTime2), CAST(N'2025-06-06T12:11:04.8109614' AS DateTime2), CAST(150.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (3, 4, 1, CAST(N'2025-06-06T11:13:42.6223445' AS DateTime2), CAST(N'2025-06-06T12:13:42.6223445' AS DateTime2), CAST(150.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (4, 2, 2, CAST(N'2025-06-06T11:13:50.7079090' AS DateTime2), CAST(N'2025-06-06T12:13:50.7079090' AS DateTime2), CAST(150.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (5, 2, 4, CAST(N'2025-06-06T11:13:54.8195908' AS DateTime2), CAST(N'2025-06-06T12:13:54.8195908' AS DateTime2), CAST(150.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (6, 2, 6, CAST(N'2025-06-06T11:13:59.6181015' AS DateTime2), CAST(N'2025-06-06T12:13:59.6181015' AS DateTime2), CAST(300.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (7, 2, 8, CAST(N'2025-06-06T11:14:09.4361289' AS DateTime2), CAST(N'2025-06-06T12:14:09.4361289' AS DateTime2), CAST(400.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (8, 2, 9, CAST(N'2025-06-06T11:14:14.3496134' AS DateTime2), CAST(N'2025-06-06T12:14:14.3496134' AS DateTime2), CAST(400.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (9, 2, 10, CAST(N'2025-06-06T11:14:18.9109357' AS DateTime2), CAST(N'2025-06-06T12:14:18.9109357' AS DateTime2), CAST(400.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (10, 4, 1, CAST(N'2025-06-06T11:30:35.7964242' AS DateTime2), CAST(N'2025-06-06T12:30:35.7964242' AS DateTime2), CAST(150.00 AS Decimal(10, 2)), N'Отменённая')
INSERT [dbo].[Sessions] ([id], [user_id], [computer_id], [start_time], [end_time], [total_cost], [status]) VALUES (11, 2, 1, CAST(N'2025-06-06T11:31:47.9235873' AS DateTime2), CAST(N'2025-06-06T12:31:47.9235873' AS DateTime2), CAST(150.00 AS Decimal(10, 2)), N'Отменённая')
SET IDENTITY_INSERT [dbo].[Sessions] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [login], [password], [full_name], [email], [balance], [role_id]) VALUES (1, N'admin', N'admin111', N'Иванов Алексей Сергеевич', N'admin@club.ru', CAST(-1.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Users] ([id], [login], [password], [full_name], [email], [balance], [role_id]) VALUES (2, N'user1', N'user111', N'Петров Дмитрий Иванович', N'user1@mail.com', CAST(0.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Users] ([id], [login], [password], [full_name], [email], [balance], [role_id]) VALUES (3, N'user2', N'user222', N'Сидорова Анна Владимировна', N'user2@mail.com', CAST(750.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Users] ([id], [login], [password], [full_name], [email], [balance], [role_id]) VALUES (4, N'user3', N'user333', N'Николаева Екатерина Олеговна', N'user3@mail.com', CAST(300.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Users] ([id], [login], [password], [full_name], [email], [balance], [role_id]) VALUES (5, N'admin', N'admin222', N'Матвеева Сафия Максимовна', N'admin2@club.ru', CAST(-1.00 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Computers] ADD  DEFAULT ('Обычный') FOR [type]
GO
ALTER TABLE [dbo].[Computers] ADD  DEFAULT ('Активный') FOR [status]
GO
ALTER TABLE [dbo].[Sessions] ADD  DEFAULT ('Активная') FOR [status]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0.00)) FOR [balance]
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD FOREIGN KEY([computer_id])
REFERENCES [dbo].[Computers] ([id])
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Computers]  WITH CHECK ADD CHECK  (([status]='Не работает' OR [status]='Активный'))
GO
ALTER TABLE [dbo].[Computers]  WITH CHECK ADD CHECK  (([type]='VIP' OR [type]='Премиум' OR [type]='Обычный'))
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD CHECK  (([status]='Отменённая' OR [status]='Завершённая' OR [status]='Активная'))
GO
USE [master]
GO
ALTER DATABASE [ComputerClub] SET  READ_WRITE 
GO
