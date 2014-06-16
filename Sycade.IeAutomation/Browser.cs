using mshtml;
using SHDocVw;
using Sycade.IeAutomation.Elements.Base;
using System;
using System.Collections.Generic;

namespace Sycade.IeAutomation
{
    public class Browser : IDisposable
    {
        private InternetExplorer _ie;
        private HTMLDocument _document;

        public bool Visible
        {
            get { return _ie.Visible; }
            set { _ie.Visible = value; }
        }

        public Browser()
        {
            _ie = new InternetExplorerClass();
        }

        public void Dispose()
        {
            _ie.Quit();
        }


        public void Navigate(string url)
        {
            _ie.Navigate(url);

            while (_ie.Busy) ;

            _document = (HTMLDocument)_ie.Document;
        }


        public TElement GetElementById<TElement>(string id)
            where TElement : HtmlElement
        {
            var browserElement = _document.getElementById(id);

            if (browserElement == null)
                throw new InvalidOperationException("Element not found");

            var element = (TElement)Activator.CreateInstance(typeof(TElement), browserElement);

            if (!element.IsValid)
                throw new InvalidOperationException("Not valid");

            return element;
        }

        public List<TElement> GetElementsByTagName<TElement>(string tagName)
            where TElement : HtmlElement
        {
            var browserElements = _document.getElementsByTagName(tagName);

            var elements = new List<TElement>();

            foreach (var browserElement in browserElements)
            {
                var element = (TElement)Activator.CreateInstance(typeof(TElement), browserElement);

                if (!element.IsValid)
                    throw new InvalidOperationException("Not valid");

                elements.Add(element);
            }

            return elements;
        }
    }
}
