using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation
{
    public class DomDocument : IDomDocument
    {
        private const string QueryByInputTypeFormatString = "input[type='{0}']";

        private IBrowser _browser;
        private HTMLDocument _document;
        private IHtmlElementFactory _htmlElementFactory;

        public DomDocument(HTMLDocument document, IBrowser browser, IHtmlElementFactory htmlElementFactory = null)
        {
            _document = document;
            _browser = browser;

            _htmlElementFactory = htmlElementFactory ?? new HtmlElementFactory();
        }


        public TElement GetElementById<TElement>(string id)
            where TElement : HtmlElement
        {
            var browserElement = _document.getElementById(id);

            if (browserElement == null)
                return null;

            return _htmlElementFactory.CreateHtmlElement<TElement>(browserElement);
        }


        public IEnumerable<TElement> GetElements<TElement>()
            where TElement : HtmlElement
        {
            // Get tag name from attribute
            var tag = typeof(TElement).GetCustomAttributes(false).Cast<TagAttribute>().SingleOrDefault();

            if (tag == null)
                throw new ArgumentException("No tag name declared for the specified element type.", "TElement");

            // Create elements
            if (tag.InputType != null)
                return QueryElements<TElement>(string.Format(QueryByInputTypeFormatString, tag.InputType));
            else
                return _htmlElementFactory.CreateHtmlElements<TElement>(_document.getElementsByTagName(tag.Name));
        }

        public IEnumerable<TElement> GetElementsByName<TElement>(string name)
            where TElement : HtmlElement
        {
            return _htmlElementFactory.CreateHtmlElements<TElement>(_document.getElementsByName(name));
        }


        public IEnumerable<TElement> QueryElements<TElement>(string query)
            where TElement : HtmlElement
        {
            return _htmlElementFactory.CreateHtmlElements<TElement>(_document.querySelectorAll(query));
        }
    }
}
