namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class seedUsersRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'16c42e79-a9ec-42b4-abb2-466562d829af', N'CanManageMovies');
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'48c7e94e-6181-4f01-9d31-4d453ab1af8b', N'guest@vidly.com', 0, N'AMsQ3IEo0jrNNk+zbv1bDKbx12sV1qpdx7OZrPAjalDQwL7/e2NSNG1uhFLmtb5tzA==', N'a1471a9c-1483-4e61-b5f5-963cae33f7e8', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com');
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b9977f3f-a1b8-47a0-8b78-a90fa968765d', N'admin@vidly.com', 0, N'AMpTcIvjUa5LFS5fAA1/dRh+4l0v+7A4LBJdym/9Q4YA6+Ljz2UEw8bjdcTRpqjL/w==', N'38e599c5-dea8-4c95-b5e6-b445fe2585f7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com');
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b9977f3f-a1b8-47a0-8b78-a90fa968765d', N'16c42e79-a9ec-42b4-abb2-466562d829af');
            ");
        }

        public override void Down()
        {
        }
    }
}
