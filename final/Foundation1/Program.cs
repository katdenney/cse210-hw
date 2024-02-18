using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List <Video> _videoList = new List<Video>();
        Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new Video("Funny Cats","Fred Smith",300);
        video1.AddComment("Emily Thompson","The purple giraffe danced salsa at the disco.");
        video1.AddComment("Jacob Miller","Flying pigs harmonized with talking bananas");
        video1.AddComment("Olivia Davis","Unicorns held a poetry slam in the candy forest");
        video1.DisplayVideoInfo();
        video1.DisplayCommentList();
        _videoList.Add(video1);
        Video video2 = new Video("DIY Creative Crafts","Ethan Harris",200);
        video2.AddComment("Ava Robinson","In space, marshmallows had a zero-gravity party.");
        video2.AddComment("Mason Turner","The ninja squirrel wore sunglasses to sneak around.");
        video2.AddComment("Sophia Clark","Pancakes challenged waffles to a syrup wrestling match.");
        video2.DisplayVideoInfo();
        video2.DisplayCommentList();
        _videoList.Add(video2);
        Video video3 = new Video("Tech Talk","Logan Bennett",600);
        video3.AddComment("Emily Thompson","Robots practiced breakdancing in the computer lab.");
        video3.AddComment("Jacob Miller","The sneezing elephant startled the quiet library.");
        video3.AddComment("Olivia Davis","Jellyfish organized an underwater fashion show.");
        video3.DisplayVideoInfo();
        video3.DisplayCommentList();
        _videoList.Add(video3);

        foreach (Video video in _videoList)
        {
            video.DisplayVideoInfo();
            video.DisplayCommentList();
        }

    }
}
/*
-fake video titles-
DIY Creative Crafts
Boost Your Productivity
Tech Talk
A Travel Adventure
-random names-
Emily Thompson
Jacob Miller
Olivia Davis
Ethan Harris
Ava Robinson
Mason Turner
Sophia Clark
Logan Bennett
Mia Campbell
Liam Parker
***
-random comments-
The purple giraffe danced salsa at the disco.
Flying pigs harmonized with talking bananas.
Unicorns held a poetry slam in the candy forest.
In space, marshmallows had a zero-gravity party.
The ninja squirrel wore sunglasses to sneak around.
Pancakes challenged waffles to a syrup wrestling match.
Robots practiced breakdancing in the computer lab.
The sneezing elephant startled the quiet library.
Jellyfish organized an underwater fashion show.
Penguins attempted a synchronized swimming routine in a bathtub.
*/