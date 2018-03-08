using System.Collections.Generic;
using System.Linq;
using Treehouse.FitnessFrog.Models;

namespace Treehouse.FitnessFrog.Data
{

    public class ActivitiesRepository
    {
 
        public List<Activity> GetActivities()
        {
            return Data.Activities
                .OrderBy(a => a.Name)
                .ToList();
        }
    }
}