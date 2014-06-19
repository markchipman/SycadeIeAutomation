using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation
{
    public class HtmlElementFactory : IHtmlElementFactory
    {
        public TElement CreateHtmlElement<TElement>(IHTMLElement element)
            where TElement : HtmlElement
        {
            return (TElement)Activator.CreateInstance(typeof(TElement), element, this);
        }

        public IEnumerable<TElement> CreateHtmlElements<TElement>(IEnumerable elements)
            where TElement : HtmlElement
        {
            return elements.Cast<IHTMLElement>().Select(ihe => CreateHtmlElement<TElement>(ihe));
        }
    }
}
