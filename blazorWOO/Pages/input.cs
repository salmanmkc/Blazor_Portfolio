using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class input
    {
        public input(string Type, string Placeholder)
        {
            type = Type;
            placeholder = Placeholder;
        }

        public string type { get; set; }
        public string placeholder { get; set; }
    }
}
