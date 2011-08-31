using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Shell.Models;

namespace Shell.Infrastructure.BackgroundJobs
{
    public class QueueUpdateManager : IJobListener
    {
        private Jobs _jobs = new Jobs();

        #region IJobListener Members

        public void JobExecutionVetoed(JobExecutionContext context)
        {
            _jobs.Update(new { Status = "Cancelled" }, context.JobDetail.JobDataMap["QueueID"]);

        }

        public void JobToBeExecuted(JobExecutionContext context)
        {
            _jobs.Update(new { Status = "Started" }, context.JobDetail.JobDataMap["QueueID"]);
        }

        public void JobWasExecuted(JobExecutionContext context, JobExecutionException jobException)
        {
            if(jobException == null)
                _jobs.Update(new { Status = "Complete",  RunTimeMinutes = Math.Round(context.JobRunTime.TotalMinutes, 2)}, context.JobDetail.JobDataMap["QueueID"]);
            else
                _jobs.Update(new { Status = "Error", RunTimeMinutes = Math.Round(context.JobRunTime.TotalMinutes, 2) }, context.JobDetail.JobDataMap["QueueID"]);
        }

        public string Name
        {
            get { return "QueueUpdateManager"; }
        }

        #endregion
    }
}