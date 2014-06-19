using mshtml;
using Sycade.IeAutomation.Contracts;
using System;
using System.Threading;

namespace Sycade.IeAutomation.Base
{
    public abstract class HtmlElement
    {
        protected internal dynamic Element { get; set; }

        public IBrowser Browser { get; protected set; }

        public bool IsEnabled
        {
            get { return !Element.disabled; }
            set { Element.disabled = !value; }
        }
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
            return (TElement)Activator.CreateInstance(typeof(TElement), Browser, Element.children[index]);
        }
    }
}
