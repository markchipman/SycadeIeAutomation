using Sycade.IeAutomation.Base;
using System;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Contracts
{
    public interface IBrowser : IDisposable
    {
        bool IsBusy { get; }
        bool IsVisible { get; set; }

        void Navigate(string url);

        List<TElement> GetElements<TElement>()
            where TElement : HtmlElement;
        //List<TElement> GetElementsByName<TElement>(string name)
        //    where TElement : HtmlElement;
        TElement GetElementById<TElement>(string id)
            where TElement : HtmlElement;
        
    }
}
