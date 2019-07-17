using PassionTea.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.PassionTeaPages.Executors
{
    public class MenuPage:Locators.MenuPageLocators
    {
        public void ClickGreenTeaButton()
        {
            GreenTeaButton.IsDisplayedAfterWait().Should().BeTrue();
            GreenTeaButton.ClickWithWait();
        }
        public void ClickRedTeaButton()
        {
            RedTeaButton.IsDisplayedAfterWait().Should().BeTrue();
            RedTeaButton.ClickWithWait();
        }
        public void ClickOolongTeaButton()
        {
            OolongTeaButton.IsDisplayedAfterWait().Should().BeTrue();
            OolongTeaButton.ClickWithWait();
        }
    }
}
