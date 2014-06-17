using mshtml;
using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Elements
{
    [TagName("select")]
    public class HtmlSelect : HtmlElement<HTMLSelectElementClass>
    {
        public IEnumerable<HtmlOption> Options
        {
            get { return Element.Cast<IHTMLElement>().Select(ihe => new HtmlOption(Browser, ihe)); }
        }

        public HtmlSelect(IBrowser browser, IHTMLElement element)
            : base(browser, element) { }


        public void Select(int index)
        {
            Element.selectedIndex = index;
        }

        public void Select(HtmlOption option)
        {
            for (int i = 0; i < Options.Count(); i++)
            {
                if (Options.ElementAt(i).Element == option.Element)
                {
                    Select(i);
                    return;
                }
            }
        }
    }
}
