using System;

namespace Sycade.IeAutomation.Contracts
{
    public interface IBrowser : IDisposable
    {
        IDomDocument Document { get; }

        bool IsReady { get; }
        bool IsVisible { get; set; }

        void Navigate(string url);        
    }
}
