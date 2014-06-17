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

        [DllImport("user32.dll")]
        public static extern bool UpdateWindow(IntPtr hWnd);

        public static void Go()
        {
            var browser = new Browser(true);
            //browser.DocumentCompleted += OnDocumentCompleted;

            browser.Navigate("http://google.nl");

            while (browser.IsBusy) ;

            Console.WriteLine("ODC");

            browser.GetElementById<HtmlInputText>("gbqfq").Value = "TestTest";
            //browser.GetElementById<HtmlButton>("gbqfba").Click();

            Console.WriteLine("ODC done");

            UpdateWindow(browser.Hwnd);
        }

        static void OnDocumentCompleted(IBrowser browser)
        {
            //browser.DocumentCompleted -= OnDocumentCompleted;

            
        }
    }
}
