USE [master]
GO
/****** Object:  Database [myShop]    Script Date: 06.08.2020 17:30:48 ******/
CREATE DATABASE [myShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'myShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\myShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'myShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\myShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [myShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [myShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [myShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [myShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [myShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [myShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [myShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [myShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [myShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [myShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [myShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [myShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [myShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [myShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [myShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [myShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [myShop] SET  ENABLE_BROKER 
GO
ALTER DATABASE [myShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [myShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [myShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [myShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [myShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [myShop] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [myShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [myShop] SET RECOVERY FULL 
GO
ALTER DATABASE [myShop] SET  MULTI_USER 
GO
ALTER DATABASE [myShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [myShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [myShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [myShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [myShop] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'myShop', N'ON'
GO
ALTER DATABASE [myShop] SET QUERY_STORE = OFF
GO
USE [myShop]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 06.08.2020 17:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 06.08.2020 17:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[IdCategory] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Category] PRIMARY KEY CLUSTERED 
(
	[IdCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chart]    Script Date: 06.08.2020 17:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chart](
	[IdOrder] [int] NOT NULL,
	[IdProduct] [int] NOT NULL,
	[Price] [real] NOT NULL,
	[Units] [int] NOT NULL,
	[Discount] [real] NOT NULL,
 CONSTRAINT [PK_dbo.Chart] PRIMARY KEY CLUSTERED 
(
	[IdOrder] ASC,
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 06.08.2020 17:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[HouseNumber] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Voivodeship] [nvarchar](max) NULL,
	[ZIP] [nvarchar](max) NULL,
	[Points] [int] NOT NULL,
	[MoneySpent] [real] NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Client] PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 06.08.2020 17:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[IdOrder] [int] IDENTITY(1,1) NOT NULL,
	[IdClient] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[OrderName] [nvarchar](max) NULL,
	[OrderStreet] [nvarchar](max) NULL,
	[OrderHouseNumber] [nvarchar](max) NULL,
	[OrderCity] [nvarchar](max) NULL,
	[OrderVoivodeship] [nvarchar](max) NULL,
	[OrderZIP] [nvarchar](max) NULL,
	[TotalPrice] [real] NOT NULL,
 CONSTRAINT [PK_dbo.Order] PRIMARY KEY CLUSTERED 
(
	[IdOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 06.08.2020 17:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[IdCategory] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Discontinued] [bit] NOT NULL,
	[Manufacturer] [nvarchar](max) NULL,
	[UnitPrice] [real] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
	[UnitsOrdered] [int] NOT NULL,
	[UnitsSold] [int] NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Product] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202005111115393_AutomaticMigration', N'P4_Projekt.myShopContext', 0x1F8B0800000000000400DD5C5B6FDCBA117E2FD0FF20E8A92D72BCB6D387D6D83D0739EBA4351A5F90B583A22F012DD16B35BA6C25CAF0A2E82FEB437F52FF42471225F12A89A256DE5304086C52FC3824E7C6E18CFFFBEFFF2C7F7A8D42E705A75990C42BF7ECE4D47570EC257E106F576E4E9E7EF883FBD38FBFFED5F2A31FBD3A5FEBEFDE17DFC1C8385BB9CF84EC2E168BCC7BC611CA4EA2C04B932C7922275E122D909F2CCE4F4FFFB8383B5B60807001CB71965FF29804112E7F815FD749ECE11DC951789DF838CC683BF46C4A54E7064538DB210FAFDCBBDF7FBB4B93BFE3EFC4753E8401020A36387C721D14C7094104E8BB78C8F086A449BCDDECA00185F7FB1D86EF9E5098614AF745FBF9D0259C9E174B58B4036B282FCF481219029EBDA77BB210878FDA59B7D933D8B58FB0BB645FACBADCB995BB46046F9374EF3AE26417EB302D3E6437F6A43C85937AD03BA7ED7AD7F000B04AF1EF9DB3CE4392A77815E39CA42884AFF3C730F0FE82F7F7C9771CAFE23C0C59EA803EE8E31AA009F0773825FB2FF889D27CE5B7542FF8F10B11A019AE185BADEE2A26EFCF5DE70688418F216E9881D9890D4952FC271CE314C6FA7788109CC605162EB753A24298B3F8BF9E0DB80F04C875AED1EB671C6FC9F3CA851F5DE753F08AFDBA8552F01007206F3088A439EE9BE412675E1AEC2A36997AAE1BF4126CCBBD1066855FFDDC0381FB82C3B23F7B0E7695DC9DD0BE6FED867F4A93E84B12B6E39ABE6FF728DD62C0B94F341F6C923CF504CA968B969F3BB9BC21D380C9E99837E3F1866673166F86CEC5E1C3A5EA182425C8BC049615E7D8AF27FB3901AE43B131C1D728CE9F9057B0407A70C2E1637297065EBB45304F888D892E70B2AB18CEDCFB6E775E25D26DEAE3B4DD4A0BA44D125AC25C45688B1FD2704615D872BEAD0EAC559C5607D64A723069CF28EDD1CDD5170AA28A0E3D4565AF8A9CC12A99CE6CE2751423DE4C1D975C2E6EFDF4AA9B4E63250343F57F37CC649AC68E8C525BC3A5C09412AD50D01D560845D953F176C6CA04DB2E392A5CA7CA49B1769FBA4554EB3871023C4A44E94E19886839E2B8447432A19BD45B0A031C5BCA6749F4251050C3143FDF0791B9949648B3B85EE54C808E319967AE3F2779866FF2E87106F7AC9C705D9EFF1C337D4D82171851688C7926FCDBD5DDC127BA07110B47599E6E27281BAFF0451F48690D061343055F4F0CFD4022A66CD7115375DAF96374621387AC1CF27641204AF18810D020F53B9DC2FF9C6C8303446584593E0569466651E39FD14C13CD642AE6B412B31888396DC31C66E12E0962DB8BC47512E3FD6687CDAF122231CF8074F0255FA360CE284669483AAD64B761D25C8B78AB35C4307DC8B2C40B4A1AF84B521B43E197F431F69DBE804AB58BCCAD0AF612EC52B0034B0434ACDCDF493BD501DBACB5856DE33B3CEE992B5AB2DBF812879860E78357BD08AD51E6215F3E2AD81F9F6F01E387D3C2E2A0700D2704E614A442B69441EC053B14F6502F8C337C6829E86B66127B2E314859611A7BCEC59E84662661EBFA766AB960D8AC9BFB381F51C7226A87B1650F7AC1147943CF73EA9003C36F5550A08F8947718C6A31C38E4A17231BCE2AAA755BCE3D1F8F541AB2E748053FBE8747BAF4925AFF323C4235F6B1692415DD035581D2E31FC360DC29D84E3E0387F1C1C05E4BC507EF7BAD5F9726D2441BE75145CA050D3B2E4D0C7E9CE162D76E3DFDE4EC5239523086C0089C521AA2FDE639D915ADF85575AF7FC830BDDA67D4591459A040DD60C2BF730518BCC4D67593FC1F89917814BA2F2A0CDDAB8944088DD7C844549CD833BCF674A5E1EAF0B1347BA90694D3ABE311CCA149DBC0BC0B329FE9DE0E454E1AE0F936D4B33B2FB1E4005F9701621941B410FC62076C041F82933741EF7EF53B600CCDF5A1772C5DE972B1CBA6344EB564CA2DDA252BBC897E7F62D492790F825D72CDEBD66B161EB33A985D3670034CDC6836E78C9ACD61D7D7D9460B377DCB4595AA481B960B4D4EE3F21AED7670CD67721C698BB3A9121CD73F6CCC3300A30A63E1658A44C086DA662692A4688B855E981A282DE38B9788A04754041AD67E247DC6DB1C8D22ADE792CC8A7C5EB586AD87143F53866A83D13AFDD86EE02758535498F5328E2BAB32C550A7C83045214A3B329DD649984771FF3D558F560551599CAA65380297F6C702711D32DE7221EC8DE4A648BB2F5D06F8F31C74DA8D748E3CEBDA47303F6AED48FD49370E097FD05AD7EE17C4355C0A1CC7365CCF70443E118E45E47B862332D96E2C1CD36C86D566BC89706D8F216293F92621363D868855069C0457351BF05B9306C7715BD37A34FA40EBD80DD3FC2A676188DA578FD34B2FBD1AF0A2AB893875E14CA7511492314E2A14DC66AC49CAF42C498BE4AA68C99B711A758747725A75D6E69CA61977784EABAF1782B5D1C4B0F4484C96110BC5341B62C9C68B6936C4AA9F8725B4BAC3108F7B079640B95E43E4EAD557825C2B92077AB1B8C75D0992EB35442E9F7225C4B27538129BC2C362B1ED47A315EA1BEE5803A4BCA40FB1409A818717689A8BC2C2D0A6E1184CA6098BC3341BD08354506DEB702495363057045A1D3052FC65C937157AADBC8F147549CA0D05BC4EC6E07C0FDA66706160D231B8EB02D36E40539593C1915435995C6102C161AE5A665656522449FCA499BD89280991A3258DE2F497CC4A619DEA13D781AD7909FC22A4B3D967044727C507279B7F84B5C2A93F80DB5DF084335225F3B9E7A767E742F5EDF154C22EB2CC0F1551B061E5B057B18F5F57EE3F9D7FBD7DCD6A501C416F52A245F15DFC82520F6E49BF89D0EB6F59A491A5A80678131475DA1E95EE25CABCF4F22007A5E107FD3614C32E9CABBF7E6B47BE734ADFEEC239854D7A3B4E5194623E066492324C2BC2A452CB14A3709242CBF2A82628B31C8DC316598E01114B2C0F21DABAE2405BC17E8B22BEE1B249ABA72C0453AD7F064D7E5797BB5B4C3F91C4D870A7582E38800AEB7AB88370E5383E3B80A9E16A250C0C0D2D0EB16027A9C2CD879FC924156E56C64151C5668FA7A841B007658B0DECD1145505F6A04CF98015985C3936A5E86BABA3AC6F051315311D44FAB9BA25ABD3916A93ACD0C4FA232BB00905796A199E4C7CA796DCA98496AFEB1963EFE5AA9E517E0757D363B524B66E6702D7D8A21C46BC24CE57A822255A8D2BC1199532DC910D6412957146E409FFBF15B4D895B0D03BDC9C452BB395A9E8120F8C663B96C214DE9198AB74C498D7A6D20FBA27BBE1DE9911AB9830E62FA7C4C4B6AA645EE560A69FB5D9380752101DF3CD542A2267F78AE7A62C05D9771682544F4970697F4CE0A02BBFC7B44CA4AB4A4485AF8BD9294B48F415244AD2871797E86B4B54C02665271D55274A9ADFAE224564113EDD7A406EBE2AA9FFC8EA4DE4728BCE85714CC7E4211E4D4509CF636C9E4A6F1149FF561C41D1C810969AF8C40CCA42E4477BD0F3CC5FC3061B9305DB16A2F8DBD831F6380DDF7C73153F25B5AD1128AA3F11EFAD98201FD4FF879404C5531A747B38CBCABF3BF11585397CF2317AC4FE557C9B935D4E60C9387A0C39592E0C56D7FC65ED0B4FF3F2B67C27CEA6580290191421E2DBF8E73C281EB928DD9F14813F0D4461096900AD384B5204D2B6FB06E9464A29D101D1ED6B0CF83D8E76218065B7F106BDE031B43D64F833DE226F5FE75EE841FA0F82DFF6E56580B6298A328AD18E875F8187FDE8F5C7FF01A77A78CC145E0000, N'6.2.0-61023')
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([IdCategory], [Name], [Description]) VALUES (1, N'Procesor', N'CPU do komputerów stacjonarnych.')
INSERT [dbo].[Category] ([IdCategory], [Name], [Description]) VALUES (2, N'Karta Graficzna', N'GPU do komputerów stacjonarnych.')
INSERT [dbo].[Category] ([IdCategory], [Name], [Description]) VALUES (3, N'Laptop', N'Przenośne urządzenia do pracy i rozrywki.')
INSERT [dbo].[Category] ([IdCategory], [Name], [Description]) VALUES (4, N'RAM', N'Pamięć komputera przeznaczona do wykorzystania w chwili pracy.')
INSERT [dbo].[Category] ([IdCategory], [Name], [Description]) VALUES (5, N'Dysk Twardy', N'Pamięć masowa przeznaczona do gromadzenia danych i zapisywania.')
SET IDENTITY_INSERT [dbo].[Category] OFF
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (1, 1, 3200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (1, 6, 375, 1, 0.25)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (2, 2, 8000, 2, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (31, 6, 500, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (32, 6, 500, 3, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (33, 5, 1000, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (33, 6, 500, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (34, 6, 500, 2, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (35, 6, 500, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (36, 5, 1000, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (37, 5, 1000, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (38, 6, 500, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (39, 6, 500, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (40, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (41, 2, 4000, 5, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (42, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (43, 1, 3200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (45, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (46, 5, 1000, 3, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (46, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (47, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (48, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (49, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (50, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (50, 5, 1000, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (50, 6, 500, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (51, 7, 1200, 2, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (53, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (54, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (55, 3, 600, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (55, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (57, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (58, 3, 600, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (59, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (60, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (61, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (62, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (63, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (64, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (65, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (66, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (67, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (67, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (68, 3, 600, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (69, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (70, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (71, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (72, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (73, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (74, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (75, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (76, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (77, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (78, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (79, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (80, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (81, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (82, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (83, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (84, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (85, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (86, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (87, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (88, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (89, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (90, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (91, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (92, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (93, 7, 1200, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (94, 4, 800, 1, 0)
INSERT [dbo].[Chart] ([IdOrder], [IdProduct], [Price], [Units], [Discount]) VALUES (94, 7, 1200, 1, 0)
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([IdClient], [Login], [FirstName], [LastName], [Street], [HouseNumber], [City], [Voivodeship], [ZIP], [Points], [MoneySpent], [Phone], [Mail]) VALUES (1, N'user', N'Piotr', N'Doe', N'Bielska', N'1232', N'Bielsko-Biała', N'Śląsk', N'43-000', 100, 89593, N'123-456-789', N'John.Doe@gmail.com')
INSERT [dbo].[Client] ([IdClient], [Login], [FirstName], [LastName], [Street], [HouseNumber], [City], [Voivodeship], [ZIP], [Points], [MoneySpent], [Phone], [Mail]) VALUES (2, N'admin', N'imieadmin', N'adminlast', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 24, 13800, N'111-222-333', N'admin@mail.com')
INSERT [dbo].[Client] ([IdClient], [Login], [FirstName], [LastName], [Street], [HouseNumber], [City], [Voivodeship], [ZIP], [Points], [MoneySpent], [Phone], [Mail]) VALUES (3, N'Piotr', N'Piotr', N'Troip', N'Ulica', N'123', N'Bielsko-Biała', N'Śląsk', N'43-300', 13, 3200, N'222-222-222', N'dwad@mail.pl')
INSERT [dbo].[Client] ([IdClient], [Login], [FirstName], [LastName], [Street], [HouseNumber], [City], [Voivodeship], [ZIP], [Points], [MoneySpent], [Phone], [Mail]) VALUES (4, N'user2', N'imie', N'nazwisko', N'ulica', N'1', N'bielsko', N'Śląsk', N'43-300', 22, 11600, N'323 323 323', N'mail@mail.com')
INSERT [dbo].[Client] ([IdClient], [Login], [FirstName], [LastName], [Street], [HouseNumber], [City], [Voivodeship], [ZIP], [Points], [MoneySpent], [Phone], [Mail]) VALUES (5, N'kacper', N'k', N'k', N'daw', N'123', N'Bielsko', N'Śląsk', N'43-300', 11, 800, N'323 322 233', N'mail@mail.com')
INSERT [dbo].[Client] ([IdClient], [Login], [FirstName], [LastName], [Street], [HouseNumber], [City], [Voivodeship], [ZIP], [Points], [MoneySpent], [Phone], [Mail]) VALUES (6, N'test', N'test', N'test', N'test', N'test', N'test', N'test', N'test', 11, 1200, N'test', N'test')
INSERT [dbo].[Client] ([IdClient], [Login], [FirstName], [LastName], [Street], [HouseNumber], [City], [Voivodeship], [ZIP], [Points], [MoneySpent], [Phone], [Mail]) VALUES (7, N'piotr1', N'piotr', N't', N'street', N'number', N'city', N'voivo', N'43300', 11, 1200, N'123', N'pt@gmail.com')
INSERT [dbo].[Client] ([IdClient], [Login], [FirstName], [LastName], [Street], [HouseNumber], [City], [Voivodeship], [ZIP], [Points], [MoneySpent], [Phone], [Mail]) VALUES (8, N'admin2', N'imie', N'nazwisko', N'ulica', N'12/b', N'Bielsko', N'Śląsk', N'43-300', 12, 2000, N'123456789', N'mail@mail.com')
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (1, 1, CAST(N'2020-03-22T13:15:39.457' AS DateTime), N'Zamówienie user #1', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 3575)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (2, 1, CAST(N'2020-05-01T13:15:39.490' AS DateTime), N'Zamówienie user #2', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 8000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (3, 1, CAST(N'2020-03-12T19:51:55.093' AS DateTime), N'Zamówienie user #3', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 8000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (4, 1, CAST(N'2020-03-12T19:52:02.717' AS DateTime), N'Zamówienie user #3', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 8000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (5, 1, CAST(N'2019-06-26T20:31:05.720' AS DateTime), N'Zamówienie user #5', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 4000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (6, 1, CAST(N'2019-06-26T20:31:20.530' AS DateTime), N'Zamówienie user #6', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (7, 1, CAST(N'2020-04-21T20:31:51.557' AS DateTime), N'Zamówienie user #7', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 320)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (8, 1, CAST(N'2011-07-18T20:32:07.983' AS DateTime), N'Zamówienie user #8', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 333)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (9, 1, CAST(N'2020-05-11T20:32:26.820' AS DateTime), N'Zamówienie user #9', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 333)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (10, 1, CAST(N'2020-05-10T20:32:45.823' AS DateTime), N'Zamówienie user #9', N'Villowa', N'12B/2', N'Katowice', N'Śląsk', N'43-000', 32)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (11, 1, CAST(N'2020-05-13T22:58:54.990' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (12, 1, CAST(N'2020-05-13T22:59:03.200' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (13, 1, CAST(N'2020-05-13T23:03:50.047' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (14, 1, CAST(N'2020-05-13T23:03:55.573' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (15, 1, CAST(N'2020-05-13T23:04:01.197' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (16, 1, CAST(N'2020-05-13T23:06:13.910' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (17, 1, CAST(N'2020-05-13T23:06:15.207' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (18, 1, CAST(N'2020-05-13T23:06:20.163' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (19, 1, CAST(N'2020-05-13T23:07:59.657' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (20, 1, CAST(N'2020-05-13T23:08:07.637' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (21, 1, CAST(N'2020-05-13T23:08:47.207' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (22, 1, CAST(N'2020-05-13T23:11:20.943' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (23, 1, CAST(N'2020-05-13T23:11:30.487' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (24, 1, CAST(N'2020-05-13T23:12:43.310' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (25, 1, CAST(N'2020-05-14T00:05:33.570' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (26, 1, CAST(N'2020-05-14T11:46:36.490' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (27, 1, CAST(N'2020-05-14T11:46:49.860' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (28, 1, CAST(N'2020-05-14T11:51:27.983' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (29, 1, CAST(N'2020-05-14T16:25:13.783' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (30, 1, CAST(N'2020-05-14T16:27:57.330' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (31, 1, CAST(N'2020-05-14T16:33:46.557' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (32, 1, CAST(N'2020-05-14T16:34:31.190' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (33, 1, CAST(N'2020-05-14T17:42:48.897' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (34, 1, CAST(N'2020-05-14T17:56:16.673' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (35, 1, CAST(N'2020-05-14T18:00:00.063' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 500)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (36, 1, CAST(N'2020-05-14T18:01:15.287' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (37, 1, CAST(N'2020-05-14T18:01:46.913' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (38, 1, CAST(N'2020-05-14T18:02:32.733' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 500)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (39, 1, CAST(N'2020-05-14T18:03:35.490' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 500)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (40, 1, CAST(N'2020-05-14T18:04:31.057' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 800)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (41, 1, CAST(N'2020-05-14T18:04:46.723' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 20000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (42, 1, CAST(N'2020-05-14T18:10:22.330' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 800)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (43, 1, CAST(N'2020-05-14T18:11:14.913' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 3200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (44, 1, CAST(N'2020-05-14T18:13:12.257' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (45, 1, CAST(N'2020-05-14T18:56:15.697' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 800)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (46, 1, CAST(N'2020-05-14T20:42:50.423' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 4200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (47, 1, CAST(N'2020-05-14T20:44:51.177' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (48, 1, CAST(N'2020-05-14T20:46:47.287' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (49, 1, CAST(N'2020-05-14T21:07:35.527' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (50, 1, CAST(N'2020-05-14T21:48:55.360' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 2300)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (51, 1, CAST(N'2020-05-14T21:58:00.423' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 2400)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (52, 1, CAST(N'2020-05-14T21:59:14.600' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (53, 1, CAST(N'2020-05-14T22:24:17.817' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (54, 1, CAST(N'2020-05-15T11:39:35.620' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (55, 1, CAST(N'2020-05-15T13:11:25.583' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1400)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (56, 1, CAST(N'2020-05-15T13:19:35.287' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (57, 1, CAST(N'2020-05-15T13:23:21.287' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 800)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (58, 1, CAST(N'2020-05-15T13:25:17.280' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 600)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (59, 1, CAST(N'2020-05-15T13:31:43.113' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (60, 1, CAST(N'2020-05-15T13:33:07.033' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (61, 1, CAST(N'2020-05-15T13:33:18.373' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (62, 1, CAST(N'2020-05-15T13:35:55.027' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (63, 1, CAST(N'2020-05-15T13:46:58.727' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'12', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (64, 1, CAST(N'2020-05-15T16:10:31.023' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'1232', N'Bielsko-Biała', N'Śląsk', N'43-000', 800)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (65, 1, CAST(N'2020-05-15T17:05:38.543' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'1232', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (66, 3, CAST(N'2020-05-15T19:00:33.747' AS DateTime), N'Zamówienie klienta o ID 3', N'Ulica', N'123', N'Bielsko-Biała', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (67, 3, CAST(N'2020-05-15T19:13:45.700' AS DateTime), N'Zamówienie klienta o ID 3', N'Ulica', N'123', N'Bielsko-Biała', N'Śląsk', N'43-300', 2000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (68, 2, CAST(N'2020-05-15T19:22:07.520' AS DateTime), N'Zamówienie klienta o ID 2', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 600)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (69, 4, CAST(N'2020-05-15T20:53:26.557' AS DateTime), N'Zamówienie klienta o ID 4', N'-', N'-', N'-', N'-', N'-', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (70, 2, CAST(N'2020-05-15T21:00:20.527' AS DateTime), N'Zamówienie klienta o ID 2', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (71, 2, CAST(N'2020-05-15T21:01:33.797' AS DateTime), N'Zamówienie klienta o ID 2', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (72, 2, CAST(N'2020-05-15T21:02:05.960' AS DateTime), N'Zamówienie klienta o ID 2', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (73, 2, CAST(N'2020-05-15T21:09:15.167' AS DateTime), N'Zamówienie klienta admin: Villowa, 1232E/13, Łodygowice 43-300 Śląsk', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (74, 2, CAST(N'2020-05-15T21:12:47.327' AS DateTime), N'Zamówienie klienta "admin" admin adminlast: Villowa 1232E/13, Łodygowice 43-300 Śląsk', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (75, 4, CAST(N'2020-05-15T21:35:15.510' AS DateTime), N'Zamówienie klienta "user2" - -: - -, - - -', N'-', N'-', N'-', N'-', N'-', 800)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (76, 1, CAST(N'2020-05-15T23:57:29.660' AS DateTime), N'Zamówienie klienta "user" Piot Doe: Bielska 1232, Bielsko-Biała 43-000 Śląsk', N'Bielska', N'1232', N'Bielsko-Biała', N'Śląsk', N'43-000', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (77, 4, CAST(N'2020-05-16T00:00:52.323' AS DateTime), N'Zamówienie klienta "user2" CosFirst CosLast: Cos 123, BielskoCity 43-300 Śląsk', N'Cos', N'123', N'BielskoCity', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (78, 5, CAST(N'2020-05-16T11:39:47.387' AS DateTime), N'Zamówienie klienta "kacper" k k: daw 123, Bielsko 43-300 Śląsk', N'daw', N'123', N'Bielsko', N'Śląsk', N'43-300', 800)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (79, 4, CAST(N'2020-05-16T19:54:32.043' AS DateTime), N'Zamówienie klienta "user2" - -: - -, - - -', N'-', N'-', N'-', N'-', N'-', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (80, 4, CAST(N'2020-05-16T19:56:12.013' AS DateTime), N'Zamówienie klienta "user2" - -: - -, - - -', N'-', N'-', N'-', N'-', N'-', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (81, 4, CAST(N'2020-05-16T20:01:21.483' AS DateTime), N'Zamówienie klienta "user2" - nazwisko: ulica 1, bielsko 43-300 Śląsk', N'ulica', N'1', N'bielsko', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (82, 4, CAST(N'2020-05-16T20:02:54.347' AS DateTime), N'Zamówienie klienta "user2" - nazwisko: ulica 1, bielsko 43-300 Śląsk', N'ulica', N'1', N'bielsko', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (83, 4, CAST(N'2020-05-16T20:07:54.590' AS DateTime), N'Zamówienie klienta "user2" - nazwisko: ulica 1, bielsko 43-300 Śląsk', N'ulica', N'1', N'bielsko', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (84, 4, CAST(N'2020-05-16T20:14:27.173' AS DateTime), N'Zamówienie klienta "user2" imie nazwisko: ulica 1, bielsko 43-300 Śląsk', N'ulica', N'1', N'bielsko', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (85, 4, CAST(N'2020-05-16T20:19:18.440' AS DateTime), N'Zamówienie klienta "user2" - nazwisko: ulica 1, bielsko 43-300 Śląsk', N'ulica', N'1', N'bielsko', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (86, 2, CAST(N'2020-05-16T20:28:56.547' AS DateTime), N'Zamówienie klienta "admin" adminfirst adminlast: Villowa 1232E/13, Łodygowice 43-300 Śląsk', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (87, 2, CAST(N'2020-05-17T13:36:50.913' AS DateTime), N'Zamówienie klienta "admin" adminfirst adminlast: Villowa 1232E/13, Łodygowice 43-300 Śląsk', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (88, 2, CAST(N'2020-05-17T13:42:19.960' AS DateTime), N'Zamówienie klienta "admin" adminfirst adminlast: Villowa 1232E/13, Łodygowice 43-300 Śląsk', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (89, 2, CAST(N'2020-05-17T13:42:37.033' AS DateTime), N'Zamówienie klienta "admin" imie adminlast: Villowa 1232E/13, Łodygowice 43-300 Śląsk', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (90, 2, CAST(N'2020-05-17T14:28:07.747' AS DateTime), N'Zamówienie klienta "admin" imie adminlast: Villowa 1232E/13, Łodygowice 43-300 Śląsk', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (91, 6, CAST(N'2020-05-17T14:29:22.990' AS DateTime), N'Zamówienie klienta "test" test test: test test, test test test', N'test', N'test', N'test', N'test', N'test', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (92, 2, CAST(N'2020-05-28T08:33:24.770' AS DateTime), N'Zamówienie klienta "admin" imieadmin adminlast: Villowa 1232E/13, Łodygowice 43-300 Śląsk', N'Villowa', N'1232E/13', N'Łodygowice', N'Śląsk', N'43-300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (93, 7, CAST(N'2020-05-28T08:50:29.460' AS DateTime), N'Zamówienie klienta "piotr1" piotr t: street number, city 43300 voivo', N'street', N'number', N'city', N'voivo', N'43300', 1200)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (94, 8, CAST(N'2020-05-28T09:15:19.277' AS DateTime), N'Zamówienie klienta "admin2" imie nazwisko: ulica 12/b, Bielsko 43-300 Śląsk', N'ulica', N'12/b', N'Bielsko', N'Śląsk', N'43-300', 2000)
INSERT [dbo].[Order] ([IdOrder], [IdClient], [OrderDate], [OrderName], [OrderStreet], [OrderHouseNumber], [OrderCity], [OrderVoivodeship], [OrderZIP], [TotalPrice]) VALUES (95, 1, CAST(N'2020-05-29T14:22:15.960' AS DateTime), N'Zamówienie klienta o ID 1', N'Bielska', N'1232', N'Bielsko-Biała', N'Śląsk', N'43-000', 0)
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([IdProduct], [IdCategory], [Name], [Discontinued], [Manufacturer], [UnitPrice], [UnitsInStock], [UnitsOrdered], [UnitsSold], [ImageUrl]) VALUES (1, 3, N'Nitro 5', 0, N'Acer', 3200, 11, 5, 512, N'https://i.ebayimg.com/images/g/xZYAAOSwzcpdijv8/s-l1600.jpg')
INSERT [dbo].[Product] ([IdProduct], [IdCategory], [Name], [Discontinued], [Manufacturer], [UnitPrice], [UnitsInStock], [UnitsOrdered], [UnitsSold], [ImageUrl]) VALUES (2, 3, N'MacBook', 0, N'Apple', 4000, 0, 2, 100, N'https://image.ceneostatic.pl/data/products/66886711/i-apple-macbook-pro-15-4-i7-16gb-512gb-macos-silver-mr972ze-a.jpg')
INSERT [dbo].[Product] ([IdProduct], [IdCategory], [Name], [Discontinued], [Manufacturer], [UnitPrice], [UnitsInStock], [UnitsOrdered], [UnitsSold], [ImageUrl]) VALUES (3, 1, N'i5-8300H', 0, N'Intel', 600, 7, 20, 603, N'https://www.notebookcheck.pl/fileadmin/_processed_/a/e/csm_8th_Gen_Intel_Core_i5_Badge_ee07502dbf.jpg')
INSERT [dbo].[Product] ([IdProduct], [IdCategory], [Name], [Discontinued], [Manufacturer], [UnitPrice], [UnitsInStock], [UnitsOrdered], [UnitsSold], [ImageUrl]) VALUES (4, 2, N'GTX 1050', 0, N'Nvidia', 800, 39, 90, 1509, N'https://images.morele.net/i1064/975580_0_i1064.jpg')
INSERT [dbo].[Product] ([IdProduct], [IdCategory], [Name], [Discontinued], [Manufacturer], [UnitPrice], [UnitsInStock], [UnitsOrdered], [UnitsSold], [ImageUrl]) VALUES (5, 4, N'Predator RGB 8GB DDR4', 0, N'HyperX', 1000, 8, 20, 204, N'https://image.ceneostatic.pl/data/products/62977095/i-hyperx-predator-rgb-8gb-ddr4-2933mhz-cl15-hx429c15pb3a8.jpg')
INSERT [dbo].[Product] ([IdProduct], [IdCategory], [Name], [Discontinued], [Manufacturer], [UnitPrice], [UnitsInStock], [UnitsOrdered], [UnitsSold], [ImageUrl]) VALUES (6, 5, N'Dysk CX 400', 0, N'GOODRAM', 500, 25, 3, 19, N'https://www.mediaexpert.pl/media/cache/gallery/product/1/198/252/686/bqwt8jfi/images/13/1389913/Dysk-GOODRAM-CX400-512GB-skos.jpg')
INSERT [dbo].[Product] ([IdProduct], [IdCategory], [Name], [Discontinued], [Manufacturer], [UnitPrice], [UnitsInStock], [UnitsOrdered], [UnitsSold], [ImageUrl]) VALUES (7, 1, N'i7-7700T', 0, N'Intel', 1200, 360, 0, 142, N'https://image.ceneostatic.pl/data/products/30884418/i-intel-core-i7-4790k-4-0ghz-box-bx80646i74790k.jpg')
INSERT [dbo].[Product] ([IdProduct], [IdCategory], [Name], [Discontinued], [Manufacturer], [UnitPrice], [UnitsInStock], [UnitsOrdered], [UnitsSold], [ImageUrl]) VALUES (8, 1, N'6809', 1, N'Motorola', 200, 0, 0, 9900, N'https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/KL_Motorola_MC6809.jpg/1200px-KL_Motorola_MC6809.jpg')
SET IDENTITY_INSERT [dbo].[Product] OFF
/****** Object:  Index [IX_IdOrder]    Script Date: 06.08.2020 17:30:49 ******/
CREATE NONCLUSTERED INDEX [IX_IdOrder] ON [dbo].[Chart]
(
	[IdOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_IdProduct]    Script Date: 06.08.2020 17:30:49 ******/
CREATE NONCLUSTERED INDEX [IX_IdProduct] ON [dbo].[Chart]
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_IdClient]    Script Date: 06.08.2020 17:30:49 ******/
CREATE NONCLUSTERED INDEX [IX_IdClient] ON [dbo].[Order]
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_IdCategory]    Script Date: 06.08.2020 17:30:49 ******/
CREATE NONCLUSTERED INDEX [IX_IdCategory] ON [dbo].[Product]
(
	[IdCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Chart]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Chart_dbo.Order_IdOrder] FOREIGN KEY([IdOrder])
REFERENCES [dbo].[Order] ([IdOrder])
GO
ALTER TABLE [dbo].[Chart] CHECK CONSTRAINT [FK_dbo.Chart_dbo.Order_IdOrder]
GO
ALTER TABLE [dbo].[Chart]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Chart_dbo.Product_IdProduct] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([IdProduct])
GO
ALTER TABLE [dbo].[Chart] CHECK CONSTRAINT [FK_dbo.Chart_dbo.Product_IdProduct]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Order_dbo.Client_IdClient] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_dbo.Order_dbo.Client_IdClient]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Product_dbo.Category_IdCategory] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Category] ([IdCategory])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_dbo.Product_dbo.Category_IdCategory]
GO
USE [master]
GO
ALTER DATABASE [myShop] SET  READ_WRITE 
GO
