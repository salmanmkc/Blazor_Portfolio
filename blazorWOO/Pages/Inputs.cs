using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class Inputs
    {
        public List<input> inputList = new List<input>();
        public Inputs()
        {
            input i1 = new input("text", "First Name");
            inputList.Add(i1);
            input i2 = new input("text", "Second Name");
            inputList.Add(i2);
            input i3 = new input("email", "Email Address");
            inputList.Add(i3);
            input i4 = new input("date", "Date of Birth");
            inputList.Add(i4);


        }
    }
}
