using Sycade.IeAutomation.Contracts;
using Sycade.IeAutomation.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sycade.IeAutomation.TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Go();
        }

        public static void Go()
        {
            //var browser = new Browser(true, true);
            //browser.Navigate("https://ppmc.hosting.corp/itg/fm/FinancialSummary.do?fsId=248482");
            var browser = new Browser(true, true);
            browser.Navigate(@"C:\Users\Michiel\Desktop\test\first.html");

            while (!browser.IsReady) ;

            Console.WriteLine("Browser done");

            // Navigate to Edit Costs through the button
            //var editCostsButton = browser.GetElementById<HtmlInputButton>("editForecastActuals");
            //editCostsButton.Click();
            var button = browser.Document.GetElementById<HtmlAnchor>("linkje");
            //button.Click();

            //Console.WriteLine("Button clicked");

            //while (!browser.IsReady) ;

            //Console.WriteLine("Browser done");

            //var button2 = browser.Document.GetElementById<HtmlButton>("testbtn");

            //Console.WriteLine("Button is null: {0}", button2 == null);

            Console.ReadLine();

            //// Set Fiscal Year to 2016
            //var fiscalYearSelect = browser.GetElementById<HtmlSelect>("editYearId");
            //fiscalYearSelect.Select(4);

            //Console.WriteLine("Year selected");
        }
    }
}
