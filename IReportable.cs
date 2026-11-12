using System;
using System.Collections.Generic;
using System.Text;

namespace SocialFeed
{
    public interface IReportable
    {
        void Report();
        int ReportCount();
        string GetDescription();
    }
}
