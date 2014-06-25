using mshtml;
using Sycade.IeAutomation.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Base
{
    public class HtmlElement : ISelectorQueryable
    {
        protected internal dynamic Element { get; set; }
        protected IHtmlElementFactory HtmlElementFactory { get; set; }

        public HtmlAttributeCollection Attributes { get; protected set; }

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
        public bool IsEnabled
        {
            get { return !Element.disabled; }
            set { Element.disabled = !value; }
        }

        public HtmlElement(IHTMLElement element, IHtmlElementFactory htmlElementFactory)
        {
            Element = element;
            HtmlElementFactory = htmlElementFactory;

            Attributes = new HtmlAttributeCollection(Element);
        }


        public void Blur()
        {
            Element.blur();
        }

        public void Click()
        {
            Focus();
            Element.click();
        }

        public void FireEvent(string eventName)
        {
            Element.FireEvent(eventName);
        }

        public void Focus()
        {
            Element.focus();
        }


        public TElement GetChild<TElement>(int index = 0)
            where TElement : HtmlElement
        {
            return HtmlElementFactory.CreateHtmlElement<TElement>(Element.children[index]);
        }

        public IEnumerable<TElement> QueryElements<TElement>(string query)
            where TElement : HtmlElement
        {
            return HtmlElementFactory.CreateHtmlElements<TElement>(Element.querySelectorAll(query));
        }
    }
}
