using System;
using System.Collections.Generic;
using System.Text;

namespace SocialFeed
{
    public abstract class Post : IReportable
    {
        private string _author;
        private int _likes;
        private int _reports;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public int Likes
        {
            get { return _likes; }
        }


        public Post(string author)
        {
            _author = author;
            _likes = 0;
        }

        public virtual bool Like()
        {
            _likes++;
            return true;
        }

        public virtual string GetDescription()
        {
            return $"{_author}, {_likes} kedvelés";
        }

        public abstract int Score();

        public void Report()
        {
            _reports++;
        }
        public int ReportCount()
        {
            return _reports;
        }
    }
}
