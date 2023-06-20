using FamilyBudget.DataAccess.Context;
using FamilyBudget.DataAccess.Entities.Account;
using FamilyBudget.Services.Services;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace FamilyBudget.Services.Tests
{
    public class UserServiceTests
    {
        public UserServiceTests()
        {
        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var expected = new List<User>()
                {
                    new User { Id = 1, UserName = "MockUser1" },
                    new User { Id = 2, UserName = "MockUser2" }
                };

            var options = new DbContextOptionsBuilder<FamilyBudgetDbContext>()
                .UseInMemoryDatabase(databaseName: "FamilyBudgetDb")
                .Options;

            using (var context = new FamilyBudgetDbContext(options))
            {
                context.Users.Add(expected[0]);
                context.Users.Add(expected[1]);
                context.SaveChanges();
            }

            using (var context = new FamilyBudgetDbContext(options))
            {
                var userService = new UserService(context);

                var testResult = userService.GetAllUsers();

                Assert.That(expected.First().UserName, Is.EqualTo(testResult.First().UserName));
            }

        }
    }
}