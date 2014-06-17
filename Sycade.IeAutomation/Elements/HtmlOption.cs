using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    [TagName("option")]
    public class HtmlOption : HtmlElement
    {
        public string Value
        {
            get { return Element.value; }
            set { Element.value = value; }
        }

        public HtmlOption(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
