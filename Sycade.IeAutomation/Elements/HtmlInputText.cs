using mshtml;
using Sycade.IeAutomation.Elements.Base;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlInputText : HtmlElement<HTMLInputTextElementClass>
    {
        public string Value
        {
            get { return Element.value; }
            set { Element.value = value; }
        }

        public HtmlInputText(IHTMLElement element)
            : base(element) { }
    }
}
