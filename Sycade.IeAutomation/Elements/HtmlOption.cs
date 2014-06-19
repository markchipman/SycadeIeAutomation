using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    [Tag("option")]
    public class HtmlOption : HtmlElement
    {
        public string Value
        {
            get { return Element.value; }
            set { Element.value = value; }
        }

        public HtmlOption(IHTMLElement element, IHtmlElementFactory htmlElementFactory)
            : base(element, htmlElementFactory) { }
    }
}
