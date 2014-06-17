using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlInputText : HtmlElement
    {
        public string Value
        {
            get { return Element.value; }
            set { Element.value = value; }
        }

        public HtmlInputText(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
