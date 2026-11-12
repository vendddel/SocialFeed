using System;
using System.Collections.Generic;
using System.Text;

namespace SocialFeed
{
    public class TextPost : Post
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public TextPost(string text, string author) : base(author)
        {
            _text = text;
        }

        public override int Score()
        {
            return Likes;
        }

        public override string GetDescription()
        {
            
            if (_text.Length > 20)
            {
                return base.GetDescription() + $": {_text.Substring(0, 20)}...";
            }
            else
            {
                return base.GetDescription() + $": {_text}";
            }
        }
    }
}
