using Sycade.IeAutomation.Contracts;
using Sycade.IeAutomation.Elements;
using System;
using System.Linq;
using System.Threading;

namespace Sycade.IeAutomation.Test
{
    public static class TestClass
    {
        public const string PpmcBaseUrl = "https://ppmc.hosting.corp/itg/fm/";

        public static void Go()
        {
            var browser = new Browser(true);
            //browser.DocumentCompleted += LoadFinancialSummaryComplete;
            
            // Go to Financial Summary
            browser.Navigate(PpmcBaseUrl + "FinancialSummary.do?fsId=248482");

            Thread.Sleep(Timeout.Infinite);
        }

        static void LoadFinancialSummaryComplete(IBrowser browser)
        {
            Console.WriteLine("Loaded FS");

            //browser.DocumentCompleted -= LoadFinancialSummaryComplete;
            //browser.DocumentCompleted += LoadEditCostsComplete;

            // Go to Edit Costs
            var editCostsButton = browser.GetElementById<HtmlInputButton>("editForecastActuals");
            editCostsButton.Click();
        }

        static void LoadEditCostsComplete(IBrowser browser)
        {
            Console.WriteLine("Loaded EC");

            //browser.DocumentCompleted -= LoadEditCostsComplete;

            // Get Fiscal Year select and select 2016
            var fiscalYearSelect = browser.GetElementById<HtmlSelect>("editYearId");

            var yearToSelectOption = fiscalYearSelect.Options.Where(o => o.InnerText == "2016").SingleOrDefault();

            fiscalYearSelect.Select(yearToSelectOption);
            fiscalYearSelect.Click();
        }
    }
}
