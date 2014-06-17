using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Elements
{
    [Tag("tr")]
    public class HtmlTableRow : HtmlElement
    {
        public IEnumerable<HtmlTableCell> Cells
        {
            get { return ((IEnumerable)Element.cells).Cast<IHTMLElement>().Select(ihe => new HtmlTableCell(Browser, ihe)); }
        }

        public HtmlTableRow(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
