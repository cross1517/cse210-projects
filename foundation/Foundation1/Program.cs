using System;

class Program
{
    static List<Video> videos = new List<Video>();
    static void Main(string[] args)
    {
        MakeVideos();
        DisplayAllVideosAndComments();
    }

    static void MakeVideos()
    {
        Video video1 = new Video("The Art of Picking Pimples", "Stacy's Mom", 600);

        Video video2 = new Video("Reaching Escape Velocity With Sphagetti", "Science by Dexter", 9853);

        Video video3 = new Video("Killer Worms in the Ground!!!!", "Tinfoil Hat Dan", 38923);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
    }

    static void DisplayAllVideosAndComments()
    {
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommentInfo());
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    
}