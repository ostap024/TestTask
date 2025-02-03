using Atata;

namespace TestProject
{
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure()
                .UseChrome()
                    .WithArguments("start-maximized")
                    .WithArguments("headless")
                .Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.Dispose();
        }
    }
}