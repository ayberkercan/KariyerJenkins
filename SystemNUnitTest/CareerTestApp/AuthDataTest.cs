using Allure.Net.Commons;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Identity.Client;
using Nest;
using System.Data.Entity;
// Kullanmak istediðiniz AppRole türünün namespace'i


namespace CareerTestApp
{
    //List - Create - Delete - Update - Entity Framework üzerinden database'e test yazýlmasý.
    public class AuthDataTest
    {
        private DbContextOptions<ApplicationDbContext> dbContextOptions =
            new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer(@"Server=(localdb)\MSSQLLOCALDB;Database=CarierPlanSystem;Trusted_Connection=True;").Options;

        //[Fact]
        //public void Get_All_Users()
        //{
        //    using var context = new ApplicationDbContext(dbContextOptions);
        //    var okResult = context.Users.ToList();
        //    Assert.Equal<int>(0, okResult.ToList().Count());

        //}
        //[Fact]
        //public void List_All_Roles()
        //{
        //   using var context = new ApplicationDbContext(dbContextOptions);
        //    var okResult = context.AppRoles.ToList();
        //}

        //[Fact]
        //public void AddAndGetRole()
        //{
        //    // Arrange
        //    using var context = new ApplicationDbContext(dbContextOptions);

        //    // Act
        //    var roleToAdd = new AppRole
        //    {
        //        Id = Guid.NewGuid(),
        //        Definition = null,
        //        Name = "TestEngineer",
        //        NormalizedName = "normaltest",
        //    };

        //    context.AppRoles.Add(roleToAdd);
        //    context.SaveChanges();

        //    // Assert
        //    var retrievedRole = context.AppRoles.FirstOrDefault(r => r.Id == roleToAdd.Id);

        //    Assert.NotNull(retrievedRole);
        //    Assert.Equal(roleToAdd.Id, retrievedRole.Id);
        //    Assert.Equal("TestEngineer", retrievedRole.Name);
        //    Assert.Equal("normaltest", retrievedRole.NormalizedName);


        //}

        //[Fact]
        //public void Updated_Role()
        //{
        //    // Arrange
        //    using var context = new ApplicationDbContext(dbContextOptions);

        //    // Veritabanýndan belirli bir Id'ye sahip role ulaþalým
        //    var roleIdToUpdate =Guid.Parse("afb7e648-dbb5-423f-b174-7b365e8074a1");
        //    var roleToUpdate = context.AppRoles.Find(roleIdToUpdate);

        //    // Assert - Güncellenecek rolü doðrulayalým
        //    Assert.NotNull(roleToUpdate);

        //    // Act - Rolün adýný güncelleyelim
        //    var newName = "UpdatedRoleName";
        //    roleToUpdate.Name = newName;
        //    context.SaveChanges();

        //    // Assert - Güncellenen rolü doðrulayalým
        //    var updatedRole = context.AppRoles.Find(roleIdToUpdate);
        //    Assert.NotNull(updatedRole);
        //    Assert.Equal(newName, updatedRole.Name);

        //}
        [Fact]
        public void DeleteRole()
        {
            // Arrange
            using var context = new ApplicationDbContext(dbContextOptions);

            // Act - Delete the role by Id
            DeleteRoleById(Guid.Parse("afb7e648-dbb5-423f-b174-7b365e8074a1"), context);

            // Assert - Check if the role is deleted
            var deletedRole = context.AppRoles.Find(Guid.Parse("afb7e648-dbb5-423f-b174-7b365e8074a1"));
            Assert.Null(deletedRole);
        }

        public void DeleteRoleById(Guid roleId, ApplicationDbContext context)
        {
            // Act
            // Find the role by Id
            var roleToDelete = context.AppRoles.Find(roleId);

            // Check if the role with the specified Id exists
            if (roleToDelete != null)
            {
                // Act - Delete the role
                context.AppRoles.Remove(roleToDelete);
                context.SaveChanges();
            }
            else
            {

            }
        }

            [Fact]
            public void List_All_Roles()
            {
                using var context = new ApplicationDbContext(dbContextOptions);
                var okResult = context.AppRoles.ToList();
                Assert.Equal<int>(4, okResult.ToList().Count());

            }
    
  
        }
    }




//[Fact]
//public void Create_Roles()
//{

//    // Arrange 
//    using var context = new ApplicationDbContext(dbContextOptions);
//    var appRoles = new AppRoles(context);

//    var RoleToAdd = new AppRole { };



//        [Fact]
//        public void PassingTest()
//        {
//            Assert.Equal(4, Add(2, 2));
//        }

//        [Fact]
//        public void FailingTest()
//        {
//            Assert.Equal(5, Add(2, 2));
//        }

//        int Add(int x, int y)
//        {
//            return x + y;
//        }
//    }
//}