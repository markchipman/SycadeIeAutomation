using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlInputSubmit : HtmlElement<HTMLInputElementClass>
    {
        public HtmlInputSubmit(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
