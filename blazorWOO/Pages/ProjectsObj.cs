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
            project RocketGravityAssist = new project("Rocket Gravity Assist Simulation", "Made for physics teacher", "This program demonstrates the use of the gravity slingshot effect which can be used by physics students doing A level or GCSE physics to help prepare for their exam and use for homework as well as in the lesson as an interactive activity", "https://www.youtube.com/embed/OBJu8J10NmM");
            project FilmAdder = new project("Film Adder", "Made for adding films", "This program can be used to share films with your friends, and family, also track which films you want to watch, as well as leave a rating", "https://www.youtube.com/embed/cldPcwFMqb8");
            introductionText = "";
            project soundWarning = new project("Sound Warning", "Made to alert the user when their microphone/speakers are too loud", "Made this project in repsonse to Amazon Echos in the UK not having Alexa Gaurd, which alerts customers when there has been a loud sound, such as breaking a window, to protect the user from any burglary attacks, then I ended up changing the project to alert the user when they speak too loudly into their microphone, and subsequently this should also pick up loud sounds. This program is actually very useful to me. I use audio interfaces which have a little light that comes on when you speak over a certain threshold, however I put my audio interfaces off to the side, so I can never see the light, therefore this program is so useful as I have set it up to give me a pop up notification on my screen saying that I am talking too loud into it. In the future, I would probably change it to have toast notifications, or let the user choose if they want toast or normal notifications", "/css/Assets/ProjectImages/SoundWarning/recordingAudio.png");

            projects.Add(RocketGravityAssist);
            projects.Add(FilmAdder);
            projects.Add(soundWarning);
        }

        public string introductionText { get; set; }


    }
}
