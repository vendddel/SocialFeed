using System;
using System.Collections.Generic;
using System.Text;

namespace SocialFeed
{
    public class PollPost : Post
    {
        private int _votes;
        private bool _isClosed;

        public int Votes
        {
            get { return _votes; }
        }

        public bool IsClosed
        {
            get { return _isClosed; }
        }

        public PollPost(string author) : base(author)
        {
            _votes = 0;
            _isClosed = false;
        }

        public bool Vote()
        {
            if (!_isClosed)
            {
                _votes++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Close()
        {
            _isClosed = true;
        }
        public override int Score()
        {
            return Likes + Votes;
        }

        public override string GetDescription()
        {
            
            if (_isClosed)
            {
                return base.GetDescription() + $", {_votes} szavazat, lezárva";
            }
            return base.GetDescription() + $", {_votes} szavazat";
        }

        public override bool Like()
        {
            if (!_isClosed)
            {
                base.Like();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
