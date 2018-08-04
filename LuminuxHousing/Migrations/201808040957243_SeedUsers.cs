namespace LuminuxHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'24f63595-ef05-494c-8ea1-cbb5db433ed2', N'user@luminux.com', 0, N'AERGCYnjn8y53G9I1ihe9tRWhIDyfODYUmJ+JTX71/joUJUQ/YQ7FuMu21xHHt7wWw==', N'3b54e50a-fbbc-46ac-81b3-4fbf857e209d', NULL, 0, 0, NULL, 1, 0, N'user@luminux.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a0c5ef8f-2fda-4ded-aa58-a6d78c4bddcf', N'admin@luminux.com', 0, N'AIlvNYwsuCurZC+DD9D1xTpAyp3npXU1lHdUiXnjAt8s2RHh4yjnlC5lytJES1gQ8g==', N'0e1728bd-617d-46f1-909c-b3d1c4144609', NULL, 0, 0, NULL, 1, 0, N'admin@luminux.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ef38529d-b322-48b4-a17a-3afb4dec114a', N'admin')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a0c5ef8f-2fda-4ded-aa58-a6d78c4bddcf', N'ef38529d-b322-48b4-a17a-3afb4dec114a')



");
        }
        
        public override void Down()
        {
        }
    }
}
