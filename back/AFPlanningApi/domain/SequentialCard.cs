using System.Collections.Generic;

namespace AFPlanningApi.domain
{
    public class SequentialCard
        : Card
    {
        public SequentialCard()
        {
            Values = new List<ValueCard>
            {
                new ValueCard
                {
                    Label =  "0",
                    Active = true,
                    Value = 0
                },
                                new ValueCard
                {
                    Label =  "1",
                    Active = true,
                    Value = 1
                },
                                new ValueCard
                {
                    Label =  "2",
                    Active = true,
                    Value = 2
                },
                                new ValueCard
                {
                    Label =  "3",
                    Active = true,
                    Value = 3
                },
                                new ValueCard
                {
                    Label =  "4",
                    Active = true,
                    Value = 4
                },
                                new ValueCard
                {
                    Label =  "5",
                    Active = true,
                    Value = 5
                },
                                new ValueCard
                {
                    Label =  "6",
                    Active = true,
                    Value = 6
                },
                                new ValueCard
                {
                    Label =  "7",
                    Active = true,
                    Value = 7
                },
                                new ValueCard
                {
                    Label =  "8",
                    Active = true,
                    Value = 8
                },
                                new ValueCard
                {
                    Label =  "9",
                    Active = true,
                    Value = 9
                },
                                new ValueCard
                {
                    Label =  "10",
                    Active = true,
                    Value = 10
                },
                                new ValueCard
                {
                    Label =  "?",
                    Active = true,
                    Value = 0
                },
                                new ValueCard
                {
                    Label =  "Coffee",
                    Active = true,
                    Value = 0
                },

            };
        }
    }
}