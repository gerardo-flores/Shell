//
//  Copyright Info
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Quartz;
using Quartz.Impl;
using System.Reflection;
using Ninject;
using Shell.Infrastructure.Logging;
using QuartzNetWebConsole;
using Shell.Models;

namespace Shell.Infrastructure.BackgroundJobs
{
    public class BackgroundJobManager : IBackgroundJobManager
    {
        private IScheduler _scheduler;
        private Shell.Infrastructure.Logging.ILogger _logger;
        private Jobs _jobs;

        public BackgroundJobManager(Shell.Infrastructure.Logging.ILogger logger, IScheduler sched)
        {
            _jobs = new Jobs();
            _logger = logger;
            _scheduler = sched;

            if (!_scheduler.IsStarted)
            {
                _scheduler.Start();
                _scheduler.AddGlobalJobListener(new QueueUpdateManager());
                QuartzNetWebConsole.Setup.Scheduler = () => _scheduler;
                QuartzNetWebConsole.Setup.Logger = new MemoryLogger(10000);
            }
        }

        public void LongRunningJob(dynamic user)
        {
            string description = "Long Running Task";
            JobDetail details = new JobDetail(description, typeof(LongRunningNotepadJob));
            details.Description = "Long running job";
            details.Group = "External executable job";

            Trigger trigger = new SimpleTrigger("QuartzManager Long Running Task", DateTime.Now);
            trigger.Description = "Trigger immediately";
            trigger.Group = "Immediate";

            dynamic result = _jobs.CreateJob(description, 1, DateTime.Now, user.ID, "LongRunning", 1);
            details.JobDataMap["QueueID"] = result.JobId;
            _scheduler.ScheduleJob(details, trigger);
        }

    }
}