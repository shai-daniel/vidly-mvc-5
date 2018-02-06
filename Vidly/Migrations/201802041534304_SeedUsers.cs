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
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4b1f44ff-849a-4871-b898-0b2bb0c04461', N'admin2@vidly.com', 0, N'AEnXcsSor4ziPNzhY7ba8oiROSIZ7xO7MFTF4NoqwJxOkm24HdwXF/K56FubR+DnUQ==', N'0f4a3c18-b545-495c-b7b4-2fcf56f9c5b3', NULL, 0, 0, NULL, 1, 0, N'admin2@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6bb6ac28-7372-4fbd-974e-16e3d1fdb180', N'guest2@vidly.com', 0, N'AFBn5hOlqy9aMcRhrXYbUPZ6E70sz//rTUvLeS4EsFIBhpTpp4PG+j6RcXu0nYXpcQ==', N'a028f541-8f59-45ec-8ad3-91644ec42dd1', NULL, 0, 0, NULL, 1, 0, N'guest2@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cfe4b2de-be93-41f2-b086-a78d354123e1', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e5e98b70-7b1a-47a5-984c-67a980445ec1', N'cfe4b2de-be93-41f2-b086-a78d354123e1')
");
        }
        
        public override void Down()
        {
        }
    }
}
