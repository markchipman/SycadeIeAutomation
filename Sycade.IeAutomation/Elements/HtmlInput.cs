using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    public abstract class HtmlInput : HtmlElement
    {
        public string Value
        {
            get { return Element.value; }
            set { Element.value = value; }
        }

        public HtmlInput(IHTMLElement element, IHtmlElementFactory htmlElementFactory)
            : base(element, htmlElementFactory) { }
    }
}
