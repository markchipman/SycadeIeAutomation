using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    [TagName("td")]
    public class HtmlTableCell : HtmlElement<HTMLTableCellClass>
    {
        public HtmlTableCell(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
