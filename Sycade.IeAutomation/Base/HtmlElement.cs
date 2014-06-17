using mshtml;
using Sycade.IeAutomation.Contracts;
using System.Threading;

namespace Sycade.IeAutomation.Base
{
    public abstract class HtmlElement
    {
        protected internal dynamic Element { get; set; }

        public IBrowser Browser { get; protected set; }

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

        public HtmlElement(IBrowser browser, IHTMLElement element)
        {
            Browser = browser;

            Element = element;
        }


        public void Click()
        {
            Element.focus();
            Element.click();
        }
    }
}
