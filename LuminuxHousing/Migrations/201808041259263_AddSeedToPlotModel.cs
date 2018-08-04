namespace LuminuxHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeedToPlotModel : DbMigration
    {
        public override void Up()
        {

            Sql(@"

INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES (N'Luminux Housing Mirpur', 1, 1500, N'2015-03-02 00:00:00', N'Some note for Luminux Housing', 0, N'Torikul Islam', N'01711111111')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES (N'Build maker Developer', 4, 3434, N'2015-03-01 00:00:00', N'Some note for Build maker Developer', 1, N'Shahed kaisar', N'01554635987')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'Building builders', 2, 1700, N'2018-08-02 00:00:00', N'some note about Building builders', 1, N'Jul kawsar', N'01897545664')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'dhaka Developer', 4, 222, N'2017-12-27 00:00:00', N'sdfdsfsd fdddddddddddd', 1, N'torikul islam', N'01512345678')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'Sagor buiding', 4, 222, N'2018-08-03 00:00:00', N'33333', 0, N'torikul islam', N'01931699713')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'Fast building developer', 2, 222, N'2018-08-03 00:00:00', N'33333', 1, N'torikul islam', N'01631699754')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'Gulshan house', 4, 3333, N'2018-08-03 00:00:00', N'33333', 0, N'torikul islam', N'01631668724')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'jatrabari house', 2, 15000, N'2018-08-04 00:00:00', N'some note for jatrabari house', 1, N'Jessan khan', N'01689333478')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'Banani white  house', 1, 15400, N'2018-02-07 00:00:00', N'some note for banani white house', 1, N'Murshed ul haque', N'01936555224')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'shamim sharoni house', 3, 1400, N'2018-04-25 00:00:00', N'some note for shamim sharoni house', 0, N'Shamim uddin', N'01566332223')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'white house', 3, 2500, N'2018-03-13 00:00:00', N'some note for white house', 1, N'Mushfiqur Rahman', N'01899635214')
INSERT INTO [dbo].[Plots] ( [Name], [SizeId], [Price], [StartDate], [Note], [Sold], [OwnerName], [OwnerPhone]) VALUES ( N'Dom-inno house 02', 3, 36000, N'2018-02-14 00:00:00', N'some note for Dom-inno house 02', 1, N'Jessan khan', N'01966335224')





");
        }
        
        public override void Down()
        {
        }
    }
}
