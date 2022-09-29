using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo1
{
    internal class VideoPost : Post
    {

        // member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, int length)
        {

            this.ID = GetNextId();
            this.Title = title;
            this.isPublic = isPublic;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
           
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0} s",currDuration);
                GC.Collect();
            }

        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
           

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} -  {3} - {4}", this.ID, this.Title, this.SendByUsername,this.VideoURL,this.Length);
        }
    }
}
