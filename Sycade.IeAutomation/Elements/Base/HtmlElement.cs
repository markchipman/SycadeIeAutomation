using mshtml;

namespace Sycade.IeAutomation.Elements.Base
{
    public abstract class HtmlElement
    {
        public bool IsValid { get; protected set; }
    }

    public abstract class HtmlElement<TElement> : HtmlElement
        where TElement : class, IHTMLElement
    {
        protected internal TElement Element { get; set; }

        public string InnerHtml
        {
            get { return Element.innerHTML; }
            set { Element.innerHTML = value; }
        }
        public string InnerText
        {
            get { return Element.innerText; }
            set { Element.innerText = value; }
        }

        public HtmlElement(IHTMLElement element)
        {
            Element = element as TElement;

            IsValid = Element != null;
        }


        public void Click()
        {
            Element.click();
        }
    }
}
