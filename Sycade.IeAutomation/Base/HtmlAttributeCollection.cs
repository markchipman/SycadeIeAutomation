using mshtml;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sycade.IeAutomation.Base
{
    public class HtmlAttributeCollection
    {
        private IHTMLElement5 _element;

        protected IEnumerable<IHTMLDOMAttribute> Items
        {
            get { return ((IEnumerable)_element.attributes).Cast<IHTMLDOMAttribute>(); }
        }

        public int Count
        {
            get { return Items.Where(a => a.specified).Count(); }
        }

        public HtmlAttributeCollection(IHTMLElement5 element)
        {
            _element = element;
        }


        public string this[string key]
        {
            get
            {
                return _element.getAttribute(key).ToString();
            }
            set
            {
                _element.setAttribute(key, value);
            }
        }
    }
}
