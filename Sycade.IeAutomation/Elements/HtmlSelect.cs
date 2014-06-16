using mshtml;
using Sycade.IeAutomation.Elements.Base;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Elements
{
    public class HtmlSelect : HtmlElement<HTMLSelectElementClass>
    {
        public IEnumerable<HtmlOption> Options
        {
            get { return Element.Cast<IHTMLElement>().Select(ihe => new HtmlOption(ihe)); }
        }

        public HtmlSelect(IHTMLElement element)
            : base(element) { }


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
