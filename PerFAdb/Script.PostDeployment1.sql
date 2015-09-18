/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

SET ANSI_PADDING OFF
GO

INSERT [dbo].[Credit] ([ID], [Credit rate(%)], [Credti body], [Monthly payment]) VALUES (81, 15, 240000.0000, -3000.0000)
GO

INSERT [dbo].[Credit] ([ID], [Credit rate(%)], [Credti body], [Monthly payment]) VALUES (93, NULL, NULL, NULL)
GO

INSERT [dbo].[Deposit] ([ID], [Deposit rate(%)], [Money on deposit], [Expected income]) VALUES (66, 20, 2500.0000, 25.0000)
GO

INSERT [dbo].[Deposit] ([ID], [Deposit rate(%)], [Money on deposit], [Expected income]) VALUES (76, 10, 10000.0000, 100.0000)
GO

INSERT [dbo].[Deposit] ([ID], [Deposit rate(%)], [Money on deposit], [Expected income]) VALUES (91, NULL, NULL, NULL)
GO

INSERT [dbo].[Grant] ([ID], [Grant type], [Grant-rate]) VALUES (67, N'asdasdasdasd', 250.0000)
GO

INSERT [dbo].[Grant] ([ID], [Grant type], [Grant-rate]) VALUES (72, NULL, NULL)
GO

INSERT [dbo].[Grant] ([ID], [Grant type], [Grant-rate]) VALUES (77, N'КПІ', 700.0000)
GO

INSERT [dbo].[Grant] ([ID], [Grant type], [Grant-rate]) VALUES (94, NULL, NULL)
GO

INSERT [dbo].[Grant] ([ID], [Grant type], [Grant-rate]) VALUES (102, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (2, N'Харчуванняsdfsdfsdfsdfsdfsdfsdf5146', N'Продукти на тиждень')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (11, NULL, N'fdsfd     ')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (12, N'qq1       ', N'vvbcd     ')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (13, N'івававіа  ', N'івавіааіва')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (14, N'qqq       ', N'qqhu      ')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (15, N'фівs      ', N'фів       ')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (18, N'HO        ', N'ho        ')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (19, N'asd       ', N'adsd      ')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (20, N'asd       ', N'asdd      ')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (21, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (22, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (23, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (24, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (25, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (26, N'as        ', N'asd       ')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (29, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (30, N'asdds     ', NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (79, N'Харчування', N'Продукти на тиждень')
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (86, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (88, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (90, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (95, NULL, NULL)
GO

INSERT [dbo].[HouseholdExpence] ([ID], [HE type], [Comment]) VALUES (101, NULL, NULL)
GO

INSERT [dbo].[LongTermExpence] ([ID], [LtE type], [Comment], [Term of usage]) VALUES (82, N'Техніка', N'Acer Aspire 8930', NULL)
GO

INSERT [dbo].[LongTermExpence] ([ID], [LtE type], [Comment], [Term of usage]) VALUES (98, NULL, NULL, NULL)
GO

INSERT [dbo].[OtherExpence] ([ID], [OE type], [Comment]) VALUES (71, NULL, NULL)
GO

INSERT [dbo].[OtherExpence] ([ID], [OE type], [Comment]) VALUES (83, N'Транспорт', N'Місячний проїзний на метро')
GO

INSERT [dbo].[OtherExpence] ([ID], [OE type], [Comment]) VALUES (99, NULL, NULL)
GO

INSERT [dbo].[OtherIncome] ([ID], [OI type], [Comment]) VALUES (78, N'Нерегулярний дохід', N'Виграш в лотерею Мегалот')
GO

INSERT [dbo].[OtherIncome] ([ID], [OI type], [Comment]) VALUES (97, NULL, NULL)
GO

INSERT [dbo].[Rent] ([ID], [Rate], [Meters], [Public utilities]) VALUES (80, -4000.0000, -150.0000, -100.0000)
GO

INSERT [dbo].[Rent] ([ID], [Rate], [Meters], [Public utilities]) VALUES (92, NULL, NULL, NULL)
GO

SET IDENTITY_INSERT [dbo].[Transaction] ON
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (1, CAST(N'2014-12-01' AS Date), N'МакДональд', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (2, CAST(N'2014-12-09' AS Date), N'Сільпо jsdhfsjdhfkjsdhfkjsdhfksdj dk;jfhdkshfsk', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (3, CAST(N'2014-12-15' AS Date), N'Зарплатаasdsadsadsadsadsadsa', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (4, CAST(N'2014-12-20' AS Date), N'Оренда квартири', 11)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (5, CAST(N'2014-12-20' AS Date), NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (6, CAST(N'2014-12-20' AS Date), NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (7, CAST(N'2014-12-20' AS Date), NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (8, CAST(N'2014-12-20' AS Date), NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (9, CAST(N'2014-12-20' AS Date), NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (10, CAST(N'2014-12-20' AS Date), NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (11, CAST(N'2016-03-07' AS Date), NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (12, CAST(N'2014-12-20' AS Date), N'Ewwecc    ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (13, CAST(N'2014-12-21' AS Date), N'Папаарам  ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (14, CAST(N'2012-01-01' AS Date), N'qqqqa  a  ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (15, CAST(N'2008-02-02' AS Date), N'Подарок   ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (16, CAST(N'2005-02-08' AS Date), N'Аванс     ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (17, CAST(N'2011-01-02' AS Date), N'Лотерея   ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (18, CAST(N'2009-01-05' AS Date), N'HP d ss   ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (19, CAST(N'2014-02-18' AS Date), N'asd       ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (20, CAST(N'2014-02-12' AS Date), N'asdfxx    ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (21, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (22, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (23, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (24, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (25, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (26, NULL, N'asd       ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (27, NULL, N'cxccc     ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (28, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (29, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (30, NULL, N'asd       ', 22)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (31, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (32, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (33, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (34, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (35, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (36, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (37, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (38, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (39, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (40, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (41, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (42, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (43, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (44, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (45, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (46, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (47, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (48, NULL, N'dsds', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (49, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (50, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (51, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (52, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (53, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (54, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (55, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (56, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (57, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (58, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (59, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (60, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (61, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (62, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (63, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (64, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (65, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (66, NULL, N'asdasdasd', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (67, CAST(N'2012-02-12' AS Date), N'asdfsadasd', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (68, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (69, NULL, N'eew', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (70, NULL, N'ewewew', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (71, NULL, N'rewerw', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (72, NULL, N' rw wrwr rw rw ', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (73, NULL, NULL, 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (74, NULL, N'4', 3)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (75, CAST(N'2014-10-11' AS Date), N'Аванс', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (76, CAST(N'2014-11-11' AS Date), N'Гривневий депозит', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (77, CAST(N'2014-11-20' AS Date), N'Стипендія', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (78, CAST(N'2014-12-25' AS Date), N'Лотерея', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (79, CAST(N'2014-11-23' AS Date), N'Сільпо', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (80, CAST(N'2014-12-07' AS Date), N'Оренда квартири', 24)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (81, CAST(N'2014-11-20' AS Date), N'Кредит на квартиру', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (82, CAST(N'2014-12-25' AS Date), N'Придбання комп''ютера', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (83, CAST(N'2014-12-11' AS Date), N'Проїзний на метро', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (84, CAST(N'2014-11-24' AS Date), N'Зарплата', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (85, CAST(N'2014-10-25' AS Date), N'Аванс', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (86, CAST(N'2014-10-15' AS Date), N'Новус', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (87, CAST(N'2014-10-12' AS Date), N'Зарплата', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (88, CAST(N'2014-10-05' AS Date), N'Миючі засоби', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (89, NULL, NULL, 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (90, CAST(N'2014-10-01' AS Date), N'Чай', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (91, CAST(N'2014-10-03' AS Date), N'Долларовий депозит', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (92, CAST(N'2014-10-12' AS Date), N'Оренда квартири', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (93, CAST(N'2014-10-05' AS Date), N'Кредит на житло', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (94, CAST(N'2014-10-06' AS Date), N'Стипендія', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (95, CAST(N'2014-10-17' AS Date), N'Сільпо', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (96, CAST(N'2014-09-07' AS Date), N'Зарплата', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (97, CAST(N'2014-09-09' AS Date), N'Продаж квасу', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (98, CAST(N'2014-09-02' AS Date), N'Придбання авто', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (99, CAST(N'2014-09-23' AS Date), N'Ремонт кухні', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (100, CAST(N'2014-09-12' AS Date), N'Аванс', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (101, CAST(N'2014-12-26' AS Date), N'asd', 23)
GO

INSERT [dbo].[Transaction] ([ID], [Date], [Description], [Author_ID]) VALUES (102, CAST(N'2014-12-05' AS Date), N'asd', 23)
GO

SET IDENTITY_INSERT [dbo].[Transaction] OFF
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (1, 3, -70.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (2, 3, -1500.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (2, 11, -80.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (2, 17, 25.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (2, 18, 30.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (3, 3, 30.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (3, 11, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (3, 17, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (4, 3, -2000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (4, 11, -2000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (12, 3, 43.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (13, 3, -561.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (13, 17, 2.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (13, 18, 3.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (13, 22, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (14, 3, -250.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (14, 11, 6.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (14, 17, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (14, 18, 5.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (15, 3, -215.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (15, 17, -400.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (16, 3, 5000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (17, 3, 25000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (31, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (32, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (33, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (34, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (35, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (66, 3, 2500.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (66, 11, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (66, 17, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (67, 3, 2500.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (68, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (69, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (70, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (71, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (72, 3, 54.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (73, 11, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (74, 3, NULL)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (74, 18, 54.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (75, 23, 5000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (76, 23, 100.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (77, 23, 700.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (78, 23, 10000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (79, 22, -50.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (79, 23, -100.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (80, 23, -2125.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (80, 24, -2125.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (81, 23, -3000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (82, 23, -10000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (83, 23, -95.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (84, 23, 5000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (85, 23, 3000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (86, 23, -150.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (87, 23, 5000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (88, 23, -170.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (90, 23, -15.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (91, 23, 200.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (92, 23, -2000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (93, 23, -5000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (94, 23, 700.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (95, 23, -200.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (96, 23, 4000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (97, 23, 200.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (98, 23, 10000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (99, 23, -1000.0000)
GO

INSERT [dbo].[TransactionUser] ([ID_transaction], [ID_user], [Sum]) VALUES (100, 23, 2000.0000)
GO

SET IDENTITY_INSERT [dbo].[User] ON
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (3, N'Роман', N'roman', N'alex')
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (11, N'Олег', N'oleg', N'bobpass')
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (17, N'Віталій', N'vitaliy', N'victorpass')
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (18, N'Назар', N'nazar', N'donpass')
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (19, N'Володимир', N'vjljdumur', N'fredpass')
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (22, N'Тарас', N'taras', N'taars     ')
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (23, N'Олександр', N'user', N'user')
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (24, N'Андрій', N'andriy', N'andriy')
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (25, N'Дмитро', N'dima', N'DIMA')
GO

INSERT [dbo].[User] ([ID], [Name], [Login], [Password]) VALUES (26, N'Name', N'name', N'name')
GO

SET IDENTITY_INSERT [dbo].[User] OFF
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (3, N'asdsaddddddddddddddaaaaaaddsad', 105.0000)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (16, N'Біоніка   ', 10000.0000)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (27, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (36, N'srdrdsr4d4rd4rd4rd4d5td5td5td5tds5d5d4r', NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (37, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (38, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (39, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (40, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (41, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (42, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (43, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (44, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (45, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (46, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (47, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (48, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (49, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (50, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (51, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (52, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (53, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (54, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (55, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (56, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (57, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (58, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (59, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (60, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (61, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (62, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (63, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (64, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (65, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (70, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (73, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (74, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (75, N'Bionic', 10000.0000)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (84, N'Bionic', 10000.0000)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (85, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (87, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (89, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (96, NULL, NULL)
GO

INSERT [dbo].[Wage] ([ID], [Workplace], [Wage-rate]) VALUES (100, NULL, NULL)
GO