using System;
using System.Collections.Generic;

class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }
}

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Learn C#", "Code Academy", 1800);
        video1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Brian", "I finally understand classes."));
        video1.AddComment(new Comment("Cindy", "Great explanation."));
        video1.AddComment(new Comment("David", "Thanks for sharing!"));

        // Video 2
        Video video2 = new Video("Top 10 Programming Tips", "Tech World", 900);
        video2.AddComment(new Comment("Emma", "Awesome tips."));
        video2.AddComment(new Comment("Frank", "This improved my coding."));
        video2.AddComment(new Comment("Grace", "Very informative."));
        video2.AddComment(new Comment("Henry", "Looking forward to more videos."));

        // Video 3
        Video video3 = new Video("Introduction to OOP", "Programming Hub", 1500);
        video3.AddComment(new Comment("Isaac", "Excellent explanation."));
        video3.AddComment(new Comment("Jane", "This made OOP easy."));
        video3.AddComment(new Comment("Kevin", "Simple and clear."));
        video3.AddComment(new Comment("Linda", "Best OOP tutorial!"));

        // Video 4
        Video video4 = new Video("GitHub for Beginners", "Dev Channel", 1200);
        video4.AddComment(new Comment("Mike", "Exactly what I needed."));
        video4.AddComment(new Comment("Nancy", "Very easy to follow."));
        video4.AddComment(new Comment("Oscar", "Helped me complete my assignment."));
        video4.AddComment(new Comment("Paula", "Thanks for the great content!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}