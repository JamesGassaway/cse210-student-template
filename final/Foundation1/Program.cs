using System;

class Program
{
    private List<Video> _videos = new List<Video>();
    public void DisplayVideos() {
        foreach (Video video in _videos)
        {
            video.DisplayVideo();
        }
    }
    public void CreateVideos() {
        Video video1 = new Video("BACKFLIPPING THE SHARK IN SKATE 3", "YuB", "18:52");
        video1.CreateComment("@aesthetictea5875", "Oh, those tubes? They're just tubes. *loud coughing*.\n-YuB stream 2018");
        video1.CreateComment("@YourHostEnder", "I have a challenge idea YuB.\n\nAt 1:17 if you paused the video, there is a pipe towards the top of the screen. My request is that you skate it.");
        video1.CreateComment("@Nemo-ms9eq", "6:30 my name is Spencer, and I can confirm all Spencers talk like that.");
        _videos.Add(video1);

        Video video2 = new Video("WARNING: SCARIEST GAME IN YEARS | Five Nights at Freddy's - Part 1", "Markiplier", "17:43");
        video2.CreateComment("@dtendy4153", "It’s a ritual to return to this every once in a while");
        video2.CreateComment("@angeredginger58", "Markiplier: \"If I didn't wanna stay the first night, why would I stay anymore than 5?\"\nMark's Fnaf playlist: 1 of 148");
        _videos.Add(video2);

        Video video3 = new Video("How Super Mario 64 TRIGGERS You! (Ft. SMG4)", "Nathaniel Bandy", "9:23");
        video3.CreateComment("@hobobros", "SM64 FOR LIFE");
        video3.CreateComment("@NathanielBandy", "Luke and Kevin are amazing, thanks guys for collabing with this! :)");
        video3.CreateComment("@seantae", "When you delete a save file, Mario screams to make you feel guilty");
        video3.CreateComment("@jasminejohnston6393", "Fun fact: the Chain Chomp is based on a dog that Shigeru Miyamoto was scared of as a kid. It would chase after him aggressively before being yanked back by its chain");
        _videos.Add(video3);

        DisplayVideos();
    }


    static void Main(string[] args)
    {
        Program program = new Program();
        program.CreateVideos();
    }
}