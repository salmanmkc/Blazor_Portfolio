using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class Inputs
    {
        public Inputs()
        {
            input i1 = new input("text", "First Name");
            input i2 = new input("text", "Second Name");
            input i3 = new input("email", "Email Address");
            input i4 = new input("date", "Date of Birth");

        }
    }
}
