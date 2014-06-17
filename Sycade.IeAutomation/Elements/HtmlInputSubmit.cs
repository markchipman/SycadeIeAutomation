using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    [Tag("input", "submit")]
    public class HtmlInputSubmit : HtmlElement
    {
        public HtmlInputSubmit(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
