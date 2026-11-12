using System;
using System.Collections.Generic;
using System.Text;

namespace SocialFeed
{
    public class ImagePost : Post
    {
        private int _imageCount;
        public int ImageCount
        {
            get { return _imageCount; }
            set
            {
                if (value < 1 || value > 10)
                {
                    _imageCount = 1;
                }
                else
                {
                    _imageCount = value;
                }
            }
        }

        public ImagePost(int imageCount, string author) : base(author)
        {
            ImageCount = imageCount;
        }

        public override int Score()
        {
            return Likes * 2;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $": {_imageCount} kép";
        }


    }
}

