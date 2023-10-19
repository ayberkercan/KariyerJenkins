namespace CareerTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 5; int b = 6;

            //Act.
            App1 app = new App1();

            //Assert
            int topla = app.Topla(a, b);

            Assert.Equal<int>(11, topla);

        }
    }
}