using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SocialFeed
{
    public class Comment : IReportable
    {
        private string _author;
        private string _text;
        private Post _parentPost;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public Post ParentPost
        {
            get { return _parentPost; }
        }

        public Comment(string author, string text, Post parentPost)
        {
            _author = author;
            _text = text;
            _parentPost = parentPost; 
        }

        public string GetDescription()
        {
            return $"{_author} hozzászólása {_parentPost.Author} bejegyzéséhez: {_text}";
        }

        private int _reports;
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
