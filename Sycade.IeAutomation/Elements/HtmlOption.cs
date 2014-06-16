using mshtml;
using Sycade.IeAutomation.Elements.Base;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlOption : HtmlElement<HTMLOptionElementClass>
    {
        public string Value
        {
            get { return Element.value; }
            set { Element.value = value; }
        }

        public HtmlOption(IHTMLElement element)
            : base(element) { }
    }
}
