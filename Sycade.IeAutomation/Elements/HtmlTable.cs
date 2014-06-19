using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Elements
{
    [Tag("table")]
    public class HtmlTable : HtmlElement
    {
        public List<HtmlTableRow> Rows
        {
            get { return ((IEnumerable)Element.rows).Cast<IHTMLElement>().Select(ihe => new HtmlTableRow(Browser, ihe)).ToList(); }
        }

        public HtmlTable(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
