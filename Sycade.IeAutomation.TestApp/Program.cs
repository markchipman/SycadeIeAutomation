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
            var browser = new Browser(true);
            browser.Navigate("http://www.w3schools.com/html/html_tables.asp");

            while (browser.IsBusy) ;

            Console.WriteLine("ODC");

            var selects = browser.GetElements<HtmlTable>();

            browser.GetElementById<HtmlInputText>("gbqfq").Value = "TestTest";
            browser.GetElementById<HtmlButton>("gbqfba").Click();

            Console.WriteLine("ODC done");

            
        }
    }
}
