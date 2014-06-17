using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Elements
{
    [TagName("table")]
    public class HtmlTable : HtmlElement<HTMLTableClass>
    {
        public IEnumerable<HtmlTableRow> Rows
        {
            get { return Element.rows.Cast<IHTMLElement>().Select(ihe => new HtmlTableRow(Browser, ihe)); }
        }

        public HtmlTable(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
