using mshtml;
using Sycade.IeAutomation.Elements.Base;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlInputSubmit : HtmlElement<HTMLInputElementClass>
    {
        public HtmlInputSubmit(IHTMLElement element)
            : base(element) { }
    }
}
