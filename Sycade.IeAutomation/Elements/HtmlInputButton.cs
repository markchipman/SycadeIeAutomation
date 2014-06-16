using mshtml;
using Sycade.IeAutomation.Elements.Base;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlInputButton : HtmlElement<HTMLInputButtonElementClass>
    {
        public HtmlInputButton(IHTMLElement element)
            : base(element) { }
    }
}
