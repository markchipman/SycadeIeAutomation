using mshtml;
using Sycade.IeAutomation.Elements.Base;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlButton : HtmlElement<HTMLButtonElementClass>
    {
        public HtmlButton(IHTMLElement element)
            : base(element) { }
    }
}
