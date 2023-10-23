using EKSystemApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CareerTestApp
{
    //List - Create - Delete - Update - Entity Framework üzerinden database'e test yazýlmasý.
    public class AuthDataTest
    {
        private DbContextOptions<ApplicationDbContext> dbContextOptions =
            new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer(@"Server=(localdb)\MSSQLLOCALDB;Database=CarierPlanSystem;Trusted_Connection=True;").Options;

        [Fact]
        public void Get_All_Users()
        {
            using var context = new ApplicationDbContext(dbContextOptions);
            var okResult = context.Users.ToList();
            Assert.Equal<int>(3, okResult.ToList().Count());

        }
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}