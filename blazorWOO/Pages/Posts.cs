using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class Posts
    {
        public List<post> posts = new List<post>();
        public Posts()
        {
            post OneSmallChange = new post("One Small Change","After telling my mother that I would be meeting the author(Rob Miles) of the C# 70-483 exam preparation book that I have been reading, she enquired whether or not I would be writing my own book. I honestly was taken a step back and second guessed myself. Would I have thought that I would be an author when I was 9 years old, perhaps, but that's when I took a major turn in my life? I used to love writing stories, conjuring up a whole new universe and having complete control over someone's thoughts, actions and consequences without any backlash; the possibilities are endless. Yet, at the same time, you know exactly what will happen by the end of the story, or you can let them be a surprise for yourself (I personally prefer the latter), letting the flow overtake your writing into its own abyss.", "/css/Assets/BlogImages/OneSmallChange/0.jfif", "I remember this one time in my primary school, Montpelier; we all had to write a book and marked by a deadline, we had to record the book. I got so indulged in writing the book (much like I do with programming today) that I never ended up recording the audio for it. My teacher would give feedback to my mother saying that she got annoyed that I had flute lessons because I always left the stories on cliffhangers (although sometimes I did this for dramatic effect). That thought makes me smile, to have a story that brings that effect onto someone. I miss that, I miss being in a world of creativity, being able to bring a change to someone's life. As I have gotten better at programming I have been able to incorporate that creativity back, as well as through different mediums such as photography and music.", );
            posts.Add(OneSmallChange);
        }
    }
}
