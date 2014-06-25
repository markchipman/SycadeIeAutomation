using mshtml;
using Sycade.IeAutomation.Base;
using System.Collections;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Contracts
{
    public interface IHtmlElementFactory
    {
        /// <summary>
        /// Creates an element with the specified type from the provided IHTMLElement.
        /// </summary>
        /// <typeparam name="TElement">The element type to create.</typeparam>
        /// <param name="element">The IHTMLElement to instantiate the element with.</param> 
        /// <returns>The element with the specified type.</returns>
        TElement CreateHtmlElement<TElement>(IHTMLElement element)
            where TElement : HtmlElement;

        /// <summary>
        /// Creates elements with the specified type from the provided IEnumerable.
        /// </summary>
        /// <typeparam name="TElement">The element type to create.</typeparam>
        /// <param name="elements">The IHTMLElements to instantiate the elements with.</param>
        /// <returns>The elements with the specified type.</returns>
        List<TElement> CreateHtmlElements<TElement>(IEnumerable elements)
            where TElement : HtmlElement;
    }
}