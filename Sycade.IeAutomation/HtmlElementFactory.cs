using mshtml;
using Sycade.IeAutomation.Contracts;
using System;

namespace Sycade.IeAutomation
{
    public class HtmlElementFactory : IHtmlElementFactory
    {
        public TElement CreateHtmlElement<TElement>(IBrowser browser, IHTMLElement element)
        {
            return (TElement)Activator.CreateInstance(typeof(TElement), browser, element);
        }
    }
}
