using System;

public class Comment
{
    private string _commenterName;
    private string _commentText;
    private static readonly List<string> _possibleNames = new List<string>()
    {
        "John",
        "Jane",
        "Bob",
        "Sue",
        "Alice",
        "Charlie",
        "Frederick the Third",
        "Joe Dirt",
        "Napoleon Dynamite",
        "Darth Vader",
        "Luke Skywalker",
        "Egor",
        "L33tH4x0r",
        "IDreamOfAragorn",
        "LaughyTaffy McGee",
        "TheOneWhoKnocks",
    };

    private static readonly List<string> _possibleComments = new List<string>()
    {
        "I love this video!",
        "This video is so cool!",
        "I can't believe this video!",
        "lols, this video is cringe",
        "I can't stop watching this video!",
        "Whoever made this video needs to get a job in the real world",
        "I can't believe I wasted my time watching this video",
        "Back to cat videos for me",
        "A+ for effort",
        "My eyes!!!",
        "Grandma would love this video",
        "I can't believe I watched the whole thing",
        "Expecto Patronum!",
        "I'm going to watch this video every day",
        "Don't feed them after midnight",
        "My favorite poop time video",
        "hahahah noob",
        "Git gud scrub",
        "When next video?",
        "Soon TM",
        "I can't wait for the next video",
        "Fell asleep watching this video. Really weird dreams.",
        "This was disgusting and disturbing",
        "Vomit inducing",
        "Such pretty pink ponies",
        "This video changed my life! I'm now a professional unicorn trainer.",
        "Is this what the kids are into these days? Back in my day, we watched paint dry for fun.",
        "I showed this to my cat. He's now questioning his existence.",
        "Plot twist: the video was cake all along!",
        "I'm pretty sure I saw Bigfoot in the background at 2:13.",
        "This video is longer than my attention span... ooh, a butterfly!",
        "I've seen better production quality in my grandma's VHS home videos.",
        "10/10 would recommend to my worst enemy.",
        "I'm writing my thesis on this video. It's titled 'The Decline of Western Civilization'.",
        "This video cured my insomnia... by giving me nightmares instead.",
        "I laughed, I cried, I forgot to feed my goldfish.",
        "Is this avant-garde or just bad? I can't tell anymore.",
        "Watched it backwards. Makes way more sense that way.",
        "This video owes me 5 minutes of my life back.",
        "I'm filing a class-action lawsuit for emotional distress caused by this content.",
        "Still a better love story than Twilight.",
        "My IQ dropped 10 points, but my meme game is stronger than ever.",
        "This video is like a fever dream had a baby with a acid trip.",
        "I've seen more coherent storylines in alphabet soup.",
        "Thanks, I hate it. clicks replay",
    };

    private static readonly Random randomGenerator = new Random();

    public Comment()
    {
        _commenterName = GenerateRandomName();
        _commentText = GenerateRandomComment();
    }

    public string GetCommentInfo()
    {
        return $"{_commenterName}: {_commentText}";
    }

    private string GenerateRandomName()
    {
        int index = randomGenerator.Next(0, _possibleNames.Count);
        return _possibleNames[index];
    }

    private string GenerateRandomComment()
    {
        int index = randomGenerator.Next(0, _possibleComments.Count);
        return _possibleComments[index];
    }
}