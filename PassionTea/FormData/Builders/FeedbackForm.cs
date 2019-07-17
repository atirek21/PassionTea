using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using PassionTea.FormData.Objects;

namespace PassionTea.FormData.Builders
{
    public class FeedbackFormBuilder
    {
        public static FeedbackFormModel BuildFeedbackDetails()
        {
            var fullname = Faker.Name.FullName();
            var model = new FeedbackFormModel();
                {
                Email = Faker.Internet.Email(fullname),
                Name = fullname,
                Subject = Faker.Lorem.Sentence(),
                Message= Faker.Lorem.Paragraph(),
            };
            return model;
        }
    }
}
