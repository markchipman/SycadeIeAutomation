using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    [Tag("a")]
    public class HtmlAnchor : HtmlElement
    {
        public string Href
        {
            get { return Element.href; }
            set { Element.href = value; }
        }

        public HtmlAnchor(IHTMLElement element, IHtmlElementFactory htmlElementFactory)
            : base(element, htmlElementFactory) { }
    }
}
