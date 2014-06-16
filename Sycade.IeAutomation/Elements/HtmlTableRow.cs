using mshtml;
using Sycade.IeAutomation.Elements.Base;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlTableRow : HtmlElement<HTMLTableRowClass>
    {
        public IEnumerable<HtmlTableCell> Cells
        {
            get { return Element.cells.Cast<IHTMLElement>().Select(ihe => new HtmlTableCell(ihe)); }
        }

        public HtmlTableRow(IHTMLElement element)
            : base(element) { }
    }
}
