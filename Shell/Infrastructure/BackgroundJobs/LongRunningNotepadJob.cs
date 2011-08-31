﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Shell.Infrastructure.BackgroundJobs
{
    public class LongRunningNotepadJob : IJob
    {
        public void Execute(JobExecutionContext context)
        {
            Process proc = Process.Start("notepad.exe"); 
            proc.WaitForExit();
        }
    }
}