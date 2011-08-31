//
//  Copyright Info
//

using System;
namespace Shell.Infrastructure.BackgroundJobs
{
    public interface IBackgroundJobManager
    {
        void LongRunningJob(dynamic user);
    }
}
