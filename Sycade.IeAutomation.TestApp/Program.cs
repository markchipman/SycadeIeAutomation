using Sycade.IeAutomation.Elements;
using System;
using System.Linq;
using System.Threading;

namespace Sycade.IeAutomation.TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Go();
            GoLocal();
        }

        public static void GoLocal()
        {
            var browser = new Browser(true, true);
            browser.Navigate(@"C:\Users\Michiel\Desktop\test\first.html");

            while (!browser.IsReady) ;

            var select = browser.Document.GetElementById<HtmlSelect>("testSelect");

            while (!select.IsEnabled) ;

            Console.ReadLine();
        }

        public static int GetFinancialSummaryIdByProjectId(int projectId)
        {
            var browser = new Browser(true, true);
            browser.Navigate("");

            while (!browser.IsReady) ;

            return 0;
        }

        public static void Go()
        {
            // Navigate to Financial Summary
            var browser = new Browser(true, true);
            browser.Navigate("https://ppmc.hosting.corp/itg/fm/FinancialSummary.do?fsId=248482");

            while (!browser.IsReady) ;

            // Navigate to Edit Costs through the button
            var editCostsButton = browser.Document.GetElementById<HtmlInputButton>("editForecastActuals");
            editCostsButton.Click();

            while (!browser.IsReady) ;

            // Set Fiscal Year to 2016
            var fiscalYearSelect = browser.Document.GetElementById<HtmlSelect>("editYearId");
            var yearOption = fiscalYearSelect.Options.SingleOrDefault(o => o.InnerText == "2016");

            fiscalYearSelect.Select(yearOption);

            Thread.Sleep(1250);

            // Fill values into first Cost Line
            var forecastTable = browser.Document.GetElementById<HtmlTable>("forecastActualRightTable");
            var forecastRow = forecastTable.Rows[3]; // First Cost Line

            for (int i = 0; i < 12; i++)
            {
                forecastRow.Cells[i].Click();
                forecastRow.Cells[i].GetChild<HtmlInputText>().Value = i.ToString();
            }

            // Click Save
            browser.Document.GetElementById<HtmlInputButton>("save.button.footer").Click();
        }
    }
}
