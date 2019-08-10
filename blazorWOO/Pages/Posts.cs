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
            post OneSmallChange = new post("One Small Change","After telling my mother that I would be meeting the author(Rob Miles) of the C# 70-483 exam preparation book that I have been reading, she enquired whether or not I would be writing my own book. I honestly was taken a step back and second guessed myself. Would I have thought that I would be an author when I was 9 years old, perhaps, but that's when I took a major turn in my life? I used to love writing stories, conjuring up a whole new universe and having complete control over someone's thoughts, actions and consequences without any backlash; the possibilities are endless. Yet, at the same time, you know exactly what will happen by the end of the story, or you can let them be a surprise for yourself (I personally prefer the latter), letting the flow overtake your writing into its own abyss.");
            posts.Add(OneSmallChange);
        }
    }
}
