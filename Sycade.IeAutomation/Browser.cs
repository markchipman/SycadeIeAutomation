using mshtml;
using SHDocVw;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation
{
    public class Browser : IBrowser
    {
        private InternetExplorer _ie;
        private HTMLDocument _document;
        private bool _documentReady;

        public bool IsBusy
        {
            get { return _ie.Busy || !_documentReady; }
        }
        public bool IsVisible
        {
            get { return _ie.Visible; }
            set { _ie.Visible = value; }
        }

        public Browser(bool visible = false)
        {
            _ie = new InternetExplorerClass();

            _ie.DocumentComplete += OnIeDocumentComplete;

            IsVisible = visible;
        }

        public void Dispose()
        {
            _ie.Quit();
        }


        public void Navigate(string url)
        {
            _documentReady = false;

            _ie.Navigate(url);
        }


        public List<TElement> GetElements<TElement>()
            where TElement : HtmlElement
        {
            // Get tag name from attribute
            var tagNameAttr = typeof(TElement).GetCustomAttributes(false).Cast<TagNameAttribute>().SingleOrDefault();

            if (tagNameAttr == null)
                throw new InvalidOperationException("No attr on this class");

            // Get elements from DOM
            var browserElements = _document.getElementsByTagName(tagNameAttr.TagName);

            var elements = new List<TElement>();

            foreach (var browserElement in browserElements)
            {
                var element = (TElement)Activator.CreateInstance(typeof(TElement), this, browserElement);

                if (!element.IsValid)
                    throw new InvalidOperationException("Not valid");

                elements.Add(element);
            }

            return elements;
        }

        public TElement GetElementById<TElement>(string id)
            where TElement : HtmlElement
        {
            var browserElement = _document.getElementById(id);

            if (browserElement == null)
                throw new InvalidOperationException("Element not found");

            var element = (TElement)Activator.CreateInstance(typeof(TElement), this, browserElement);

            if (!element.IsValid)
                throw new InvalidOperationException("Not valid, browserelement is " + Microsoft.VisualBasic.Information.TypeName(browserElement) + " and element is " + typeof(TElement));

            return element;
        }


        private void OnIeDocumentComplete(object pDisp, ref object URL)
        {
            _document = (HTMLDocument)_ie.Document;
            _documentReady = true;
        }
    }
}
