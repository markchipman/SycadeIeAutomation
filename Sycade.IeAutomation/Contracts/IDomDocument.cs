using Sycade.IeAutomation.Base;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Contracts
{
    public interface IDomDocument
    {
        TElement GetElementById<TElement>(string id)
            where TElement : HtmlElement;

        IEnumerable<TElement> GetElements<TElement>()
            where TElement : HtmlElement;
        IEnumerable<TElement> GetElementsByName<TElement>(string name)
            where TElement : HtmlElement;

        IEnumerable<TElement> QueryElements<TElement>(string query)
            where TElement : HtmlElement;
    }
}
