using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Elements
{
    [Tag("table")]
    public class HtmlTable : HtmlElement
    {
        public List<HtmlTableRow> Rows
        {
            get { return HtmlElementFactory.CreateHtmlElements<HtmlOption>(Element.rows); }
        }

        public HtmlTable(IHTMLElement element, IHtmlElementFactory htmlElementFactory)
            : base(element, htmlElementFactory) { }
    }
}
