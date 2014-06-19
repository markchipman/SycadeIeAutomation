using Sycade.IeAutomation.Base;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Contracts
{
    public interface ISelectorQueryable
    {
        /// <summary>
        /// Queries with the specified CSS selector query as the specified element type.
        /// </summary>
        /// <typeparam name="TElement">The element type to create.</typeparam>
        /// <param name="query">The CSS selector query to execute.</param>
        /// <returns>The elements found by the query, or an empty enumerable if none were found.</returns>
        IEnumerable<TElement> QueryElements<TElement>(string query)
            where TElement : HtmlElement;
    }
}
