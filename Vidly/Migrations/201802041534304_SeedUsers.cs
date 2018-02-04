namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8bef7625-884e-4519-a5fa-8dc71dd14350', N'guest@vidly.com', 0, N'ADQwvr6fFHbTj6HRpx55CCkJuw4+KKH2ZJ+QVKoFA6elPFtE+8WJ/OUtc93hWu1KIQ==', N'3c3ab6ed-e54d-4aca-a20e-55852110428d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e5e98b70-7b1a-47a5-984c-67a980445ec1', N'admin@vidly.com', 0, N'ACMzNdvtPtom3g5lcFkOYfJgoXs039FUMiPoIGlsUAFXn5Xmc2SuaSLaxjhTiyRLvA==', N'469e8d6e-5055-4254-912f-da09b95a8a9d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cfe4b2de-be93-41f2-b086-a78d354123e1', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e5e98b70-7b1a-47a5-984c-67a980445ec1', N'cfe4b2de-be93-41f2-b086-a78d354123e1')
");
        }
        
        public override void Down()
        {
        }
    }
}
