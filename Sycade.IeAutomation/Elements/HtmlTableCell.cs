using mshtml;
using Sycade.IeAutomation.Elements.Base;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlTableCell : HtmlElement<HTMLTableCellClass>
    {
        public HtmlTableCell(IHTMLElement element)
            : base(element) { }
    }
}
