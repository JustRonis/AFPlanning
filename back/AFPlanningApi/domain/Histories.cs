using System.Collections.Generic;

namespace AFPlanningApi.domain
{
    public class Histories
        : Entity
    {
        public int PbiId { get; set; }

        public int Title {get; set;}
        public string Description { get; set; }
        
    }
}


