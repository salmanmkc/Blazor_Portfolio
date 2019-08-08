using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class ProjectsObj
    {
        public List<project> projects = new List<project>();
        public ProjectsObj()
        {
            project project1 = new project("Rocket Gravity Assist Simulation", "Made for physics teacher", "This program demonstrates the use of the gravity slingshot effect which can be used by physics students doing A level or GCSE physics to help prepare for their exam and use for homework as well as in the lesson as an interactive activity", "https://www.youtube.com/embed/OBJu8J10NmM");
            project project2 = new project("Film Adder", "Made for adding films", "This program can be used to share films with your friends, and family, also track which films you want to watch, as well as leave a rating", "https://www.youtube.com/embed/cldPcwFMqb8");

            
            projects.Add(project1);
            projects.Add(project2);
        }

        

    }
}
