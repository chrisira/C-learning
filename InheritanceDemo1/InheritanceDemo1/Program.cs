namespace InheritanceDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the wishes", true, "Christian IRADUKUNDA");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new Shoes", "Christian IRADUKUNDA", "https://image.com/shoes", true);

            Console.WriteLine(imagePost1.ToString());


            VideoPost myVideo = new VideoPost("Failed video", "Christian IRADUKUNDA", true, "https//:video.com/video1", 10);
            Console.WriteLine(myVideo.ToString());

            myVideo.Play();
            Console.WriteLine("Press any key to stop the video");

            Console.ReadKey();

            myVideo.Stop();



        }
    }
}
