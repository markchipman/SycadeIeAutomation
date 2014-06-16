using Sycade.IeAutomation;
using Sycade.IeAutomation.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumTest
{
    public class Program
    {
        public const string PpmcBaseUrl = "https://ppmc.hosting.corp/ifg/pm/";

        private Browser _browser;

        public Program()
        {
            _browser = new Browser();
        }

        public void Go()
        {
            _browser.Navigate("http://www.bing.com/");
            _browser.Visible = true;

            _browser.GetElementById<HtmlInputButton>("sb_form_go");

            _browser.Dispose();
        }

        static void Main(string[] args)
        {
            new Program().Go();
        }
    }
}
