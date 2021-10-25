using System.Collections.Generic;

namespace AFPlanningApi.domain
{
    public class PlanningPoker
        : Entity
    {
        public Card Card {get; set;} 

        public bool AllowRevealVotes { get; set;}
        public bool AllowChangeVotes { get; set; }
        public bool ActiveCountdownTimer { get; set; }

    }
}