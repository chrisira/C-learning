using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo1
{
    // image post derives from post and adds a property (imageURL) and two constructors
    internal class ImagePost:Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {
                
        }

        public ImagePost(string title,string sendByUsername,string imageURL,bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title; 
            this.isPublic = isPublic;
            this.SendByUsername = sendByUsername;
            this.ImageURL = imageURL;   

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.SendByUsername,this.ImageURL);
        }
    }
}
