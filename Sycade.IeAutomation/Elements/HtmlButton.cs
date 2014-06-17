using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    [TagName("button")]
    public class HtmlButton : HtmlElement<HTMLButtonElementClass>
    {
        public HtmlButton(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
