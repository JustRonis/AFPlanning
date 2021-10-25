using System.Collections.Generic;

namespace AFPlanningApi.domain
{
    public class FibonacciCard
        : Card
    {
        public FibonacciCard()
        {
            Values = new List<ValueCard>
            {
                new ValueCard
                {
                    Label = "0",
                    Active = true,
                    Value = 0
                },
                new ValueCard
                {
                    Label = "1",
                    Active = true,
                    Value = 1
                },
                new ValueCard
                {
                    Label = "2",
                    Active = true,
                    Value = 2
                },
                new ValueCard
                {
                    Label = "3",
                    Active = true,
                    Value = 3
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
                    Label = "13",
                    Active = true,
                    Value = 13
                },
                new ValueCard
                {
                    Label = "21",
                    Active = true,
                    Value = 21
                },
                new ValueCard
                {
                    Label = "34",
                    Active = true,
                    Value = 34
                },
                new ValueCard
                {
                    Label = "55",
                    Active = true,
                    Value = 55
                },
                new ValueCard
                {
                    Label = "89",
                    Active = true,
                    Value = 89
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
                }
            };
        }
    }
}