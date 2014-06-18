using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation
{
    public class HtmlDocument : IHtmlDocument
    {
        private IBrowser _browser;
        private HTMLDocument _document;

        public HtmlDocument(IBrowser browser, HTMLDocument document)
        {
            _browser = browser;
            _document = document;
        }


        public TElement GetElementById<TElement>(string id)
            where TElement : HtmlElement
        {
            var browserElement = _document.getElementById(id);

            if (browserElement == null)
                return null;

            return (TElement)Activator.CreateInstance(typeof(TElement), _browser, browserElement);
        }

        public IEnumerable<TElement> GetElements<TElement>()
            where TElement : HtmlElement
        {
            // Get tag name from attribute
            var tagNameAttr = typeof(TElement).GetCustomAttributes(false).Cast<TagAttribute>().SingleOrDefault();

            if (tagNameAttr == null)
                throw new ArgumentException("No tag name declared for the specified element type.", "TElement");

            // Get elements from DOM
            var browserElements = _document.getElementsByTagName(tagNameAttr.Name);

            return browserElements.Cast<IHTMLElement>()
                                  .Select(ihe => (TElement)Activator.CreateInstance(typeof(TElement), _browser, ihe));
        }

        public IEnumerable<TElement> GetElementsByName<TElement>(string name)
            where TElement : HtmlElement
        {
            var browserElements = _document.getElementsByName(name);

            return browserElements.Cast<IHTMLElement>()
                                  .Select(ihe => (TElement)Activator.CreateInstance(typeof(TElement), _browser, ihe));
        }
    }
}
