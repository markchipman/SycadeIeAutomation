using mshtml;
using Sycade.IeAutomation.Elements.Base;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlTable : HtmlElement<HTMLTableClass>
    {
        public IEnumerable<HtmlTableRow> Rows
        {
            get { return Element.rows.Cast<IHTMLElement>().Select(ihe => new HtmlTableRow(ihe)); }
        }

        public HtmlTable(IHTMLElement element)
            : base(element) { }
    }
}
