using System.Collections.Generic;

namespace AFPlanningApi.domain
{
    public class PlayingCard
        : Card
    {
        public PlayingCard()
        {
            Values = new List<ValueCard>
            {
                new ValueCard
                {
                    Label = "Ace",
                    Active = true,
                    Value = 0
                },
                new ValueCard
                {
                    Label = "2",
                    Active = true,
                    Value = 2
                },
                                new ValueCard
                {
                    Label = "5",
                    Active = true,
                    Value = 5
                },
                                new ValueCard
                {
                    Label = "8",
                    Active = true,
                    Value = 8
                },
                                new ValueCard
                {
                    Label = "King",
                    Active = true,
                    Value = 10
                },
                                new ValueCard
                {
                    Label = "?",
                    Active = true,
                    Value = 0
                },
                                new ValueCard
                {
                    Label = "Coffee",
                    Active = true,
                    Value = 0
                },
            };
        }
    }
}