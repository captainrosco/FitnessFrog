using System;
using System.ComponentModel.DataAnnotations;

namespace Treehouse.FitnessFrog.Models
{
 
    public class Entry
    {

        public enum IntensityLevel
        {
            Low,
            Medium,
            High
        }

        public Entry()
        {
        }

        public Entry(int id, int year, int month, int day, Activity.ActivityType activityType, 
            double duration, IntensityLevel intensity = IntensityLevel.Medium,
            bool exclude = false, string notes = null)
        {
            Id = id;
            Date = new DateTime(year, month, day);
            ActivityId = (int)activityType;
            Duration = duration;
            Intensity = intensity;
            Exclude = exclude;
            Notes = notes;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Activity")]
        public int ActivityId { get; set; }      
        
        public Activity Activity { get; set; }      
        public double Duration { get; set; }
        public IntensityLevel Intensity { get; set; }
        public bool Exclude { get; set; }
        public string Notes { get; set; }
    }
}