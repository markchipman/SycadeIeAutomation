using mshtml;

namespace Sycade.IeAutomation.Contracts
{
    public interface IHtmlElementFactory
    {
        TElement CreateHtmlElement<TElement>(IBrowser browser, IHTMLElement element);
    }
}
