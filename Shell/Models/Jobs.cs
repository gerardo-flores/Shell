﻿//
//  Copyright Info
//

using System;
using System.Dynamic;

namespace Shell.Models
{
    public class Jobs : DynamicModel
    {

       public Jobs()
            : base("Template")
        {
            PrimaryKeyField = "ID";
        }

       public dynamic CreateJob(string description, int priority, DateTime createdAt, long userID, string type, long inputId)
       {
           dynamic result = new ExpandoObject();
           result.Success = false;

           if (!string.IsNullOrEmpty(description) && ValidatePriority(priority) && ValidateCreatedAt(createdAt) && ValidateUser(userID) && ValidateType(type))
           {
               try
               {
                   result.JobId = this.Insert(new { Description = description, Priority = priority, CreatedAt = createdAt, UploadedBy = userID, Status = "Queued", Type = type, InputId = inputId});
                   result.Success = true;
                   result.Message = "job added";
               }
               catch (Exception)
               {
                   result.Message = "The right columns do not exist for the Job Object";
               }
           }
           else
           {
               result.Message = "The job was invalid";
           }

           return result;
       }

       private dynamic ValidateType(string type)
       {
           if (type.Equals("LongRunning"))
               return true;
           else
               return false;
       }

       private bool ValidateUser(long userID)
       {
           Users users = new Users();
           dynamic result = users.Single(userID);

           if (result != null)
               return true;
           else
               return false;

       }

       private bool ValidateCreatedAt(DateTime createdAt)
       {
           // If week is so far in the past that it's the Min Date, then it's wrong
           if (DateTime.MinValue == createdAt)
               return false;

           if (DateTime.Now < createdAt)
               return false;

             // Otherwise return true
           return true;
       }

       private bool ValidatePriority(int priority)
       {
           if (priority > 0 && priority < 5)
               return true;
           else
               return false;
       }


    }
}