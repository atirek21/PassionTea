using PassionTea.Core.Extensions;
using PassionTea.PassionTeaPages.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.PassionTeaPages.Executors
{
    public class WelcomePage:WelcomePageLocators
    {
        public void ClickHerbalTeaSeeCollectionButton()
        {
            HerbalTeaSeeCollectionButton.ClickWithWait();
        }
        public void ClickLooseTeaSeeCollectionButton()
        {
            LooseTeaSeeCollectionButton.ClickWithWait();
        }
        public void ClickFlavoredTeaSeeCollectionButton()
        {
            FlavoredTeaSeeCollectionButton.ClickWithWait();
        }
    }
}
