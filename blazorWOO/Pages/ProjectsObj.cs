using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class ProjectsObj
    {
        public ProjectsObj(string usertitle, string usersubtitle, string userdescription)
        {
            Title = usertitle;
            Subtitle = usersubtitle;
            Description = userdescription;
        }

        public ProjectsObj(string usertitle)
        {
            Title = usertitle;
            
        }

        public ProjectsObj(string usertitle, string usersubtitle)
        {
            Title = usertitle;
            Subtitle = usersubtitle;
        } 

        private string title;

        public string Title
        {
            get { return title; }
            set {
                if(value!= "")
                {
                    title = value;
                }
                else
                {
                    throw new Exception("Can't have an title");
                }
                
            }
        }

        private string subtitle;

        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


    }
}
