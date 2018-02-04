using System;

namespace TimeTracker
{
    class TimeElement
    {
        public long Timestamp { get; set; }
        public String Description { get; set; }

        public TimeElement(long timestamp, String description)
        {
            this.Timestamp = timestamp;
            this.Description = description;
        }
    }
}
