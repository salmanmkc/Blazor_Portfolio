using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class project
    {
        public static int imageCount = 0;
        public project(string usertitle, string usersubtitle, string userdescription, string userImagePath, string userSecondImagePath)
        {
            Title = usertitle;
            Subtitle = usersubtitle;
            Description = userdescription;
            ImagePath = userImagePath;
            SecondaryImagePath = userSecondImagePath;
            imageCount = 2;
        }

        public project(string usertitle, string usersubtitle, string userdescription, string userImagePath)
        {
            Title = usertitle;
            Subtitle = usersubtitle;
            Description = userdescription;
            ImagePath = userImagePath;
        }

        public project(string usertitle, string usersubtitle, string userdescription)
        {
            Title = usertitle;
            Subtitle = usersubtitle;
            Description = userdescription;
        }

        public project(string usertitle)
        {
            Title = usertitle;
            
        }

        public project(string usertitle, string usersubtitle)
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

        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        private string secondaryImagePath;

        public string SecondaryImagePath
        {
            get { return secondaryImagePath; }
            set { secondaryImagePath = value; }
        }

    }
}
