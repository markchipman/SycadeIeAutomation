﻿using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation.Elements
{
    [Tag("button")]
    public class HtmlButton : HtmlElement
    {
        public HtmlButton(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }
    }
}
