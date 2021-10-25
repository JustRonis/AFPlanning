using System.Collections;
using System.Collections.Generic;

namespace AFPlanningApi.domain
{
    public abstract class Card
        : Entity
    {
        public ICollection<ValueCard> Values{ get; set; }
    }
}