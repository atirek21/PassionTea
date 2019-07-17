
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassionTea.Form_Data.Objects;
using Faker;
using PassionTea.Core.Utilities;
using PassionTea.Cards;
namespace PassionTea.FormData.Builders
{
    public class CheckOutFormBuilder
    {
        public static CheckOutFormModel BuildCheckOutDetails(CardType cardType)
        {
            var fullname = Faker.Name.FullName();
            var model = new CheckOutFormModel();
            {
                Email = Faker.Internet.Email(fullname),Name = fullname,Address = Faker.Address.City(),CardType = EnumHelper.GetEnumDescription(cardType),CardNumber = Faker.RandomNumber.Next(10000000, 99999999).ToString() + Faker.RandomNumber.Next(1000000, 99999999),CardholderName = Faker.Name.FullName(),VerificationCode = Faker.RandomNumber.Next(100, 999),
                };
            return model;

            }
        }
    }

