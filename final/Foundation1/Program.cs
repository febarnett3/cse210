using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        // Create Video
        Video video1 = new Video("Baking Cookies!", "Phyllis Vance", 300);
        // Add Comments
        video1.AddComment(new Comment("Hank Frank", "Those cookies look gross.."));
        video1.AddComment(new Comment("Shirley Williams", "I want some cookies!"));
        video1.AddComment(new Comment("Sarah W.", "I've made better cookies."));
        // Add video to list
        videos.Add(video1);

        // Create Video
        Video video2 = new Video("My Thoughts On The New Avatar Movie", "Dwight Schrute", 600);
        // Add Comments
        video2.AddComment(new Comment("clairejk", "This movie was a 10/10!"));
        video2.AddComment(new Comment("febarnett3", "Is a National Geographic for animals that don't exist."));
        video2.AddComment(new Comment("tkfergie98", "OOHHH blue people!"));
        video2.AddComment(new Comment("blue-person4life", "That's not me! >:("));

        // Add video to list
        videos.Add(video1);

        // Create Video
        Video video3 = new Video("Why You Should Quit", "Michael Scott", 500);
        // Add Comments
        video3.AddComment(new Comment("Sir GotNoJob", "Unemployed 10/10"));
        video3.AddComment(new Comment("RichDude101", "Nah, I'll keep my job."));
        video3.AddComment(new Comment("crazyduckgoose", "I guess I gotta quit now!"));
        // Add video to list
        videos.Add(video1);

        foreach(Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}