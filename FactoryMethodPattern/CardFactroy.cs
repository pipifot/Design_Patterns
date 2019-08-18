using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }

}
