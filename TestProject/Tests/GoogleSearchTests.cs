using Atata;
using TestProject.PageObject.Pages;

namespace TestProject.Tests.Tests
{

    [TestFixture]
    public class GoogleSearchTests : UITestFixture
    {
        [Test]
        public void GoogleSearch_ShouldReturnRelevantResults()
        {
            var googleHomePage = Go.To<GoogleHomePage>();
            googleHomePage.SearchBox.Should.BeEnabled();

            var googleResultPage = googleHomePage.SearchFor("Selenium C# tutorial");
            //You must pause here in debug mode to manually enter capcha.
            googleResultPage.Results.First().Should.BeVisible()
                .Results.Last().Should.BeVisible()
                .Results.First().LinkText.Should.Contain("Selenium");
        }
    }
}
