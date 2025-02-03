using Atata;
using OpenQA.Selenium;

namespace TestProject.PageObject.Pages
{
    using _ = GoogleHomePage;

    [Url("/")]
    public class GoogleHomePage : BasePage<_>
    {
        [FindByName("q")]
        public TextArea<_> SearchBox { get; private set; }

        public GoogleResultsPage SearchFor(string text)
        {
            SearchBox.Set(text).Press(Keys.Enter);
            return Go.To<GoogleResultsPage>(null, null, false);
        }
    }
}
