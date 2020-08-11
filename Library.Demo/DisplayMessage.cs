using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Demo
{
    public class DisplayMessage
    {
        public string Greeting(string firstName, int hourOfTheDay)
        {
            string greetings = "";
            if (hourOfTheDay < 5)
            {
                greetings = $"Go To Bed {firstName}";
            }
            else if (hourOfTheDay < 12)
            {
                greetings = $"Good Morning {firstName}";
            }

            else if (hourOfTheDay < 18)
            {
                greetings = $"Good Afternoon {firstName}";
            }

            else
            {
                greetings = $"Good Evening {firstName}";
            }
            return greetings;
        }


      
    }
}
