using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyBudget.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitializeIdentityData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"BEGIN TRANSACTION

SET IDENTITY_INSERT dbo.AspNetRoles ON;
INSERT INTO  AspNetRoles (Id, Name, NormalizedName) VALUES(1, 'Admin', 'ADMIN');
SET IDENTITY_INSERT dbo.AspNetRoles OFF;

SET IDENTITY_INSERT dbo.AspNetUsers ON;
INSERT INTO  AspNetUsers (Id, UserName, NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,AccessFailedCount,PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled) VALUES(1 ,'Admin', 'ADMIN', 'admin@admin.pl', 'ADMIN@ADMIN.PL', 1, '',0, 0, 0, 0);
SET IDENTITY_INSERT dbo.AspNetUsers OFF;

INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES (1, 1);

COMMIT TRANSACTION");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
