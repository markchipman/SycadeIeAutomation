using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Elements
{
    [Tag("tr")]
    public class HtmlTableRow : HtmlElement
    {
        public List<HtmlTableCell> Cells
        {
            get { return HtmlElementFactory.CreateHtmlElements<HtmlOption>(Element.cells); }
        }

        public HtmlTableRow(IHTMLElement element, IHtmlElementFactory htmlElementFactory)
            : base(element, htmlElementFactory) { }
    }
}
