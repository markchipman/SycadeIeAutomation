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
        private HTMLDocumentClass _document;
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


        public IEnumerable<TElement> GetElements<TElement>()
            where TElement : HtmlElement
        {
            // Get tag name from attribute
            var tagNameAttr = typeof(TElement).GetCustomAttributes(false).Cast<TagAttribute>().SingleOrDefault();

            if (tagNameAttr == null)
                throw new ArgumentException("No tag name declared for the specified element type.", "TElement");

            // Get elements from DOM
            var browserElements = _document.getElementsByTagName(tagNameAttr.TagName);

            return browserElements.Cast<IHTMLElement>()
                                  .Select(ihe => (TElement)Activator.CreateInstance(typeof(TElement), this, ihe));
        }

        public TElement GetElementById<TElement>(string id)
            where TElement : HtmlElement
        {
            var browserElement = _document.getElementById(id);

            if (browserElement == null)
                return null;

            return (TElement)Activator.CreateInstance(typeof(TElement), this, browserElement);
        }


        private void OnIeDocumentComplete(object pDisp, ref object URL)
        {
            _document = (HTMLDocumentClass)_ie.Document;
            _documentReady = true;
        }
    }
}
