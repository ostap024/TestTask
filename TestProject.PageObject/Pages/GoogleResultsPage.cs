using Atata;

namespace TestProject.PageObject.Pages
{
    using _ = GoogleResultsPage;

    [Url("/search")]
    public class GoogleResultsPage : BasePage<_>
    {
        public ControlList<ResultItem, _> Results { get; private set; }

        [ControlDefinition("div", ContainingClass = "g")]
        public class ResultItem : Control<_>
        {
            [FindByCss("a > h3")]
            public H3<_> LinkText { get; private set; }
        }
    }
}
