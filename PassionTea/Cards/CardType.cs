
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Cards
{
    public enum CardType
    {
        [Description("Visa")]
        Visa,
        [Description("MasterCard")]
        MasterCard,
        AmericanExpress,
        DinerClub,
    }
}
