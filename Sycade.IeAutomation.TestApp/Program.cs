using Sycade.IeAutomation.Base;
using Sycade.IeAutomation.Contracts;
using Sycade.IeAutomation.Elements;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Sycade.IeAutomation.TestApp
{
    public class Program
    {
        const string PpmcBaseUrl = "https://ppmc.hosting.corp/";

        static void Main(string[] args)
        {
            int financialSummaryId = GetFinancialSummaryIdByProjectId(43428); // PMO

            FillForecastValuesForYear(financialSummaryId, 2016, new[] { 1m, 2m, 3m, 4m, 5m, 6m, 7m, 8m, 9m, 10m, 11m, 12m });
        }

        public static void Test()
        {
            IBrowser browser = new Browser(true, true);
            browser.Navigate(@"C:\Users\Michiel\Desktop\test\first.html");

            while (!browser.IsReady) ;

            var text = browser.Document.GetElements<HtmlInputButton>();
        }

        public static int GetFinancialSummaryIdByProjectId(int projectId)
        {
            // Start browser and open Search Projects page
            IBrowser browser = new Browser(true, true);
            //browser.Navigate(PpmcBaseUrl + "itg/project/SearchProjects.do");
            browser.Navigate(@"C:\Users\Michiel\Desktop\test\first.html");

            while (!browser.IsReady) ;

            // Set Project No input to project ID
            /*browser.Document.GetElementById<HtmlInputText>("PROJECT_REQUEST_ID").Value = projectId.ToString();

            // Click Go
            browser.Document.GetElementById<HtmlInputButton>("button.go").Click();

            while (!browser.IsReady) ;*/

            // Get Financial Summary anchor
            var anchor = browser.Document.GetElementById<HtmlElement>("FSFMF_KNTA_FINANCIAL_SUMMARY").GetChild<HtmlAnchor>();

            // Capture fsId from onclick attribute
            var match = Regex.Match(anchor.Attributes["onclick"], @"FinancialSummary.do\?fsId=(\d+)");

            return int.Parse(match.Groups[1].Value);
        }

        public static void FillForecastValuesForYear(int financialSummaryId, int year, decimal[] values)
        {
            // Navigate to Financial Summary
            var browser = new Browser(true, true);
            browser.Navigate(PpmcBaseUrl + "itg/fm/FinancialSummary.do?fsId=" + financialSummaryId);

            while (!browser.IsReady) ;

            // Navigate to Edit Costs through the button
            browser.Document.GetElementById<HtmlInputButton>("editForecastActuals").Click();

            while (!browser.IsReady) ;

            // Set Fiscal Year
            var fiscalYearSelect = browser.Document.GetElementById<HtmlSelect>("editYearId");
            var yearOption = fiscalYearSelect.Options.SingleOrDefault(o => o.InnerText == year.ToString());

            fiscalYearSelect.Select(yearOption);

            Thread.Sleep(1250);

            // Fill values into first Cost Line
            var forecastTable = browser.Document.GetElementById<HtmlTable>("forecastActualRightTable");
            var forecastRow = forecastTable.Rows[3]; // First Cost Line

            for (int i = 0; i < 12; i++)
            {
                forecastRow.Cells[i].Click();
                forecastRow.Cells[i].GetChild<HtmlInputText>().Value = values[i].ToString();
            }

            // Click Save
            browser.Document.GetElementById<HtmlInputButton>("save.button.footer").Click();
        }
    }
}