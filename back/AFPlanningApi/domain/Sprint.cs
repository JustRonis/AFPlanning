using System;
using System.Collections.Generic;

namespace AFPlanningApi.domain
{
    public class Sprint
        : Entity
    {
        public string AzureSprintId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TimeFrame TimeFrame {get; set;}
        public ICollection<User> StackHolders { get; set;}

        public string Goal { get; set; }

        public string AzureURL { get; set; }


    }

    public class SprintViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public string Url { get; set; }
        
    }

    public class SprintAzureResponse
    {
        public IList<SprintViewModel> Value { get; set; }
        
    }
}