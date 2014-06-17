using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    [Tag("td")]
    public class HtmlTableCell : HtmlElement
    {
        public HtmlTableCell(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
