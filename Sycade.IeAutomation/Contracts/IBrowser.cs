using Sycade.IeAutomation.Base;
using System;
using System.Collections.Generic;

namespace Sycade.IeAutomation.Contracts
{
    public interface IBrowser : IDisposable
    {
        IHtmlDocument Document { get; }

        bool IsReady { get; }
        bool IsVisible { get; set; }

        void Navigate(string url);        
    }
}
