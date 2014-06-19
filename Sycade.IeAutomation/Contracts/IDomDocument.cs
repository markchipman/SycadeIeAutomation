using Sycade.IeAutomation.Base;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Contracts
{
    public interface IDomDocument : ISelectorQueryable
    {
        /// <summary>
        /// Gets an element with the specified id from the document.
        /// </summary>
        /// <typeparam name="TElement">The type of the element.</typeparam>
        /// <param name="id">The id of the element to find.</param>
        /// <returns>The element with the specified id, or null if the element was not found.</returns>
        TElement GetElementById<TElement>(string id)
            where TElement : HtmlElement;

        /// <summary>
        /// Gets elements with the specified type from the document.
        /// </summary>
        /// <typeparam name="TElement">The type of the elements.</typeparam>
        /// <returns>The elements with the specified type, or an empty enumerable if none were found.</returns>
        IEnumerable<TElement> GetElements<TElement>()
            where TElement : HtmlElement;
        /// <summary>
        /// Gets elements with the specified name from the document.
        /// </summary>
        /// <typeparam name="TElement">The type of the elements.</typeparam>
        /// <param name="name">The name of the elements to find.</param>
        /// <returns>The elements with the specified name, or an empty enumerable if none were found.</returns>
        IEnumerable<TElement> GetElementsByName<TElement>(string name)
            where TElement : HtmlElement;
    }
}
