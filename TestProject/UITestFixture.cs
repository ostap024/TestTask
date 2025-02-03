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
                .Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.Dispose();
        }
    }
}