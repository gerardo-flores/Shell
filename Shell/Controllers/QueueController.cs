//
//  Copyright Info
//

using System.Web.Mvc;
using Shell.Infrastructure.BackgroundJobs;
using Shell.Infrastructure.Logging;
using Shell.Infrastructure.IdStore;
using Shell.Models;

namespace Shell.Controllers
{
    public class QueueController : ApplicationController
    {
        private IBackgroundJobManager _jobManager;
        private Jobs _jobs;

        public QueueController(ILogger logger, IBackgroundJobManager manager, IIdStore store)
            : base(store, logger)
        {
            _jobManager = manager;
            _jobs = new Jobs();
        }

        [Authorize]
        public ActionResult Index(int pageNum = 1)
        {
            dynamic jobsAndRequestors = _jobs.Paged(columns: "Jobs.InputId, Jobs.Description, Jobs.CreatedAt, Jobs.Priority, Jobs.Status, Jobs.RunTimeMinutes, Jobs.Type, Users.Email", join: "INNER JOIN Users ON Users.ID = Jobs.UploadedBy", currentPage: pageNum, pageSize: 10, orderBy: "CreatedAt desc");

            var viewModel = new JobsViewModel
            {
                Jobs = jobsAndRequestors.Items,
                CurrentPage = pageNum,
                TotalRecords = jobsAndRequestors.TotalRecords,
                TotalPages = jobsAndRequestors.TotalPages
            };

            ViewBag.Message = "All the jobs in the queue";

            return View(viewModel);
        }
    }
}
