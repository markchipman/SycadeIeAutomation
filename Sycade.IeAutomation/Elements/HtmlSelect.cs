using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Elements
{
    [Tag("select")]
    public class HtmlSelect : HtmlElement
    {
        public List<HtmlOption> Options
        {
            get { return HtmlElementFactory.CreateHtmlElements<HtmlOption>(Element); }
        }
        public string Value
        {
            get { return Element.value; }
            set { Element.value = value; }
        }

        public HtmlSelect(IHTMLElement element, IHtmlElementFactory htmlElementFactory)
            : base(element, htmlElementFactory) { }


        public void Select(int index)
        {
            Element.selectedIndex = index;

            FireEvent("onchange");
        }

        public void Select(HtmlOption option)
        {
            for (int i = 0; i < Options.Count(); i++)
            {
                if (Options[i].Element == option.Element)
                {
                    Select(i);
                    return;
                }
            }
        }

        public void SelectByValue(string value)
        {
            var optionToSelect = Options.SingleOrDefault(o => o.Value == value);

            if (optionToSelect != null)
                Select(optionToSelect);
        }
    }
}
