﻿namespace MyEFCourse.Entities
{
    public class WorkItemTag
    { 
        public WorkItem WorkItem { get; set; }
        public int WorkItemId { get; set; }
        public Tag Tag { get; set; }
        public int TagId { get; set; }
    }
}