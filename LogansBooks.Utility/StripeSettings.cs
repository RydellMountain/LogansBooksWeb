using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogansBooks.Utility
{
    //A simple declaration of variables for the Stripe API Keys, whic are referenced in the appsetting.json. And then these variables can be called isntead of using hte magic strings
    public class StripeSettings
    {
        public string SecretKey { get; set; }
        public string PublishableKey { get; set; }
    }
}
