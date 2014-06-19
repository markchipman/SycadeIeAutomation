﻿using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    [Tag("input", "text")]
    public class HtmlInputText : HtmlElement
    {
        public string Value
        {
            get { return Element.value; }
            set { Element.value = value; }
        }

        public HtmlInputText(IHTMLElement element, IHtmlElementFactory htmlElementFactory)
            : base(element, htmlElementFactory) { }
    }
}
