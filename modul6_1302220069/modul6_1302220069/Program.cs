// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    public SayaTubeVideo(String title)
    {
        if (title.Length==0 || title.Length > 200)
        {
            throw new ArgumentNullException("Judul video maksimal 200 karakter, dan tidak kosong");
        }
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount(int playCount)
    {
        if (playCount>25000000 || playCount<0)
        {
            throw new ArgumentNullException("input penambahan playCount maksimal 25.000.000 dan tidak negatif per panggilan methodnya");
        }
        this.playCount += playCount;
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("Id: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
    public int GetPlayCount()
    {
        return this.playCount;
    }
}
public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public String username;
    public SayaTubeUser(String username)
    {
        if (username.Length == 0 || username.Length > 100)
        {
            throw new ArgumentNullException("Username maksimal 100 karakter, dan tidak kosong");
        }
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }
    public int GetTotalVideoPlayCount()
    {
        int total=0;
        for (int i = 0; i < uploadedVideos.Count; i++) 
        {
            total+=uploadedVideos[i].GetPlayCount();
        }
        return total;
    }
    public void AddVideo(SayaTubeVideo uploadedVideo)
    {
        uploadedVideos.Add(uploadedVideo);
    }
    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            uploadedVideos[i].PrintVideoDetails();
        }
    }
}
public class MainClass
{
    public static void Main(string[] args)
    {
        SayaTubeUser sayaTubeUser = new SayaTubeUser("user1");
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("video1");
        sayaTubeVideo.IncreasePlayCount(50);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeVideo = new SayaTubeVideo("video2");
        sayaTubeVideo.IncreasePlayCount(20);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeVideo = new SayaTubeVideo("video3");
        sayaTubeVideo.IncreasePlayCount(23);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeVideo = new SayaTubeVideo("video4");
        sayaTubeVideo.IncreasePlayCount(81);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeVideo = new SayaTubeVideo("video5");
        sayaTubeVideo.IncreasePlayCount(502);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeVideo = new SayaTubeVideo("video6");
        sayaTubeVideo.IncreasePlayCount(11);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeVideo = new SayaTubeVideo("video7");
        sayaTubeVideo.IncreasePlayCount(220);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeVideo = new SayaTubeVideo("video8");
        sayaTubeVideo.IncreasePlayCount(67);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeVideo = new SayaTubeVideo("video9");
        sayaTubeVideo.IncreasePlayCount(81);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeVideo = new SayaTubeVideo("video10");
        sayaTubeVideo.IncreasePlayCount(401);
        sayaTubeUser.AddVideo(sayaTubeVideo);
        sayaTubeUser.PrintAllVideoPlaycount();
        Console.WriteLine("User total playcount: "+sayaTubeUser.GetTotalVideoPlayCount());
    }
}