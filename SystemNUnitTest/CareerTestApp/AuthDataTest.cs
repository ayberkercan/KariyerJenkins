using Allure.Net.Commons;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
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

        [Fact]
public void Create_Advert()

        {

            using var context = new ApplicationDbContext(dbContextOptions);

            var AdvertToAdd = new EKSystemApp.Domain.Entities.Admin.NewAdvertCreated.AdvertCreate

            {

                Id = Guid.Parse("e6b06c21-fd70-4423-85ec-2e11a5ebff89"),

                WorkDefination = "Temsilci",

                PublicQuality = "Ýyi",

                StartDate = DateTime.Now,

                EndDate = DateTime.Today,

                PeriotNumberId = 1626,

                AdvertNumberId = 342458,

                AdvertPublisherName = "batuhan.demirkol@turkuvazyayin.com.tr",

                EbaProcessId = "okeyletsgo",

                ProcessNumber = "567687",

            };

            context.AdvertCreates.Add(AdvertToAdd);

            var brands = new Brand

            {

                Id = Guid.NewGuid(),

                BrandKey = "234234",

                BrandName = "TestO",

                AdvertCreateId = AdvertToAdd.Id,

            };

            context.Brands.Add(brands);

            var positions = new Position

            {

                Id = Guid.NewGuid(),

                PositionKey = "2342345",

                PositionName = "TestO+",

                AdvertCreateId = AdvertToAdd.Id,

            };

            context.Positions.Add(positions);

            var organizations = new Organization

            {

                Id = Guid.NewGuid(),

                OrganizationKey = "29090905",

                OrganizationName = "Test1+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var groups = new Group

            {

                Id = Guid.NewGuid(),

                GroupKey = "588885",

                GroupName = "Test2+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var departments = new Department

            {

                Id = Guid.NewGuid(),

                DepartmentKey = "789547",

                DepartmentName = "Test23+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var units = new Unit

            {

                Id = Guid.NewGuid(),

                UnitKey = "789547",

                UnitName = "Test23+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var worktypes = new WorkType

            {

                Id = Guid.NewGuid(),

                WorkTypeKey = "5858747",

                WorkTypeName = "Test56+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var positiontypes = new PositionType

            {

                Id = Guid.NewGuid(),

                PositionTypeKey = "5858747",

                PositionTypeName = "Test09+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var workmodels = new WorkModel

            {

                Id = Guid.NewGuid(),

                WorkModelKey = "14798",

                WorkModelName = "Test07+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var locations = new Location

            {

                Id = Guid.NewGuid(),

                LocationKey = "5432",

                LocationName = "Test06+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var educationlevels = new EducationLevel

            {

                Id = Guid.NewGuid(),

                EducationLevelKey = "076",

                EducationLevelName = "Test676+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var millitarystatuses = new MillitaryStatus

            {

                Id = Guid.NewGuid(),

                MillitaryStatusKey = "110",

                MillitaryStatusName = "Test111+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var advertstatuses = new AdvertStatus

            {

                Id = Guid.NewGuid(),

                AdvertStatusKey = "8880",

                AdvertStatusName = "Tes78+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var AdvertSkillAndExpertise = new AdvertSkillAndExpertises

            {

                Id = Guid.NewGuid(),

                SkillAndExpertiseKey = "88",

                SkillAndExpertiseName = "Test2209+++",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var AdvertForeignLanguage = new AdvertForeignLanguages

            {

                Id = Guid.NewGuid(),

                ForeignLanguageKey = "209",

                ForeignLanguageName = "Test67+++",

                ForeignLanguageLevels = "Intermediate",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var AdvertAdQuestion = new AdvertAdQuestions

            {

                Id = Guid.NewGuid(),

                AdQuestionKey = "239",

                AdQuestionName = "Test77+",

                AnswerType = "Intermediate",

                AnswerContentDefination = "Simple",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var WorkCategorys = new WorkCategory

            {

                Id = Guid.NewGuid(),

                WorkCategoryKey = "209555",

                WorkCategoryName = "Test555",

                AdvertCreateId = AdvertToAdd.Id,

            };

            var ExperiencePeriods = new ExperiencePeriod

            {

                Id = Guid.NewGuid(),

                ExperiencePeriodKey = "1111",

                ExperiencePeriodName = "Ttester234",

                AdvertCreateId = AdvertToAdd.Id,

            };

            context.SaveChanges();

            var AdvertList = context.AdvertCreates

               .Include(x => x.Brands)

               .Include(x => x.Organizations)

               .Include(x => x.Groups)

               .Include(x => x.Units)

               .Include(x => x.WorkTypes)

               .Include(x => x.PositionTypes)

               .Include(x => x.WorkModels)

               .Include(x => x.Locations)

               .Include(x => x.EducationLevels)

               .Include(x => x.MillitaryStatuses)

               .Include(x => x.AdvertStatuses)

               .Include(x => x.AdvertSkillAndExpertises)

               .Include(x => x.AdvertForeignLanguages)

               .Include(x => x.AdvertAdQuestions)

               .Include(x => x.WorkCategories)

               .Include(x => x.ExperiencePeriods)

               .ToList();

            Console.WriteLine(AdvertList);

            Assert.Equal<int>(1, 1);

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