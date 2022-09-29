using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo1
{
    internal class Post
    {
        private static int currentPostId;

        // properties

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool isPublic { get; set; }

        // Default constructor. If a derived class doesn't invoke a base class constructor explicitly,
        // the default constructor is called implicitly
        public Post()
        {
            ID = 0;
            Title = "my First Post";
            isPublic = true;
            SendByUsername = "Christian IRADUKUNDA";

        }

        //instance constructor that has three parameters

        public Post(string title, bool isPublic,string sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.isPublic = isPublic;
            this.SendByUsername = sendByUsername;   
            
        }

        // method to generate the index
        protected int GetNextId()
        {
            return ++currentPostId;
        }

        // making the update method

        public void update(string title, bool isPublic)
        {
            this.Title = title;
            this.isPublic = isPublic;
                
        }

        // virtual method override of the ToString method that is inherited from System.Object

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}",this.ID,this.Title,this.SendByUsername);
        }
    }
}
