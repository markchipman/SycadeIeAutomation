using System;

namespace Sycade.IeAutomation.Contracts
{
    public interface IBrowser : IDisposable
    {
        /// <summary>
        /// Gets the currently active IDomDocument.
        /// </summary>
        IDomDocument Document { get; }

        /// <summary>
        /// Gets a value indicating whether the browser is done navigating and the document is ready.
        /// </summary>
        /// <seealso cref="Document"/>
        bool IsReady { get; }
        /// <summary>
        /// Gets or sets a value indicating whether the browser window is user-visible.
        /// </summary>
        bool IsVisible { get; set; }

        /// <summary>
        /// Starts navigation to the specified URL.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        void Navigate(string url);        
    }
}
