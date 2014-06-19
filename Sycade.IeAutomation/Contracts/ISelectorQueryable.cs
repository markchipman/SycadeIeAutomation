using Sycade.IeAutomation.Base;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Contracts
{
    public interface ISelectorQueryable
    {
        IEnumerable<TElement> QueryElements<TElement>(string query)
            where TElement : HtmlElement;
    }
}
