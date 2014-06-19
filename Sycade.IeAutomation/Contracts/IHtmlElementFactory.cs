using mshtml;
using Sycade.IeAutomation.Base;
using System.Collections;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Contracts
{
    public interface IHtmlElementFactory
    {
        TElement CreateHtmlElement<TElement>(IHTMLElement element)
            where TElement : HtmlElement;

        IEnumerable<TElement> CreateHtmlElements<TElement>(IEnumerable elements)
            where TElement : HtmlElement;
    }
}