﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Email.Outlook.Pst;
using Aspose.Email;
using Aspose.Email.Outlook;
using Aspose.Email.Recurrences;

/* This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET 
   API reference when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq 
   for more information. If you do not wish to use NuGet, you can manually download 
   Aspose.Email for .NET API from http://www.aspose.com/downloads, 
   install it and then add its reference to this project. For any issues, questions or suggestions 
   please feel free to contact us using http://www.aspose.com/community/forums/default.aspx            
*/

namespace Aspose.Email.Examples.CSharp.Email.Outlook
{
    class WeeklyEndAfterNoccurrences
    {
        public static void Run()
        {
            // ExStart:WeeklyEndAfterNoccurrences
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Outlook();
            TimeZone localZone = TimeZone.CurrentTimeZone;
            TimeSpan ts = localZone.GetUtcOffset(DateTime.Now);
            DateTime StartDate = new DateTime(2015, 7, 16);
            StartDate = StartDate.Add(ts);

            DateTime DueDate = new DateTime(2015, 7, 16);
            DateTime endByDate = new DateTime(2015, 9, 1);
            DueDate = DueDate.Add(ts);
            endByDate = endByDate.Add(ts);

            MapiTask task = new MapiTask("This is test task", "Sample Body", StartDate, DueDate);
            task.State = MapiTaskState.NotAssigned;

            // Set the weekly recurrence
            var rec = new MapiCalendarWeeklyRecurrencePattern
            {
                EndType = MapiCalendarRecurrenceEndType.EndAfterNOccurrences,
                PatternType = MapiCalendarRecurrencePatternType.Week,
                Period = 1,
                WeekStartDay = DayOfWeek.Sunday,
                DayOfWeek = MapiCalendarDayOfWeek.Friday,
                OccurrenceCount = GetOccurrenceCount(StartDate, endByDate, "FREQ=WEEKLY;BYDAY=FR"),
            };

            if (rec.OccurrenceCount == 0)
            {
                rec.OccurrenceCount = 1;
            }

            task.Recurrence = rec;
            task.Save(dataDir + "Weekly_out.msg", TaskSaveFormat.Msg);
            // ExEnd:WeeklyEndAfterNoccurrences
        }
        private static uint GetOccurrenceCount(DateTime start, DateTime endBy, string rrule)
        {
            // ExStart:GetOccurrenceCount
            CalendarRecurrence pattern = new CalendarRecurrence(string.Format("DTSTART:{0}\r\nRRULE:{1}", start.ToString("yyyyMMdd"),rrule));            
            DateCollection dates = pattern.GenerateOccurrences(start, endBy);            
            return (uint)dates.Count;
            // ExEnd:GetOccurrenceCount
        }
    }
}
