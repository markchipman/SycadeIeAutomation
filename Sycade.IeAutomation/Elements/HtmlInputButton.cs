using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlInputButton : HtmlElement
    {
        public HtmlInputButton(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
