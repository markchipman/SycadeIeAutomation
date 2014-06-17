using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlInputButton : HtmlElement<HTMLInputButtonElementClass>
    {
        public HtmlInputButton(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
