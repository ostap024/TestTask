using Atata;

namespace TestProject.PageObject
{
    public class BasePage<TPage> : Page<TPage>
        where TPage : BasePage<TPage>
    {
    }
}
