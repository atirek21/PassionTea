using PassionTea.Core.Extensions;
using PassionTea.FormData.Objects;
using PassionTea.PassionTeaPages.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.PassionTeaPages.Executors
{
    public class FeedbackPage:FeedbackPageLocators
    {
        public void FillFeedbackForm(FeedbackFormModel model)
        {
            EmailInput.SendKeysWithWait(model.Email);
            NameInput.SendKeysWithWait(model.Name);
            SubjectInput.SendKeysWithWait(model.Subject);
            MessageInput.SendKeysWithWait(model.Message);
        }
    }
}
