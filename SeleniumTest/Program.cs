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
        

        private Browser _browser;

        public Program()
        {
            _browser = new Browser();
        }

        public void Go()
        {

        }

        static void Main(string[] args)
        {
            new Program().Go();
        }
    }
}
