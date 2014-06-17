using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Elements
{
    [TagName("tr")]
    public class HtmlTableRow : HtmlElement<HTMLTableRowClass>
    {
        public IEnumerable<HtmlTableCell> Cells
        {
            get { return Element.cells.Cast<IHTMLElement>().Select(ihe => new HtmlTableCell(Browser, ihe)); }
        }

        public HtmlTableRow(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
