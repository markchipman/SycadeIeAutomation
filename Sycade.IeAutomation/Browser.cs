using mshtml;
using SHDocVw;
using Sycade.IeAutomation.Contracts;

namespace Sycade.IeAutomation
{
    public class Browser : IBrowser
    {
        private IWebBrowser2 _ie;
        private bool _isReady;

        public IDomDocument Document { get; protected set; }

        public bool IsReady
        {
            get
            {
                var readyState = _ie.ReadyState == tagREADYSTATE.READYSTATE_COMPLETE;

                return _isReady && readyState;
            }
            set { _isReady = value; }
        }
        public bool IsVisible
        {
            get { return _ie.Visible; }
            set { _ie.Visible = value; }
        }

        public Browser(bool visible = false, bool mediumIntegrityLevel = false)
        {
            if (mediumIntegrityLevel)
                _ie = new InternetExplorerMediumClass();
            else
                _ie = new InternetExplorerClass();

            ((DWebBrowserEvents2_Event)_ie).DocumentComplete += OnIeDocumentComplete;
            ((DWebBrowserEvents2_Event)_ie).BeforeNavigate2 += OnIeBeforeNavigate;

            IsVisible = visible;
        }

        public void Dispose()
        {
            _ie.Quit();
        }


        public void Navigate(string url)
        {
            IsReady = false;

            _ie.Navigate(url);
        }


        private void OnIeDocumentComplete(object pDisp, ref object URL)
        {
            Document = new DomDocument((HTMLDocument)_ie.Document, this);

            IsReady = true;
        }

        private void OnIeBeforeNavigate(object pDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
        {
            IsReady = false;
        }
    }
}
